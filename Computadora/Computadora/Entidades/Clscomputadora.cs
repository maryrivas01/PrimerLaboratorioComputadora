using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class Clscomputadora
    {
        private int rAM;
        private int discoDuro;
        private String fDuenteDePoder;
        private String tarjetaGrafica;
        private String pantalla;
        private String procesador;
        private String ventiladores;
        private String Case1;
        private String teclado;
        private String mouse;

        public int RAM { get => rAM; set => rAM = value; }
        public int DiscoDuro { get => discoDuro; set => discoDuro = value; }
        public string FDuenteDePoder { get => fDuenteDePoder; set => fDuenteDePoder = value; }
        public string TarjetaGrafica { get => tarjetaGrafica; set => tarjetaGrafica = value; }
        public string Pantalla { get => pantalla; set => pantalla = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Ventiladores { get => ventiladores; set => ventiladores = value; }
        public string Case11 { get => Case1; set => Case1 = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mouse { get => mouse; set => mouse = value; }
    }
