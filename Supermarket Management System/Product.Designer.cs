
namespace Supermarket_Management_System
{
	partial class Product
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.cbSearchCategory = new System.Windows.Forms.ComboBox();
			this.DGV3 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.cdProdCategory = new System.Windows.Forms.ComboBox();
			this.txtProdPrice = new System.Windows.Forms.TextBox();
			this.txtProdQuan = new System.Windows.Forms.TextBox();
			this.txtProdName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProdId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.cbSearchCategory);
			this.panel1.Controls.Add(this.DGV3);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.cdProdCategory);
			this.panel1.Controls.Add(this.txtProdPrice);
			this.panel1.Controls.Add(this.txtProdQuan);
			this.panel1.Controls.Add(this.txtProdName);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtProdId);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(188, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1133, 696);
			this.panel1.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(628, 662);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(304, 21);
			this.label8.TabIndex = 21;
			this.label8.Text = "[Shown Price(RS) is for 1Kg or 1 Item]";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(915, 110);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(113, 38);
			this.button7.TabIndex = 18;
			this.button7.Text = "REFRESH";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// cbSearchCategory
			// 
			this.cbSearchCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSearchCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSearchCategory.FormattingEnabled = true;
			this.cbSearchCategory.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.cbSearchCategory.Location = new System.Drawing.Point(685, 115);
			this.cbSearchCategory.Name = "cbSearchCategory";
			this.cbSearchCategory.Size = new System.Drawing.Size(185, 31);
			this.cbSearchCategory.TabIndex = 17;
			this.cbSearchCategory.Text = "Select Category";
			this.cbSearchCategory.SelectionChangeCommitted += new System.EventHandler(this.cbSearchCategory_SelectionChangeCommitted);
			// 
			// DGV3
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.DGV3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.DGV3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV3.BackgroundColor = System.Drawing.Color.White;
			this.DGV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DGV3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DGV3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.DGV3.ColumnHeadersHeight = 30;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV3.DefaultCellStyle = dataGridViewCellStyle6;
			this.DGV3.EnableHeadersVisualStyles = false;
			this.DGV3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DGV3.Location = new System.Drawing.Point(486, 176);
			this.DGV3.Name = "DGV3";
			this.DGV3.RowHeadersVisible = false;
			this.DGV3.RowHeadersWidth = 51;
			this.DGV3.RowTemplate.Height = 28;
			this.DGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV3.Size = new System.Drawing.Size(610, 483);
			this.DGV3.TabIndex = 16;
			this.DGV3.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.DGV3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.DGV3.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DGV3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DGV3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DGV3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DGV3.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.DGV3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DGV3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
			this.DGV3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DGV3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DGV3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DGV3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DGV3.ThemeStyle.HeaderStyle.Height = 30;
			this.DGV3.ThemeStyle.ReadOnly = false;
			this.DGV3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.DGV3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DGV3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DGV3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DGV3.ThemeStyle.RowsStyle.Height = 28;
			this.DGV3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DGV3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DGV3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV3_CellDoubleClick);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(309, 436);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(113, 38);
			this.button6.TabIndex = 15;
			this.button6.Text = "DELETE";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(172, 436);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(113, 38);
			this.button5.TabIndex = 14;
			this.button5.Text = "UPDATE";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(32, 436);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 38);
			this.button4.TabIndex = 13;
			this.button4.Text = "ADD";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// cdProdCategory
			// 
			this.cdProdCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cdProdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cdProdCategory.FormattingEnabled = true;
			this.cdProdCategory.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
			this.cdProdCategory.Location = new System.Drawing.Point(183, 357);
			this.cdProdCategory.Name = "cdProdCategory";
			this.cdProdCategory.Size = new System.Drawing.Size(185, 31);
			this.cdProdCategory.TabIndex = 12;
			this.cdProdCategory.Text = "Select Category";
			this.cdProdCategory.SelectedIndexChanged += new System.EventHandler(this.cdProdCategory_SelectedIndexChanged);
			// 
			// txtProdPrice
			// 
			this.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProdPrice.Location = new System.Drawing.Point(183, 301);
			this.txtProdPrice.Name = "txtProdPrice";
			this.txtProdPrice.Size = new System.Drawing.Size(185, 25);
			this.txtProdPrice.TabIndex = 11;
			// 
			// txtProdQuan
			// 
			this.txtProdQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProdQuan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProdQuan.Location = new System.Drawing.Point(183, 251);
			this.txtProdQuan.Name = "txtProdQuan";
			this.txtProdQuan.Size = new System.Drawing.Size(185, 25);
			this.txtProdQuan.TabIndex = 10;
			// 
			// txtProdName
			// 
			this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProdName.Location = new System.Drawing.Point(183, 201);
			this.txtProdName.Name = "txtProdName";
			this.txtProdName.Size = new System.Drawing.Size(185, 25);
			this.txtProdName.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(52, 357);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Category";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(52, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(52, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Quantity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(52, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Name";
			// 
			// txtProdId
			// 
			this.txtProdId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProdId.Location = new System.Drawing.Point(183, 142);
			this.txtProdId.Name = "txtProdId";
			this.txtProdId.Size = new System.Drawing.Size(185, 25);
			this.txtProdId.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(52, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(452, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Manage Products";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button2.Location = new System.Drawing.Point(12, 325);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 38);
			this.button2.TabIndex = 9;
			this.button2.Text = "CATEGORIES";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button1.Location = new System.Drawing.Point(12, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 38);
			this.button1.TabIndex = 10;
			this.button1.Text = "SELLER";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.button3.Location = new System.Drawing.Point(12, 705);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 38);
			this.button3.TabIndex = 11;
			this.button3.Text = "LOGOUT";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.label5.Location = new System.Drawing.Point(1330, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "X";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// Product
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 785);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Product";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product";
			this.Load += new System.EventHandler(this.Product_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProdPrice;
		private System.Windows.Forms.TextBox txtProdQuan;
		private System.Windows.Forms.TextBox txtProdName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProdId;
		private System.Windows.Forms.ComboBox cdProdCategory;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ComboBox cbSearchCategory;
		private Guna.UI2.WinForms.Guna2DataGridView DGV3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
	}
}