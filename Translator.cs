using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Translator : Ienglish, Iarabic
    {
         void Ienglish.greet() => throw new NotImplementedException();

         void Iarabic.greet() => throw new NotImplementedException();
    }
}
