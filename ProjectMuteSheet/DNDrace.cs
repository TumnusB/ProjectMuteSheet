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

        public string Name { get => name; set => name = value; }
        public string Ability { get => ability; set => ability = value; }
        public List<string> Abilities { get => abilities; set => abilities = value; }
    }
}
