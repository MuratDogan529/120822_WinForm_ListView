using System;
using System.Windows.Forms;

namespace _120822_WinForm_ListView
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi =new ListViewItem();
            
            lvi.Text = txtIsim.Text;
            lvi.SubItems.Add(txtSoyisim.Text);
            string telefon = string.Format("{0} {1} {2}",comboBox1.Text,comboBox2.Text,mskdtelefon.Text);
            lvi.SubItems.Add(telefon);
            lvi.SubItems.Add(dtpDogumTarihi.Value.ToShortDateString());
            
            listView1.Items.Add(lvi);
         }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
