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
    public partial class UppdateraKund : Form
    {
        private readonly string namnAttAndra;

        public UppdateraKund(string namnAttAndra)
        {
            InitializeComponent();
            this.namnAttAndra = namnAttAndra;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var namn = textBox1.Text;
            var telefon = Telefon.Text;
            var email = Email.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;database=sporthall;Integrated Security=SSPI;";

            var sql = $"UPDATE Kund SET Namn = @NAME,Telefon = @TELEFON,Email = @EMAIL where namn = @KUNDANDRA";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue($"@NAME", namn);
            cmd.Parameters.AddWithValue($"@TELEFON", telefon);
            cmd.Parameters.AddWithValue($"@EMAIL", email);
            cmd.Parameters.AddWithValue($"@KUNDANDRA", namnAttAndra);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
