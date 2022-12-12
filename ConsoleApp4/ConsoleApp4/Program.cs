using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {   
                 string title = "The string to uppcase\n";
            string sentence1 = "This string will be change to uppercase.\n";
            string sentence2 = "This string will also change to uppercase.";
            Console.WriteLine(title.ToUpper() + sentence1.ToUpper() + sentence2.ToUpper());
            Console.Read(); 

            StringBuilder sb = new StringBuilder("The Paragraph\n");

            sb.Append("This is a paragraph.\n");
            sb.Append("A paragraph that is made using one sentance at a time\n");
            sb.Append("The stirng builder makes this possible.");
            Console.WriteLine(sb);
            Console.Read();
            Console.Read();
            
        }
    }
}
