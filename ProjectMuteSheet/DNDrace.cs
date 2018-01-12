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

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the abilities.
        /// </summary>
        /// <value>
        /// The abilities.
        /// </value>
        public List<string> Abilities
        {
            get { return abilities; }
            set { abilities = value; }
        }

        /// <summary>
        /// Gets or sets the ability.
        /// </summary>
        /// <value>
        /// The ability.
        /// </value>
        public string Ability
        {
            get { return ability; }
            set { ability = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNDrace"/> class.
        /// </summary>
        public DNDrace()
        {
            name = "";
            ability = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNDrace"/> class.
        /// </summary>
        /// <param name="name">The name of the race.</param>
        /// <param name="ability">The ability of the race.</param>
        public DNDrace(string name, string ability)
        {
            name = this.name;
            ability = this.ability;
        }

    }
}
