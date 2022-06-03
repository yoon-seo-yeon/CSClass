using System;

namespace CSClass
{
    class Box2
    {
        private int width;
        private int height;

        public void setWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("양수를 입력해주세요!");

            }
        }

        public void setHeight(int height)
        {
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("양수를 입력해주세요!");

            }
        }

        public int getWidth(int width)
        {
            return width;
        }

        public int getHeight(int height)
        {
            return height;
        }

        public Box2(int width, int height)
        {
            setWidth(width);
            setHeight(height);
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}