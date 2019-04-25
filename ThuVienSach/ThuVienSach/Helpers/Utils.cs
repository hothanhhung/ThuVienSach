using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThuVienSach.Helpers
{
    public class Utils
    {
        private static string ConvertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string ConvertNameToKey(string str)
        {
            str = str.Trim();
            str = str.Replace(' ', '-');
            return ConvertToUnSign3(str);
        }

        public async static Task<string> GetImageAsBase64Url(string url)
        {
            //var credentials = new NetworkCredential(user, pw);
           // using (var handler = new HttpClientHandler { Credentials = credentials })
            using (var client = new HttpClient())
            {
                var bytes = await client.GetByteArrayAsync(url);
                return "image/jpeg;base64," + Convert.ToBase64String(bytes);
            }
        }
    }
}
