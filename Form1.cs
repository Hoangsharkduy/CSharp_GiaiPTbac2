using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_GiaiPTbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void btngpt_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b= Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            Double delta, x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                     if (c != 0)
                    {
                        grb.Text = "Phương Trình Bậc";
                    }
                    else
                    {
                        grb.Text = "Phương trình có vô số nghiệm";
                    }
                }
                else
                {
                    x1 = x2 = -c / b;
                    grb.Text = "Phương trình có nghiệm x = " + x1;
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    grb.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    grb.Text = "Phương trình có nghiệm kép x1 = x2 = " + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    grb.Text = "Phương trình có 2 nghiệm phân biệt " + " \nx1 = " + x1 + " \nx2 = " + x2;
                }
            }
                
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
           
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           
        }
    }
     
}

