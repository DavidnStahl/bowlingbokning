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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nyKund_Click(object sender, EventArgs e)
        {
            var form = new Nykund();
            form.ShowDialog();

        }

        private void sokKunder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var kundnamn = textBox1.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;database=sporthall;Integrated Security=SSPI;";
            var sql = $"Select namn from kund where namn like @NAME";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (kundnamn.Length == 1)
            {
                cmd.Parameters.AddWithValue($"@NAME", kundnamn + "%");
            }
            else
            {
                cmd.Parameters.AddWithValue($"@NAME", "%" + kundnamn + "%");
            }
            SqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {

                listBox1.Items.Add((result["namn"].ToString()));
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UppdaKund_Click(object sender, EventArgs e)
        {
            var selectedKund = listBox1.SelectedItem.ToString();
            var form = new UppdateraKund(selectedKund);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedKund = listBox1.SelectedItem.ToString();
            var form = new BokaBana(selectedKund);
            form.ShowDialog();
        }
    }
}
