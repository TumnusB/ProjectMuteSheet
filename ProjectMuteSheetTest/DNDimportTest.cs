using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectMuteSheet;

namespace ProjectMuteSheetTest
{
    [TestClass]
    public class DNDimportTest
    {
        [TestMethod]
        public void DNDimport_Backgroundname_SizeCheck()
        {
            //Arrange
            DNDimport import = new DNDimport();
            //Act
            import.XMLimport();
            //Assert
            Assert.AreEqual(import.Backgroundname.Count, 43, "Amount of XML enteries does not correspond to expected value");
                
        }

        [TestMethod]
        public void DNDimport_Backgroundproficiency_SizeCheck()
        {
            //Arrange
            DNDimport import = new DNDimport();
            //Act
            import.XMLimport();
            //Assert
            Assert.AreEqual(import.Backgroundproficiency.Count, 43, "Amount of XML enteries does not correspond to expected value");

        }

        [TestMethod]
        public void DNDimport_Classname_SizeCheck()
        {
            //Arrange
            DNDimport import = new DNDimport();
            //Act
            import.XMLimport();
            //Assert
            Assert.AreEqual(import.Classname.Count, 15, "Amount of XML enteries does not correspond to expected value");

        }

        [TestMethod]
        public void DNDimport_Classproficiency_SizeCheck()
        {
            //Arrange
            DNDimport import = new DNDimport();
            //Act
            import.XMLimport();
            //Assert
            Assert.AreEqual(import.Classproficiency.Count, 15, "Amount of XML enteries does not correspond to expected value");

        }

        [TestMethod]
        public void DNDimport_Racename_SizeCheck()
        {
            //Arrange
            DNDimport import = new DNDimport();
            //Act
            import.XMLimport();
            //Assert
            Assert.AreEqual(import.Racename.Count, 44, "Amount of XML enteries does not correspond to expected value");

        }

        [TestMethod]
        public void DNDimport_Raceability_SizeCheck()
        {
            //Arrange
            DNDimport import = new DNDimport();
            //Act
            import.XMLimport();
            //Assert
            Assert.AreEqual(import.Raceability.Count, 44, "Amount of XML enteries does not correspond to expected value");

        }
    }
}
