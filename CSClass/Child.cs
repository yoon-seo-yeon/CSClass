using System;

namespace CSClass
{
    public class Child : Parent
    {
        public new string variable = "hiding";

        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }

        //public sealed override void Method2()
        public override void Method2()
        {
            Console.WriteLine("자식의 메서드");
        }

        public Child() : base(10)
        {
            Console.WriteLine("Child():base(10)");
        }

        public Child(string input) : base(input) {
            Console.WriteLine("Child(string input):base(input)");
        }

        public void CountChild()
        {
            Child.counter++;
        }

        /*
        public override void Method3()
        {
            Console.WriteLine("추상 메서드 구현");
        }
        */
    }
}