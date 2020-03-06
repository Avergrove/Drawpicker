using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DrawPicker
{
    class DickSizeHasher
    {
        /// <summary>
        /// Generates a person's dick size using hashing.
        /// </summary>
        /// <param name="name">The name of the person</param>
        /// <returns></returns>
        public static int getDickSizeFromString(String name)
        {
            return Math.Abs((name.ToLower().GetHashCode() - 5) % 11);
        }

        /// <summary>
        /// Returns a string to represent person's dick size. Because we're all adults over here.
        /// </summary>
        /// <returns></returns>
        public static String getDickSizeAsAscii(int length)
        {
            return String.Format("8{0}D", string.Concat(Enumerable.Repeat("=", length)));
        }
    }
}
