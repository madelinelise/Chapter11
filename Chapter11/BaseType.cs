using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class BaseType
    {
        private int _age;

        public int Age
        {
            get { return _age; }
           
        }

        private string _name;

        public string Name
        {
            get { return _name; }
          
        }

        public BaseType(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string baseRegular()
        {
            return "baseRegular(), " + _name + " " + _age.ToString();
        }
        
        public virtual string baseVirtual()
        {
            return "basevirtual(), " + _name + " " + _age.ToString();
        }
    }
}
