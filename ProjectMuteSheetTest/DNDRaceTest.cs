using System;
using ProjectMuteSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectMuteSheetTest
{
    [TestClass]
    public class DNDRaceTest
    {

        /// <summary>
        /// Test that <see cref="DNDrace"/> Constructor is not Null
        /// </summary>
        [TestMethod]
        public void DNDraceTest_Constuctor_NotNull()
        {
            ///Arrange
            string name = "Aarakocra";
            string ability = "Dex 2, Wis 1";
            ///Act
            DNDrace testclass = new DNDrace(name, ability);
            ///Assert
            Assert.IsNotNull(testclass, "Object not initialized");
        }
        /// <summary>
        /// Test that <see cref="DNDrace"/> Empty Constructor is not Null
        /// </summary>
        [TestMethod]
        public void DNDraceTest_EmptyConstuctor_NotNull()
        {
            ///Arrange & Act
            DNDrace emptycon = new DNDrace();
            ///Assert
            Assert.IsNotNull(emptycon, "Object not initialized");
        }
        /// <summary>
        /// Test that <see cref="DNDrace.Name"/> is working
        /// </summary>
        [TestMethod]
        public void DNDraceTest_Name()
        {
            ///Arrange
            DNDrace testclass = new DNDrace();
            ///Act
            testclass.Name = "Aarakocra";
            ///Assert
            Assert.AreEqual(testclass.Name, "Aarakocra", "Property Assigning Incorrect Value");
        }
        /// <summary>
        /// Test that <see cref="DNDrace.Proficency"/> is working
        /// </summary>
        [TestMethod]
        public void DNDraceTest_Ability()
        {
            ///Arrange
            DNDrace testclass = new DNDrace();
            ///Act
            testclass.Ability = "Dex 2, Wis 1";
            ///Assert
            Assert.AreEqual(testclass.Ability, "Dex 2, Wis 1", "Property Assigning Incorrect Value");
        }
        /// <summary>
        /// Test that <see cref="DNDrace.Proficiencies"/> is working
        /// </summary>
        [TestMethod]
        public void DNDraceTest_Abilities()
        {
            ///Arrange
            DNDrace testclass = new DNDrace();
            ///Act
            testclass.Abilities.Add("Dex 2, Wis 1");
            ///Assert
            Assert.AreEqual(testclass.Abilities[0].ToString(), "Dex 2, Wis 1", "Property Assigning Incorrect Value");
        }


    }
}
