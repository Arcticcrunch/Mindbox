using System;

namespace MindboxMath
{
    public class Circle : Figure
    {
        private float radius = 1;

        public Circle()
        {
        }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value <= 0)
                    throw new MathException("Радиус не может быть меньше или равен 0", this);
                radius = value;
            }
        }

        public override float GetArea()
        {
            return (float)Math.PI * radius * radius;
        }
    }
}
