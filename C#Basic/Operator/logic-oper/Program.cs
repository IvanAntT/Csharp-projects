using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_oper
{
    class Program
    {
        static void Main()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a&&b);   //logi4esko i trqbva i dvete da sa izpulneni za da vurne True
            Console.WriteLine(a||b);   //logi4esko ili trqbva da e izpulneno samo 1 ot usloviqta za da vurne True
            Console.WriteLine(a^b);
            int i=5;
            bool chislo=((i>3)&&(i<6)) ;
            bool chislo2 = ((i > 20) && (i < 30));
            bool z = (chislo ^ chislo2);
            Console.WriteLine(z);
            Console.WriteLine(!b);
          
        }
    }
}
