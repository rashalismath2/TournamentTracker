using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        ///    Represent the first name of the Person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Reperesent the last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     Reperesent the email address of this person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        ///     Reperesent the contact number
        /// </summary>
        public string ContactNumber { get; set; }
    }
}
