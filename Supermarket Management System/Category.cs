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
	public partial class Category : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=SupermarketSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public Category()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (txtCatId.Text == "" || txtCatName.Text == "" || txtCatDesc.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Category (CatID,CatName,CatDescription) values ('" + txtCatId.Text + "','" + txtCatName.Text + "','" + txtCatDesc.Text + "')", con);
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
			txtCatId.Text = "";
			txtCatName.Text = "";
			txtCatDesc.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Category", con);
				adpt.Fill(dt);
				DGV1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCatId.Text = DGV1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtCatName.Text = DGV1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtCatDesc.Text = DGV1.Rows[e.RowIndex].Cells[2].Value.ToString();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if(txtCatId.Text=="")
				{
					MessageBox.Show("Select the Category to Delete");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("delete from Category where CatID='" + txtCatId.Text + "' ", con);
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
				if (txtCatId.Text == "" || txtCatName.Text == "" || txtCatDesc.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("update Category set CatName='" + txtCatName.Text + "' , CatDescription='" + txtCatDesc.Text + "' where CatID='" + txtCatId.Text + "' ", con);
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

		private void button1_Click(object sender, EventArgs e)
		{
			Seller sl = new Seller();
			sl.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product pd = new Product();
			pd.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 se3 = new Form1();
			se3.Show();
			this.Hide();
		}
	}
}
