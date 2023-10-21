using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace n01603404Assignment2.Controllers { 

    public class J1Controller : ApiController
    {
        //For J1 -The New CCC
        //GET api/J1/Menu/{burger}/{drink}/{side}/{dessert}

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public int Menu(int burger, int drink, int side, int dessert)
        {
            //Burger calories list
            List<int> Burgers = new List<int>();
            Burgers.Add(461);
            Burgers.Add(431);
            Burgers.Add(420);
            Burgers.Add(0);

            //Drink calories list
            List<int> Drinks = new List<int>();
            Drinks.Add(130);
            Drinks.Add(160);
            Drinks.Add(118);
            Drinks.Add(0);

            //Side calories list
            List<int> Side = new List<int>();
            Side.Add(100);
            Side.Add(57);
            Side.Add(70);
            Side.Add(0);

            //Dessert calories list
            List<int> Dessert = new List<int>();
            Dessert.Add(167);
            Dessert.Add(266);
            Dessert.Add(75);
            Dessert.Add(0);

;            return Burgers[burger-1] + Drinks[drink-1] + Side[side-1] + Dessert[dessert-1];

        }

    }
}
