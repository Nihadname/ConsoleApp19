using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp19.Helpers
{
    public static class PhoneNumberCheck
    {
        public static bool  PhoneNumberChecking( this string phoneNumber,string pattern)
        {
            Regex regex=new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
    }
}
