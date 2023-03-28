using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class deposito : Form
    {
        public deposito()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            transferencia trans = new transferencia ();
            deposito.ActiveForm.Visible = false;
            trans.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retiro ret = new retiro();
            deposito.ActiveForm.Visible = false;
            ret.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            deposito.ActiveForm.Visible = false;
            men.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            deposito.ActiveForm.Visible = false;
            men.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("desea realizar su Deposito", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Deposito Exitoso");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
