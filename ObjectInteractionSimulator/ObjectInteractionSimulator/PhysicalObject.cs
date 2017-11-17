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
        private Tuple<int, int, int> color;

        public PhysicalObject(float centerX, float centerY, float angle, float speed, float radius, float mass, Tuple<int, int, int> color)
        {
            CenterX = centerX;
            CenterY = centerY;
            Angle = angle;
            Speed = speed;
            SetAxisSpeeds(angle, speed);
            Radius = radius;
            Mass = mass;
            Color = color;
        }

        public void SetAxisSpeeds(float angle, float speed)
        {
            Angle = angle;
            Speed = speed;
            float cos = (float)Math.Cos((Math.PI / 180) * angle);
            float sin = (float)Math.Sin((Math.PI / 180) * angle);
            cos = (float)Math.Round(cos, 6);
            sin = (float)Math.Round(sin, 6);
            SpeedX = speed * cos;
            speedY = -speed * sin;
        }

        public float CenterX
        {
            get
            {
                return centerX;
            }
            set
            {
                if (value < Radius)
                    value = Radius;
                if (value > 800 - Radius)
                    value = 800 - Radius;
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
                if (value < Radius)
                    value = Radius;
                if (value > 800 - Radius)
                    value = 800 - Radius;
                centerY = value;
            }
        }

        public float SpeedX
        {
            get
            {
                return speedX;
            }
            private set
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
            private set
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
                if (value > 0)
                    radius = value;
                else
                    radius = 1;
            }
        }

        public float Angle
        {
            get
            {
                return angle;
            }
            private set
            {
                //0 < angle < 360
                if(value < 0)
                {
                    value = value % 360;
                    value = value + 360;
                }
                else
                {
                    value = value % 360;
                }
                angle = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }
            private set
            {
                if (value > 0)
                    speed = value;
                else
                    speed = 0;
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
                if (value > 0)
                    mass = value;
                else
                    mass = 1;
            }
        }

        public Tuple<int, int, int> Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
    }
}
