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
        public static int cardiaco_max(int eta, int battito_minuto)
        {
            int max = 0;

            if (eta > 0 && battito_minuto > 0)
            {
                max = 220 - eta; //Trovo la frequenza cardiaca massima dell'utente
            }

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
            double calcolo;

            if (riposo > 0) // Controllo se è maggiore di 0
            {
                calcolo = riposo * 14;
            }
            else
            {
                calcolo = 0;
            }


            return calcolo;
        }

        // Controllo peso (ES 6)
        public static string controllo_peso(double eta, double peso)
        {
            string messaggio = "";
            
            if (eta > 0 && peso > 0) // Controllo se i dati sono maggiori di 0
            {
                if (eta >= 18 || eta <= 30) // Controllo l'eta
                {
                    //Controllo il peso
                    if (peso <= 26)
                    {

                        messaggio = "Sottopeso";
                    }

                    if (peso >= 27 || peso <= 55)
                    {

                        messaggio = "Normopeso";
                    }

                    if (peso >= 56 || peso <= 70)
                    {

                        messaggio = "Sovrapeso";
                    }
                }

                if (eta >= 31 || eta <= 40)
                {
                    if (peso <= 28)
                    {

                        messaggio = "Sottopeso";
                    }

                    else if (peso >= 29 || peso <= 65)
                    {

                        messaggio = "Normopeso";
                    }

                    else if (peso >= 66 || peso <= 80)
                    {

                        messaggio = "Sovrapeso";
                    }

                }

                if (eta >= 41 || eta <= 50)
                {
                    if (peso <= 30)
                    {

                        messaggio = "Sottopeso";
                    }

                    if (peso >= 31 || peso <= 75)
                    {

                        messaggio = "Normopeso";
                    }

                    if (peso >= 76 || peso <= 90)
                    {

                        messaggio = "Sovrapeso";
                    }

                }

                if (eta >= 51 || eta <= 60)
                {
                    if (peso <= 32)
                    {
                        messaggio = "Sottopeso";
                    }

                    if (peso >= 33 || peso <= 85)
                    {
                        messaggio = "Normopeso";
                    }

                    if (peso >= 86 || peso <= 100)
                    {
                        messaggio = "Sovrapeso";
                    }

                }

                if (eta >= 61)
                {
                    if (peso <= 34)
                    {

                        messaggio = "Sottopeso";
                    }

                    if (peso >= 35 || peso <= 95)
                    {

                        messaggio = "Normopeso";
                    }

                    if (peso >= 96 || peso <= 110)
                    {

                        messaggio = "Sovrapeso";
                    }

                }

            }
            else
            {
                messaggio = "errore inserimento dati";
            }

            return messaggio;
        }
    }
}

