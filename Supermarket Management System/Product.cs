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
	public partial class Product : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=SupermarketSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		SqlDataReader dr;
		public Product()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
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
			cdProdCategory.ValueMember = "CatName";
			cdProdCategory.DataSource = dt;
			con.Close();
		}

		private void Product_Load(object sender, EventArgs e)
		{
			fillcombo();
			fillcombo1();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Seller sl1 = new Seller();
			sl1.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Category cat = new Category();
			cat.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (txtProdId.Text == "" || txtProdName.Text == "" || txtProdQuan.Text == "" || txtProdPrice.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Product (ProID,ProName,ProQuantity,ProPrice,ProCategory) values ('" + txtProdId.Text + "','" + txtProdName.Text + "','" + txtProdQuan.Text + "','" + txtProdPrice.Text + "','" + cdProdCategory.SelectedValue.ToString()+ "')", con);
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
			txtProdId.Text = "";
			txtProdName.Text = "";
			txtProdQuan.Text = "";
			txtProdPrice.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Product", con);
				adpt.Fill(dt);
				DGV3.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DGV3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtProdId.Text = DGV3.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtProdName.Text = DGV3.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtProdQuan.Text = DGV3.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtProdPrice.Text = DGV3.Rows[e.RowIndex].Cells[3].Value.ToString();
			cdProdCategory.SelectedValue = DGV3.Rows[e.RowIndex].Cells[4].Value.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtProdId.Text == "" || txtProdName.Text == "" || txtProdQuan.Text == "" || txtProdPrice.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("update Product set ProName='" + txtProdName.Text + "' , ProQuantity='" + txtProdQuan.Text + "', ProPrice='" + txtProdPrice.Text + "', ProCategory='" + cdProdCategory.SelectedValue.ToString() + "' where ProID='" + txtProdId.Text + "' ", con);
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

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtProdId.Text == "")
				{
					MessageBox.Show("Select the Category to Delete");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("delete from Product where ProID='" + txtProdId.Text + "' ", con);
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

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 se1 = new Form1();
			se1.Show();
			this.Hide();
		}

		private void cdProdCategory_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbSearchCategory_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Product where ProCategory='"+cbSearchCategory.SelectedValue.ToString()+"' ", con);
				adpt.Fill(dt);
				DGV3.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void fillcombo1()
		{
			//This method will bind the combobox with the Database
			con.Open();
			cmd = new SqlCommand("select CatName from Category", con);
			dr = cmd.ExecuteReader();
			dt = new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(dr);
			cbSearchCategory.ValueMember = "CatName";
			cbSearchCategory.DataSource = dt;
			con.Close();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			display();
		}
	}
}
