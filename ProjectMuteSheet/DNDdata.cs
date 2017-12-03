using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMuteSheet
{
    /// <summary>
    /// Contains the lists for <see cref="DNDbackground"/> and <see cref="DNDclass"/>.
    /// </summary>
    public class DNDdata
    {

        /// <summary>
        ///  Creates a list of <see cref="DNDbackground"/> named backgroundlist
        /// </summary>
        private List<DNDbackground> backgroundlist = new List<DNDbackground>();

        /// <summary>
        /// Gets or sets the background list.
        /// </summary>
        /// <value>
        /// Retruns the background list.
        /// </value>
        public List<DNDbackground> BackgroundList
       {
           get
           {
               return backgroundlist;
           }
           set
           {
               backgroundlist = value;
           }
       }

        /// <summary>
        /// Adds the specified background to the list.
        /// </summary>
        /// <param name="newbackground">Enter Details for the background <see cref="DNDbackground"/>.</param>
        public void Addbackground(DNDbackground newbackground)
       {
           BackgroundList.Add(newbackground);
       }

        /// <summary>
        /// Creates a list of <see cref="DNDclass"/> named Classlist
        /// </summary>
        private List<DNDclass> classlist = new List<DNDclass>();

        /// <summary>
        /// Gets or sets the class list.
        /// </summary>
        /// <value>
        /// Retruns the class list.
        /// </value>
        public List<DNDclass> ClassList
       {
           get
           {
               return classlist;
           }
           set
           {
               classlist = value;
           }
       }

        /// <summary>
        /// Adds the specified class to the list.
        /// </summary>
        /// <param name="newclass">Enter Details for the class <see cref="DNDclass"/></param>
        public void Addclass(DNDclass newclass)
       {
           ClassList.Add(newclass);
       }

        /// <summary>
        ///  Creates a list of <see cref="DNDbackground"/> named backgroundlist
        /// </summary>
        private List<DNDrace> racelist = new List<DNDrace>();

        /// <summary>
        /// Gets or sets the background list.
        /// </summary>
        /// <value>
        /// Retruns the background list.
        /// </value>
        public List<DNDrace> RaceList
        {
            get
            {
                return racelist;
            }
            set
            {
                racelist = value;
            }
        }

        /// <summary>
        /// Adds the specified background to the list.
        /// </summary>
        /// <param name="newbackground">Enter Details for the background <see cref="DNDbackground"/>.</param>
        public void Addrace(DNDrace newrace)
        {
            RaceList.Add(newrace);
        }

    }
}
