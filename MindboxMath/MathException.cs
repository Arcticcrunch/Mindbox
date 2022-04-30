using System;

namespace MindboxMath
{
    public class MathException : Exception
    {
        public MathException(string message, Figure figure) : base("Ошибка при работе с фигурой " + figure.GetType().ToString() + ": " + message)
        {

        }
    }
}
