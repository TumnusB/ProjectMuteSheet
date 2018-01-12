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
        /// The string
        /// </summary>
        int str = 0;
        /// <summary>
        /// The dex
        /// </summary>
        int dex = 0;
        /// <summary>
        /// The con
        /// </summary>
        int con = 0;
        /// <summary>
        /// The inte
        /// </summary>
        int inte = 0;
        /// <summary>
        /// The wis
        /// </summary>
        int wis = 0;
        /// <summary>
        /// The cha
        /// </summary>
        int cha = 0;

        /// <summary>
        /// Creates a public instance of DNDCreateDataSet named dataset
        /// in the first scope to ensure
        /// its accessible anywhere on the form
        /// </summary>
        public DNDCreateDataSet dataset = new DNDCreateDataSet();

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

            DNDdata = dataset.DataGen();

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

            AbilityScores();
        }

        /// <summary>
        /// Abilities the scores.
        /// </summary>
        private void AbilityScores()
        {
            numStr.Value = 0;
            numDex.Value = 0;
            numCon.Value = 0;
            numInt.Value = 0;
            numWis.Value = 0;
            numCha.Value = 0;

            for (int i = 0; i < DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.Count(); i++)
            {

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Str"))
                {

                    str += int.Parse(DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString());
                }

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Dex"))
                {

                    dex += int.Parse(DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString());
                }

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Con"))
                {
                   con += int.Parse(DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString());
                }

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Int"))
                {
                   inte += int.Parse(DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString());
                }

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Wis"))
                {
                  wis += int.Parse(DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString());
                }

                if (DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i).Contains("Cha"))
                {
                  cha += int.Parse(DNDdata.RaceList.ElementAt(ComboxRace.SelectedIndex).Abilities.ElementAt(i + 1).ToString());
                }

            }
        }



        /// <summary>
        /// The Label StrB
        /// will be changed to a value
        /// based on the numeric input from 
        /// numStr for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void numStr_ValueChanged(object sender, EventArgs e)
        {
            int newstr = str;

            newstr += Convert.ToInt32(numStr.Value);

            string temp = newstr.ToString();

            lbStrB.Text = newdnds.CalcAbilityScoreModifier(temp);
        }

        /// <summary>
        /// The Label DexB
        /// will be changed to a value
        /// based on the numeric input from 
        /// numDex for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void numDex_ValueChanged(object sender, EventArgs e)
        {
            int newdex = dex;

            newdex += Convert.ToInt32(numDex.Value);

            string temp = newdex.ToString();

            lbDexB.Text = newdnds.CalcAbilityScoreModifier(temp);
        }

        /// <summary>
        /// The Label ConB
        /// will be changed to a value
        /// based on the numeric input from 
        /// numCon for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void numCon_ValueChanged(object sender, EventArgs e)
        {
            int newcon = con;

            newcon += Convert.ToInt32(numCon.Value);

            string temp = newcon.ToString();

            lbConB.Text = newdnds.CalcAbilityScoreModifier(temp);
        }

        /// <summary>
        /// The Label IntB
        /// will be changed to a value
        /// based on the numeric input from 
        /// numInt for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void numInt_ValueChanged(object sender, EventArgs e)
        {
            int newint = inte;

            newint += Convert.ToInt32(numInt.Value);

            string temp = newint.ToString();

            lbIntB.Text = newdnds.CalcAbilityScoreModifier(temp);
        }

        /// <summary>
        /// The Label WisB
        /// will be changed to a value
        /// based on the numeric input from 
        /// numStr for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void numWis_ValueChanged(object sender, EventArgs e)
        {
            int newwis = wis;

            newwis += Convert.ToInt32(numWis.Value);

            string temp = newwis.ToString();

            lbWisB.Text = newdnds.CalcAbilityScoreModifier(temp);
        }

        /// <summary>
        /// The Label ChaB
        /// will be changed to a value
        /// based on the numeric input from  
        /// numCha for more info <see cref="DNDsheet.CalcAbilityScoreModifier(string)"/>
        /// </summary>
        private void numCha_ValueChanged(object sender, EventArgs e)
        {
            int newcha = cha;

            newcha += Convert.ToInt32(numCha.Value);

            string temp = newcha.ToString();

            lbChaB.Text = newdnds.CalcAbilityScoreModifier(temp);
        }


        private void checkPointBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPointBuy.Checked)
            {
                btnPoints.Visible = true;
            }
            else if (!checkPointBuy.Checked)
            {
                btnPoints.Visible = false;
            }
            
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {

            FormPointBuy formPointBuy = new FormPointBuy();
            formPointBuy.ShowDialog();

            numStr.ReadOnly = true;
            numDex.ReadOnly = true;
            numCon.ReadOnly = true;
            numInt.ReadOnly = true;
            numWis.ReadOnly = true;
            numCha.ReadOnly = true;
        }
    }
}