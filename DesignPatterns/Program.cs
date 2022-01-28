using DesignPatterns.Adapter;
using DesignPatterns.Composition;
using DesignPatterns.State;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestComposition();
        }

        private static void TestStatePattern()
        {
            var work = new Work();
            work.Hour = 9;
            work.WriteProgram();

            work.Hour = 10;
            work.WriteProgram();

            work.Hour = 12;
            work.WriteProgram();

            work.Hour = 13;
            work.WriteProgram();

            work.Hour = 14;
            work.WriteProgram();

            work.Hour = 17;
            work.Finished = true;
            work.WriteProgram();

            work.Hour = 19;
            work.WriteProgram();

            work.Hour = 22;
            work.WriteProgram();
        }

        private static void TestAdapterPattern()
        {
            Player a = new Forward("A");
            a.Attack();

            Player b = new Guard("B");
            b.Attack();

            Player c = new Translator("C");
            c.Attack();
            c.Defend();
        }

        private static void TestComposition()
        {
            var root = new ConcreteCompany("Beijing headquarter");
            root.Add(new HRDepartment("HR department"));
            root.Add(new FinancialDepartment("Financial department"));

            var shanghai = new ConcreteCompany("Shanghai office");
            shanghai.Add(new HRDepartment("HR department"));
            shanghai.Add(new FinancialDepartment("Financial department"));

            root.Add(shanghai);

            root.Display(1);
        }
    }
}
