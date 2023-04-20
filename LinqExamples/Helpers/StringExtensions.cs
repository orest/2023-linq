using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples.Helpers {
    public static class StringExtensions {
        public static int ToInt(this string value, int defaultValue) {

            if (Int32.TryParse(value, out int returnValue)) {
                return returnValue;
            }

            return defaultValue;
        }

        public static bool IsValidZip(this string value, int validLength) {
            if (validLength == 9 || validLength == 5) {
                if (validLength == 9) {
                    if (value.IndexOf("-",StringComparison.CurrentCultureIgnoreCase) > -1) {
                        validLength = 10;
                    }
                }

                return value.Length == validLength;
            }

            return false;
        }
    }
}
