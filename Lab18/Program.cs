using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана строка, содержащая скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы.
            //    Проверить, корректно ли в ней расставлены скобки. Например, в строке([]{ })[] скобки расставлены корректно, а в строке([]] — нет.
            //    Указание: задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в строке в стек 
            //    помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека(при этом скобка с вершины стека снимается); 
            //в конце прохода стек должен быть пуст.

            string str = "([]]";
            Stack<char> scoba = new Stack<char>();
            foreach (var i in str)
            {
                if (i == '(' || i == '[' || i == '{')
                {
                    scoba.Push(i);
                }
                if (i == ')')
                {
                    if (scoba.Contains('('))
                    {
                        scoba.Pop();
                    }
                }
                if (i == ']')
                {
                    if (scoba.Contains('['))
                    {
                        scoba.Pop();
                    }
                }
                if (i == '}')
                {
                    if (scoba.Contains('{'))
                    {
                        scoba.Pop();
                    }
                }
            }

            if (scoba.Count == 0)
            {
                Console.WriteLine("Скобки расставлены верно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не верно");
            }
            Console.ReadKey();
        }
    }
}

