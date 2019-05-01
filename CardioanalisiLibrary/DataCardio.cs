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
    }
}
