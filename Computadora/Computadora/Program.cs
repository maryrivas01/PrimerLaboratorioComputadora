using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Clscomputadora clscomputadora = new Clscomputadora();
            NclsComputadora nclscomputadora = new NclsComputadora();


            clscomputadora.Procesador = "Intel";
            clscomputadora.RAM = 8;
            clscomputadora.Teclado = "Razer";


           



        }
    }


}
