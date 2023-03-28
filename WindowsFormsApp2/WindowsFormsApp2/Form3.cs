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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            retiro ret = new retiro();
            menu.ActiveForm.Visible = false;
            ret.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            deposito dep = new deposito();
            menu.ActiveForm.Visible = false;
            dep.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            transferencia trans = new transferencia();
            menu.ActiveForm.Visible = false;
            trans.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            retiro ret = new retiro();
            menu.ActiveForm.Visible = false;
            ret.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deposito dep = new deposito();
            menu.ActiveForm.Visible = false;
            dep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transferencia trans = new transferencia();
            menu.ActiveForm.Visible = false;
            trans.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            menu.ActiveForm.Visible = false;
            ini.Show();
        }
    }
}
