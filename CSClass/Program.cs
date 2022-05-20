using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            
            //정수
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            //실수
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);

            /*
            List<int> list = new List<int>();
            list.Add(97);
            list.Add(19);
            list.Add(13);
            list.Add(7);
            */

            List<int> list = new List<int> { 97, 19, 13, 7 };
            list.Remove(19);

            foreach(var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            Hamburger food = new Hamburger();

            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;

            //인스턴스 변수를 생성과 동시에 초기화(C# 고유 문법)
            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { price = 5000, name = "당근케이크"};
            Product productD = new Product() { name = "보름달" };
        }
    }
}