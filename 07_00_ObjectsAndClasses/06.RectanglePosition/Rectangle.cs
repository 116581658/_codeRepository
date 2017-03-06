using System;

namespace _06.RectanglePosition
{
    public class Rectangle
    {
        private int left;
        private int top;
        private int width;
        private int heigh;

        public int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid argument: Width should be a positive number.");
                }
                this.width = value;
            }
        }

        public int Heigh
        {
            get { return this.heigh; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid argument: Heigh should be a positive number.");
                }

                this.heigh = value;
            }
        }

        public int Right
        {
            get { return this.left + this.width; }
        }

        public int Bottom
        {
            get { return this.top + this.heigh; }
        }

    }
}
