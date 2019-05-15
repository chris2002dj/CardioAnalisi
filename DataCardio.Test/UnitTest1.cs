using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        // ES 1
        [TestMethod]
        [DataRow(20,60)]
        public void TestMethod_01(int eta, int battito_minuto)
        {
            int cardiaco_max = CardioanalisiLibrary.DataCardio.cardiaco_max(eta, battito_minuto); //Chiamo il metodo per controllare la frequenza cardiaca massima

            int controllo_cardiaco_min = CardioanalisiLibrary.DataCardio.controllo_battito_min(cardiaco_max); //Chiamo il metodo per controllare il battito min

            int controllo_cardiaco_max = CardioanalisiLibrary.DataCardio.controllo_battito_min(cardiaco_max); //Chiamo il metodo per controllare il battito max
        }

        // ES 2
        [DataTestMethod]
        [DataRow(50, "Bradicardia")]
        [DataRow(80, "Normale")]
        [DataRow(120, "Tachicardia")]
        public void TestMethod_02(int battito, string tipo_battito)
        {
            string controllo = CardioanalisiLibrary.DataCardio.controllo_frequenza(battito); // Chiamo il metodo

            Assert.AreEqual(controllo, tipo_battito); // Confronto i due valori
        }

        // ES 3 
        [DataTestMethod]
        [DataRow(50, 80, 20, 20)]
        public void TestMethod_03(double eta, double peso, double frequenza, double durata)
        {
            double calcolo = CardioanalisiLibrary.DataCardio.calcolo_uomo(eta, peso, frequenza, durata); // Chiamo il metodo per calcolare
            
        }

        // ES 3
        [DataTestMethod]
        [DataRow(50, 80, 20, 10)]
        public void TestMethod_04(double eta, double peso, double frequenza, double durata)
        {
            double calcolo = CardioanalisiLibrary.DataCardio.calcolo_donna(eta, peso, frequenza, durata); // Chiamo il metodo per calcolare
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

        // ES 5.B
        [DataTestMethod]
        [DataRow(15,210)]
        [DataRow(0,0)]
        public void TestMethod_08(double battito, double risultato, double messaggio)
        {
            double risultato_finale = CardioanalisiLibrary.DataCardio.riposo(battito);

            Assert.AreEqual(risultato_finale, risultato);
        }

        // ES 6
        [DataTestMethod]
        [DataRow(61, 25, "Sottopeso")]
        [DataRow(32, 70, "Normopeso")]
        [DataRow(52, 33, "Normopeso")]
        public void TestMethod_ControlloPeso(double eta, double peso, string risultato)
        {
            string risultato_finale = CardioanalisiLibrary.DataCardio.controllo_peso(eta, peso);

            Assert.AreEqual(risultato_finale, risultato);
        }


    }
}
