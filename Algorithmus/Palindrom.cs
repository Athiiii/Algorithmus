using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmus
{
    public static class Palindrom
    {
        public static bool IsPalindromAsLoop(this string palindrom)
        {
            var palindromArray = palindrom.ToCharArray();
            var result = true;
            while (palindromArray.Length > 1)
            {
                if (palindromArray[0].ToString().ToLower() !=
                    palindromArray[palindromArray.Length - 1].ToString().ToLower())
                {
                    result = false;
                    break;
                }

                palindromArray = palindromArray.Skip(1).ToArray();
                palindromArray = palindromArray.Take(palindromArray.Length - 1).ToArray();

            }

            return result;
        }

        public static bool IsPalindromAsRecursion(this string palindrom)
        {
            var palindromArray = palindrom.ToArray();
            if (palindromArray.ToArray().Length > 1)
            {
                if (palindromArray[0].ToString().ToLower() !=
                    palindromArray[palindromArray.Length - 1].ToString().ToLower())
                {
                    return false;
                }

                palindromArray = palindromArray.Skip(1).ToArray();
                palindromArray = palindromArray.Take(palindromArray.Length - 1).ToArray();
                return IsPalindromAsRecursion(new string(palindromArray));
            }

            return true;
        }
    }
}
