using System;
using System.Collections;
using System.Linq;

namespace Prime.Services {
    public class PrimeService {
        public bool IsPrime (int candidate) {
            if (candidate < 2) {
                return false;
            }
            throw new NotImplementedException ("Please create a test first");
        }

        public bool IsOdd (int num) {
            if (num % 2 != 0) return false;
            throw new NotImplementedException ("Please create a test first");
        }

        public int[] IsListOfIntegers () {
            int[] array = new int[5];
            array[0] = 34;
            array[1] = 6;
            array[2] = 57565;
            array[3] = 234;

            return array.OrderBy (x => x).ToArray ();
        }
    }
}
