﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _03_MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start();
            }

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }

        //IO - tela(Monitor), Rede, Armazenamento
        //causam atrasos, lentidão ao processamento.
        //Este método vai ser executado no "fluxo paralelo".
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Fluxo paraleleo: " + i);
            }
        }
    }
}
