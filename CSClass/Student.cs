namespace CSClass
{
    class Student
    {
        public int grade;
        public string name ;

        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }
    }
}