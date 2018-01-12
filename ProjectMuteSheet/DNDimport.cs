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

        private List<XElement> classproficiency;
        private List<XElement> classname;
        private List<XElement> backgroundproficiency;
        private List<XElement> backgroundname;
        private List<XElement> racename;
        private List<XElement> raceability;

        public List<XElement> Classproficiency
        {
            get { return classproficiency; }
            set { classproficiency = value; }
        }

        public List<XElement> Classname
        {
            get { return classname; }
            set { classname = value; }
        }


        public List<XElement> Backgroundname
        {
            get { return backgroundname; }
            set { backgroundname = value; }
        }

        public List<XElement> Backgroundproficiency
        {
            get { return backgroundproficiency; }
            set { backgroundproficiency = value; }
        }

        public List<XElement> Racename
        {
            get { return racename; }
            set { racename = value; }
        }

        public List<XElement> Raceability
        {
            get { return raceability; }
            set { raceability = value; }
        }

        /// <summary>
        /// Fuction to Import the XML Data.
        /// </summary>
        /// <returns>
        /// data which is a instance of <see cref="DNDdata" />
        /// that is accessible so we can use the XML Data elsewhere
        /// </returns>
        public void XMLimport()
        {
            ///Creates a string that points to the user Appdata Folder
            string fileName = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData), "Character Compendium Edited.xml");

            ///checks if Character Compendium Edited.xml exist in Appdata
            if (!System.IO.File.Exists(fileName))
            {

                ///Opens a File Dialog asking the user to open a certain file
                System.Windows.Forms.OpenFileDialog openXML = new System.Windows.Forms.OpenFileDialog
                {
                    Filter = "XML Files|*.xml",
                    Title = "Navigate to Character Compendium Edited.xml"

                };

                ///If the user selects a file and hits open it run this code
                if (openXML.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ///This will copy the XML file to the Appdata folder
                    File.Copy(openXML.FileName.ToString(), fileName);
                }

            } 
            
            ///checks if the AppData Folder has the XML File 
            if (System.IO.File.Exists(fileName))
                {
                ///This will create a instance of XDocument Named Doc 
                ///Then get the files path and pass it to the load function of XDcoument 
                //XDocument doc = XDocument.Load(openXML.FileName.ToString());
                XDocument doc = XDocument.Load(fileName);

                ///XElement gets a single element 
                ///we then set this element to Documents Root
                ///which is in this case the first element in the document
                XElement compendium = doc.Root;

                ///DND CLASS IMPORT

                ///We create a list of XElements called proficiency to do this we search for elements called class then proficiency
                ///this is searched and then automaticlly made into a list without needing to loop trough each one indvidually
                ///this is then done for each pair we require

                classproficiency = compendium.Elements("class").Select(x => x.Element("proficiency")).ToList();
                classname = compendium.Elements("class").Select(x => x.Element("name")).ToList();

                ///DND BACKGROUND IMPORT

                backgroundproficiency = compendium.Elements("background").Select(x => x.Element("proficiency")).ToList();
                backgroundname = compendium.Elements("background").Select(x => x.Element("name")).ToList();

                //DND RACE IMPORT
                racename = compendium.Elements("race").Select(x => x.Element("name")).ToList();
                raceability = compendium.Elements("race").Select(x => x.Element("ability")).ToList();

                

            }

        }

        }

    }
