using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Color c
        {
            set { colorDialog1.Color = value; }
            get { return colorDialog1.Color; }
                
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult dlg = colorDialog1.ShowDialog();

            if (dlg == DialogResult.OK)
           {
               c = colorDialog1.Color;
               Invalidate();
        }

        }
        public Font f
        {
            set { if (value.Name == "Times New Roman")
                    radioButton1.Checked = true;
                else if (value.Name == "Arial")
                    radioButton2.Checked = true;
                else
                    radioButton3.Checked = true;
                }

            get {
                Font f;
                if (radioButton1.Checked==true)
                {
                    f = new Font("Times New Roman", 20);
                }
                 else if (radioButton2.Checked==true)
                {
                    f = new Font("Arial", 20);
                }

                else { f = new Font("Calibri", 20); }
                    
                  
                return f;
             
            }

        }
    
        public string TXTBox
        {
            set { textBox2.Text = value; }
            get
            {
                string str;
                if (textBox1.Text == "")
                {
                    str = textBox2.Text;
                }
                else
                {
                    str = textBox1.Text;
                }
                return str;
            }
        }
      
       

    }
}
