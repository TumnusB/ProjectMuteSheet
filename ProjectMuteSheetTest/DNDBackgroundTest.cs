using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectMuteSheet;

namespace ProjectMuteSheetTest
{
    [TestClass]
    public class DNDBackgroundTest
    {


        /// <summary>
        /// Check that <see cref="DNDbackground"/> Constructor is not Null.
        /// </summary>
        [TestMethod]
        public void DNDBackgroundTest_Constructor_NotNull()
        {
            ///Arrange
            string name = "Acolyte";
            string prof = "Insight, Religion";
            ///Act
            DNDbackground testclass = new DNDbackground(name, prof);
            ///Assert
            Assert.IsNotNull(testclass, "Object not initialized");
        }

        /// <summary>
        /// Check that <see cref="DNDbackground"/>  Empty Constructor is not Null.
        /// </summary>
        [TestMethod]
        public void DNDBackgroundTest_EmptyConstuctor_NotNull()
        {
            ///Arrange & Act
            DNDbackground emptycon = new DNDbackground();
            ///Assert
            Assert.IsNotNull(emptycon, "Object not initialized");
        }
        /// <summary>
        /// Check that <see cref="DNDbackground.Name"/> is working.
        /// </summary>
        [TestMethod]
        public void DNDBackgroundTest_Name()
        {
            ///Arrange
            DNDbackground testclass = new DNDbackground();
            ///Act
            testclass.Name = "Acolyte";
            ///Assert
            Assert.AreEqual(testclass.Name, "Acolyte", "Property Assigning Incorrect Value");
        }

        /// <summary>
        /// Check that <see cref="DNDbackground.Proficency"/> is working.
        /// </summary>
        [TestMethod]
        public void DNDBackgroundTest_Proficency()
        {
            ///Arrange
            DNDbackground testclass = new DNDbackground();
            ///Act
            testclass.Proficency = "Insight, Religion";
            ///Assert
            Assert.AreEqual(testclass.Proficency, "Insight, Religion", "Property Assigning Incorrect Value");
        }
        /// <summary>
        /// Check that <see cref="DNDbackground.Proficiencies"/> is working.
        /// </summary>
        [TestMethod]
        public void DNDBackgroundTest_Proficiencies()
        {
            ///Arrange
            DNDbackground testclass = new DNDbackground();
            ///Act
            testclass.Proficiencies.Add("Insight, Religion");
            ///Assert
            Assert.AreEqual(testclass.Proficiencies[0].ToString(), "Insight, Religion", "Property Assigning Incorrect Value");
        }

    }
}
