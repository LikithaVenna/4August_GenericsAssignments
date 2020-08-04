using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "quick", "fox", "the", "lazy" };
            LinkedList<string> ll= new LinkedList<string>(str);
            Console.WriteLine("----------------Adding new element at First-----------------");
            ll.AddFirst("the");
            foreach (var l in ll)
            {
                Console.Write(" "+l);
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------Adding element at last-----------------");
            ll.AddLast("fox");
            foreach (var m in ll)
            {
                Console.Write(" "+ m);
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------Using find to Add element after for brown-----------------");
            var node = ll.Find("quick");
            ll.AddAfter(node, "brown");
            foreach (var n in ll)
            {
                Console.Write(" "+n);
            }
            Console.WriteLine("\n");
            Console.WriteLine("------------------Add element before by using AddBefore----------------------");
            var node2 = ll.FindLast("the");
            ll.AddBefore(node2, "jumps");
            ll.AddBefore(node2, "over");
            foreach (var o in ll)
            {
                Console.Write(" "+o);
            }
            Console.ReadLine();
        }
    }
}
