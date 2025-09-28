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

        public CuteArray(int[] cuteArray)
        {
            this.count = cuteArray.Length;
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
        public void SortChoice()
        {
            for (int i=0; i<count-1; i++)
            {
                int minIndex = i;
                for(int j = i+1; j<count; j++)
                {
                    if (cuteArray[j] < cuteArray[minIndex]) minIndex = j;
                }
                if (minIndex != i) (cuteArray[i], cuteArray[minIndex]) = (cuteArray[minIndex], cuteArray[i]);
            }
        }


        public void SortQuick()
        {
            if (cuteArray.Length <= 1) return;
            else
            {
                QuickSort(0, cuteArray.Length - 1);
            }  
        }
        private void QuickSort(int left, int right)
        {
            if (left < right)
            {
                int pivot = cuteArray[right];
                int i = left - 1;
                for (int j = left; j < right; j++)
                {
                    if (cuteArray[j] <= pivot)
                    {
                        i++;
                        Swap(i, j);
                    }
                }
                Swap(i + 1, right);
                int pivotIndex =  i + 1;
                QuickSort(left, pivotIndex - 1);
                QuickSort(pivotIndex + 1, right);
            }
        }
        private void Swap(int i, int j) => (cuteArray[i], cuteArray[j]) = (cuteArray[j], cuteArray[i]);

    }
}
