using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        /*Controllo il cardiaco max dell'utente* (ES 1)*/
        public static int cardiaco_max(int x, int y)
        {
            int max = 220 - x; //Trovo la frequenza cardiaca massima dell'utente

            return max;
        }

        /*Controllo il battito minimo efficace (ES 1)*/
        public static int controllo_battito_min(int cardiaco_max)
        {
            int frequenza_mix = (cardiaco_max * 70) / 100; //Frequenza cardiaca minima

            return frequenza_mix;
        }

        /*Controllo il battito massimo efficace (ES 1)*/
        public static int controllo_battito_max(int cardiaco_max)
        {
            int frequenza_max = (cardiaco_max * 90) / 100; //Frequenza cardiaca massima

            return frequenza_max;
        }

        /*Controllo frequenza (ES 2)*/
        public static string controllo_frequenza(int variabile)
        {
            string messaggio = "";

            // Controlli
            if (variabile < 60)
            {
                messaggio = "Bradicardia";
            }

            if (variabile > 60 && variabile < 100)
            {
                messaggio = "Normale";
            }

            if (variabile > 100)
            {
                messaggio = "Tachicardia";
            }
            return messaggio; // Restituisco il valore
        }

        /*Calcolo Uomo (ES 3)*/
        public static double calcolo_uomo(double a, double p, double f, double t)
        {
            double calorie_uomoni = (a * 0.2017) + (p * 0.199) + (f * 0.6309) - (55.0969 * t / 4.184); // Calcolo i valori

            return calorie_uomoni;
        }

        /*Calcolo Donna (ES 3)*/
        public static double calcolo_donna(double a, double p, double f, double t)
        {
            double calorie_donne = (a * 0.074) - (p * 0.126) + (f * 0.4472) - (20.4022 * t / 4.184); // Calcolo i valori

            return calorie_donne;
        }

        /*Calcolo Corsa (ES 4)*/
        public static double corsa(double km, double peso)
        {
            double spesa_energetica = 0.9 * km * peso;

            return spesa_energetica;
        }

        /*Calcolo Camminata (ES 4)*/
        public static double camminata(double km, double peso)
        {
            double spesa_energetica = 0.5 * km * peso;

            return spesa_energetica;
        }

        /*Battito a riposo (ES 5.B)*/
        public static double riposo(double riposo)
        {
            double calcolo = riposo * 14;

            return calcolo;
        }
    }
}

