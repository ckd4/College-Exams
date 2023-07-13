using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace быстрее_бы_сдать_я_устал
{
    internal static class Passwording
    {
        private static string blockedCharacters = " !?.*";

        public static bool Check(string password)
        {
            bool isDigit = false, isCapital = false, hasBlockedChars = false;
            if (password.Length < 10)
                return false;
            
            foreach (char c in password)
            {
                hasBlockedChars = hasBlockedChars || blockedCharacters.Contains(c);
                isDigit = isDigit || char.IsDigit(c);
                isCapital = isCapital || char.IsUpper(c);
            }

            return isDigit && isCapital && !hasBlockedChars;
        }
    }
}
