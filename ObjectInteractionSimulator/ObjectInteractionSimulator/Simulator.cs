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
        List<Delegate> paintedObjects = new List<Delegate>();

        Gravity gravity;
        private float gravity_const = 0.0000000000667f;

        int currentObjectIndex = -1;
        const int MAX_OBJECTS = 100;

        Random random = new Random();

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

            //objects.Add(new PhysicalObject(centerX: 160, centerY: 400, angle: 300, speed: 1, radius: 30, mass: 1, color: Tuple.Create(255, 25, 255)));//purple
            //objects.Add(new PhysicalObject(centerX: 200, centerY: 486.6f, angle: 90, speed: 1, radius: 30, mass: 1, color: Tuple.Create(25, 25, 255)));//blue
            //objects.Add(new PhysicalObject(centerX: 240, centerY: 400, angle: 240, speed: 1, radius: 30, mass: 1, color: Tuple.Create(255, 25, 25)));//red

            //objects.Add(new PhysicalObject(centerX: 100, centerY: 400, angle: 0, speed: 2, radius: 30, mass: 1, color: Tuple.Create(255, 25, 25)));
            //objects.Add(new PhysicalObject(centerX: 240, centerY: 400, angle: 180, speed: 3, radius: 30, mass: 1, color: Tuple.Create(255, 25, 25)));



            //objects.Add(new PhysicalObject(centerX: 400, centerY: 300, angle: 0, speed: 0.6f, radius: 10, mass: 10000000, color: Tuple.Create(255, 25, 25)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 600, angle: 0, speed: 0.45f, radius: 15, mass: 10000000, color: Tuple.Create(255, 25, 25)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 400, angle: 0, speed: 0, radius: 30, mass: 1000000000000, color: Tuple.Create(255, 255, 0)));


            //objects.Add(new PhysicalObject(centerX: 400, centerY: 100, angle: 0, speed: 0.345f, radius: 5, mass: 1000000000, color: Tuple.Create(25, 255, 25)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 90, angle: 0, speed: 0.404f, radius: 2, mass: 100000000, color: Tuple.Create(125, 125, 125)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 330, angle: 0, speed: 0.65f, radius: 4, mass: 1000000000, color: Tuple.Create(255, 25, 25)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 260, angle: 0, speed: 0.5f, radius: 4, mass: 1000000000, color: Tuple.Create(255, 25, 255)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 400, angle: 0, speed: 0, radius: 30, mass: 1000000000000, color: Tuple.Create(255, 255, 0)));

            //AddObject(centerX: 100, centerY: 100, angle: 0, speed: 0, radius: 30, mass: 10000);
            //TODO: Something is wrong with the mass; very light objects not acting properly around cery heavy objects
            //objects.Add(new PhysicalObject(centerX: 500, centerY: 500, angle: 0, speed: 0.7f, radius: 30, mass: 1, color: Tuple.Create(255, 25, 255)));
            //objects.Add(new PhysicalObject(centerX: 400, centerY: 700, angle: 0, speed: 3, radius: 10, mass: 10000000, color: Tuple.Create(255, 25, 25)));

            //for (int i = 0; i < 6; ++i)
            //{
            //    objects.Add(new PhysicalObject(centerX: i * 50 + 30, centerY: 400, angle: 0, speed: 4, radius: 20, mass: 1, color: Tuple.Create(255, 25, 255)));
            //}

            //for (int i = 0; i < 6; ++i)
            //{
            //    objects.Add(new PhysicalObject(centerX: i * 50 + 30, centerY: 500, angle: 0, speed: 4, radius: 20, mass: 1, color: Tuple.Create(255, 25, 255)));
            //}

            //for (int i = 0; i < 6; ++i)
            //{
            //    objects.Add(new PhysicalObject(centerX: i * 50 + 30, centerY: 600, angle: 15, speed: 4, radius: 20, mass: 1, color: Tuple.Create(255, 25, 255)));
            //}

            //objects.Add(new PhysicalObject(centerX: 400, centerY: 40, angle: 0, speed: 0, radius: 30, mass: 1000, color: Tuple.Create(25, 225, 25)));
            //Random rnd = new Random();

            //for (int i = 100; i < 700; i += 50)
            //{
            //    for (int k = 100; k < 700; k += 50)
            //    {
            //        int r = rnd.Next(0, 360);
            //        objects.Add(new PhysicalObject(centerX: i, centerY: k, angle: r, speed: 8, radius: 5, mass: 1, color: Tuple.Create(255, 25, 255)));
            //    }
            //}

            objects.ForEach((item) => this.Paint += new PaintEventHandler((sender, e) => PaintObject(sender, e, item)));
            this.Size = new Size(1216, 839);
            this.DoubleBuffered = true;

            gravity = new Gravity(objects, gravity_const);
            constBox.Text = gravity_const.ToString();

            //Interval_Label.Text = timer.Interval.ToString();
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
            Color[] colors = { Color.FromArgb(255, po.Color.Item1 / 5 * 3, po.Color.Item2 / 5 * 3, po.Color.Item3 / 5 * 3) };
            pthGrBrush.SurroundColors = colors;

            //SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#ff00ff"));
            graphics.FillEllipse(pthGrBrush, rect);
        }

        private void MoveObject(PhysicalObject po)
        {
            float newBall_x = po.CenterX + po.SpeedX;
            float newBall_y = po.CenterY + po.SpeedY;

            if (newBall_x < po.Radius || newBall_x > this.ClientSize.Width - po.Radius - menu.Width)
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
            if (timer.Enabled)
            {
                control.BackColor = Color.Red;
                control.Text = "Stop";
            }
            else
            {
                control.BackColor = Color.Lime;
                control.Text = "Start";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //objects.ForEach((item) => MoveObject(item));
            if(GravityToggle.Checked)
                objects.ForEach((item) => gravity.ApplyGravityOn(item));

            DetectCollisions();

            objects.ForEach((item) => MoveObject(item));

            //tick every 15 ms; acc = how much speed is gained in 15 ms;
            //y = 6.67 * 10^(-11)N.m^2/kg^2
            //F = y * (m1 * m2) / r^2
            //F = ma
        }

        private void DetectCollisions()
        {   
            for (int i = 0; i < objects.Count; ++i)
            {
                for (int k = i + 1; k < objects.Count; ++k)
                {
                    if (dist2(objects[i].CenterX + objects[i].SpeedX - objects[k].CenterX - objects[k].SpeedX, objects[i].CenterY + objects[i].SpeedY - objects[k].CenterY - objects[k].SpeedY) < (objects[i].Radius + objects[k].Radius) * (objects[i].Radius + objects[k].Radius))
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

        private void AddObject(float centerX, float centerY, float angle, float speed, float radius, float mass, int r, int g, int b)
        {
            //check validity of parameters
            if (radius < 0 || radius > 50)
            {
                radius = GetRandValue(5, 50);
            }
            if (centerX < radius || centerX > this.ClientSize.Width - radius - menu.Width)
            {
                centerX = GetRandValue((int)radius * 2 + 1, (int)(this.ClientSize.Width - radius - menu.Width));
            }
            if (centerY < radius || centerY > this.ClientSize.Height - radius)
            {
                centerY = GetRandValue((int)radius * 2 + 1, (int)(this.ClientSize.Height - radius));
            }
            if (angle < 0 || angle >= 360)
            {
                angle = GetRandValue(0, 360);
            }
            if (speed < 0 || speed > 20)//Speed maxed at 300; TODO: make global
            {
                speed = GetRandValue(0, 20);
            }
            if (mass < 0) //no upper bound
            {
                mass = GetRandValue(0, 10);
            }
            if (r < 0 || r > 255)
            {
                r = random.Next(0, 255);
            }
            if (g < 0 || g > 255)
            {
                g = random.Next(0, 255);
            }
            if (b < 0 || b > 255)
            {
                b = random.Next(0, 255);
            }

            //if the new object intersects an existing object, find it new coordinates 
            for (int i = 0;  DoesOverlap(centerX, centerY, radius); ++i)
            {
                centerX = GetRandValue((int)radius * 2 + 1, (int)(this.ClientSize.Width - radius - menu.Width));
                centerY = GetRandValue((int)radius * 2 + 1, (int)(this.ClientSize.Height - radius));
                if(i > 10)
                    radius = ReduceRadius(radius);
            }

            PhysicalObject po = new PhysicalObject(centerX: centerX, centerY: centerY, angle: angle, speed: speed, radius: radius, mass: mass, color: Tuple.Create(r, g, b));
            objects.Add(po);
            var peh = new PaintEventHandler((sender, e) => PaintObject(sender, e, po));
            this.Paint += peh;
            paintedObjects.Add(peh);
            Invalidate();
        }

        private float GetRandValue(int min, int max)
        {
            return (float)random.NextDouble() * (max-min) + min;
        }
        
        //checks if new object overlaps existing object
        private bool DoesOverlap(float x, float y, float r)
        {
            for (int i = 0; i < objects.Count; ++i)
            {
                if (i == currentObjectIndex)//objects overlap themselves
                    continue;
                if (dist2(objects[i].CenterX - x, objects[i].CenterY - y) < (objects[i].Radius + r) * (objects[i].Radius + r))
                {
                    return true;
                }
            }
            return false;
        }

        private float ReduceRadius(float r)
        {
            if (!(r <= 1))
            {
                return --r;
            }
            return r;
        }

        private void Interval_Label_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Interval_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Set_Interval_Click(object sender, EventArgs e)
        //{
        //    int i;
        //    int.TryParse(Enter_Interval.Text, out i);
        //    if (i == 0)
        //        i = 15;
        //    timer.Interval = i;
        //    Interval_Label.Text = i.ToString();
        //}

        private void addObjectButton_Click(object sender, EventArgs e)
        {
            if(ToFloat(numberToAdd.Text.ToString()) < 0) { 
                if (objects.Count <= MAX_OBJECTS)
                    AddObject(ToFloat(centerXBox.Text.ToString()), ToFloat(centerYBox.Text.ToString()), ToFloat(angleBox.Text.ToString()), ToFloat(speedBox.Text.ToString()), ToFloat(radiusBox.Text.ToString()), ToFloat(massBox.Text.ToString()), (int)ToFloat(rBox.Text.ToString()), (int)ToFloat(gBox.Text.ToString()), (int)ToFloat(bBox.Text.ToString()));
            }
            else { 
                for (int i = 0; i < (int)ToFloat(numberToAdd.Text.ToString()); ++i)
                {
                    if (objects.Count <= MAX_OBJECTS)
                        AddObject(ToFloat(centerXBox.Text.ToString()), ToFloat(centerYBox.Text.ToString()), ToFloat(angleBox.Text.ToString()), ToFloat(speedBox.Text.ToString()), ToFloat(radiusBox.Text.ToString()), ToFloat(massBox.Text.ToString()), (int)ToFloat(rBox.Text.ToString()), (int)ToFloat(gBox.Text.ToString()), (int)ToFloat(bBox.Text.ToString()));
                }
            }

            numberToAdd.Text = "1";
        }

        //returns -1 if String is not a number
        private float ToFloat(String s)
        {
            if(float.TryParse(s, out float f))
            {
                return f;
            }
            return -1;
        }

        private int FindObjectIndex(String x, String y)
        {
            float fx, fy;
            float.TryParse(x, out fx);
            float.TryParse(y, out fy);
            for(int i = 0; i<objects.Count ; ++i)
            {
                if (dist2(objects[i].CenterX - fx, objects[i].CenterY - fy) < (objects[i].Radius) * (objects[i].Radius))
                {
                    currentObjectIndex = i;
                    return i;
                }
            }
            currentObjectIndex = -1;
            return -1;
        }

        private void ModifyObject()
        {
            if(currentObjectIndex >= 0)
            {
                float x = ToFloat(centerXMod.Text.ToString());
                float y = ToFloat(centerYMod.Text.ToString());
                float a = ToFloat(angleMod.Text.ToString());
                float s = ToFloat(speedMod.Text.ToString());
                float r = ToFloat(radiusMod.Text.ToString());
                float m = ToFloat(massMod.Text.ToString());
                int red = (int)ToFloat(rBoxMod.Text.ToString());
                int green = (int)ToFloat(gBoxMod.Text.ToString());
                int blue = (int)ToFloat(bBoxMod.Text.ToString());

                //check the entered values
                if (r < 0 || r > 50)
                {
                    r = GetRandValue(5, 50);
                }
                if (x < r || x > this.ClientSize.Width - r - menu.Width)
                {
                    x = GetRandValue((int)r * 2 + 1, (int)(this.ClientSize.Width - r - menu.Width));
                }
                if (y < r || y > this.ClientSize.Height - r)
                {
                    y = GetRandValue((int)r * 2 + 1, (int)(this.ClientSize.Height - r));
                }
                if (a < 0 || a >= 360)
                {
                    a = GetRandValue(0, 360);
                }
                if (s < 0 || s > 20)//Speed maxed at 300; TODO: make global
                {
                    s = GetRandValue(0, 20);
                }
                if (m < 0) //no upper bound
                {
                    m = GetRandValue(0, 10);
                }
                if (red < 0 || red > 255)
                {
                    red = random.Next(0, 255);
                }
                if (green < 0 || green > 255)
                {
                    green = random.Next(0, 255);
                }
                if (blue < 0 || blue > 255)
                {
                    blue = random.Next(0, 255);
                }

                for (int i = 0;  DoesOverlap(x, y, r); ++i)
                {
                    x = GetRandValue((int)r * 2 + 1, (int)(this.ClientSize.Width - r - menu.Width));
                    y = GetRandValue((int)r * 2 + 1, (int)(this.ClientSize.Height - r));
                    if (i > 10)//if the app cannot find place for the object quickly it reduces its size
                        r = ReduceRadius(r);
                }

                //set the new values
                objects[currentObjectIndex].CenterX = x;
                objects[currentObjectIndex].CenterY = y;
                objects[currentObjectIndex].SetAxisSpeeds(a, s);
                objects[currentObjectIndex].Radius = r;
                objects[currentObjectIndex].Mass = m;
                objects[currentObjectIndex].Color = new Tuple<int, int, int>(red, green, blue);

                //display new values in the text boxes
                centerXMod.Text = objects[currentObjectIndex].CenterX.ToString();
                centerYMod.Text = objects[currentObjectIndex].CenterY.ToString();
                angleMod.Text = objects[currentObjectIndex].Angle.ToString();
                speedMod.Text = objects[currentObjectIndex].Speed.ToString();
                radiusMod.Text = objects[currentObjectIndex].Radius.ToString();
                massMod.Text = objects[currentObjectIndex].Mass.ToString();
                rBoxMod.Text = objects[currentObjectIndex].Color.Item1.ToString();
                gBoxMod.Text = objects[currentObjectIndex].Color.Item2.ToString();
                bBoxMod.Text = objects[currentObjectIndex].Color.Item3.ToString();

            }
            //currentObjectIndex = -1;
            Invalidate();
        }

        private void Simulator_Click(object sender, EventArgs e)
        {
            Point relativePoint = this.PointToClient(Cursor.Position);
            int index = FindObjectIndex(relativePoint.X.ToString(), relativePoint.Y.ToString());
            //Interval_Label.Text = index.ToString();
            if(index >= 0)
            {
                centerXMod.Text = objects[index].CenterX.ToString();
                centerYMod.Text = objects[index].CenterY.ToString();
                angleMod.Text = objects[index].Angle.ToString();
                speedMod.Text = objects[index].Speed.ToString();
                radiusMod.Text = objects[index].Radius.ToString();
                massMod.Text = objects[index].Mass.ToString();
                rBoxMod.Text = objects[index].Color.Item1.ToString();
                gBoxMod.Text = objects[index].Color.Item2.ToString();
                bBoxMod.Text = objects[index].Color.Item3.ToString();
                //populate textboxes
                //OnButtonClick give it the index and run ModifyObject
                //hold index in global variable or some lambda shit
            }
            else
            {
                ClearTextBoxes();
            }


        }

        private void ClearTextBoxes()
        {
            centerXMod.Clear();
            centerYMod.Clear();
            angleMod.Clear();
            speedMod.Clear();
            radiusMod.Clear();
            massMod.Clear();
            rBoxMod.Clear();
            gBoxMod.Clear();
            bBoxMod.Clear();
        }

        private void massBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMass_Click(object sender, EventArgs e)
        {

        }

        private void centerXBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelY_Click(object sender, EventArgs e)
        {

        }

        private void modifyObjectButton_Click(object sender, EventArgs e)
        {
            if(currentObjectIndex >= 0)
            {
                ModifyObject();
            }
            //currentObjectIndex = -1;
        }

        private void deleteObjectButton_Click(object sender, EventArgs e)
        {
            if(currentObjectIndex >= 0)
            {
                this.Paint -= (PaintEventHandler)paintedObjects[currentObjectIndex];
                objects.RemoveAt(currentObjectIndex);
                paintedObjects.RemoveAt(currentObjectIndex);
                Invalidate();
                centerXMod.Clear();
                centerYMod.Clear();
                angleMod.Clear();
                speedMod.Clear();
                radiusMod.Clear();
                massMod.Clear();
            }
            currentObjectIndex = -1;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < paintedObjects.Count; ++i)
            {
                this.Paint -= (PaintEventHandler)paintedObjects[i];
            }
            objects.Clear();
            paintedObjects.Clear();
            Invalidate();
            currentObjectIndex = -1;
        }

        private void GravityToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (GravityToggle.Checked)
            {
                GravityToggle.Text = "On";
                GravityToggle.BackColor = Color.Aqua;
            }
            else
            {
                GravityToggle.Text = "Off";
                GravityToggle.BackColor = Color.Silver;
            }
        }

        private void setConst_Click(object sender, EventArgs e)
        {
            float c;
            if (float.TryParse(constBox.Text.ToString(), out c))
            {
                gravity_const = c;
            }
            else
            {
                //set default
                gravity_const = 0.0000000000667f;
            }
            constBox.Text = gravity_const.ToString();
            gravity.Gravity_Const = gravity_const;
        }

        private void deafultConst_Click(object sender, EventArgs e)
        {
            gravity_const = 0.0000000000667f;
            constBox.Text = gravity_const.ToString();
            gravity.Gravity_Const = gravity_const;
        }
        //TODO: use grav_const in Gravity class
        //TODO: if grav_const is negative +180deg the force angle in the Gravity class
    }
}
