using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBottler1
{
    class Tea: Hot_Drink
    {
        //Initialisieren der Variablen
        int _count;
        double _price;
        string _name;

        //Konstruktor
        public Tea(string name, int count, double price)
        {
            _name = name;
            _count = count;
            _price = price;
        }

        //Properties
        public int count
        {
            get { return _count; }
            set { _count = value; }

        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string name
        {
            get { return _name; }
        }
    }
}
