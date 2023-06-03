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

namespace Apartman_Otomasyonu
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        SqlHelper sqlHelper = new SqlHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(comboBox1.Text);
            int tutar = (int)numericUpDown1.Value;
            DateTime yeniTarih = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("Daireno",daireNo);
            SqlParameter p2 = new SqlParameter("Para", tutar);
            SqlParameter p3 = new SqlParameter("Tarih", yeniTarih);

            sqlHelper.ExecuteProc("odeme_al",p1,p2,p3);

        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable ciktilar = sqlHelper.GetTable("select * from AidatOdemesi");

            foreach (DataRow item in ciktilar.Rows)
            {
                listBox1.Items.Add(item["DaireNo"]).ToString();
                listBox3.Items.Add(item["Para"]).ToString();
                listBox2.Items.Add(item["Tarih"]).ToString();
            }
        }
    }
}
