using DesignPatterns.State;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region State

            TestStatePattern();

            #endregion
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
    }
}
