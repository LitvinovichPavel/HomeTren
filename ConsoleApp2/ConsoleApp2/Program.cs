using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            info.InfoMethod();
        }
    }
    class Info
    {
        public void InfoMethod()
        {
            GetSet getSet = new GetSet();
            getSet.Method(1200, 500);
            getSet.Name = "AAA";
        }
    }
    class GetSet
    {
        public int Salary { get; set; }
        public int Costs { get; set; }
        public int Balance { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Method(int Salary, int Costs)
        {
            return Balance = Salary - Costs;
        }
    }
}
