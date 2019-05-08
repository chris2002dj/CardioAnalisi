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
        public static string controllo_frequenza(int battito)
        {
            string messaggio = "";

            // Controlli
            if (battito > 0)
            {
                if (battito < 60)
                {
                    messaggio = "Bradicardia";
                }

                if (battito > 60 && battito < 100)
                {
                    messaggio = "Normale";
                }

                if (battito > 100)
                {
                    messaggio = "Tachicardia";
                }
            }
            else
            {
                messaggio="errore! hai inserito male i dati";
            }
            
            return messaggio; // Restituisco il valore
        }

        /*Calcolo Uomo (ES 3)*/
        public static double calcolo_uomo(double eta, double peso, double frequenza, double durata)
        {
            double calorie_uomoni = (eta * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - (55.0969 * durata / 4.184); // Calcolo i valori

            return calorie_uomoni;
        }

        /*Calcolo Donna (ES 3)*/
        public static double calcolo_donna(double eta, double peso, double frequenza, double durata)
        {
            double calorie_donne = (eta * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - (20.4022 * durata / 4.184); // Calcolo i valori

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

