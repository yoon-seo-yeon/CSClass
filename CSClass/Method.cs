using System;

namespace CSClass
{
    class Method
    {
        int instanceVariable = 10;
        static int classVariable = 20;

        public double Multi(double v1, int v2)
        {
            return v1 * v2;
        }

        /// <summary>
        /// min부터 max까지의 합
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최대값</param>
        /// <returns>min부터 max까지의 합계</returns>
        public int Sum(int min, int max)
        {
            int output = 0;
            for(int i = min; i <= max; i++)
            {
                output += i;
            }

            return output;
        }

        /// <summary>
        /// min부터 max까지의 곱
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최대값</param>
        /// <returns>min부터 max까지의 곱</returns>
        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
            }

            return output;
        }

        static public void some()
        {
            //Console.WriteLine(instanceVariable);
            Console.WriteLine(classVariable);
        }

        public static int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        } 
    }
}