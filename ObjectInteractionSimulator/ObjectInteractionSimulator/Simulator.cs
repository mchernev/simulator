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

            //objects.Add(new PhysicalObject(centerX: 50, centerY: 400, angle: 45, speed: 6, radius: 20, mass: 1, color: Tuple.Create(255, 25, 255)));
            //objects.Add(new PhysicalObject(centerX: 100, centerY: 249, angle: 15, speed: 8, radius: 20, mass: 1, color: Tuple.Create(25, 255, 255)));
            //objects.Add(new PhysicalObject(centerX: 200, centerY: 600, angle: 215, speed: 3, radius: 20, mass: 1, color: Tuple.Create(255, 255, 25)));

            //objects.Add(new PhysicalObject(centerX: 100, centerY: 120, angle: 3, speed: 20, radius: 30, mass: 1, color: Tuple.Create(255, 25, 255)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 118, angle: 2, speed: 2, radius: 30, mass: 1, color: Tuple.Create(255, 25, 255)));

            //objects.Add(new PhysicalObject(centerX: 100, centerY: 140, angle: -120, speed: 20, radius: 30, mass: 1, color: Tuple.Create(255, 25, 255)));
            //objects.Add(new PhysicalObject(centerX: 30, centerY: 200, angle: 180, speed: 1, radius: 30, mass: 1, color: Tuple.Create(255, 25, 255)));


            objects.Add(new PhysicalObject(centerX: 400, centerY: 40, angle: 0, speed: 0, radius: 30, mass: 1000, color: Tuple.Create(25, 225, 25)));
            Random rnd = new Random();
            
            for (int i = 100; i < 700; i += 30)
            {
                for(int k = 100; k < 700; k += 30)
                {
                    int r = rnd.Next(0, 360);
                    objects.Add(new PhysicalObject(centerX: i, centerY: k, angle: r, speed: 8, radius: 5, mass: 1, color: Tuple.Create(255, 25, 255)));
                }
            }

            objects.ForEach((item) => this.Paint += new PaintEventHandler((sender, e) => PaintObject(sender, e, item)));
            this.Size = new Size(816, 839);
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
            pthGrBrush.CenterColor = Color.FromArgb(255, po.Color.Item1, po.Color.Item2, po.Color.Item3);
            Color[] colors = { Color.FromArgb(255, po.Color.Item1 / 2, po.Color.Item2 / 2, po.Color.Item3 / 2) };
            pthGrBrush.SurroundColors = colors;

            //SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#ff00ff"));
            graphics.FillEllipse(pthGrBrush, rect);

            //draw movement arrow
            // Create pen.
            //Pen blackPen = new Pen(Color.Black, 5);
            // Create points that define line.
            //Point point1 = new Point((int)po.CenterX, (int)po.CenterY);
            //Point point2 = new Point((int)po.CenterX + (int)po.SpeedX * 20, (int)po.CenterY + (int)po.SpeedY * 20);
            // Draw line to screen.
            //e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void MoveObject(PhysicalObject po)
        {
            float newBall_x = po.CenterX + po.SpeedX;
            float newBall_y = po.CenterY + po.SpeedY;

            if (newBall_x < po.Radius || newBall_x > this.ClientSize.Width - po.Radius)
            {
                BounceOffVerticalWall(po);
            }
            if (newBall_y < po.Radius || newBall_y > this.ClientSize.Height - po.Radius)
            {
                BounceOffHorizontalWall(po);
            }

            po.CenterX += po.SpeedX;
            po.CenterY += po.SpeedY;
            po.CenterX += po.SpeedX;
            po.CenterY += po.SpeedY;
            Invalidate();
        }

        private void BounceOffHorizontalWall(PhysicalObject po)
        {
            po.SetAxisSpeeds(360 - po.Angle, po.Speed);
        }

        private void BounceOffVerticalWall(PhysicalObject po)
        {
            po.SetAxisSpeeds((540 - po.Angle) % 360, po.Speed);
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
            DetectCollisions();
        }

        private void DetectCollisions()
        {
            for (int i = 0; i < objects.Count; ++i)
            {
                for (int k = i + 1; k < objects.Count; ++k)
                {
                    if (dist2(objects[i].CenterX - objects[k].CenterX, objects[i].CenterY - objects[k].CenterY) < (objects[i].Radius + objects[k].Radius) * (objects[i].Radius + objects[k].Radius))
                    {
                        Collision collision = new Collision();
                        collision.CalculateCollision(objects[i], objects[k]);
                    }
                }
            }
        }

        private float dist2(float a, float b)
        {
            return a * a + b * b;
        }

    }
}
