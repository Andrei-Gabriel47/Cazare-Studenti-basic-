using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            mesaj += "Studentul " + textBox1.Text + " " + textBox2.Text + " este din localitatea " + comboBox1.SelectedItem;
            if (checkBox1.Checked)
            {
                mesaj += " si doreste cazare";
                if (radioButton1.Checked)
                {
                    mesaj += " in caminul " + radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    mesaj += " in caminul " + radioButton2.Text;
                }
                else mesaj += " in caminul " + radioButton3.Text;
            }
            else mesaj += "si nu doreste cazare";
            MessageBox.Show(mesaj);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;

            }
            else
            {
                radioButton1.Enabled=false;
                radioButton2.Enabled=false;
                radioButton3.Enabled=false;
            }
        }
    }
}
