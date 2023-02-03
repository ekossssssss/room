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
/// ��������� �������� �������
/// </summary>
/// <returns>���������� �������� ���������</returns>
        public double RoomPerimeter()
        {
            return 2 *  (roomLength + roomWidth);
        }
/// <summary>
/// ��������� ������� �������
/// </summary>
/// <returns>���������� �������� �������</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
/// <summary>
/// ����� ��������� ����� ���������� ������ �� ����� ��������
/// </summary>
/// <param name="np"></param>
/// <returns>���������� ����� ����������  ������</returns>
        public double PerconArea(int np)
        {
            return RoomArea() / np;
        }

    }
}
