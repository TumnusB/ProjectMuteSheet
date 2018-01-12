using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectMuteSheet;

namespace ProjectMuteSheetTest
{
    [TestClass]
    public class DNDimportTest
    {
        /// <summary>
        /// Check that <see cref="DNDimport.Backgroundname"/> is the expected size, 
        /// this is based on the supplied XML
        /// </summary>
        [TestMethod]
        public void DNDimport_Backgroundname_SizeCheck()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            ///Act
            import.XMLimport();
            ///Assert
            Assert.AreEqual(import.Backgroundname.Count, 43, "Amount of XML entries does not correspond to expected value");
                
        }
        /// <summary>
        /// Check that <see cref="DNDimport.Backgroundproficiency"/> is the expected size, 
        /// this is based on the supplied XML
        /// </summary>
        [TestMethod]
        public void DNDimport_Backgroundproficiency_SizeCheck()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            ///Act
            import.XMLimport();
            ///Assert
            Assert.AreEqual(import.Backgroundproficiency.Count, 43, "Amount of XML entries does not correspond to expected value");

        }
        /// <summary>
        /// Check that <see cref="DNDimport.Classname"/> is the expected size, 
        /// this is based on the supplied XML
        /// </summary>
        [TestMethod]
        public void DNDimport_Classname_SizeCheck()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            ///Act
            import.XMLimport();
            ///Assert
            Assert.AreEqual(import.Classname.Count, 15, "Amount of XML entries does not correspond to expected value");

        }
        /// <summary>
        /// Check that <see cref="DNDimport.Classproficiency"/> is the expected size, 
        /// this is based on the supplied XML
        /// </summary>
        [TestMethod]
        public void DNDimport_Classproficiency_SizeCheck()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            ///Act
            import.XMLimport();
            ///Assert
            Assert.AreEqual(import.Classproficiency.Count, 15, "Amount of XML entries does not correspond to expected value");

        }
        /// <summary>
        /// Check that <see cref="DNDimport.Racename"/> is the expected size, 
        /// this is based on the supplied XML
        /// </summary>
        [TestMethod]
        public void DNDimport_Racename_SizeCheck()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            ///Act
            import.XMLimport();
            ///Assert
            Assert.AreEqual(import.Racename.Count, 44, "Amount of XML entries does not correspond to expected value");

        }
        /// <summary>
        /// Check that <see cref="DNDimport.Raceability"/> is the expected size, 
        /// this is based on the supplied XML
        /// </summary>
        [TestMethod]
        public void DNDimport_Raceability_SizeCheck()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            ///Act
            import.XMLimport();
            ///Assert
            Assert.AreEqual(import.Raceability.Count, 44, "Amount of XML entries does not correspond to expected value");

        }
    }
}
