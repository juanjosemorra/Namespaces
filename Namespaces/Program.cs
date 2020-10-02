using Namespaces.Data.Origen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ori = Namespaces.Data.Origen;
using des = Namespaces.Data.Destino;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jerarquía lógica
            A.TestA testA = new A.TestA();
            testA.Ejemplo();

            A.subA.TestA testSubA = new A.subA.TestA();
            testSubA.Ejemplo();

            Data.Origen.Entidad entidadOrigen = new Data.Origen.Entidad();
            Data.Destino.Entidad entidadDestino = new Data.Destino.Entidad();

            
            //Utilización de Alias
            //ori.Entidad entidadOrigen = new ori.Entidad();
            //des.Entidad entidadDestino = new des.Entidad();

            Console.ReadKey();
        }
    }
}
