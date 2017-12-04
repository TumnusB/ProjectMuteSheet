﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectMuteSheet
{
    /// <summary>
    /// Creates a DND Background
    /// </summary>
    public class DNDbackground
    {

        /// <summary>
        /// The name of the background
        /// </summary>
        private string name;
        /// <summary>
        /// The proficency of the background
        /// </summary>
        private string proficency;
        /// <summary>
        /// The proficency broken down into a list of proficiencies
        /// </summary>
        private List<string> proficiencies = new List<string>();

        /// <summary>
        /// Gets or sets the proficiencies.
        /// </summary>
        /// <value>
        /// Retuns the list proficiencies.
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
        /// Gets or sets the proficency.
        /// </summary>
        /// <value>
        /// Returns the proficency.
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
        /// Initializes a empty instance of the <see cref="DNDbackground"/> class.
        /// </summary>
        public DNDbackground()
        {
            name = "";
            proficency = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNDbackground"/> class.
        /// </summary>
        /// <param name="name">Enter String for name.</param>
        /// <param name="proficency">Enter String for proficency.</param>
        public DNDbackground(string name, string proficency)
        {
            name = this.name;
            proficency = this.proficency;
        }

    }
}