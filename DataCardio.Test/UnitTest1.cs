using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_01()
        {
            int x = 20; //Età dell'utente

            int y = 60; //Battito cardiaco al minuto

            int cardiaco_max = CardioanalisiLibrary.DataCardio.cardiaco_max(x, y); //Chiamo il metodo per controllare la frequenza cardiaca massima

            int controllo_cardiaco_min = CardioanalisiLibrary.DataCardio.controllo_battito_min(cardiaco_max); //Chiamo il metodo per controllare il battito min

            int controllo_cardiaco_max = CardioanalisiLibrary.DataCardio.controllo_battito_min(cardiaco_max); //Chiamo il metodo per controllare il battito max
        }
    }
}
