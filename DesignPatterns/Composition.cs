using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composition
{
    public abstract class Company
    {
        protected string _name;

        public Company(string name)
        {
            _name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();
    }

    public class ConcreteCompany : Company
    {
        private List<Company> _children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {

        }

        public override void Add(Company c)
        {
            _children.Add(c);
        }

        public override void Remove(Company c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);

            foreach(var c in _children)
            {
                c.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach(var c in _children)
            {
                c.LineOfDuty();
            }
        }
    }

    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {

        }

        public override void Add(Company c)
        {
            
        }

        public override void Remove(Company c)
        {
            
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} recruitments and training");
        }
    }

    public class FinancialDepartment : Company
    {
        public FinancialDepartment(string name) : base(name)
        {

        }

        public override void Add(Company c)
        {

        }

        public override void Remove(Company c)
        {

        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} financial duties");
        }
    }
}
