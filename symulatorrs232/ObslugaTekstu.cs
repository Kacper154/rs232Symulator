using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SymulatorRS232
{
    public static class ObslugaTekstu
    {

        private static bool[] decToBin(int dec)
        {
            int buffD = dec;
            bool[] buffB = new bool[16];
            for (int i = 15; i >= 0; i--)
            {
                if (buffD % 2 == 1) buffB[i] = true;
                else buffB[i] = false;

                buffD /= 2;
            }
            return buffB;
        }

        private static int binToDec(bool[] bin)
        {
            int dec = 0;
            int n = 1;
            for(int i= bin.Length-1; i>=0; i--)
            {
                if(bin[i])
                {
                    dec += n;
                }
                n *= 2;
            }
            return dec;
        }


        private static bool[] odwrocTablice (bool[] tablica)
        {
            bool[] buff = new bool[tablica.Length];
            for(int i =0; i<tablica.Length; i++)
            {
                buff[i] = tablica[tablica.Length - 1 - i];
            }
            return buff;
        }


        private static bool[] dodajBityStopuIStartu(bool[] bajt)
        {
            bool[] znak = new bool[11]; //8 bitów + 1 startu + 2 stopu = 11
            znak[0] = false;
            for(int i=0; i<8; i++)
            {
                znak[i + 1] = bajt[i];
            }
            znak[9] = true;
            znak[10] = true;

            return znak;
        }

        private static bool[] usunBityStopuIStartu(bool[] slowo)
        {
            bool[] bajt = new bool[8];
            for(int i=0; i<8; i++)
            {
                bajt[i] = slowo[i + 1];
            }
            return bajt;
        }

        private static bool[] znakNaSlowoBinarne(char znak)
        {
            int kodASCIIZnaku = (int)znak;
            bool[] bajtZnaku = new bool[8];
            bajtZnaku = odwrocTablice(decToBin(kodASCIIZnaku));
            bool[] slowoBinarne = new bool[11];
            slowoBinarne = dodajBityStopuIStartu(bajtZnaku);

            return slowoBinarne; 
        }

        public static bool[][] lancuchNaSlowaBinarne(string lancuch)
        {
            bool[][] slowaBinarne = new bool[lancuch.Length][];
            for(int i=0; i<lancuch.Length; i++)
            {
                slowaBinarne[i] = znakNaSlowoBinarne(lancuch[i]);
            }
            return slowaBinarne;
        }


        private static char SlowoBinarneNaZnak(bool[] slowoBinarne)
        {
            bool[] bajt = new bool[8];
            bajt = usunBityStopuIStartu(slowoBinarne);
            int kodASCIIZnaku = binToDec(odwrocTablice(bajt));  
            char znak = (char)kodASCIIZnaku;
            return znak;
        }


        public static string slowaBinarneNaLancuch(bool[][] slowaBinarne)
        {
            string buff = "";
            foreach (bool[] x in slowaBinarne)
            {
                buff += SlowoBinarneNaZnak(x);
            }
            return buff;
        }







        private static string numberToText(bool[] number)
        {
            string tymcz = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]) tymcz += "1";
                else tymcz += "0";
            }
            return tymcz;
        }
        public static string numberToText(bool[][] number)
        {
            string buff = "";
            int i = 0;
            foreach(bool[] x in number)
            {
                buff += (numberToText(x) + "  ");
                if(i!=0 && i%4==0)
                {
                    buff += "\r\n";
                }
            }
            return buff;
        }

        public static string TextControll(string tekst)
        {
            string buff = "";
            if (tekst.Length != 0)
            {
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i].Equals('1') || tekst[i].Equals('0'))
                    {
                        buff += tekst[i];
                    } 
                }

                
            }
            return buff;


        }


        public static int policzLiczbeLinii(StreamReader f)
        {
            int liczbaLinii = 0;
            while ((f.ReadLine()) != null) liczbaLinii++;
            return liczbaLinii;

        }


        public static string[] plikDoTablicy(StreamReader f, int liczbaLinii)
        {
            string linia = "";
            
            int i = 0;
            string[] tablica = new string[liczbaLinii];

            while ((linia = f.ReadLine()) != null)
            {
                tablica[i] = linia;
                i++;
            }
            return tablica;
        }


        public static string cenzuruj(string tekstS, string[] czarnaListaSlow)
        {
            StringBuilder tekst = new StringBuilder(tekstS);
            string gwiazdki = "";
            for(int i=0; i<czarnaListaSlow.Length; i++)
            {
                for(int j=0; j<czarnaListaSlow[i].Length; j++)
                {
                    gwiazdki += "*";
                }

                tekst.Replace(czarnaListaSlow[i], gwiazdki);
                tekst.Replace(czarnaListaSlow[i].ToLower(), gwiazdki);
                tekst.Replace(czarnaListaSlow[i].ToUpper(), gwiazdki);
                gwiazdki = "";

            }
            return tekst.ToString();

        } 




    }
}
