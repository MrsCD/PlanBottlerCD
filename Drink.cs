using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBottler1
{
    class Drink
    {   //Variablen initialisieren
        int _count;
        double _price;
        string _name;

        public Drink()
        {
        }

        //Konstruktor
        public Drink(string name, int count, double price)
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

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}