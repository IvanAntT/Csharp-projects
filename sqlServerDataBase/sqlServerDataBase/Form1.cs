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
using System.Diagnostics;
using System.IO;

namespace sqlServerDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=192.168.0.101,1433;" +
                "Network Library=DBMSSOCN;" +
                "Initial Catalog=FirstDB;" +
                "User ID=THE_JOHNY_STYLE;Password=egn9211285320;"))
                {
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            MessageBox.Show("svurzva se");
                            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.People(Name) VALUES('"+textBox1.Text+"')",con);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ne se polu4ava");
                        }
                        con.Close();
                    }
                    catch (SqlException) { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=192.168.0.101,1433;" +
                "Network Library=DBMSSOCN;" +
                "Initial Catalog=FirstDB;" +
                "User ID=THE_JOHNY_STYLE;Password=egn9211285320;"))
                {
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            MessageBox.Show("svurzva se");
                            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.People WHERE Number='"+textBox3.Text+"';",con);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                textBox4.Text = reader[1].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ne se polu4ava");
                        }
                        con.Close();
                    }
                    catch (SqlException) { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=192.168.0.101,1433;" +
                "Network Library=DBMSSOCN;" +
                "Initial Catalog=FirstDB;" +
                "User ID=THE_JOHNY_STYLE;Password=egn9211285320;"))
                {
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            MessageBox.Show("svurzva se");
                            SqlCommand cmd = new SqlCommand("UPDATE dbo.People set Name='" + textBox6.Text + "' where Number='" + textBox5.Text+"';", con);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Ne se polu4ava");
                        }
                        con.Close();
                    }
                    catch (SqlException ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();
            notePad.StartInfo.FileName = @"C:\MOI RABOTI\Winamp\winamp.exe";
            notePad.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=192.168.0.101,1433;" +
                "Network Library=DBMSSOCN;" +
                "Initial Catalog=FirstDB;" +
                "User ID=THE_JOHNY_STYLE;Password=egn9211285320;"))
                {
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            FileStream file = new FileStream(textBox7.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                  
                            byte[] image = new byte[file.Length];
                            file.Read(image, 0, Convert.ToInt32(file.Length));
                            file.Close();
                            MessageBox.Show("svurzva se");
                            SqlCommand cmd = new SqlCommand("UPDATE dbo.People SET photo=@pic WHERE NUMBER='2';", con);
                            SqlParameter param = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                            cmd.Parameters.Add(param);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ne se polu4ava");
                            
                        }
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=192.168.0.102,1433;" +
                "Network Library=DBMSSOCN;" +
                "Initial Catalog=FirstDB;" +
                "User ID=THE_JOHNY_STYLE;Password=egn9211285320;"))
                {
                    try
                    {
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.People WHERE Number='" + textBox8.Text + "';", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            string names = "";
                            names = (string)dt.Rows[0][1];
                            label7.Text = names;
                            byte[] myData = new byte[0];
                            myData = (byte[])dt.Rows[0][2];
                            MemoryStream str = new MemoryStream(myData);
                            pictureBox1.Image = Image.FromStream(str);
                        }
                        else
                        {
                            MessageBox.Show("Ne se polu4ava");
                        }
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
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
