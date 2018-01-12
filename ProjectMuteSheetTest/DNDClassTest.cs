using System;
using ProjectMuteSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectMuteSheetTest
{
    [TestClass]
    public class DNDClassTest
    {
        //Test Constructors, Properties, Methods 

        [TestMethod]
        public void DNDclassTest_Constuctor_NotNull()
        {
            //Arrange
            string name = "testname";
            string prof = "testprof";
            //Act
            DNDclass testclass = new DNDclass(name, prof);
            //Assert
            Assert.IsNotNull(testclass, "Object not initialized");
        }

        [TestMethod]
        public void DNDclassTest_EmptyConstuctor_NotNull()
        {
            //Arrange & Act
            DNDclass emptycon = new DNDclass();
            //Assert
            Assert.IsNotNull(emptycon, "Object not initialized");
        }

        [TestMethod]
        public void DNDclassTest_Name()
        {
            //Arrange
            DNDclass testclass = new DNDclass();
            //Act
            testclass.Name = "Barbarian";
            //Assert
            Assert.AreEqual(testclass.Name, "Barbarian", "Propety Assigning Incorrect Value");
        }

        [TestMethod]
        public void DNDclassTest_Proficency()
        {
            //Arrange
            DNDclass testclass = new DNDclass();
            //Act
            testclass.Proficency = "Intelligence, Constitution";
            //Assert
            Assert.AreEqual(testclass.Proficency, "Intelligence, Constitution", "Propety Assigning Incorrect Value");
        }

        [TestMethod]
        public void DNDclassTest_Proficiencies()
        {
            //Arrange
            DNDclass testclass = new DNDclass();
            //Act
            testclass.Proficiencies.Add("Intelligence, Constitution");
            //Assert
            Assert.AreEqual(testclass.Proficiencies[0].ToString(), "Intelligence, Constitution", "Propety Assigning Incorrect Value");
        }


    }
}
