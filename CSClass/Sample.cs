using System;

namespace CSClass
{
    class Sample
    {
        public static int value = 42;

        public Sample()
        {
            Console.WriteLine("Sample() 생성자 호출!!");
        }

        static Sample() //static 메서드는 매개변수 안된다
        {
            value = 777;
            Console.WriteLine("Sample() 정적 생성자 호출!!");
        }
    }
}