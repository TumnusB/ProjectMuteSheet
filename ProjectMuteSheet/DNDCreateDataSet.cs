using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMuteSheet
{
    public class DNDCreateDataSet
    {
        ///Create Instance of <see cref="DNDimport"/>
        ///To gather the XML Data
        DNDimport import = new DNDimport();

        ///Create Instance of <see cref="DNDdata"/>
        ///to store the XML DataSet in
        DNDdata data = new DNDdata();

        public DNDdata DataGen()
        {
            import.XMLimport();
            

            ///We check that the amount of backgrounds we have
            ///match the amount of proficencies as these should always match
            if (import.Backgroundname.Count == import.Backgroundproficiency.Count)
            {

                ///We create an instance of <see cref="DNDbackground"/>
                ///this will be used inside the loop
                DNDbackground newbackground;
                ///Due to the fact we know that both the bgname and bgprof are the same
                ///we can just use the count of one of them for the loop
                for (int i = 0; i < import.Backgroundproficiency.Count; i++)
                {
                    ///Here for each loop we make 
                    ///newbackground have the values inside the 
                    ///brackets
                    newbackground = new DNDbackground
                    {
                        ///ElementAt(i).Value will get the current
                        ///Value per loop and put it inside the 
                        ///newbackground
                        Name = import.Backgroundname.ElementAt(i).Value,
                        Proficency = import.Backgroundproficiency.ElementAt(i).Value
                    };

                    ///Here we create a temp string to store the current
                    ///proficency string in
                    string temp = import.Backgroundproficiency.ElementAt(i).Value;
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
            if (import.Classname.Count == import.Classproficiency.Count)
            {
                for (int i = 0; i < import.Classproficiency.Count; i++)
                {
                    DNDclass newclass;
                    newclass = new DNDclass
                    {
                        Name = import.Classname.ElementAt(i).Value,
                        Proficency = import.Classproficiency.ElementAt(i).Value
                    };

                    string temp = import.Backgroundproficiency.ElementAt(i).Value;

                    string newtemp = temp.Replace(",", "");

                    string[] temparray = newtemp.Split(null);

                    newclass.Proficiencies.AddRange(temparray);

                    data.Addclass(newclass);
                }
            }

            if (import.Racename.Count == import.Raceability.Count)
            {
                for (int i = 0; i < import.Racename.Count; i++)
                {
                    DNDrace newrace;
                    newrace = new DNDrace
                    {
                        Name = import.Racename.ElementAt(i).Value,
                        Ability = import.Raceability.ElementAt(i).Value
                    };

                    string temp = import.Raceability.ElementAt(i).Value;

                    string newtemp = temp.Replace(",", "");

                    string[] temparray = newtemp.Split(null);

                    newrace.Abilities.AddRange(temparray);

                    data.Addrace(newrace);
                }
            }
            ///Once the loops have finished we pass all this
            ///data back out to where the fuction was called
            return data;
        }
    }
}
