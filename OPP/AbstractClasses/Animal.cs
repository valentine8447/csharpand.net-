using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Animal

    {
        private string name;

        public bool SetName(string _name)
        {
            name = name;
            return true;
        }
        public string GetName()
        {
            return name;    
        }
        public abstract void Eat();
    }
}
