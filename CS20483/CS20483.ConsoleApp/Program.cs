﻿
using CS20483.Modulo1.Aula1.TiposPorValor;
using CS20483.Tipos;
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
            
            NumerosInteiros nI = new NumerosInteiros();
            nI.Executar();

            PontoFlutuante pF = new PontoFlutuante();
            //pF.Executar();

            Booleanos bo = new Booleanos();
            //bo.Executar();

            Estruturas es = new Estruturas();
            //es.Executar();

            Enumeradores en = new Enumeradores();
            //en.Executar();

            //TiposVR tipos = new TiposVR();
            ////tipos.Executa();
            //TiposPorValorIntegral tp = new TiposPorValorIntegral();
            ////tp.Executa();
            //TiposValorFlutuante tf = new TiposValorFlutuante();
            ////tf.Executa();
            //Structs estruturas = new Structs();
            ////estruturas.Executa();
            //TipoReferencia tr = new TipoReferencia();
            ////tr.Executa();
            //UsandoTipos ut = new UsandoTipos();
            ////ut.Execute();

            //UsandoTipos2 ot2 = new UsandoTipos2();
            //ot2.Executa();

            //Delegados delegado = new Delegados();
            ////delegado.Executa();

            Console.ReadKey();
        }
    }
}
