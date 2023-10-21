using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603404Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        //For J2 - Roll the Dice
        //GET api/J2/DiceGame/{m}/{n}

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n) {
            int sum = 10;
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == sum)
                    {
                        count++;
                    }
                }
            }
            string returnText;
            if (count == 1) {
                returnText = "There is 1 way get the sum 10";
            }
            else {
                returnText = "There are " + count + " way to get the sum 10"; 
            }
            return returnText;
        }
    }
}
