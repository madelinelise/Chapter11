using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class DerivedType: BaseType
    {


        private double _weight;

        public double Weight
        {
            get { return _weight; }
        }




        public DerivedType(string name, double weight, int age):base("Jane",21)
        {
            _weight = weight;
        }

    }
}
