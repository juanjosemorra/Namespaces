using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces
{
    namespace A
    {
        namespace subA
        {
            public class TestA
            {
                public void Ejemplo()
                {
                    System.Console.WriteLine("Namespace A.subA");
                }                
            }
        }

        public class TestA
        {
            public void Ejemplo()
            {
                System.Console.WriteLine("Namespace A");
            }
        }
    }
}
