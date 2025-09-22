using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CuteArray
    {
        public int count {  get; set; }
        public int[] cuteArray { get; set; }

        public CuteArray(int count, int[] cuteArray)
        {
            this.count = count;
            this.cuteArray = cuteArray;
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int cute in cuteArray)
            {
                sum += cute;
            }
            return sum;
        }
        public int Even()
        {
            int sum = 0;
            foreach (int cute in cuteArray)
            {
                if (cute % 2 == 0) sum += 1;
            }
            return sum;
        }
        public int NotEven()
        {
            int sum = 0;
            foreach (int cute in cuteArray)
            {
                if (cute % 2 != 0) sum += 1;
            }
            return sum;
        }
    }
}
