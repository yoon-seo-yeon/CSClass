using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        private static int width;

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

            //2022.05.26
            /*
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "김다흰", grade = 2 });
            students.Add(new Student() { name = "김미나", grade = 1 });
            students.Add(new Student() { name = "김민정", grade = 3 });
            students.Add(new Student() { name = "김세린", grade = 1 });
            students.Add(new Student() { name = "김소연", grade = 3 });
            students.Add(new Student() { name = "김지수", grade = 2 });
            students.Add(new Student() { name = "김지호", grade = 3 });
            students.Add(new Student() { name = "김찬희", grade = 2 });
            students.Add(new Student() { name = "김하늘", grade = 1 });
            students.Add(new Student() { name = "김효리", grade = 2 });
            students.Add(new Student() { name = "윤서연", grade = 3 });
            */

            //아래 작업이 위 작업보다 훨씬 편리하다.
            List<Student> students = new List<Student>()
            {
                new Student() { name = "김다흰", grade = 2 },
                new Student() { name = "김미나", grade = 1 },
                new Student() { name = "김민정", grade = 2 },
                new Student() { name = "김세린", grade = 1 },
                new Student() { name = "김소연", grade = 1 },
                new Student() { name = "김지수", grade = 2 },
                new Student() { name = "김지호", grade = 3 },
                new Student() { name = "김찬희", grade = 2 },
                new Student() { name = "김하늘", grade = 1 },
                new Student() { name = "김효리", grade = 2 },
                new Student() { name = "윤서연", grade = 3 },
            };

            //Student 리스트 전체 출력
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");

            /*
            foreach (var item in students)
            {
                if(item.grade > 2)
                {
                    students.Remove(item);
                }
                Console.WriteLine(item);
            }
            */

            /*
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].grade < 2) 
                {
                    //연속된 속성이 제거되지 않는 경우 발생
                    students.RemoveAt(i);
                    //students.Remove(students[i]);
                }
            }
            */

            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade < 2)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");

            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 100));
            Console.WriteLine(Method.Abs(-100));
            Console.WriteLine(Method.Abs(100));
            //Console.WriteLine(method.Abs(-100)); -> Java는 가능, C#은 불가능

            Console.WriteLine("----------------");

            //Method Overloading
            //ing
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            //double
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-52.273));

            //long
            Console.WriteLine(MyMath.Abs(2223456789));
            Console.WriteLine(MyMath.Abs(-2223456789));

            Console.WriteLine("----------------");

            Product product1 = new Product("감자", 3000);
            Product product2 = new Product("고구마", 3000);
            Console.WriteLine(Product.counter + "개 생성되었습니다");

            Console.WriteLine("----------------");

            /*
            Console.WriteLine("첫번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세번째 위치");
            */
            
            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번째 위치");

            Console.WriteLine("----------------");

            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적은 : " + box1.Area());

            Box2 box2 = new Box2(10, 10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적은 : " + box2.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적은 : " + box.Area);

            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(100));
            Console.WriteLine(Fibonacci.Get(1000));

            Console.WriteLine("----------------");

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach(var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

            List<Animal> animals = new List<Animal>() { new Dog(), new Dog(), new Dog(),
                                                        new Cat(), new Cat(), new Cat()};
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                //item.Bark();
                ((Dog)item).Bark();

                if(item is Dog)
                {
                    //item.Bark(); //안됨
                    ((Dog)item).Bark();
                } else if(item is Cat)
                {
                    Cat cat = (Cat)item;
                    cat.Meow();
                }

            }
        }
    }
}