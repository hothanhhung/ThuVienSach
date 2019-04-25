namespace ThuVienSach
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wvChapterContent = new System.Windows.Forms.WebBrowser();
            this.lblChapterName = new System.Windows.Forms.Label();
            this.cbbChapters = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSaveAll = new System.Windows.Forms.Button();
            this.btGetChapters = new System.Windows.Forms.Button();
            this.lblNumberChapters = new System.Windows.Forms.Label();
            this.wvIntroduction = new System.Windows.Forms.WebBrowser();
            this.lblReadUrl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDisplayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienSachDataSet1 = new ThuVienSach.ThuVienSachDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btProcess = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbbCatogory = new System.Windows.Forms.ComboBox();
            this.categoriesTableAdapter = new ThuVienSach.ThuVienSachDataSet1TableAdapters.CategoriesTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienSachDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wvChapterContent);
            this.groupBox3.Controls.Add(this.lblChapterName);
            this.groupBox3.Controls.Add(this.cbbChapters);
            this.groupBox3.Location = new System.Drawing.Point(431, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 360);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // wvChapterContent
            // 
            this.wvChapterContent.Location = new System.Drawing.Point(19, 103);
            this.wvChapterContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvChapterContent.Name = "wvChapterContent";
            this.wvChapterContent.Size = new System.Drawing.Size(332, 250);
            this.wvChapterContent.TabIndex = 3;
            // 
            // lblChapterName
            // 
            this.lblChapterName.AutoSize = true;
            this.lblChapterName.Location = new System.Drawing.Point(16, 58);
            this.lblChapterName.Name = "lblChapterName";
            this.lblChapterName.Size = new System.Drawing.Size(35, 13);
            this.lblChapterName.TabIndex = 1;
            this.lblChapterName.Text = "label2";
            // 
            // cbbChapters
            // 
            this.cbbChapters.FormattingEnabled = true;
            this.cbbChapters.Location = new System.Drawing.Point(16, 30);
            this.cbbChapters.Name = "cbbChapters";
            this.cbbChapters.Size = new System.Drawing.Size(121, 21);
            this.cbbChapters.TabIndex = 0;
            this.cbbChapters.SelectedIndexChanged += new System.EventHandler(this.cbbChapters_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.wvIntroduction);
            this.groupBox2.Controls.Add(this.lblReadUrl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblIntroduction);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblImage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btSaveAll);
            this.panel3.Controls.Add(this.btGetChapters);
            this.panel3.Controls.Add(this.lblNumberChapters);
            this.panel3.Location = new System.Drawing.Point(320, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 109);
            this.panel3.TabIndex = 11;
            // 
            // btSaveAll
            // 
            this.btSaveAll.Location = new System.Drawing.Point(6, 41);
            this.btSaveAll.Name = "btSaveAll";
            this.btSaveAll.Size = new System.Drawing.Size(86, 23);
            this.btSaveAll.TabIndex = 4;
            this.btSaveAll.Text = "Save All";
            this.btSaveAll.UseVisualStyleBackColor = true;
            this.btSaveAll.Click += new System.EventHandler(this.btSaveAll_Click);
            // 
            // btGetChapters
            // 
            this.btGetChapters.Location = new System.Drawing.Point(6, 11);
            this.btGetChapters.Name = "btGetChapters";
            this.btGetChapters.Size = new System.Drawing.Size(86, 23);
            this.btGetChapters.TabIndex = 3;
            this.btGetChapters.Text = "Get Chapters";
            this.btGetChapters.UseVisualStyleBackColor = true;
            this.btGetChapters.Click += new System.EventHandler(this.btGetChapters_Click);
            // 
            // lblNumberChapters
            // 
            this.lblNumberChapters.AutoSize = true;
            this.lblNumberChapters.Location = new System.Drawing.Point(41, 75);
            this.lblNumberChapters.Name = "lblNumberChapters";
            this.lblNumberChapters.Size = new System.Drawing.Size(13, 13);
            this.lblNumberChapters.TabIndex = 2;
            this.lblNumberChapters.Text = "0";
            this.lblNumberChapters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wvIntroduction
            // 
            this.wvIntroduction.Location = new System.Drawing.Point(10, 132);
            this.wvIntroduction.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvIntroduction.Name = "wvIntroduction";
            this.wvIntroduction.Size = new System.Drawing.Size(405, 141);
            this.wvIntroduction.TabIndex = 10;
            // 
            // lblReadUrl
            // 
            this.lblReadUrl.AutoSize = true;
            this.lblReadUrl.Location = new System.Drawing.Point(64, 84);
            this.lblReadUrl.Name = "lblReadUrl";
            this.lblReadUrl.Size = new System.Drawing.Size(35, 13);
            this.lblReadUrl.TabIndex = 9;
            this.lblReadUrl.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Link";
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(65, 105);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(35, 13);
            this.lblIntroduction.TabIndex = 7;
            this.lblIntroduction.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giới Thiệu";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(65, 64);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(35, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tác Giả";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(65, 42);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(35, 13);
            this.lblImage.TabIndex = 3;
            this.lblImage.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Image";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu Đề";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isDisplayDataGridViewCheckBoxColumn,
            this.addedDateDataGridViewTextBoxColumn,
            this.updatedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 73);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // isDisplayDataGridViewCheckBoxColumn
            // 
            this.isDisplayDataGridViewCheckBoxColumn.DataPropertyName = "IsDisplay";
            this.isDisplayDataGridViewCheckBoxColumn.HeaderText = "IsDisplay";
            this.isDisplayDataGridViewCheckBoxColumn.Name = "isDisplayDataGridViewCheckBoxColumn";
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            this.updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            this.updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            this.updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.thuVienSachDataSet1;
            // 
            // thuVienSachDataSet1
            // 
            this.thuVienSachDataSet1.DataSetName = "ThuVienSachDataSet1";
            this.thuVienSachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btProcess);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.cbbCatogory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 0;
            // 
            // btProcess
            // 
            this.btProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.btProcess.Location = new System.Drawing.Point(725, 0);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(75, 22);
            this.btProcess.TabIndex = 2;
            this.btProcess.Text = "Process";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(121, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(679, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "https://sachvui.com/ebook/ky-nang-buong-bo-leo-babauta.2743.html";
            // 
            // cbbCatogory
            // 
            this.cbbCatogory.DataSource = this.categoriesBindingSource;
            this.cbbCatogory.DisplayMember = "Name";
            this.cbbCatogory.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbCatogory.FormattingEnabled = true;
            this.cbbCatogory.Location = new System.Drawing.Point(0, 0);
            this.cbbCatogory.Name = "cbbCatogory";
            this.cbbCatogory.Size = new System.Drawing.Size(121, 21);
            this.cbbCatogory.TabIndex = 0;
            this.cbbCatogory.ValueMember = "Id";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienSachDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbbCatogory;
        private ThuVienSachDataSet1 thuVienSachDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ThuVienSachDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDisplayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReadUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser wvIntroduction;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser wvChapterContent;
        private System.Windows.Forms.Label lblChapterName;
        private System.Windows.Forms.ComboBox cbbChapters;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSaveAll;
        private System.Windows.Forms.Button btGetChapters;
        private System.Windows.Forms.Label lblNumberChapters;
    }
}

