using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadani___hra;

namespace Test_Hra
{

    [TestClass]
    public class UnitTest1
    {
        private Hra hra;

        //1
        [TestMethod]
        public void Test_DelkaJmena()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.NastaveniJmena("Borek");

            //Assert
            Assert.IsTrue(hra.Jmeno.Length > 0);
        }

        //2
        [TestMethod]
        public void Test_Levelu()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.level = 1;

            //Assert
            Assert.IsTrue(hra.level == 1);
        }

        //3
        [TestMethod]
        public void Test_PoziceX()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.PoziceX = 0;

            //Assert
            Assert.IsTrue(hra.PoziceX == 0);
        }

        //4
        [TestMethod]
        public void Test_PoziceY()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.PoziceY = 0;

            //Assert
            Assert.IsTrue(hra.PoziceY == 0);
        }

        //5
        [TestMethod]
        public void Test_ZmenaPoziceX()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.PoziceX = 5;

            //Assert
            Assert.IsTrue(hra.PoziceX != 0);
        }

        //6
        [TestMethod]
        public void Test_ZmenaPoziceY()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.PoziceY = 2;

            //Assert
            Assert.IsTrue(hra.PoziceY != 0);
        }

        //7
        [TestMethod]
        public void Test_Specializace()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.Specializace = "Berserker";

            //Assert
            Assert.IsTrue(hra.Specializace == "Berserker" || hra.Specializace == "Kouzelnik" || hra.Specializace == "Inzenyr" || hra.Specializace == "Cizak");
        }

        //8
        [TestMethod]
        public void Test_Oblicej()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.oblicej = 1;

            //Assert
            Assert.IsTrue(hra.oblicej >= 0 && hra.oblicej <= 2);
        }

        //9
        [TestMethod]
        public void Test_Vlasu()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.vlasy = 2;

            //Assert
            Assert.IsTrue(hra.vlasy >= 0 && hra.vlasy <= 2);
        }

        //10
        [TestMethod]
        public void Test_BarvaVlasu()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.barvaVlasu = 0;

            //Assert
            Assert.IsTrue(hra.barvaVlasu >= 0 && hra.barvaVlasu <= 2);
        }

        //11
        [TestMethod]
        public void Test_XP()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.XP = 0;

            //Assert
            Assert.IsTrue(hra.XP >= 0);
        }

        //12
        [TestMethod]
        public void Test_PridaniXP()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.PridejXP(120);

            //Assert
            Assert.IsTrue(hra.XP == 120);
        }

        //13
        [TestMethod]
        public void Test_Levelovani()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.XP = 100;
            hra.PridejXP(400);
            

            //Assert
            Assert.IsTrue(hra.level == 6);
        }

        //14
        [TestMethod]
        public void Test_Prace()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.prace = 1;

            //Assert
            Assert.IsTrue(hra.barvaVlasu >= 0 && hra.barvaVlasu <= 2);
        }

        //15
        [TestMethod]
        public void Test_SilaNPC()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.sila = 20;

            //Assert
            Assert.IsTrue(hra.sila >= 0 && hra.sila <= 100);
        }

        //16
        [TestMethod]
        public void Test_ZmenaPoziceXNPC()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.poziceNPCX = 5;

            //Assert
            Assert.IsTrue(hra.poziceNPCX != 0);
        }

        //17
        [TestMethod]
        public void Test_ZmenaPoziceYNPC()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.poziceNPCY = 2;

            //Assert
            Assert.IsTrue(hra.poziceNPCY != 0);
        }

        //18
        [TestMethod]
        public void Test_NepovolenaPoziceXNPC()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.poziceNPCX = 20;

            //Assert
            Assert.IsTrue(hra.poziceNPCX <= 500);
        }

        //19
        [TestMethod]
        public void Test_NepovolenaPoziceYNPC()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.poziceNPCY = 3000;

            //Assert
            Assert.IsTrue(hra.poziceNPCX <= 500);
        }

        //20
        [TestMethod]
        public void Test_NepovolenyXP()
        {
            //Arrange
            hra = new Hra();

            //Act
            hra.XP = 20000;

            //Assert
            Assert.IsTrue(hra.XP <= 30000);
        }


    }
}
