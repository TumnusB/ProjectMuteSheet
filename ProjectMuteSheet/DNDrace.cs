using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMuteSheet
{
   public class DNDrace
    {
        /// <summary>
        /// The name of the race
        /// </summary>
        private string name;

        
        /// <summary>
        /// The ability of the race
        /// </summary>
        private string ability;

        /// <summary>
        /// The ability broken down into a list of ablities
        /// </summary>
        private List<string> abilities = new List<string>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Abilities
        {
            get { return abilities; }
            set { abilities = value; }
        }

        public string Ability
        {
            get { return ability; }
            set { ability = value; }
        }

        public DNDrace()
        {
            name = "";
            ability = "";
        }

        public DNDrace(string name, string ability)
        {
            name = this.name;
            ability = this.ability;
        }

    }
}
