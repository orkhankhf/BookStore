namespace BookStore
{
	partial class StartScreen
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.booklanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookpublisherdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookpublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.booktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookStoreDataDataSet = new BookStore.BookStoreDataDataSet();
			this.booksTableAdapter = new BookStore.BookStoreDataDataSetTableAdapters.BooksTableAdapter();
			this.book_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.book_isbn = new System.Windows.Forms.TextBox();
			this.book_author = new System.Windows.Forms.ComboBox();
			this.book_category = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.book_info = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.book_lang = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.book_price = new System.Windows.Forms.TextBox();
			this.book_publisher = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.book_amount = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.publish_date = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.book_date = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.select_photo_btn = new System.Windows.Forms.Button();
			this.book_type = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.add_book_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.booknameDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookisbnDataGridViewTextBoxColumn,
            this.bookcategoryDataGridViewTextBoxColumn,
            this.booklanguageDataGridViewTextBoxColumn,
            this.bookpriceDataGridViewTextBoxColumn,
            this.bookamountDataGridViewTextBoxColumn,
            this.bookinfoDataGridViewTextBoxColumn,
            this.bookpublisherdateDataGridViewTextBoxColumn,
            this.bookpublisherDataGridViewTextBoxColumn,
            this.booktypeDataGridViewTextBoxColumn,
            this.bookphotoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.booksBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 341);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(968, 208);
			this.dataGridView1.TabIndex = 0;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// booknameDataGridViewTextBoxColumn
			// 
			this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
			this.booknameDataGridViewTextBoxColumn.HeaderText = "book_name";
			this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
			// 
			// bookauthorDataGridViewTextBoxColumn
			// 
			this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "book_author";
			this.bookauthorDataGridViewTextBoxColumn.HeaderText = "book_author";
			this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
			// 
			// bookisbnDataGridViewTextBoxColumn
			// 
			this.bookisbnDataGridViewTextBoxColumn.DataPropertyName = "book_isbn";
			this.bookisbnDataGridViewTextBoxColumn.HeaderText = "book_isbn";
			this.bookisbnDataGridViewTextBoxColumn.Name = "bookisbnDataGridViewTextBoxColumn";
			// 
			// bookcategoryDataGridViewTextBoxColumn
			// 
			this.bookcategoryDataGridViewTextBoxColumn.DataPropertyName = "book_category";
			this.bookcategoryDataGridViewTextBoxColumn.HeaderText = "book_category";
			this.bookcategoryDataGridViewTextBoxColumn.Name = "bookcategoryDataGridViewTextBoxColumn";
			// 
			// booklanguageDataGridViewTextBoxColumn
			// 
			this.booklanguageDataGridViewTextBoxColumn.DataPropertyName = "book_language";
			this.booklanguageDataGridViewTextBoxColumn.HeaderText = "book_language";
			this.booklanguageDataGridViewTextBoxColumn.Name = "booklanguageDataGridViewTextBoxColumn";
			// 
			// bookpriceDataGridViewTextBoxColumn
			// 
			this.bookpriceDataGridViewTextBoxColumn.DataPropertyName = "book_price";
			this.bookpriceDataGridViewTextBoxColumn.HeaderText = "book_price";
			this.bookpriceDataGridViewTextBoxColumn.Name = "bookpriceDataGridViewTextBoxColumn";
			// 
			// bookamountDataGridViewTextBoxColumn
			// 
			this.bookamountDataGridViewTextBoxColumn.DataPropertyName = "book_amount";
			this.bookamountDataGridViewTextBoxColumn.HeaderText = "book_amount";
			this.bookamountDataGridViewTextBoxColumn.Name = "bookamountDataGridViewTextBoxColumn";
			// 
			// bookinfoDataGridViewTextBoxColumn
			// 
			this.bookinfoDataGridViewTextBoxColumn.DataPropertyName = "book_info";
			this.bookinfoDataGridViewTextBoxColumn.HeaderText = "book_info";
			this.bookinfoDataGridViewTextBoxColumn.Name = "bookinfoDataGridViewTextBoxColumn";
			// 
			// bookpublisherdateDataGridViewTextBoxColumn
			// 
			this.bookpublisherdateDataGridViewTextBoxColumn.DataPropertyName = "book_publisher_date";
			this.bookpublisherdateDataGridViewTextBoxColumn.HeaderText = "book_publisher_date";
			this.bookpublisherdateDataGridViewTextBoxColumn.Name = "bookpublisherdateDataGridViewTextBoxColumn";
			// 
			// bookpublisherDataGridViewTextBoxColumn
			// 
			this.bookpublisherDataGridViewTextBoxColumn.DataPropertyName = "book_publisher";
			this.bookpublisherDataGridViewTextBoxColumn.HeaderText = "book_publisher";
			this.bookpublisherDataGridViewTextBoxColumn.Name = "bookpublisherDataGridViewTextBoxColumn";
			// 
			// booktypeDataGridViewTextBoxColumn
			// 
			this.booktypeDataGridViewTextBoxColumn.DataPropertyName = "book_type";
			this.booktypeDataGridViewTextBoxColumn.HeaderText = "book_type";
			this.booktypeDataGridViewTextBoxColumn.Name = "booktypeDataGridViewTextBoxColumn";
			// 
			// bookphotoDataGridViewTextBoxColumn
			// 
			this.bookphotoDataGridViewTextBoxColumn.DataPropertyName = "book_photo";
			this.bookphotoDataGridViewTextBoxColumn.HeaderText = "book_photo";
			this.bookphotoDataGridViewTextBoxColumn.Name = "bookphotoDataGridViewTextBoxColumn";
			// 
			// booksBindingSource
			// 
			this.booksBindingSource.DataMember = "Books";
			this.booksBindingSource.DataSource = this.bookStoreDataDataSet;
			// 
			// bookStoreDataDataSet
			// 
			this.bookStoreDataDataSet.DataSetName = "BookStoreDataDataSet";
			this.bookStoreDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// booksTableAdapter
			// 
			this.booksTableAdapter.ClearBeforeFill = true;
			// 
			// book_name
			// 
			this.book_name.Location = new System.Drawing.Point(101, 12);
			this.book_name.Name = "book_name";
			this.book_name.Size = new System.Drawing.Size(181, 20);
			this.book_name.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Book Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Book Author";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Book Category";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Book ISBN";
			// 
			// book_isbn
			// 
			this.book_isbn.Location = new System.Drawing.Point(101, 64);
			this.book_isbn.Name = "book_isbn";
			this.book_isbn.Size = new System.Drawing.Size(181, 20);
			this.book_isbn.TabIndex = 5;
			// 
			// book_author
			// 
			this.book_author.FormattingEnabled = true;
			this.book_author.Location = new System.Drawing.Point(101, 38);
			this.book_author.Name = "book_author";
			this.book_author.Size = new System.Drawing.Size(181, 21);
			this.book_author.TabIndex = 9;
			// 
			// book_category
			// 
			this.book_category.FormattingEnabled = true;
			this.book_category.Location = new System.Drawing.Point(101, 90);
			this.book_category.Name = "book_category";
			this.book_category.Size = new System.Drawing.Size(181, 21);
			this.book_category.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(439, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Book Info";
			// 
			// book_info
			// 
			this.book_info.Location = new System.Drawing.Point(498, 12);
			this.book_info.Multiline = true;
			this.book_info.Name = "book_info";
			this.book_info.Size = new System.Drawing.Size(482, 156);
			this.book_info.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Book Language";
			// 
			// book_lang
			// 
			this.book_lang.FormattingEnabled = true;
			this.book_lang.Location = new System.Drawing.Point(101, 121);
			this.book_lang.Name = "book_lang";
			this.book_lang.Size = new System.Drawing.Size(181, 21);
			this.book_lang.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Book Price";
			// 
			// book_price
			// 
			this.book_price.Location = new System.Drawing.Point(101, 148);
			this.book_price.Name = "book_price";
			this.book_price.Size = new System.Drawing.Size(181, 20);
			this.book_price.TabIndex = 16;
			// 
			// book_publisher
			// 
			this.book_publisher.FormattingEnabled = true;
			this.book_publisher.Location = new System.Drawing.Point(101, 174);
			this.book_publisher.Name = "book_publisher";
			this.book_publisher.Size = new System.Drawing.Size(181, 21);
			this.book_publisher.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(15, 177);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Book Publisher";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(15, 204);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Book Amount";
			// 
			// book_amount
			// 
			this.book_amount.Location = new System.Drawing.Point(101, 201);
			this.book_amount.Name = "book_amount";
			this.book_amount.Size = new System.Drawing.Size(181, 20);
			this.book_amount.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 235);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Publish Date";
			// 
			// publish_date
			// 
			this.publish_date.Location = new System.Drawing.Point(101, 229);
			this.publish_date.Name = "publish_date";
			this.publish_date.Size = new System.Drawing.Size(181, 20);
			this.publish_date.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(15, 264);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 13);
			this.label11.TabIndex = 23;
			this.label11.Text = "Book Date";
			// 
			// book_date
			// 
			this.book_date.Location = new System.Drawing.Point(101, 258);
			this.book_date.Name = "book_date";
			this.book_date.Size = new System.Drawing.Size(181, 20);
			this.book_date.TabIndex = 24;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 293);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "Book Photo";
			// 
			// select_photo_btn
			// 
			this.select_photo_btn.Location = new System.Drawing.Point(101, 288);
			this.select_photo_btn.Name = "select_photo_btn";
			this.select_photo_btn.Size = new System.Drawing.Size(181, 23);
			this.select_photo_btn.TabIndex = 26;
			this.select_photo_btn.Text = "Select Photo";
			this.select_photo_btn.UseVisualStyleBackColor = true;
			// 
			// book_type
			// 
			this.book_type.FormattingEnabled = true;
			this.book_type.Location = new System.Drawing.Point(101, 317);
			this.book_type.Name = "book_type";
			this.book_type.Size = new System.Drawing.Size(181, 21);
			this.book_type.TabIndex = 28;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(15, 320);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 13);
			this.label13.TabIndex = 27;
			this.label13.Text = "Book Type";
			// 
			// add_book_btn
			// 
			this.add_book_btn.Location = new System.Drawing.Point(784, 174);
			this.add_book_btn.Name = "add_book_btn";
			this.add_book_btn.Size = new System.Drawing.Size(196, 51);
			this.add_book_btn.TabIndex = 29;
			this.add_book_btn.Text = "Add Book";
			this.add_book_btn.UseVisualStyleBackColor = true;
			// 
			// StartScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(992, 569);
			this.Controls.Add(this.add_book_btn);
			this.Controls.Add(this.book_type);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.select_photo_btn);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.book_date);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.publish_date);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.book_amount);
			this.Controls.Add(this.book_publisher);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.book_price);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.book_lang);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.book_info);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.book_category);
			this.Controls.Add(this.book_author);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.book_isbn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.book_name);
			this.Controls.Add(this.dataGridView1);
			this.Name = "StartScreen";
			this.Text = "BookStore";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private BookStoreDataDataSet bookStoreDataDataSet;
		private System.Windows.Forms.BindingSource booksBindingSource;
		private BookStoreDataDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookisbnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookcategoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn booklanguageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookpriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookamountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookinfoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisherdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn booktypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookphotoDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox book_name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox book_isbn;
		private System.Windows.Forms.ComboBox book_author;
		private System.Windows.Forms.ComboBox book_category;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox book_info;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox book_lang;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox book_price;
		private System.Windows.Forms.ComboBox book_publisher;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox book_amount;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker publish_date;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker book_date;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button select_photo_btn;
		private System.Windows.Forms.ComboBox book_type;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button add_book_btn;
	}
}

