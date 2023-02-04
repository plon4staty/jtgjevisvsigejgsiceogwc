using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        NpgsqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String str = "Host=db.edu.cchgeu.ru;Port=5432;Database=193_Bordyukhin;Username=193_Bordyukhin;Password=193_Bordyukhin";
            con = new NpgsqlConnection(str);
            try
            {
                con.Open();
                button1.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button6.Enabled = false;
            dataGridView1.DataSource = null;
        }

    }
}+
    fghfghfghthgthgfthgfthgfhgfthgfhgfttttggg