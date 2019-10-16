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
    public partial class BokaBana : Form
    {
        private readonly string kundNamn;

        public BokaBana(string kundNamn)
        {
            InitializeComponent();
            this.kundNamn = kundNamn;
        }

        private void BokaBanaknapp_Click(object sender, EventArgs e)
        {
            var starttid = textBox1.Text.ToString();
            var sluttid = textBox2.Text.ToString();
            var banID = textBox3.Text.ToString();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;database=sporthall;Integrated Security=SSPI;";
            var kundid = $"SELECT kundid from kund where namn = @KUNDNAMN";
            conn.Open();
            SqlCommand cmd = new SqlCommand(kundid, conn);
            cmd.Parameters.AddWithValue($"@KUNDNAMN", kundNamn);
            var result = cmd.ExecuteScalar().ToString();
            var sql = $"INSERT INTO Bokning (starttid,sluttid,kundid,banid) values (@STARTTID,@SLUTTID,@KUNDID,@BANID)";

            SqlCommand cmd2 = new SqlCommand(sql, conn);           
            cmd2.Parameters.AddWithValue($"@STARTTID", starttid);
            cmd2.Parameters.AddWithValue($"@SLUTTID", sluttid);
            cmd2.Parameters.AddWithValue($"@KUNDID", result);
            cmd2.Parameters.AddWithValue($"@BANID", banID);
            cmd2.ExecuteNonQuery();
            conn.Close();
            this.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
