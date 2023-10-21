using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603404Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        //For J3 - myFavoritMovie
        //GET api/J3/myFavoritMovie/{movie}
        /// <summary>
        /// You have a list of movies with assigned order. When a number between 1 and 6 is entered, 
        /// it will display the corresponding movie name. For any other input,
        /// it will show "We only have 6 movies in the list(please enter 1-6 number only)" text
        /// </summary>
        /// <param name="movieNum">input number</param>
        /// <returns></returns>

        [HttpGet]
        [Route("api/J3/myFavoriteMovie/{movieNum}")]
        public string myFavoriteMovie(int movieNum) {

            //Movie list
            List<string> Movie = new List<string>();
            Movie.Add("Iron man");
            Movie.Add("In the Mood for Love");
            Movie.Add("Shangchi");
            Movie.Add("Harry potter");
            Movie.Add("Elemental");
            Movie.Add("The greatest showman");

            Boolean pickMovie = false;
            string returnText ="";
            while(pickMovie == false) {
                if (movieNum > 0 && movieNum <= 6)
                {
                    returnText = "Number " + movieNum + " on the list is " + Movie[movieNum - 1];
                    pickMovie = true;
                }
                else
                {
                    returnText = "We only have 6 movies in the list(please enter 1-6 number only)";
                    pickMovie = false;
                    break;
                }
            }

            return returnText;
        }
    }
}
