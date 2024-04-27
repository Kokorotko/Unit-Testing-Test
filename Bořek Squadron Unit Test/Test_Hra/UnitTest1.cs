using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadani___hra;

namespace Test_Hra
{

    [TestClass]
    public class UnitTest1
    {
        private Herni_Postava postava;
        private Hráč hrac;
        private NPC npc;

        //1
        [TestMethod]
        public void Test_DelkaJmena()
        {
            //Arrange
            postava = new Herni_Postava("Borek");
            //Assert
            Assert.IsTrue(postava.Jmeno.Length > 0);
        }

        //2
        [TestMethod]
        public void Test_Levelu()
        {
            //Arrange
            postava = new Herni_Postava("Borek");

            //Act
            postava.level = 1;

            //Assert
            Assert.IsTrue(postava.level == 1);
        }

        //3
        [TestMethod]
        public void Test_PoziceX()
        {
            //Arrange
            postava = new Herni_Postava("Borek");

            //Act
            postava.PoziceX = 0;

            //Assert
            Assert.IsTrue(postava.PoziceX == 0);
        }

        //4
        [TestMethod]
        public void Test_PoziceY()
        {
            //Arrange
            postava = new Herni_Postava("Borek");

            //Act
            postava.PoziceY = 0;

            //Assert
            Assert.IsTrue(postava.PoziceY == 0);
        }

        //5
        [TestMethod]
        public void Test_ZmenaPoziceX()
        {
            //Arrange
            postava = new Herni_Postava("Borek");

            //Act
            postava.PoziceX = 5;

            //Assert
            Assert.IsTrue(postava.PoziceX != 0);
        }

        //6
        [TestMethod]
        public void Test_ZmenaPoziceY()
        {
            //Arrange
            postava = new Herni_Postava("Borek");

            //Act
            postava.PoziceY = 2;

            //Assert
            Assert.IsTrue(postava.PoziceY != 0);
        }

        //7
        [TestMethod]
        public void Test_Specializace()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);
            //Assert
            Assert.IsTrue(hrac.Specializace == "Berserker" || hrac.Specializace == "Kouzelnik" || hrac.Specializace == "Inzenyr" || hrac.Specializace == "Cizak");
        }

        //8
        [TestMethod]
        public void Test_Oblicej()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);
            //Assert
            Assert.IsTrue(hrac.obličej == Hráč.Obličej.MakeUp); //bolest, pain, suffering, miluju enums :)))))
        }

        //9
        [TestMethod]
        public void Test_Vlasu()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);

            //Assert
            Assert.IsTrue(hrac.vlasy == Hráč.Vlasy.Drdol);
        }

        //10
        [TestMethod]
        public void Test_BarvaVlasu()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);

            //Assert
            Assert.IsTrue(hrac.barvaVlasu == Hráč.BarvaVlasu.Blond);
        }

        //11
        [TestMethod]
        public void Test_XP()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);

            //Act
            hrac.xp = 0;

            //Assert
            Assert.IsTrue(hrac.xp >= 0);
        }

        //12
        [TestMethod]
        public void Test_PridaniXP()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);

            //Act
            hrac.PridejXP(120);

            //Assert
            Assert.IsTrue(hrac.xp == 120);
        }

        //13
        [TestMethod]
        public void Test_Levelovani()
        {
            //Arrange
            hrac = new Hráč("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond);

            //Act
            hrac.xp = 100;
            hrac.PridejXP(400);
            

            //Assert
            Assert.IsTrue(hrac.level == 6); //kde ten cyp vzal lv 6
        }

        //14
        [TestMethod]
        public void Test_Prace()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel);
            //Assert.IsTrue(hrac.barvaVlasu >= 0 && hrac.barvaVlasu <= 2); OG Kod - Tady nekdo varil
            Assert.IsTrue(npc.prace == NPC.Práce.obyvatel);
        }

        //15
        [TestMethod]
        public void Test_SilaNPC()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel, 20, false);

            //Assert
            Assert.IsTrue(npc.sila >= 0 && npc.sila <= 100);
        }

        //16
        [TestMethod]
        public void Test_ZmenaPoziceXNPC()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel, 20, false);

            //Act
            npc.PoziceNPCX(5);

            //Assert
            Assert.IsTrue(npc.PoziceX != 0);
        }

        //17
        [TestMethod]
        public void Test_ZmenaPoziceYNPC()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel, 20, false);

            //Act
            npc.PoziceNPCY(2);

            //Assert
            Assert.IsTrue(npc.PoziceY != 0);
        }

        //18
        [TestMethod]
        public void Test_NepovolenaPoziceXNPC()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel, 20, false);

            //Act
            npc.PoziceNPCX(20);

            //Assert
            Assert.IsTrue(npc.PoziceX <= 500);
        }

        //19
        [TestMethod]
        public void Test_NepovolenaPoziceYNPC()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel, 20, false);

            //Act
            npc.PoziceNPCY(3000);

            //Assert
            Assert.IsTrue(npc.PoziceX <= 500);
        }

        //20
        [TestMethod]
        public void Test_NepovolenyXP()
        {
            //Arrange
            npc = new NPC("Borek", "Berserker", Hráč.Obličej.MakeUp, Hráč.Vlasy.Drdol, Hráč.BarvaVlasu.Blond, NPC.Práce.obyvatel, 20, false);

            //Act
            npc.xp = 20000;

            //Assert
            Assert.IsTrue(npc.xp <= 30000);
        }


    }
}
