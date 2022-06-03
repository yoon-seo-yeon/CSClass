namespace CSClass
{
    class Box1
    {
        public int width;
        public int height;

        public Box1(int width, int height)

        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}