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
        ///Create Instance of <see cref="DNDdata"/>
        ///to store the XML DataSet in
        DNDdata data = new DNDdata();

        /// <summary>
        /// Fuction to Import the XML Data.
        /// </summary>
        /// <returns>
        /// data which is a instance of <see cref="DNDdata" />
        /// that is accessible so we can use the XML Data elsewhere
        /// </returns>
        public DNDdata XMLimport()
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

                List<XElement> proficiency = compendium.Elements("class").Select(x => x.Element("proficiency")).ToList();
                List<XElement> name = compendium.Elements("class").Select(x => x.Element("name")).ToList();

                ///DND BACKGROUND IMPORT

                List<XElement> bgprof = compendium.Elements("background").Select(x => x.Element("proficiency")).ToList();
                List<XElement> bgname = compendium.Elements("background").Select(x => x.Element("name")).ToList();

                //DND RACE IMPORT
                List<XElement> racename = compendium.Elements("race").Select(x => x.Element("name")).ToList();
                List<XElement> raceability = compendium.Elements("race").Select(x => x.Element("ability")).ToList();

                ///We check that the amount of backgrounds we have
                ///match the amount of proficencies as these should always match
                if (bgname.Count == bgprof.Count)
                {

                    ///We create an instance of <see cref="DNDbackground"/>
                    ///this will be used inside the loop
                    DNDbackground newbackground;
                    ///Due to the fact we know that both the bgname and bgprof are the same
                    ///we can just use the count of one of them for the loop
                    for (int i = 0; i < bgprof.Count; i++)
                    {
                        ///Here for each loop we make 
                        ///newbackground have the values inside the 
                        ///brackets
                        newbackground = new DNDbackground
                        {
                            ///ElementAt(i).Value will get the current
                            ///Value per loop and put it inside the 
                            ///newbackground
                            Name = bgname.ElementAt(i).Value,
                            Proficency = bgprof.ElementAt(i).Value
                        };

                        ///Here we create a temp string to store the current
                        ///proficency string in
                        string temp = bgprof.ElementAt(i).Value;
                        ///We then remove the , of which we know there will be
                        string newtemp = temp.Replace(",", "");
                        ///Finally we split the string on null which defualts to whitespace
                        string[] temparray = newtemp.Split(null);
                        ///We then add the array into the list inside newbackground 
                        newbackground.Proficiencies.AddRange(temparray);

                        ///Once per loop we add the newbackground to Data which
                        ///is where each background will be stored
                        data.Addbackground(newbackground);
                    }

                }

                ///See above comments this if fuctionally the same but we are storing 
                ///<see cref="DNDclass" /> to <see cref="DNDdata" /> rather than <see cref="DNDbackground" />
                if (name.Count == proficiency.Count)
                {
                    for (int i = 0; i < proficiency.Count; i++)
                    {
                        DNDclass newclass;
                        newclass = new DNDclass
                        {
                            Name = name.ElementAt(i).Value,
                            Proficency = proficiency.ElementAt(i).Value
                        };

                        string temp = bgprof.ElementAt(i).Value;

                        string newtemp = temp.Replace(",", "");

                        string[] temparray = newtemp.Split(null);

                        newclass.Proficiencies.AddRange(temparray);

                        data.Addclass(newclass);
                    }
                }

                if (racename.Count == raceability.Count)
                {
                    for (int i = 0; i < racename.Count; i++)
                    {
                        DNDrace newrace;
                        newrace = new DNDrace
                        {
                            Name = racename.ElementAt(i).Value,
                            Ability = raceability.ElementAt(i).Value
                        };

                        string temp = raceability.ElementAt(i).Value;

                        string newtemp = temp.Replace(",", "");

                        string[] temparray = newtemp.Split(null);

                        newrace.Abilities.AddRange(temparray);

                        data.Addrace(newrace);
                    }
                }

            }

            ///Once the loops have finished we pass all this
            ///data back out to where the fuction was called
            return data;

        }

    }
}
