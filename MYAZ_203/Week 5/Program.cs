using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
    public class Program
    {
       public static void Main()
        {
            //var act1 = ResultSets.Action1();
            //Console.WriteLine($"{act1.Status,-5}"+
            //    $"{act1.Message,5}");

            //var act2 = ResultSets.Action2();
            //Console.WriteLine($"{act2.Status,-5}" +
            //    $"{act2.Message,5}");

            //var act3 = ResultSets.Action3();
            //Console.WriteLine($"{act3.Status,-5}" +
            //    $"{act3.Message,5}");

            //var act4 = ResultSets.Action4();
            //Console.WriteLine($"{act4.Status,-5}" +
            //    $"{act4.Message,5}");


            //MinHeap geap=new MinHeap();
            MaxHeap heap= new MaxHeap();
            heap.Insert(5);
            heap.Insert(4);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);

            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");
            Console.WriteLine($"{heap.Extract()}");




        }
    }
}
