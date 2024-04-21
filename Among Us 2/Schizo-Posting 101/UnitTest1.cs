using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Among_Us_2;
using System.Runtime.InteropServices;

namespace Schizo_Posting_101
{
    [TestClass]
    public class GameCharacter
    {
        [TestMethod]
        public void LongNameTrue() //name is saved
        {
            GameCharacter gameCharacter = new GameCharacter();
            gameCharacter.Name = "Sebastian";
            Assert.IsTrue(gameCharacter.Name.Length <= 10);
        }

        [TestMethod]
        public void LongNameFalse() //name is not saved
        {
            GameCharacter gameCharacter = new GameCharacter();
            gameCharacter.Name = "ThisNameIsComicallyLong";
            Assert.IsNull(gameCharacter.Name);
        }

        [TestMethod]
        public void BaseLevel() //level is 1 on initialization
        {
            GameCharacter gameCharacter = new GameCharacter();
            Assert.AreEqual(1, gameCharacter.Level);
        }

        [TestMethod]
        public void BasePositionX() //Position is 0 on inicialization
        {
            GameCharacter gameCharacter = new Among_Us_2.GameCharacter();
            Assert.IsTrue(gameCharacter.PositionX == 0);
        }

        [TestMethod]
        public void BasePositionY() //Position is 0 on inicialization
        {
            GameCharacter gameCharacter = new Among_Us_2.GameCharacter();
            Assert.IsTrue(gameCharacter.PositionY == 0);
        }

        [TestMethod]
        public void NameInicialization() //Name is set with Inicialization
        {
            GameCharacter gameCharacter = new GameCharacter("Bob");
            Assert.IsTrue(gameCharacter.Name == "Bob");
        }

        [TestMethod]
        public void ChangePosition() //Position is changed with ChangePosition()
        {
            GameCharacter gameCharacter = new GameCharacter();
            float x = gameCharacter.PositionX, y = gameCharacter.PositionY;
            gameCharacter.ChangePosition();
            Assert.IsTrue(gameCharacter.PositionX != x && gameCharacter.PositionY != y);
        }

        [TestMethod]
        public void GameCharacterToString() //Gives back text with ToString Override
        {
            GameCharacter gameCharacter = new GameCharacter("Bob Ross");
            Assert.IsTrue(gameCharacter.ToString() == "Name: Bob Ross\nLevel: 1\nPositionX: 0\nPositionY: 0");
        }
    }

    [TestClass]
    public class Gamer
    {
        [TestMethod]
        public void Specialization_Mage()
        {
            Gamer gamer = new Gamer();
            gamer.Specialization = "Mage";
            Assert.AreEqual("Mage", gamer.Specialization);
        }

        [TestMethod]
        public void Specialization_Berserker()
        {
            Gamer gamer = new Gamer();
            gamer.Specialization = "Berserker";
            Assert.AreEqual("Berserker", gamer.Specialization);
        }

        [TestMethod]
        public void Specialization_Engineer()
        {
            Gamer gamer = new Gamer();
            gamer.Specialization = "Engineer";
            Assert.AreEqual("Engineer", gamer.Specialization);
        }

        [TestMethod]
        public void Specialization_Stranger()
        {
            Gamer gamer = new Gamer();
            gamer.Specialization = "Stranger";
            Assert.AreEqual("Stranger", gamer.Specialization);
        }

        [TestMethod]
        public void Specialization_WrongInput()
        {
            Gamer gamer = new Gamer();
            gamer.Specialization = "Yippe";
            Assert.AreEqual("", gamer.Specialization);
        }

        [TestMethod]
        public void Face_Standard() 
        {
            Gamer gamer = new Gamer();
            Assert.IsTrue(gamer.Face == Face.BigNose);
        }

        [TestMethod]
        public void Face_BigNose()
        {
            Gamer gamer = new Gamer();
            gamer.Face = Face.MakeUp;
            Assert.IsTrue(gamer.Face == Face.BigNose);
        }

        [TestMethod]
        public void Face_BigEars() //Něco mi říká že to dělám blbě, taky tf is enum
        {
            Gamer gamer = new Gamer();
            gamer.Face = Face.BigEars;
            Assert.IsTrue(gamer.Face == Face.BigEars);
        }

        [TestMethod]
        public void Face_MakeUp()
        {
            Gamer gamer = new Gamer();
            gamer.Face = Face.MakeUp;
            Assert.IsTrue(gamer.Face == Face.MakeUp);
        }

        /*[TestMethod]
        public void Face_None()
        {
            Gamer gamer = new Gamer();
            gamer.Face.BigNose = false;
            gamer.Face.BigEars = false;
            gamer.Face.MakeUp = false;
            Assert.IsTrue(gamer.Face.BigNose == false && gamer.Face.BigEars == false && gamer.Face.MakeUp == false);
        }                                               I may have Stupid*/
        //
        [TestMethod]
        public void Hair_Standart()
        {
            Gamer gamer = new Gamer();
            Assert.IsTrue(gamer.Hair == Hair.Bun);
        }

        [TestMethod]
        public void Hair_Bun()
        {
            Gamer gamer = new Gamer();
            gamer.Hair = Hair.Bun;
            Assert.IsTrue(gamer.Hair == Hair.Bun);
        }

        [TestMethod]
        public void Hair_Ponytail() //Něco mi říká že to dělám blbě, taky tf is enum
        {
            Gamer gamer = new Gamer();
            gamer.Hair = Hair.Ponytail;
            Assert.IsTrue(gamer.Hair == Hair.Ponytail);
        }

        [TestMethod]
        public void Hair_Bald() //Literally Me
        {
            Gamer gamer = new Gamer();
            gamer.Hair = Hair.Bald;
            Assert.IsTrue(gamer.Hair == Hair.Bald);
        }
        //
        [TestMethod]
        public void HairColour_Standart()
        {
            Gamer gamer = new Gamer();
            Assert.IsTrue(gamer.HairColour == HairColour.Brown);
        }

        [TestMethod]
        public void HairColour_Brown()
        {
            Gamer gamer = new Gamer();
            gamer.HairColour = HairColour.Brown;
            Assert.IsTrue(gamer.HairColour == HairColour.Brown);
        }

        [TestMethod]
        public void HairColour_Blond() //Něco mi říká že to dělám blbě, taky tf is enum
        {
            Gamer gamer = new Gamer();
            gamer.HairColour = HairColour.Blond;
            Assert.IsTrue(gamer.HairColour == HairColour.Blond);
        }

        [TestMethod]
        public void HairColour_Red() 
        {
            Gamer gamer = new Gamer();
            gamer.HairColour = HairColour.Red;
            Assert.IsTrue(gamer.HairColour == HairColour.Red);
        }

        [TestMethod]
        public void XP_Inicialization()
        {
            Gamer gamer = new Gamer();
            Assert.IsTrue(gamer.XP == 0);
        }

        public void AddXPTest()
        {
            Gamer gamer = new Gamer();
            gamer.AddXP(350);
            Assert.IsTrue(gamer.Level == 3 && gamer.XP == 50);
        }

        public void GamerToString()
        {                                                    //name, Specialization, Face, Hair, HairColour
            Gamer gamer = new Gamer("Bob Ross","Mage", Face.BigEars, Hair.Bald, HairColour.Red);
            Assert.IsTrue(gamer.ToString() == "Name: Bob Ross\nLevel: 1\nPositionX: 0\nPositionY: 0\nSpecialization: Mage\nFace: BigEars\nHair: Bald\nHairColour: Red\nXP: 0");
        }
    }
    [TestClass]
    public class NPC
    {

    }
}
