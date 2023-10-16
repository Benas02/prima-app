﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    internal class AutoInterattiva : Auto {
        #region "Costruttore"
        // -------------------- Costruttore Vuoto --------------------
        public AutoInterattiva() { }

        public AutoInterattiva(string? marca, string? modello, Motore tipoMotore, string? colore, int livelloCarburante) : base(marca, modello, tipoMotore, colore, livelloCarburante) { }

        #endregion

        #region "Menu"
        // -------------------- Motodo Menu --------------------
        public int stampaMenu()
        {
            int answer;

            Console.WriteLine("\n---------------------------------");

            Console.WriteLine("\n1) ACCENDERE il Veicolo");
            Console.WriteLine("2) SPEGNERE il Veicolo");
            Console.WriteLine("3) RIFORNIRE il Veicolo");
            Console.WriteLine("0) USCIRE");

            do
            {
                Console.Write("\nSelezionare l'Azione da Eseguire: ");
                answer = Int32.Parse(Console.ReadLine());
            } while (answer < 0 || answer > 3);

            return answer;
        }

        // -------------------- Motodo che Setta il Menu --------------------
        public void setScelta() {
            int menu;

            do {
                menu = stampaMenu();

                switch (menu) {
                    case 1:
                        this.accendi();
                        Console.WriteLine("\n- Tento di Accendere il Veicolo");
                        this.stampaStato();
                        break;
                    case 2:
                        this.spegni();
                        Console.WriteLine("\n- Spengo il Veicolo");
                        this.stampaStato();
                        break;
                    case 3:
                        int livelloCarburante;

                        do {
                            Console.Write("Livello Rifornimento: ");
                            livelloCarburante = Int32.Parse(Console.ReadLine());
                        } while (livelloCarburante < 0);

                        this.rifornisci(livelloCarburante);
                        Console.WriteLine("\n- Rifornisco il Veicolo");
                        this.stampaStatoNoStato();
                        break;
                    case 0:
                        //Environment.Exit(0);              // CHIUDE IL PROGRAMMA
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            } while (menu != 0);
        }
        #endregion
    }
}
