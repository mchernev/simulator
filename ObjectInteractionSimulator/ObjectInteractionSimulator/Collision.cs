using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInteractionSimulator
{
    class Collision
    {
        private float m1, m2;//masses of the objects
        private float v1, v2;//initial object speed
        private float momentum;
        private float energy;
        private float u1, u2;//new speeds along x axis
        private float alpha, beta;//in deg
        private float newAlpha, newBeta;//in deg
        private float inclineAngle;//in deg
        private float newSpeed1, newSpeed2;//new full speeds
        private const float eps = 0.00000001f;

        public void CalculateCollision(PhysicalObject po1, PhysicalObject po2)
        {
            m1 = po1.Mass;
            m2 = po2.Mass;

            v1 = po1.Speed;
            v2 = po2.Speed;

            alpha = po1.Angle; //in deg
            beta = po2.Angle; //in deg

            Console.WriteLine("\nAlpha: " + alpha);
            Console.WriteLine("Beta: " + beta);

            inclineAngle = GetInclineAngle(po1.CenterX, po2.CenterX, po1.CenterY, po2.CenterY);
            Console.WriteLine("Incline: " + inclineAngle);

            ShiftAngles();
            Console.WriteLine("Alpha after shift: " + alpha);
            Console.WriteLine("Beta after shift: " + beta);

            po1.SetAxisSpeeds(alpha, v1);
            po2.SetAxisSpeeds(beta, v2);

            Console.WriteLine("InitSpeed1: " + v1);
            Console.WriteLine("InitSpeed2: " + v2);

            //Momentum must be calculated after angle shift
            CalculateMomentum();
            Console.WriteLine("Momentum: " + momentum);

            CalculateEnergy();
            Console.WriteLine("Energy: " + energy);

            CalculateU2();
            Console.WriteLine("u2: " + u2);

            FindU1();
            Console.WriteLine("u1: " + u1);

            //find new speeds and calculate new angles
            newSpeed1 = CalculateNewSpeed(u1, alpha, v1);
            Console.WriteLine("New Speed 1: " + newSpeed1);

            newSpeed2 = CalculateNewSpeed(u2, beta, v2);
            Console.WriteLine("New Speed 2: " + newSpeed2);

            newAlpha = CalculateNewAngle(newSpeed1, u1, po1.SpeedY);
            Console.WriteLine("New Alpha: " + newAlpha);

            newBeta = CalculateNewAngle(newSpeed2, u2, po2.SpeedY);
            Console.WriteLine("New Beta: " + newBeta);

            RestoreAngles();
            Console.WriteLine("New Alpha after restore: " + newAlpha);
            Console.WriteLine("New Beta after restore: " + newBeta);

            po1.SetAxisSpeeds(newAlpha, Math.Abs(newSpeed1));//spped should be positive
            po2.SetAxisSpeeds(newBeta, Math.Abs(newSpeed2));//speed should be positive

        }

        private void CalculateMomentum()
        {
            momentum = m1 * (float)Math.Cos(Angle(alpha)) * v1 + m2 * (float)Math.Cos(Angle(beta)) * v2;
            momentum = (float)Math.Round(momentum, 6);
        }

        private void CalculateEnergy()
        {
            energy = (m1 * SquareF(v1)) + (m2 * SquareF(v2));
        }

        private float GetInclineAngle(float x1, float x2, float y1, float y2)
        {
            float dx, dy;

            dx = Math.Abs(x1 - x2);
            dy = Math.Abs(y1 - y2);

            float angle = (float)Math.Atan(dy / dx);//angle in rad
            if ((x1 - x2) * (y1 - y2) >= 0)
                return (float)Math.Round((180 / Math.PI) * angle, 2);//angle in deg
            else
                return (float)Math.Round(-(180 / Math.PI) * angle, 2);//angle in deg
        }

        private void ShiftAngles()
        {
            //+incline angle

            alpha += inclineAngle;
            beta += inclineAngle;
            if (alpha < 0)
                alpha += 360;
            if (beta < 0)
                beta += 360;
        }

        private void RestoreAngles()
        {
            //-incline angle
            newAlpha -= inclineAngle;
            newBeta -= inclineAngle;
            if (newAlpha < 0)
                newAlpha += 360;
            if (newBeta < 0)
                newBeta += 360;
        }

        private void CalculateU2()
        {
            //solve: (m2m2 + m1m2)u2u2 - (2 p m2)u2 + pp + m1m1 sin2a v1v1 + m1m2 sin2b v2v2 - em1 = 0

            float D = SquareF(2 * momentum * m2) - 4 * (SquareF(m2) + m1 * m2) * (SquareF(momentum) + SquareF(m1) * SquareF((float)Math.Sin(Angle(alpha))) * SquareF(v1) + (m1 * m2 * SquareF((float)Math.Sin(Angle(beta))) * SquareF(v2) - energy * m1));
            Console.WriteLine("D: " + D);
            if(D < 0)
            {
                D = 0;
                Console.WriteLine("ERROR: D is negative");
            }
            float x1, x2;
            x1 = ((2 * momentum * m2) + (float)Math.Sqrt(D)) / (2 * (SquareF(m2) + m1 * m2));
            x2 = ((2 * momentum * m2) - (float)Math.Sqrt(D)) / (2 * (SquareF(m2) + m1 * m2));

            if (Math.Abs(x1 - Math.Cos(Angle(beta)) * v2) > Math.Abs(x2 - Math.Cos(Angle(beta)) * v2))
                u2 = x1;
            else
                u2 = x2;
        }

        private void FindU1()
        {
            u1 = (momentum - m2 * u2) / m1;
        }

        private float CalculateNewSpeed(float u, float angle, float v)
        {
            return (float)Math.Round(Math.Sqrt(SquareF(u) + SquareF((float)Math.Sin(Angle(angle))) * SquareF(v)), 6);
        }

        private float CalculateNewAngle(float speed, float u, float speedY)
        {
            float angle;//in rad; later converted in deg

            if (speed < eps)//if speed is -> 0; nullify angle
            {
                angle = 0;
            }
            else
            {
                if (u > speed)//crashes if u > NewSpeed
                {
                    u = speed;
                    //Console.WriteLine("    ERROR: LOOK AT CALCULATE_NEW_ANGLE; Speeds are wrongly calculated    ");
                }
                if(Math.Abs(u) / Math.Abs(speed) > 1)
                {
                    u = -speed;
                }
                angle = (float)Math.Acos(u / speed);//angle is in rad
                
                if (speedY > 0)
                {
                    angle = 2 * (float)Math.PI - angle;
                }
            }
            angle = (float)Math.Round(angle * (180 / (float)Math.PI), 6);//convert angle to deg

            return angle;
        }

        private float Angle(float angle)//returns angle in rad
        {
            return angle * ((float)Math.PI / 180);
        }

        private float SquareF(float f)
        {
            return f * f;
        }
    }
}
