﻿using CS20483.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curso 20483");
            TiposVR tipos = new TiposVR();
            //tipos.Executa();
            TiposPorValorIntegral tp = new TiposPorValorIntegral();
            tp.Executa();
            TiposValorFlutuante tf = new TiposValorFlutuante();
            //tf.Executa();
            Console.ReadKey();
        }
    }
}