using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ObjectInteractionSimulator
{
    public partial class Simulator : Form
    {

        Graphics graphics;

        List<PhysicalObject> objects = new List<PhysicalObject>();

        public Simulator()
        {
            InitializeComponent();
            //this.Paint += new PaintEventHandler(paintBall);
            objects.Add(new PhysicalObject(centerX: 50, centerY: 400, angle: 45, speed: 6, radius: 20, mass: 1));
            objects.Add(new PhysicalObject(centerX: 100, centerY: 249, angle: 15, speed: 8, radius: 20, mass: 1));
            objects.Add(new PhysicalObject(centerX: 200, centerY: 600, angle: 215, speed: 3, radius: 20, mass: 1));
            objects.ForEach((item) => this.Paint += new PaintEventHandler((sender, e) => PaintObject(sender, e, item)));
            this.Size = new Size(816, 839);
            //Console.WriteLine(this.ClientSize.Width);
            //Console.WriteLine(this.ClientSize.Height);
            this.DoubleBuffered = true;
        }

        private void PaintObject(object sender, PaintEventArgs e, PhysicalObject po)
        {
            graphics = e.Graphics;

            RectangleF rect = new RectangleF(po.CenterX - po.Radius, po.CenterY - po.Radius, po.Radius * 2, po.Radius * 2);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);

            //center color should be brghter; to make darker - lower values proportionally
            pthGrBrush.CenterColor = Color.FromArgb(255, 0, 255, 0);
            Color[] colors = { Color.FromArgb(255, 0, 120, 0) };
            pthGrBrush.SurroundColors = colors;

            //SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#ff00ff"));
            graphics.FillEllipse(pthGrBrush, rect);
        }

        private void MoveObject(PhysicalObject po)
        {
            float newBall_x = po.CenterX + po.SpeedX;
            float newBall_y = po.CenterY + po.SpeedY;

            if (newBall_x < po.Radius || newBall_x > this.ClientSize.Width - po.Radius)
                po.SpeedX = -po.SpeedX;
            if (newBall_y < po.Radius || newBall_y > this.ClientSize.Height - po.Radius)
            {
                po.SpeedY = -po.SpeedY;
            }

            po.CenterX += po.SpeedX;
            po.CenterY += po.SpeedY;
            po.CenterX += po.SpeedX;
            po.CenterY += po.SpeedY;
            //TODO: find angle and speed;
            //speed: Pitagor
            //angle: arctan/arccotan
            Invalidate();
            //TODO: refactor method
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void control_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            objects.ForEach((item) => MoveObject(item));
        }
    }
}
