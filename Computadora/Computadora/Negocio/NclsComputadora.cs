using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NclsComputadora
    {
        public string Saludo(Clscomputadora computadora)
        {
            return "Bienvenido querido usuario";
        }
        public string Reiniciar(Clscomputadora computadora)
        {
            return "Reiniciando computadora";
        }
        public string Apagar(NclsComputadora computadora)
        {
            return "Apagando computadora";
        }
        public string Encender(Clscomputadora computadora)
        {
            return "La memoria Ram de su Pc con capacidad de" + computadora.Capacidad_ram + " GB y micro procesadora " + computadora.Procesador + " Está encendida";
        }
    }
}
