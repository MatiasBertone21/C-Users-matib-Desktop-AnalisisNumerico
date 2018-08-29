﻿namespace AnalisisNumerico.Entidades
{
    public class Parametros
    {
        public string Funcion { get; set; }

        public double Xi { get; set; }

        public double Xd { get; set; }

        public int Iteraciones { get; set; }

        public double Tolerancia { get; set; }

        public bool Tipo { get; set; }
    }
}