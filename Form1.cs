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

namespace khongsiemnua
{
    public partial class Form1 : Form
    {
        String str = "Data Source=A209PC40;Initial Catalog=khongsiemnua;Integrated Security=true";
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection connect;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(str);
                connect.Open();
                string insertString = "insert into khongsiemnua values ('10','dixemay')";
                SqlCommand cmd = new SqlCommand(insertString, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(str);
                connect.Open();
                string updateString = "update khongsiemnua set ID = '05' where ID = '09'";
                string updateString1 = "update khongsiemnua set NAME = 'yessir' where ID = '05'";
                SqlCommand cmd = new SqlCommand(updateString, connect);
                SqlCommand cmd1 = new SqlCommand(updateString1, connect);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Success!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(str);
                connect.Open();
                string updateString = "delete khongsiemnua where ID = '10'";
                SqlCommand cmd = new SqlCommand(updateString, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!!");
            }
        }
    }
}
