using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectMuteSheet
{
    /// <summary>
    /// Class to import XML Data,
    /// <a href="https://github.com/ceryliae/DnDAppFiles/blob/master/Compendiums/Character%20Compendium.xml">Data source Github DnDAppFiles</a>
    /// </summary>
    public class DNDimport
    {

        /// <summary>
        /// List of <see cref="XElement"/>s named classproficiency
        /// </summary>
        private List<XElement> classproficiency;

        /// <summary>
        /// List of <see cref="XElement"/>s named classname
        /// </summary>
        private List<XElement> classname;

        /// <summary>
        /// List of <see cref="XElement"/>s named backgroundproficiency
        /// </summary>
        private List<XElement> backgroundproficiency;

        /// <summary>
        /// List of <see cref="XElement"/>s named backgroundname
        /// </summary>
        private List<XElement> backgroundname;

        /// <summary>
        /// List of <see cref="XElement"/>s named racename
        /// </summary>
        private List<XElement> racename;

        /// <summary>
        /// List of <see cref="XElement"/>s named raceability
        /// </summary>
        private List<XElement> raceability;

        /// <summary>
        /// Gets or sets the classproficiency.
        /// </summary>
        /// <value>
        /// Public property of <see cref="DNDimport.classproficiency"/>.
        /// </value>
        public List<XElement> Classproficiency
        {
            get { return classproficiency; }
            set { classproficiency = value; }
        }

        /// <summary>
        /// Gets or sets the classname.
        /// </summary>
        /// <value>
        /// Public property of <see cref="DNDimport.classname"/>.
        /// </value>
        public List<XElement> Classname
        {
            get { return classname; }
            set { classname = value; }
        }


        /// <summary>
        /// Gets or sets the backgroundname.
        /// </summary>
        /// <value>
        /// Public property of <see cref="DNDimport.backgroundname"/>.
        /// </value>
        public List<XElement> Backgroundname
        {
            get { return backgroundname; }
            set { backgroundname = value; }
        }

        /// <summary>
        /// Gets or sets the backgroundproficiency.
        /// </summary>
        /// <value>
        /// Public property of <see cref="DNDimport.backgroundproficiency"/>.
        /// </value>
        public List<XElement> Backgroundproficiency
        {
            get { return backgroundproficiency; }
            set { backgroundproficiency = value; }
        }

        /// <summary>
        /// Gets or sets the racename.
        /// </summary>
        /// <value>
        /// Public property of <see cref="DNDimport.racename"/>.
        /// </value>
        public List<XElement> Racename
        {
            get { return racename; }
            set { racename = value; }
        }

        /// <summary>
        /// Gets or sets the raceability.
        /// </summary>
        /// <value>
        /// Public property of <see cref="DNDimport.raceability"/>.
        /// </value>
        public List<XElement> Raceability
        {
            get { return raceability; }
            set { raceability = value; }
        }

        /// <summary>
        /// Function to Import the XML Data.
        /// </summary>
        public void XMLimport()
        {
            ///<summary>
            ///Creates a string that points to the user Appdata Folder
            ///</summary>
            string fileName = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData), "Character Compendium Edited.xml");

            ///<summary>
            ///checks if Character Compendium Edited.xml exist in Appdata
            ///</summary>
            if (!System.IO.File.Exists(fileName))
            {
                ///<summary>
                ///Opens a File Dialog asking the user to open a certain file
                ///</summary>
                System.Windows.Forms.OpenFileDialog openXML = new System.Windows.Forms.OpenFileDialog
                {
                    Filter = "XML Files|*.xml",
                    Title = "Navigate to Character Compendium Edited.xml"

                };

                ///<summary>
                ///If the user selects a file and hits open it run this code
                ///</summary>
                if (openXML.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ///<summary>
                    ///This will copy the XML file to the Appdata folder
                    ///</summary>
                    File.Copy(openXML.FileName.ToString(), fileName);
                }

            }
            ///<summary>
            ///checks if the AppData Folder has the XML File 
            ///</summary>
            if (System.IO.File.Exists(fileName))
                {
                ///<summary>
                ///This will create a instance of XDocument Named Doc 
                ///Then get the files path and pass it to the load function of XDcoument 
                ///XDocument doc = XDocument.Load(openXML.FileName.ToString());
                ///</summary>
                XDocument doc = XDocument.Load(fileName);

                ///<summary>
                ///XElement gets a single element 
                ///we then set this element to Documents Root
                ///which is in this case the first element in the document
                ///</summary>
                XElement compendium = doc.Root;

                ///DND CLASS IMPORT
                ///
                ///<summary>
                ///We create a list of XElements called proficiency to do this we search for elements called class then proficiency
                ///this is searched and then automatically made into a list without needing to loop trough each one individually
                ///this is then done for each pair we require
                ///</summary>
                classproficiency = compendium.Elements("class").Select(x => x.Element("proficiency")).ToList();
                classname = compendium.Elements("class").Select(x => x.Element("name")).ToList();

                ///DND BACKGROUND IMPORT

                backgroundproficiency = compendium.Elements("background").Select(x => x.Element("proficiency")).ToList();
                backgroundname = compendium.Elements("background").Select(x => x.Element("name")).ToList();

                ///DND RACE IMPORT
                racename = compendium.Elements("race").Select(x => x.Element("name")).ToList();
                raceability = compendium.Elements("race").Select(x => x.Element("ability")).ToList();

                

            }

        }

        }

    }
