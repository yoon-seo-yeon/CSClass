using System;

namespace CSClass
{
    public class Dog : Animal
    {
        public String Color { get; set; }

        public void Bark()
        {
            this.Eat(); //Dog의 Eat호출
            base.Eat(); //Animal의 Eat호출
            Console.WriteLine("왈왈 짖습니다.");
        }

        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다");
        }
    }
}