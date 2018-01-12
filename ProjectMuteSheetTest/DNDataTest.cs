using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectMuteSheet;

namespace ProjectMuteSheetTest
{
    [TestClass]
    public class DNDataTest
    {
        /// <summary>
        /// Check to see if <see cref="DNDrace"/> in <see cref="DNDdata"/> is of Expected Type.
        /// </summary>
        [TestMethod]
        public void Validate_DNDdata_Race()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            DNDCreateDataSet dataset = new DNDCreateDataSet();
            DNDdata data = new DNDdata();
            ///Act
            import.XMLimport();
            data = dataset.DataGen();
            ///Assert
            Assert.IsInstanceOfType(data.RaceList[0], typeof(DNDrace) ,"Racelist is not Expected Type");

        }

        /// <summary>
        /// Check to see if <see cref="DNDclass"/> in <see cref="DNDdata"/> is Expected Type.
        /// </summary>
        [TestMethod]
        public void Validate_DNDdata_Class()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            DNDCreateDataSet dataset = new DNDCreateDataSet();
            DNDdata data = new DNDdata();
            ///Act
            import.XMLimport();
            data = dataset.DataGen();
            ///Assert
            Assert.IsInstanceOfType(data.ClassList[0], typeof(DNDclass), "Classlist is not Expected Type");

        }

        /// <summary>
        /// Check to see if <see cref="DNDclass"/> in <see cref="DNDdata"/> is Expected Type.
        /// </summary>
        [TestMethod]
        public void Validate_DNDdata_Background()
        {
            ///Arrange
            DNDimport import = new DNDimport();
            DNDCreateDataSet dataset = new DNDCreateDataSet();
            DNDdata data = new DNDdata();
            ///Act
            import.XMLimport();
            data = dataset.DataGen();
            ///Assert
            Assert.IsInstanceOfType(data.BackgroundList[0], typeof(DNDbackground), "Backgroundlist is not Expected Type");

        }

    }
}
