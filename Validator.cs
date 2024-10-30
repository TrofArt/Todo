using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    internal class Validator
    {
        public static bool IsValidEmail(string email)
        {
            var splitted1 = email.Split("@");

            if (splitted1.Length != 2)
            {
                return false;
            }

            var domain = splitted1[1].Split(".");

            if (domain.Length != 2)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }

        public static bool IsValidName(string name)
        {
            return name.Length >= 3;
        }
    }
}
