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
	public partial class Form1 : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=SupermarketSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public Form1()
		{
			InitializeComponent();
			con = new SqlConnection(path);
		}

		public static string SellerName = "";
		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUsername.Text == "" || txtPassword.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					if (cbRole.SelectedIndex > -1)
					{
						if (cbRole.SelectedItem.ToString() == "ADMIN")
						{
							if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
							{
								Product pd3 = new Product();
								pd3.Show();
								this.Hide();
							}
							else
							{
								MessageBox.Show("If you are the Admin please enter correct username & password");
							}
						}
						else
						{
							try
							{
								dt = new DataTable();
								con.Open();
								adpt = new SqlDataAdapter("select count(8) from Seller where SellName='"+txtUsername.Text+ "' and SellPassword='"+txtPassword.Text+"' ", con);
								adpt.Fill(dt);
								if(dt.Rows[0][0].ToString()=="1")
								{
									SellerName = txtUsername.Text;
									Selling s4 = new Selling();
									s4.Show();
									this.Hide();
								}
								else
								{
									MessageBox.Show("Wrong username & password");
								}
								con.Close();
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						MessageBox.Show("Select a Role");
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
