using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Ptmax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap slpt: ");
            int n = int.Parse(Console.ReadLine());

            List<int> lstInpt = new List<int>();    //ko cần khai báo slpt
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                lstInpt.Add(int.Parse(Console.ReadLine()));
            }

            int max_value = lstInpt.Max();  //cho ra giá trị lớn nhất
            int max_index = lstInpt.IndexOf(max_value);
            Console.WriteLine("Gia tri max={1}, tai thu {0}", max_index, max_value);

            Console.ReadKey();
        }
    }
}
