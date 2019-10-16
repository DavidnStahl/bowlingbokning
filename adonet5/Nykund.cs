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

namespace adonet5
{
    public partial class Nykund : Form
    {
        

        public Nykund()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var namn = textBox3.Text;
            var telefon = textBox4.Text;
            var email = textBox5.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;database=sporthall;Integrated Security=SSPI;";

            var sql = $"INSERT INTO Kund (Namn,Telefon,Email)  values (@NAME,@TELEFON,@EMAIL)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue($"@NAME", namn);
            cmd.Parameters.AddWithValue($"@TELEFON", telefon);
            cmd.Parameters.AddWithValue($"@EMAIL", email);
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
