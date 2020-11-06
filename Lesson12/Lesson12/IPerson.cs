using System;

namespace Lesson12
{
    public interface IPerson
    {
        /// <summary>
        /// Выполнить перемещение.
        /// </summary>
        /// <param name="distance">Расстояние.</param>
        /// <returns>Время движения.</returns>
        int Move(int distance);
    }
}
