using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "Aplikacja WinForms";
            lblText.Text = "";

            listBox1.Items.Clear();
            listBox1.Items.Add("Polska");
            listBox1.Items.Add("Ukraina");
            listBox1.Items.Add("Lista");
            listBox1.SelectedIndex = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Wciśnięto przycisk z tekstem: "+btn.Text);
        }

        private void cbOpcja1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOpcja1.Checked)
            {
                lblText.Text = " >= 18";
            } else
            {
                lblText.Text = " < 18 ";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblText.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Timer = " + counter;
            counter++;
        }
    }
}
