using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ThuVienSach.Models;

namespace ThuVienSach.Helpers
{
    public class Parsers
    {
        public static Book GetBookDetailFromSachVui(string url)
        {
            Book book = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string data = string.Empty;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }

                if (!string.IsNullOrWhiteSpace(data))
                {
                    var source = data;// System.Text.RegularExpressions.Regex.Unescape(data);
                    //source = WebUtility.HtmlDecode(source.Replace("\"", ""));
                    HtmlDocument resultat = new HtmlDocument();
                    resultat.LoadHtml(source);

                    var item = resultat.DocumentNode.SelectSingleNode("//div[@class='row thong_tin_ebook']");
                    if (item != null)
                    {
                        book = new Book();
                        var name = item.SelectSingleNode("//h1[@class='ebook_title text-primary']");
                        if (name != null)
                        {
                            book.Name = name.InnerText.Trim();
                            book.Id = Utils.ConvertNameToKey(book.Name);
                        }
                        var author = item.SelectSingleNode("//h5");
                        if (author != null)
                        {
                            book.Author = author.InnerText.Replace("Tác giả :","").Trim();
                        }

                        var imageUrl = item.SelectSingleNode("//img[@class='img-thumbnail']");
                        if (imageUrl != null)
                        {
                            book.ImageUrl = imageUrl.GetAttributeValue("src", string.Empty).Trim();
                        }

                        var readContentUrl = item.SelectSingleNode("//a[@class='btn btn-warning btn-md']");
                        if (readContentUrl != null)
                        {
                            book.ReadContentUrl = readContentUrl.GetAttributeValue("href", string.Empty).Trim();
                        }

                        var introduction = resultat.DocumentNode.SelectSingleNode("//div[@class='gioi_thieu_sach text-justify']");
                        if (introduction != null)
                        {
                            book.Introduction = introduction.InnerHtml;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return book;
        }

        public static Chapter GetChapterDetailFromSachVui(string url)
        {
            Chapter chapter = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string data = string.Empty;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }

                if (!string.IsNullOrWhiteSpace(data))
                {
                    var source = data;// System.Text.RegularExpressions.Regex.Unescape(data);
                    //source = WebUtility.HtmlDecode(source.Replace("\"", ""));
                    HtmlDocument resultat = new HtmlDocument();
                    resultat.LoadHtml(source);

                    var item = resultat.DocumentNode.SelectSingleNode("//div[@class='doc-online']");
                    if (item != null)
                    {
                        chapter = new Chapter();
                        var names = item.SelectNodes("h3");
                        if (names != null && names.Count > 1)
                        {
                            chapter.Name = names[1].InnerText.Trim();
                        }
                        var nextChapters = item.SelectNodes("div");
                        if (nextChapters != null && nextChapters.Count > 0)
                        {
                            var next = nextChapters[0].LastChild;
                            if (next != null && next.Name.Equals("a", StringComparison.OrdinalIgnoreCase))
                            {
                                chapter.NextChapterUrl = next.GetAttributeValue("href", string.Empty).Trim();
                            }
                        }
                        var strBuilder = new StringBuilder();
                        nextChapters[nextChapters.Count - 1].Remove();
                        //var contents = item.SelectNodes("p");
                        bool startContent = false;
                        foreach(var pTab in item.ChildNodes)
                        {
                            if (!startContent)
                            {
                                if (pTab.GetAttributeValue("class", string.Empty).Contains("noi_dung_online")) startContent = true;
                            }
                            else
                            {
                                var str = pTab.OuterHtml.Trim();
                                if (!string.IsNullOrWhiteSpace(str))
                                {
                                    strBuilder.AppendLine(str);
                                }
                            }
                        }
                        chapter.Content = strBuilder.ToString();
                        
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return chapter;
        }
    }
}
