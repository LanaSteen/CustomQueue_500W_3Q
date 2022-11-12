using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue_500W_3Q
{   /*Შექმენით Custom Queue- ჯენერიკ იმპლემენტიაცია განუსაზღვრეთ კონსტრუქტორი პარამეტრიანი და უპარამეტროც.
     Უნდა შეიძებოდეს ქიუს ზომის შემოწმება ცარიელია თუ არა. 
     Უნდა იყოს ელემენტის დამატების და წაშლის მეთოდები. 
     Დანარჩენი მეთოდები შეგიძლიათ დაამატოთ სურვილისამებრ.*/
    internal class Program
    {
        static void Main(string[] args)
        {

            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(-50);


            Console.WriteLine(queue.PeekQueue());
            Console.WriteLine(queue.Size());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Size());
            queue.ClearQueue();
            Console.WriteLine(queue.Size());
        }
    }
}
