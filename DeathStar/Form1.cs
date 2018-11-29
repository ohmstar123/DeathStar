using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            float xx; float yy; float sizze;
            xx = Convert.ToInt16(xInput.Text);
            yy = Convert.ToInt16(yInput.Text);
            sizze = Convert.ToInt16(sizeInput.Text);

            Pen deathPen = new Pen(Color.White, 5);
            DeathStar(deathPen, xx, yy, sizze);
        }

        public void DeathStar(Pen deathPen, float x, float y, float size)
        {
            Graphics g = this.CreateGraphics();

            g.DrawArc(deathPen, 20, 20, 200, 200, 282, 335);

            Pen testPen = new Pen(Color.Red, 5);
            g.DrawLine(testPen, 100, 20, 100, 50);
            g.DrawLine(testPen, 140, 20, 140, 50);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
