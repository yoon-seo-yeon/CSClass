using System;
namespace CSClass
{
    internal class Product
    {
        public static int counter = 0;
        public int id;

        public Product(string name, int price)
        {
            Product.counter++;
            this.id = Product.counter;
            this.name = name;
            this.price = price;
            Console.WriteLine(this);
        }

        public static string MADEIN = "Korea";

        /// <summary>
        /// 상품 이름
        /// </summary>
        public string name = "무명";

        /// <summary>
        /// 상품 가격, 단위는 원
        /// </summary>
        public int price = 1000;

        public Product()
        {

        }

        public override string ToString()
        {
            return this.id + " : " + this.name + "(" + this.price + "원)"; 
        }
    }
}