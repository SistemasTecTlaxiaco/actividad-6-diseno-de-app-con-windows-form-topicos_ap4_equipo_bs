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
    public partial class transferencia : Form
    {
        public transferencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deposito dep = new deposito();
            transferencia.ActiveForm.Visible = false;
            dep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retiro ret = new retiro();
            transferencia.ActiveForm.Visible = false;
            ret.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            transferencia.ActiveForm.Visible = false;
            men.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            transferencia.ActiveForm.Visible = false;
            men.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea realizar la Transferencia", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Transferencia Exitosa!");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
