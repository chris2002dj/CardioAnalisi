using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        // ES 1
        [TestMethod]
        public void TestMethod_01()
        {
            int x = 20; //Età dell'utente

            int y = 60; //Battito cardiaco al minuto

            int cardiaco_max = CardioanalisiLibrary.DataCardio.cardiaco_max(x, y); //Chiamo il metodo per controllare la frequenza cardiaca massima

            int controllo_cardiaco_min = CardioanalisiLibrary.DataCardio.controllo_battito_min(cardiaco_max); //Chiamo il metodo per controllare il battito min

            int controllo_cardiaco_max = CardioanalisiLibrary.DataCardio.controllo_battito_min(cardiaco_max); //Chiamo il metodo per controllare il battito max
        }

        // ES 2
        [DataTestMethod]
        [DataRow(50, "Bradicardia")]
        [DataRow(80, "Normale")]
        [DataRow(120, "Tachicardia")]
        public void TestMethod_02(int variabile_01, string variabile_02)
        {
            string controllo = CardioanalisiLibrary.DataCardio.controllo_frequenza(variabile_01); // Chiamo il metodo

            Assert.AreEqual(controllo, variabile_02); // Confronto i due valori
        }

        // ES 3
        [DataTestMethod]
        [DataRow(50, 80, 20, 20)]
        public void TestMethod_03(double a, double p, double f, double t)
        {
            double calcolo = CardioanalisiLibrary.DataCardio.calcolo_uomo(a, p, f, t); // Chiamo il metodo per calcolare
        }

        // ES 3
        [DataTestMethod]
        [DataRow(50, 80, 20, 10)]
        public void TestMethod_04(double a, double p, double f, double t)
        {
            double calcolo = CardioanalisiLibrary.DataCardio.calcolo_donna(a, p, f, t); // Chiamo il metodo per calcolare
        }

        // ES 4
        [DataTestMethod]
        [DataRow(10, 80)]
        public void TestMethod_05(double km, double peso)
        {
            double corsa = CardioanalisiLibrary.DataCardio.corsa(km, peso);
        }

        // ES 4
        [DataTestMethod]
        [DataRow(10, 50)]
        public void TestMethod_06(double km, double peso)
        {
            double camminata = CardioanalisiLibrary.DataCardio.camminata(km, peso);
        }

       

    }
}
