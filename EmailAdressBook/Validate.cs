using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailAdressBook
{
  public  class Validate
    {
        private string _message;

        public string Message { get { return _message; } }
        public bool ValidateName(string name)
        {
            if (name.Length<1)
            {
                _message = "Name is required";
                return false;
            }
            return true;
        }

        public bool ValidatePhoneNumber(string number)
        {
            Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
           bool isValid= r.IsMatch(number);
            switch (isValid)
            {
                case true:
                    break;
                case false:
                    _message = "Phone number is not in the right format";
                    break;
            }
            return isValid;

        }

        public bool ValidatEmail(string email)
        {
            Regex r = new Regex("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
            bool isValid = r.IsMatch(email);
            switch (isValid)
            {
                case true:
                    break;
                case false:
                    _message = "Email address is not valid.";
                    break;
            }
            return isValid;
        }
    }
}
