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
    public partial class retiro : Form
    {
        public retiro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea realizar el Retiro", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Retiro Exitoso!");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            retiro.ActiveForm.Visible = false;
            men.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            retiro.ActiveForm.Visible = false;
            men.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deposito dep = new deposito();
            retiro.ActiveForm.Visible = false;
            dep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transferencia trans = new transferencia();
            retiro.ActiveForm.Visible = false;
            trans.Show();
        }
    }
}
