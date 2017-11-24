using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInteractionSimulator
{
    class Gravity
    {
        private List<PhysicalObject> list;
        private Tuple<float, float> vector;//(size, angle)
        private const float GRAVITY_CONST = 0.0000000000667f;//6.67 * 10^(-11)N.m^2/kg^2

        public Gravity()
        {
            vector = new Tuple<float, float>(0, 0);
        }

        public Gravity (List<PhysicalObject> objects)
        {
            list = objects;
            vector = new Tuple<float, float>(0, 0);
        }

        public List<PhysicalObject> List
        {
            set
            {
                list = value;
            }
        }

        public void ApplyGravityOn(PhysicalObject po)
        {
            for(int i = 0; i < list.Count; ++i)
            {
                Console.WriteLine("grav force " + CalculateGravitationalForce(po, list[i]));
                Console.WriteLine("grav force angle " + CalculateForceAngle(po, list[i]));
                AddToVector(CalculateGravitationalForce(po, list[i]) / po.Mass, CalculateForceAngle(po, list[i]));
            }
            Console.WriteLine("force size  " + vector.Item1);
            Console.WriteLine("force angle " + vector.Item2);
            AddToVector(po.Speed, po.Angle);
            po.SetAxisSpeeds(vector.Item2, vector.Item1);
            Console.WriteLine("New Speed " + vector.Item1);
            Console.WriteLine("New Angle " + vector.Item2);
            vector = new Tuple<float, float>(0, 0);//nullify vector
        }

        //private void AddVector()
        //{

        //}

        private float CalculateGravitationalForce(PhysicalObject po1, PhysicalObject po2)
        {
            //if the object is the same the force is 0
            if (DistanceSq(po1.CenterX, po1.CenterY, po2.CenterX, po2.CenterY) == 0)
                return 0;
            else
                return GRAVITY_CONST * (po1.Mass * po2.Mass) / DistanceSq(po1.CenterX, po1.CenterY, po2.CenterX, po2.CenterY);
        }

        //calculates the force vector's angle
        private float CalculateForceAngle(PhysicalObject main, PhysicalObject second)
        {
            float dx = main.CenterX - second.CenterX;
            float dy = main.CenterY - second.CenterY;
            if (dx == 0 && dy == 0)//if same object return 0
                return 0;
            float angle;// in rad
            //if dy < 0  ->  180 < a < 360
            //if dy > 0  ->  0 < a < 180
            angle = (float)Math.Atan(-(dy / dx));
            angle = angle * (180 / (float)Math.PI);
            if (angle < 0)
            {
                angle += 180;
            }
            if (dy < 0)
            {
                angle += 180;
            }
            if (dy == 0 && dx > 0)
            {
                angle += 180;
            }

            return angle;
        }

        //adds a force vector to the combined force vector
        private void AddToVector(float size, float angle)
        {
            float vSize = vector.Item1;
            float vAngle = vector.Item2;
            float newSize, newAngle;

            newSize = (float)Math.Sqrt(size * size + vSize * vSize + 2 * size * vSize * (float)Math.Cos(Angle(vAngle - angle))); // -2*size*vSize*(-cos(vAngle-angle))
            newAngle = CalculateAngle(size, angle);

            vector = new Tuple<float, float>(newSize, newAngle);
        }

        //adds the force vector to the objects movement vector
        //private void AddVectorToDirection(PhysicalObject po)
        //{

        //}

        //calculates the angle the new combined vector (old combined + new force) using its coordinates
        private float CalculateAngle(float size, float angle)
        {
            float ax, ay, bx, by;
            ax = size * (float)Math.Cos(Angle(angle));
            ay = size * (float)Math.Sin(Angle(angle));
            bx = vector.Item1 * (float)Math.Cos(Angle(vector.Item2));
            by = vector.Item1 * (float)Math.Sin(Angle(vector.Item2));

            float cx, cy;
            cx = ax + bx;
            cy = ay + by;
            if (cx == 0 && cy == 0)
            {
                return 0;
            }

            float newAngle = (float)Math.Atan(cy / cx) * (180 / (float)Math.PI);

            if (newAngle < 0)
            {
                newAngle += 360;
            }

            if (cx < 0)
            {
                newAngle += 180;
            }

            return newAngle % 360;
        }

        //find r^2
        private float DistanceSq(float x1, float y1, float x2, float y2)
        {
            float dx = x1 - x2;
            float dy = y1 - y2;
            return dx * dx + dy * dy;
        }

        private float Angle(float angle)//returns angle in rad
        {
            return angle * ((float)Math.PI / 180);
        }
    }
}
