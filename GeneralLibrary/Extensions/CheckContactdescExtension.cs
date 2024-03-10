using GeneralLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GeneralLibrary.Extensions;

public static class CheckContactdescExtension
{
    public static string CheckContactDesc(this string input, ContactType contactType)
    {
        if(contactType == ContactType.PhoneNumber)
        {
            if (!string.IsNullOrEmpty(input) && input.All(char.IsDigit))
            {
                return input;
            }
            else
            {
                throw new ArgumentException("Phone Number must contain only numbers.");
            }

        }
        if (contactType == ContactType.Email)
        {
            if (IsValidEmail(input))
            {
                return input;
            }
            else
            {
                throw new ArgumentException("Email is not valid");
            }
        }

        return input;
    }

    private static bool IsValidEmail(string email)
    {
        // Regular expression pattern for email validation
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        // Perform the regex match
        Match match = Regex.Match(email, pattern);

        // Return true if the string matches the pattern
        return match.Success;
    }
}
