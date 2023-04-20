using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples.Helpers {
    public static class StrUtils {
        public static int ToInt(string value) {
            var returnValue = 0;
            if (Int32.TryParse(value, out returnValue)) {
                return returnValue;
            }

            return returnValue;
        }
    }
}
