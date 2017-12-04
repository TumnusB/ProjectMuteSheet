using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProjectMuteSheet
{
    public partial class FormDnDSheet : Form
    {
        public FormDnDSheet()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Creates a public instance of DNDimport named Import
        /// in the first scope to ensure
        /// its accessible anywhere on the form
        /// </summary>
        public DNDimport Import = new DNDimport();
        /// <summary>
        /// Creates a public instance of DNDdata named DNDdata
        /// in the first scope to ensure
        /// its accessible anywhere on the form
        /// </summary>
        public DNDdata DNDdata = new DNDdata();
        /// <summary>
        /// Creates a public instance of DNDsheet named newdnds
        /// in the first scope to ensure
        /// its accessible anywhere on the form
        /// </summary>
        public DNDsheet newdnds = new DNDsheet();

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
            {
                TopMost = true;
                Focus();
                BringToFront();
                TopMost = false;
            }

            DNDdata = Import.XMLimport();

            ///This For Loop will loop through all the 
            ///The data stored in ClassList which are 
            ///Instances of <see cref="DNDclass"/>
            ///And store the name in the combobox
            for (int i = 0; i < DNDdata.ClassList.Count(); i++)
            {
                ComBoxClass.Items.Add(DNDdata.ClassList.ElementAt(i).Name);
            }

            ///This For Loop will loop through all the 
            ///The data stored in BackgroundList which are 
            ///Instances of <see cref="DNDbackground"/>
            ///And store the name in the combobox
            for (int i = 0; i < DNDdata.BackgroundList.Count(); i++)
            {
                ComboxBackground.Items.Add(DNDdata.BackgroundList.ElementAt(i).Name);
            }

            for (int i = 0; i < DNDdata.RaceList.Count(); i++)
            {
                ComboxRace.Items.Add(DNDdata.RaceList.ElementAt(i).Name);
            }

            ///This for loop will add
            ///1 to 20 to a combobox which is
            ///used in the function <see cref="DNDsheet.CalcLevelProficency(string)"/>
            for (int i = 0; i < 20; i++)
            {
                int a = i + 1;
                comboxLevel.Items.Add(a);
            }
        }

        /// <summary>
        /// The Label ProfVal
        /// will be changed to a value
        /// based on the combox Selected Index 
        /// for more info <see cref="DNDsheet.CalcLevelProficency(string)"/>
        /// </summary>
        private void ComboxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProfVal.Text = newdnds.CalcLevelProficency(comboxLevel.SelectedIndex.ToString());

        }

        /// <summary>
        /// Based on the Selected Index 
        /// The Propety of Proficency in ClassList
        /// is displayed in a text box
        /// </summary>
        private void ComBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxProf.Text = DNDdata.ClassList.ElementAt(ComBoxClass.SelectedIndex).Proficency;
        }

        /// <summary>
        /// Based on the Selected Index 
        /// The Propety of Proficency in BackgroundList
        /// is displayed in a text box
        /// </summary>
        private void ComboxBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxbgProf.Text = DNDdata.BackgroundList.ElementAt(ComboxBackground.SelectedIndex).Proficency;
        }

        private void ComboxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxRaceAbility.Text = DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Ability;
            

            for (int i = 0; i < DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.Count(); i++)
            {
                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Dex"))
                {
                    txtbCha.Text = DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString();
                }

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Wis"))
                {
                    txtbWis.Text = DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString();
                }

            }
        }

        /// <summary>
        /// The Label StrB
        /// will be changed to a value
        /// based on the text input from 
        /// txtbStr for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void txtbStr_TextChanged(object sender, EventArgs e)
        {
            lbStrB.Text = newdnds.CalcAbilityScoreModifier(txtbStr.Text);
        }

        /// <summary>
        /// The Label DexB
        /// will be changed to a value
        /// based on the text input from 
        /// txtbDex for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void txtbDex_TextChanged(object sender, EventArgs e)
        {
            lbDexB.Text = newdnds.CalcAbilityScoreModifier(txtbDex.Text);
        }

        /// <summary>
        /// The Label ConB
        /// will be changed to a value
        /// based on the text input from 
        /// txtbCon for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void txtbCon_TextChanged(object sender, EventArgs e)
        {
            lbConB.Text = newdnds.CalcAbilityScoreModifier(txtbCon.Text);
        }

        /// <summary>
        /// The Label IntB
        /// will be changed to a value
        /// based on the text input from 
        /// txtbInt for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void txtbInt_TextChanged(object sender, EventArgs e)
        {
            lbIntB.Text = newdnds.CalcAbilityScoreModifier(txtbInt.Text);
        }

        /// <summary>
        /// The Label WisB
        /// will be changed to a value
        /// based on the text input from 
        /// WisbStr for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void txtbWis_TextChanged(object sender, EventArgs e)
        {
            lbWisB.Text = newdnds.CalcAbilityScoreModifier(txtbWis.Text);
        }
        /// <summary>
        /// The Label ChaB
        /// will be changed to a value
        /// based on the text input from 
        /// txtbCha for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void txtbCha_TextChanged(object sender, EventArgs e)
        {
            lbChaB.Text = newdnds.CalcAbilityScoreModifier(txtbCha.Text);
        }

        private void checkPointBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPointBuy.Checked)
            {
                FormPointBuy formPointBuy = new FormPointBuy();
                formPointBuy.ShowDialog();
            }
            else if (!checkPointBuy.Checked)
            {

            }
            
        }
    }
}


