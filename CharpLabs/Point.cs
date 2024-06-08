using System;

namespace GeometryLibrary
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        // Конструктор
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Властивості
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
