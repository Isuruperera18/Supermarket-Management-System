using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket_Management_System
{
	public partial class Selling : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=SupermarketSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		SqlDataReader dr;
		public Selling()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
			populate();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select ProName,ProPrice from Product", con);
				adpt.Fill(dt);
				DGV4.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		int flag = 0;
		private void DGV4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtSellProname.Text = DGV4.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtSellPrice.Text = DGV4.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
		}

		int GrdTotal = 0 , n=0 ;

		private void button4_Click(object sender, EventArgs e)
		{
			if (txtSellBillid.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Bill (BillID,SellerName,BillDate,TotalAmount) values ('" + txtSellBillid.Text + "','" + lblSeller.Text + "','" + lblDate.Text + "','" + lblRS.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
					populate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			try
			{
				if (txtSellProname.Text == "" || txtSellQuantity.Text == "" || txtSellPrice.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					int Total = Convert.ToInt32(txtSellQuantity.Text) * Convert.ToInt32(txtSellPrice.Text);

					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(DGV6);
					newRow.Cells[0].Value = n + 1;
					newRow.Cells[1].Value = txtSellProname.Text;
					newRow.Cells[2].Value = txtSellQuantity.Text;
					newRow.Cells[3].Value = txtSellPrice.Text;
					newRow.Cells[4].Value = Convert.ToInt32(txtSellQuantity.Text) * Convert.ToInt32(txtSellPrice.Text);
					DGV6.Rows.Add(newRow);
					n++;
					GrdTotal = GrdTotal + Total;
					lblRS.Text = "" + GrdTotal;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void clear()
		{
			txtSellBillid.Text = "";
			txtSellProname.Text = "";
			txtSellQuantity.Text = "";
			txtSellPrice.Text = "";
		}

		private void DGV5_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			flag = 1;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("ISSA'S Family SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));

			e.Graphics.DrawString("Bill ID : " + DGV5.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.RoyalBlue, new Point(100,70));

			e.Graphics.DrawString("Seller Name : " + DGV5.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.RoyalBlue, new Point(100, 100));

			e.Graphics.DrawString("Bill Date : " + DGV5.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.RoyalBlue, new Point(100, 130));

			e.Graphics.DrawString("Total Amount : " + DGV5.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.RoyalBlue, new Point(100, 160));

			e.Graphics.DrawString("Thank You", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.RoyalBlue, new Point(230,230));
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			display();
		}

		private void cdSellCategory_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select ProName,ProPrice from Product where ProCategory='" + cdSellCategory.SelectedValue.ToString() + "' ", con);
				adpt.Fill(dt);
				DGV4.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void fillcombo()
		{
			//This method will bind the combobox with the Database
			con.Open();
			cmd = new SqlCommand("select CatName from Category", con);
			dr = cmd.ExecuteReader();
			dt = new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(dr);
			cdSellCategory.ValueMember = "CatName";
			cdSellCategory.DataSource = dt;
			con.Close();
		}

		private void Selling_Load(object sender, EventArgs e)
		{
			fillcombo();
			lblSeller.Text = Form1.SellerName;
		}

		private void label10_Click(object sender, EventArgs e)
		{
			Form1 f2 = new Form1();
			f2.Show();
			this.Hide();
		}

		public void populate()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Bill", con);
				adpt.Fill(dt);
				DGV5.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
