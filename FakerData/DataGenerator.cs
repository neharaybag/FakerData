using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerData
{
    public class DataGenerator
    {

        /// <summary>
        /// Get FirstName
        /// </summary>
        /// <returns></returns>
        public string GetFirstName()
        {
            return Name.First();
           
        }


        /// <summary>
        /// Get last name
        /// </summary>
        /// <returns></returns>
        public string GetLastName()
        {
            return Name.Last();
        }


        /// <summary>
        /// Get full name
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return Name.FullName();
        }


        /// <summary>
        /// Get email
        /// </summary>
        /// <returns></returns>
        public string GetEmail()
        {
            return Internet.Email();
        }


        /// <summary>
        /// Get random phone number
        /// </summary>
        /// <returns></returns>
        public string GetMobileNumber()
        {
            return Phone.Number();
        }


        /// <summary>
        /// Get uk post code
        /// </summary>
        /// <returns></returns>
        public string GetPostCode()
        {
            return Address.UkPostCode();
        }

        /// <summary>
        /// Get Random number in btween (1-28 for date)
        /// </summary>
        /// <returns></returns>
        public int GetRandomDate()
        {
            return RandomNumber.Next(1, 28);
        }


        /// <summary>
        /// Get random month
        /// </summary>
        /// <returns></returns>
        public int GetRandomMonth()
        {
            return RandomNumber.Next(1, 12);
        }


        /// <summary>
        /// Get random year
        /// </summary>
        /// <returns></returns>
        public int GetRandomYear()
        {
            return RandomNumber.Next(1970, 1991);
        }


    }

}
