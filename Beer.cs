using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBottler1
{
     class Beer:Alcoholic
     {


        //Konstruktor
        public Beer(string beername, int beercount, double beerprice)
        {
            name = beername;
            count = beercount;
            price = beerprice;
        }

       


     }
}
