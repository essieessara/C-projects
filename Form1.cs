using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab_5
{

    public partial class Form1 : Form
    {
        //String
        string m_text;
        Brush m_textbrush;
        Font m_textfont;
        Color m_textcolor;
        //PointF m_textstart;

        //Line
        Pen m_line;
        Color m_linecolor;
        Point m_linestart;
        Point m_lineend;

        //rectangle
        Color m_FillRectColor;
        Brush m_FillRectBrush;
        Rectangle m_FillRect;
        HatchStyle m_FillRectStyle;
        Color m_FillRectBkColor;



        public Form1()
        {
            InitializeComponent();
            m_text = "ITI .Net Full Stack";
            m_textcolor = Color.Red;
            m_textfont = new Font("Arial", 20, style:FontStyle.Underline);
            m_textbrush = new SolidBrush(m_textcolor);
            m_linecolor = Color.Blue;
            m_line = new Pen(m_linecolor);
            m_linestart = new Point(275,300);
            m_lineend = new Point(525,300);
            m_FillRectColor = Color.Beige;
            m_FillRectStyle = HatchStyle.BackwardDiagonal;
            m_FillRectBkColor = Color.Blue;
            m_FillRectBrush = new HatchBrush(m_FillRectStyle, m_FillRectColor, m_FillRectBkColor);
            m_FillRect = new Rectangle(100, 40, 80, 100);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayText();
            DisplayLine();
            DisplayRect();
        }

        private void DisplayText()
        {

            //float x = 400.0F;
            float x = (float)(this.Width / 2.0);
            //float y = 225.0F;
            float y = (float)(this.Height / 2.0);
            Graphics g = this.CreateGraphics();
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(m_text, m_textfont, m_textbrush, x,y, stringFormat);
        

        }
        private void DisplayLine()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(m_line, m_linestart, m_lineend);

        }
        private void DisplayRect()
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(m_FillRectBrush, m_FillRect);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            m_text = "X = " + e.X.ToString() + ", Y = " + e.Y.ToString();
            Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 2: //Blue
                    {
                        m_FillRectColor = Color.Blue;
                        break;
                    }
                case 7: //Green
                    {
                        m_FillRectColor = Color.Green;
                        break;
                    }
                case 18: //Red
                    {
                        m_FillRectColor = Color.Red;
                        break;
                    }
            }
            m_FillRectBrush = new HatchBrush(m_FillRectStyle,m_FillRectColor);
        
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
