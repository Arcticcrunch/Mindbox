
namespace MindboxMath
{
    public abstract class Figure
    {
        /// <summary>
        /// Получение площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract float GetArea();

        /// <summary>
        /// Статический вариант метода получения площади фигуры
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns></returns>
        public static float GetFigureArea(Figure figure)
        {
            return figure.GetArea();
        }
    }

}
