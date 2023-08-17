using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    internal class MainPrintFile
    {
        public void Print(object file)
        {
            if (file is Word)
            {
                Console.WriteLine("word cap edildi");

            }
            if (file is Excel)
            {
                Console.WriteLine("excel cap edildi");
            }
            if (file is PDF)
            {
                Console.WriteLine("excel cap edildi");
            }
        }
    }
}
