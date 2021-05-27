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
	public partial class Seller : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=SupermarketSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public Seller()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product pd1 = new Product();
			pd1.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Category cat1 = new Category();
			cat1.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (txtSellId.Text == "" || txtSellName.Text == "" || txtSellAddress.Text == "" || txtSellAge.Text == "" || txtSellPhonenum.Text == "" || txtSellPassword.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Seller (SellID,SellName,SellAddress,SellAge,SellPhonenumber,SellPassword) values ('" + txtSellId.Text + "','" + txtSellName.Text + "','" + txtSellAddress.Text + "','" + txtSellAge.Text + "','" + txtSellPhonenum.Text + "','" + txtSellPassword.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
					display();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void clear()
		{
			txtSellId.Text = "";
			txtSellName.Text = "";
			txtSellAddress.Text = "";
			txtSellAge.Text = "";
			txtSellPhonenum.Text = "";
			txtSellPassword.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Seller", con);
				adpt.Fill(dt);
				DGV2.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtSellId.Text == "")
				{
					MessageBox.Show("Select the Seller to Delete");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("delete from Seller where SellID='" + txtSellId.Text + "' ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been deleted");
					clear();
					display();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtSellId.Text == "" || txtSellName.Text == "" || txtSellAddress.Text == "" || txtSellAge.Text == "" || txtSellPhonenum.Text == "" || txtSellPassword.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("update Seller set SellName='" + txtSellName.Text + "' , SellAddress='" + txtSellAddress.Text + "', SellAge='" + txtSellAge.Text + "', SellPhonenumber='" + txtSellPhonenum.Text + "', SellPassword='" + txtSellPassword.Text + "' where SellID='" + txtSellId.Text + "' ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been updated");
					clear();
					display();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DGV2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtSellId.Text = DGV2.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtSellName.Text = DGV2.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtSellAddress.Text = DGV2.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtSellAge.Text = DGV2.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtSellPhonenum.Text = DGV2.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtSellPassword.Text = DGV2.Rows[e.RowIndex].Cells[5].Value.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 se2 = new Form1();
			se2.Show();
			this.Hide();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

		}
	}
}
