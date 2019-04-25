using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienSach.Helpers;
using ThuVienSach.Models;

namespace ThuVienSach
{
    public partial class Form1 : Form
    {
        private bool isGettingData = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienSachDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.thuVienSachDataSet1.Categories);

        }

        private Book book;
        private void btProcess_Click(object sender, EventArgs e)
        {
            book = Parsers.GetBookDetailFromSachVui(txtAddress.Text);
            if (book!=null){
                lblName.Text = book.Name;
                lblImage.Text = book.ImageUrl;
                lblAuthor.Text = book.Author;
                lblIntroduction.Text = book.Introduction;
                lblReadUrl.Text = book.ReadContentUrl;
                wvIntroduction.DocumentText = book.Introduction;
            }
        }

        private void btGetChapters_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                if (isGettingData) isGettingData = false;
                else
                {
                    btGetChapters.Text = "Getting";
                    isGettingData = true;
                    updateUI(null);
                    GetChapterDetailFromSachVui(book.ReadContentUrl);
                }
            }
        }

        private void GetChapterDetailFromSachVui(string url)
        {
            Thread t = new Thread(() =>
            {
                var chapter = Parsers.GetChapterDetailFromSachVui(url);
                if (chapter != null)
                {
                    updateUI(chapter);
                    if (!string.IsNullOrWhiteSpace(chapter.NextChapterUrl) && isGettingData)
                    {
                        GetChapterDetailFromSachVui(chapter.NextChapterUrl);
                    }
                    else
                    {
                        isGettingData = false;
                        btGetChapters.Invoke(new Action(() => btGetChapters.Text = "Get Chapters"));
                    }
                }
                else
                {
                    isGettingData = false;
                    btGetChapters.Invoke(new Action(() => btGetChapters.Text = "Get Chapters"));
                }
            });

            t.Start();
        }

        private void updateUI(Chapter chapter)
        {
            if (chapter == null)
            {
                cbbChapters.Invoke(new Action(()=>cbbChapters.Items.Clear())) ;
                lblNumberChapters.Invoke(new Action(() => lblNumberChapters.Text = cbbChapters.Items.Count.ToString()));
            }
            else
            {
                cbbChapters.Invoke(new Action(() => cbbChapters.Items.Add(chapter)));
                lblNumberChapters.Invoke(new Action(() => lblNumberChapters.Text = cbbChapters.Items.Count.ToString()));
            }
        }

        private void bindData(Chapter chapter)
        {
            if (chapter != null)
            {
                lblChapterName.Text = chapter.Name;
                wvChapterContent.DocumentText = chapter.Content;
            }
            else
            {
                lblChapterName.Text = string.Empty;
                wvChapterContent.DocumentText = string.Empty;
            }

        }

        private void cbbChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chapter = (Chapter)cbbChapters.SelectedItem;
            bindData(chapter);
        }

        private void btSaveAll_Click(object sender, EventArgs e)
        {
            if(book!=null && cbbChapters.Items.Count > 0)
            {
                book.CategoryId = (string) cbbCatogory.SelectedValue;
                book.IsDisplay = true;
                book.IsFull = true;
                book.NumberOfChapters = cbbChapters.Items.Count;
                book.UpdatedDate = book.AddedDate = DateTime.Now;
                using (var datacontext = new ThuVienContext())
                {
                    book = datacontext.Books.Add(book);
                    foreach(Chapter chapter in cbbChapters.Items)
                    {
                        chapter.BookId = book.Id;
                        chapter.UpdatedDate = chapter.AddedDate = DateTime.Now;
                        datacontext.Chapters.Add(chapter);
                    }

                    datacontext.SaveChanges();
                }
            }
            MessageBox.Show("Saved");
        }
    }
}
