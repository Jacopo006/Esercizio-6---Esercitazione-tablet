using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6___Esercitazione_tablet
{
    class tablet
    {
        private string marca;
        private double velocita;
        private double grandezza;
        private double duratabat;
        public void leggidati()
        {
            Console.WriteLine("Inserisci la marca del tablet");
            marca=Console.ReadLine();
            Console.WriteLine("Inserisci la velocità del tablet");
            velocita = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Inserisci la grandezza del tablet");
            grandezza = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci la durata della batteria del tablet");
            duratabat = Convert.ToDouble(Console.ReadLine());
        }
        public void stampadati()
        {
            Console.WriteLine($"Il tablet è di marca {marca}\nLa velocità è di {velocita} gHz\nLa grandezza è di {grandezza} pollici\nLa batteria è di {duratabat} mAh");
        }

        public double punteggio()
        {
            double punteggio = 10 * velocita + grandezza + (duratabat / 1000);
            return punteggio;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            tablet[] arrogg = new tablet[5];
            for (int i=0; i<arrogg.Length; i++)
            {
                Console.WriteLine($"Inserisci i dati per il tablet {i + 1}:");
                arrogg[i] = new tablet();
                arrogg[i].leggidati();
                arrogg[i].stampadati();
            }
            double punteggiomedio=0;
            double punteggiomigliore=0;
            double punteggiopeggiore = arrogg[0].punteggio();
            tablet tabletmigliore = new tablet();
            tablet tabletpeggiore = new tablet();

            for (int i=0; i<arrogg.Length;i++)
            {
                double Punteggio = arrogg[i].punteggio();
                punteggiomedio+=Punteggio;
                if (Punteggio>punteggiomigliore)
                {
                    punteggiomigliore = Punteggio;
                    tabletmigliore = arrogg[i];
                }     
                if (Punteggio<punteggiopeggiore)
                {
                    punteggiopeggiore = Punteggio;
                    tabletpeggiore = arrogg[i];
                }
            }

            punteggiomedio = punteggiomedio / arrogg.Length;
            Console.WriteLine("Il punteggio medio è "+punteggiomedio);
            Console.WriteLine("\nTablet migliore:");
            tabletmigliore.stampadati();
            Console.WriteLine("\nTablet peggiore:");
            tabletpeggiore.stampadati();
        }
    }

}