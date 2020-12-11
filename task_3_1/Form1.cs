using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3_1
{
    public partial class Form1 : Form
    {
        PointF [] points;
        Graphics graphics;
        Figure[] figures;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            Draw(graphics);
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
          
            pictureBox1.Refresh();
        }

        private void Draw(Graphics graphics)
        {
            int n = int.Parse(textBox1.Text);
            points = new PointF[n];
            string[] temp_X = textBox2.Text.Split(' ');
            string[] temp_Y = textBox3.Text.Split(' ');
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = float.Parse(temp_X[i]);
                points[i].Y = float.Parse(temp_Y[i]);
            }

            float R = float.Parse(textBox4.Text.Replace(",", ".")); 
           


            Figure figures = new Figure();

            figures.setRadious(R);
            figures.setColor(Color.Red);
            figures.setPoints(points);

            figures.DrawFigure(graphics);
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            graphics = CreateGraphics();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
