using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class Work
    {
        private State _state;

        public int Hour { set; get; }
        public bool Finished { set; get; }

        public Work()
        {
            _state = new MorningState();
        }

        public void SetState(State state)
        {
            _state = state;
            Console.WriteLine("Current state: " + state.GetType().Name);
        }

        public void WriteProgram()
        {
            _state.WriteProgram(this);
        }
    }

    abstract class State
    {
        public abstract void WriteProgram(Work work);
    }

    class MorningState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour < 12)
            {
                Console.WriteLine("Current time: {0}. Work in the morning.", work.Hour);
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }

        }
    }

    class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour < 13)
            {
                Console.WriteLine("Current time: {0}. Hungry.", work.Hour);
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }

    class AfternoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine("Current time: {0}. Still working.", work.Hour);
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }

    class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Finished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if(work.Hour < 21)
                {
                    Console.WriteLine("Current time: {0}. Overtime.", work.Hour);
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }

    class RestState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("Current time: {0}. Rest.", work.Hour);
        }
    }

    class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("Current time: {0}. Fall asleep during work.", work.Hour);
        }
    }
}
