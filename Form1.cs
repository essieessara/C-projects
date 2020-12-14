using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //display
        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "Select * From Employee";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            listView1.Items.Clear();
            while (dReader.Read())
            {
                string str = ((int)dReader[0]).ToString() + (string)dReader[1]  + ((int)dReader[2]).ToString() +(string)dReader[3] + "\n" ;
               
                listView1.Items.Add(str);
                
            }
            dReader.Close();
            sqlConnection1.Close();

        }

        //Insert
        private void button2_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "Insert Into Employee Values('"+ textBox1.Text+ "' ,' " + (textBox2.Text) + "','"+textBox3.Text + "' ,' " + textBox4.Text + "')";
            try
            {
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                
           }
            catch (SqlException)
            {
                MessageBox.Show("ID already Exist");
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        //search
        private void button3_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "Select * From Employee Where ID = " + textBox1.Text;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            if (dReader.Read())
            {
                textBox2.Text = (string)dReader[1];
                textBox3.Text = ((int)dReader[2]).ToString();
                textBox4.Text = (string)dReader[3];
            }
            else
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                MessageBox.Show("ID is not available");
            }
            dReader.Close();
            sqlConnection1.Close();
        }

        //update
        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "Select * From Employee Where ID = " + textBox1.Text;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            if (dReader.Read())
            {
                dReader.Close();
                sqlCommand1.CommandText = "Update Employee Set Name = '" + textBox2.Text + "' Where ID = " + textBox1.Text
                + "Update Employee Set Salary = '" + textBox3.Text + "' Where ID = " + textBox1.Text
                + "Update Employee Set Position = '" + textBox4.Text + "' Where ID = " + textBox1.Text;
                sqlCommand1.ExecuteNonQuery();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
            else
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                MessageBox.Show("ID is not available");
            }
            sqlConnection1.Close();

        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "Select * From Employee Where ID = " + textBox1.Text;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            if (dReader.Read())
            {
                dReader.Close();
                sqlCommand1.CommandText = "Delete From Employee Where ID = " + textBox1.Text;
                sqlCommand1.ExecuteNonQuery();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
            else
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                MessageBox.Show("ID is not available");
            }
            sqlConnection1.Close();
        }

    }
    }

