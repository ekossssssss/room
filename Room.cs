using System;

namespace classroom
{
    public class Room
    {
        double roomLength; 
        double roomWidth;
        public double RoomLength
        {
            get { return RoomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
/// <summary>
/// Вычисляет периметр комнаты
/// </summary>
/// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 *  (roomLength + roomWidth);
        }
/// <summary>
/// Вычисляет площадь комнаты
/// </summary>
/// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
/// <summary>
/// Метод вычисляет число квадратных метров на одног человека
/// </summary>
/// <param name="np"></param>
/// <returns>Возвращает число квадратных  метров</returns>
        public double PerconArea(int np)
        {
            return RoomArea() / np;
        }

    }
}
