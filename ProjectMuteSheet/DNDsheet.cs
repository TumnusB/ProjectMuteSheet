using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMuteSheet
{
    /// <summary>
    /// This class stores fuctions that 
    /// generates items that would be
    /// on a DND 5E Sheet
    /// </summary>
    public class DNDsheet
    {
     
        

        /// <summary>
        /// Calculates the ability score modifier.
        /// </summary>
        /// <param name="abilityscoremodifier">Ability Score Modifier takes a string.</param>
        /// <returns>
        /// A string with a numeric value will be returned based on the string passed in
        /// </returns>

        public string CalcAbilityScoreModifier(string abilityscoremodifier)
        {
            ///This checks if the value has no data if it does it
            ///passes out N/A to where the fuction is called
            if (abilityscoremodifier == "")
            {
                return "N/A";
            }

            

            try
            {

                switch (abilityscoremodifier)
                {
                    case "1":
                        return "-5";

                    case "2":
                    case "3":
                        return "-4";


                    case "4":
                    case "5":
                        return "-3";

                    case "6":
                    case "7":
                        return "-2";

                    case "8":
                    case "9":
                        return "-1";

                    case "10":
                    case "11":
                        return "0";

                    case "12":
                    case "13":
                        return "+1";

                    case "14":
                    case "15":
                        return "+2";

                    case "16":
                    case "17":
                        return "+3";

                    case "18":
                    case "19":

                        return "+4";

                    case "20":
                    case "21":
                        return "+5";

                    case "22":
                    case "23":
                        return "+6";

                    case "24":
                    case "25":
                        return "+7";

                    case "26":
                    case "27":
                        return "+8";

                    case "28":
                    case "29":
                        return "+9";

                    case "30":
                        return "+10";


                    default:
                        return "N/A";

                }

            }
            catch (Exception)
            {
                return "N/A";
            }
        }

        /// <summary>
        /// Calculates the level proficency.
        /// </summary>
        /// <param name="level">level takes a string</param>
        /// <returns>
        /// A string with a numeric value will be returned based on the string passed in
        /// </returns>
        public string CalcLevelProficency(string level)
       {
           switch (level)
           {
               case "1":
               case "2":
               case "3":
               case "4":
                   return "+2";
               case "5":
               case "6":
               case "7":
               case "8":
                   return "+3";
               case "9":
               case "10":
               case "11":
               case "12":
                   return "+4";
               case "13":
               case "14":
               case "15":
               case "16":
                   return "+5";
               case "17":
               case "18":
               case "19":
               case "20":
                   return "+6";
               default:
                   return "0";
           }
       }

    }
}
