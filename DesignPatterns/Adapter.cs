using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    abstract class Player
    {
        protected string _name;

        public Player(string name)
        {
            _name = name;
        }

        public abstract void Attack();
        public abstract void Defend();
    }

    class Forward : Player
    {
        public Forward(string name) : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("Forward {0} attacks", _name);
        }

        public override void Defend()
        {
            Console.WriteLine("Forward {0} defends", _name);
        }
    }

    class Center : Player
    {
        public Center(string name) : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("Center {0} attacks", _name);
        }

        public override void Defend()
        {
            Console.WriteLine("Center {0} defends", _name);
        }
    }

    class Guard : Player
    {
        public Guard(string name) : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("Guard {0} attacks", _name);
        }

        public override void Defend()
        {
            Console.WriteLine("Guard {0} defends", _name);
        }
    }

    class ForeignPlayer
    {
        public string Name { set; get; }

        public void Jingong()
        {
            Console.WriteLine("Foreign player {0} jingong", Name);
        }

        public void Fangshou()
        {
            Console.WriteLine("Foreign player {0} fangshou", Name);
        }
    }

    class Translator : Player
    {
        private ForeignPlayer _foreignPlayer = new ForeignPlayer();

        public Translator(string name) : base(name)
        {
            _foreignPlayer.Name = name;
        }

        public override void Attack()
        {
            _foreignPlayer.Jingong();
        }

        public override void Defend()
        {
            _foreignPlayer.Fangshou();
        }
    }
}
