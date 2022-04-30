using System;

namespace MindboxMath
{
    public class Triangle : Figure
    {
        private float edge1 = 1;
        private float edge2 = 1;
        private float edge3 = 1;

        /// <summary>
        /// По умолчанию все стороны треугольника равны 1
        /// </summary>
        public Triangle()
        {

        }

        public Triangle(float edge1, float edge2, float edge3)
        {
            Edge1 = edge1;
            Edge2 = edge2;
            Edge3 = edge3;
        }

        public float Edge1
        {
            get
            {
                return edge1;
            }

            set
            {
                if (value <= 0)
                    throw new MathException("Сторона не может быть меньше или равна 0", this);
                edge1 = value;
            }
        }
        public float Edge2
        {
            get
            {
                return edge2;
            }

            set
            {
                if (value <= 0)
                    throw new MathException("Сторона не может быть меньше или равна 0", this);
                edge2 = value;
            }
        }
        public float Edge3
        {
            get
            {
                return edge3;
            }

            set
            {
                if (value <= 0)
                    throw new MathException("Сторона не может быть меньше или равна 0", this);
                edge3 = value;
            }
        }

        public override float GetArea()
        {
            float p = (edge1 + edge2 + edge3) * 0.5f;
            return (float)Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsSquare()
        {
            // Равносторонний треугольник не может быть прямоугольным
            if (edge1 == edge2 && edge2 == edge3)
                return false;
            else
            {
                // Проверка является ли треугольник прямоугольным по теореме Пифагора
                // осуществляется поочерёдной проверкой каждоый из сторон треугольника (как если бы они были гепотенузой)
                // на соответствие теореме.
                // Решение этой задачи через поиск заранее наибольшей стороны приведёт лишь к излишнему ветвлению
                // и "спагеттификации" кода т.к. возможны варианты когда какие то 2 стороны одной длинны.

                float edge1Squared = edge1 * edge1;
                float edge2Squared = edge2 * edge2;
                float edge3Squared = edge3 * edge3;
                if (edge1Squared == (edge2Squared + edge3Squared) || edge2Squared == (edge1Squared + edge3Squared) ||
                    edge3Squared == (edge1Squared + edge2Squared))
                    return true;
                else return false;
            }
        }
    }
}
