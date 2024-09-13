using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordCheckerApp
{
    public class PasswordChecker
    {
        public int CheckPassword(string password)
        {
            int score = 0;

            if (Regex.IsMatch(password, @"\d")) score++;

            if (Regex.IsMatch(password, @"[a-z]")) score++;

            if (Regex.IsMatch(password, @"[A-Z]")) score++;

            if (Regex.IsMatch(password, @"[\W_]")) score++;

            if (password.Length > 7) score++;

            return score;
        }
    }
}
