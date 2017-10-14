using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInteractionSimulator
{
    class PhysicalObject
    {
        private float centerX;
        private float centerY;
        private float angle;//in degrees
        private float speed;
        private float speedX;//dx
        private float speedY;//dy
        private float radius;
        private float mass;
        //TODO: maybe add Color variable

        public PhysicalObject(float centerX, float centerY, float angle, float speed, float radius, float mass)
        {
            CenterX = centerX;
            CenterY = centerY;
            Angle = angle;
            Speed = speed;
            SetAxisSpeeds(angle, speed);
            Radius = radius;
            Mass = mass;
        }

        private void SetAxisSpeeds(float angle, float speed)
        {
            double cos = Math.Cos((Math.PI / 180) * angle);
            double sin = Math.Sin((Math.PI / 180) * angle);
            cos = Math.Round(cos, 7);
            sin = Math.Round(sin, 7);
            SpeedX = speed * (float)cos;
            speedY = -speed * (float)sin;
        }

        public float CenterX
        {
            get
            {
                return centerX;
            }
            set
            {
                centerX = value;
            }
        }

        public float CenterY
        {
            get
            {
                return centerY;
            }
            set
            {
                centerY = value;
            }
        }

        public float SpeedX
        {
            get
            {
                return speedX;
            }
            set
            {
                speedX = value;
            }
        }

        public float SpeedY
        {
            get
            {
                return speedY;
            }
            set
            {
                speedY = value;
            }
        }

        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public float Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
    }
}
