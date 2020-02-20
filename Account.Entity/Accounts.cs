using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Entity
{
    public class Accounts
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string LanguageKnown { get; set; }

        public Accounts(string id, string password, string gender, byte age,string city,string phoneNo,string language)
        {
            this.EmailId = id;
            this.Password = password;
            this.Gender = gender;
            this.Age = age;
            this.City = city;
            this.PhoneNumber = phoneNo;
            this.LanguageKnown = language;

        }
        public Accounts()
        {

        }

    }
}
