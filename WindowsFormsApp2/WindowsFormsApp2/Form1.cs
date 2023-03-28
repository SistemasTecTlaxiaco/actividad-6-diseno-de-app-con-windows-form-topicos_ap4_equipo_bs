using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLi;
namespace WindowsFormsApp2
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }
        String res1 = "";
        String res2 = "";
        String res3 = "";
        String res4 = "";
        String res5 = "";
        String res6 = "";

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult res = MessageBox.Show("desea realizar su registro","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                res1 = Class1.nom(text1.Text);
                res2 = Class1.apellidos(text2.Text);
                res3 = Class1.cuenta(text3.Text);
                res4 = Class1.email(text4.Text);
                res5 = Class1.use(text5.Text);
                res6 = Class1.pasw(text6.Text);
                if (res1.Equals(""))
                {
                    if (res1.Equals(""))
                    {
                        if (res2.Equals(""))
                        {
                            if (res3.Equals(""))
                            {
                                if (res4.Equals(""))
                                {
                                    if (res5.Equals(""))
                                    {
                                        if (res6.Equals(""))
                                        {
                                            MessageBox.Show("Registro exitoso");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso de manera incorrecta los siguintes datos\n "+res1+"\n"+res2+"\n" + res3 + "\n" + res4 + "\n" + res5 + "\n" + res6 + "\n");
                }
                
            }
            else
            {
                text1.Text = "";
                text2.Text = "";
                text3.Text = "";
                text4.Text = "";
                text6.Text = "";
                text5.Text = "";
            }
            inicio ini = new inicio();
            registro.ActiveForm.Visible = false;
            ini.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
