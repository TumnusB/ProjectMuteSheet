﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectMuteSheet
{
    /// <summary>
    /// Creates a DND Class
    /// </summary>
    public class DNDclass
    {
        /// <summary>
        /// The name of the Class
        /// </summary>
        private string name;
        /// <summary>
        /// The proficiency of the class
        /// </summary>
        private string proficency;
        /// <summary>
        /// The proficiency broken down into a list of proficiencies
        /// </summary>
        private List<string> proficiencies = new List<string>();

        /// <summary>
        /// Gets or sets the proficiencies.
        /// </summary>
        /// <value>
        /// Returns the list proficiencies.
        /// </value>
        public List<string> Proficiencies
        {

            get
            {
                return proficiencies;
            }

            set
            {
                value = proficiencies;
            }

        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// Returns the name.
        /// </value>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }


        }

        /// <summary>
        /// Gets or sets the proficiency.
        /// </summary>
        /// <value>
        /// Returns the proficiency.
        /// </value>
        public string Proficency
        {
            get
            {
                return proficency;
            }
            set
            {

                proficency = value;

            }
        }

        /// <summary>
        /// Initializes a empty instance of the <see cref="DNDclass"/> class.
        /// </summary>
        public DNDclass()
        {
            name = "";
            proficency = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNDclass"/> class.
        /// </summary>
        /// <param name="name">Enter String for name.</param>
        /// <param name="proficency">Enter String for proficiency.</param>
        public DNDclass(string name, string proficency)
        {
            name = this.name;
            proficency = this.proficency;
        }

    }
}
