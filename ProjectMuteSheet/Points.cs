using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMuteSheet
{
    class Points
    {
        /// <summary>
        /// The value for the points
        /// </summary>
        public int points = 27;

        /// <summary>
        /// Boolean to check if the points hit the max
        /// </summary>
        Boolean maxpoints = false;

        /// <summary>
        /// Resets the point buy form.
        /// </summary>
        /// <param name="att1">TextBox that contains a Attribute.</param>
        /// <param name="att2">TextBox that contains a Attribute.</param>
        /// <param name="att3">TextBox that contains a Attribute.</param>
        /// <param name="att4">TextBox that contains a Attribute.</param>
        /// <param name="att5">TextBox that contains a Attribute.</param>
        /// <param name="att6">TextBox that contains a Attribute.</param>
        /// <param name="pointbox">The TextBox that contains the Points.</param>
        public void Reset(TextBox att1, TextBox att2, TextBox att3, TextBox att4, TextBox att5, TextBox att6, TextBox pointbox)
        {
            att1.Text = "8";
            att2.Text = "8";
            att3.Text = "8";
            att4.Text = "8";
            att5.Text = "8";
            att6.Text = "8";
            pointbox.Text = "27";

        }

        /// <summary>
        /// Decreases the current points.
        /// </summary>
        /// <param name="input">String Input for the Point decrease calculation.</param>
        /// <param name="pointbox">The TextBox that contains the Points.</param>
        /// <returns></returns>
        public string PointsDec(string input, TextBox pointbox)
        {
            int val = Convert.ToInt32(input);

            {
                switch (val)
                {
                    case 8:
                        break;
                    case 9:
                        points += 1;
                        break;
                    case 10:
                        points += 1;
                        break;
                    case 11:
                        points += 1;
                        break;
                    case 12:
                        points += 1;
                        break;
                    case 13:
                        points += 1;
                        break;
                    case 14:
                        points += 2;
                        break;
                    case 15:
                        points += 2;
                        break;

                }
            }

            if (Convert.ToInt32(input) <= 8)
            {
                return "8";
            }

            pointbox.Text = points.ToString();

            val--;

            string newstring = val.ToString();

            return newstring;
        }

        /// <summary>
        /// Increases the current points.
        /// </summary>
        /// <param name="input">String Input for the Point decrease calculation.</param>
        /// <param name="pointbox">The TextBox that contains the Points.</param>
        /// <returns></returns>
        public string PointsInc(string input, TextBox pointbox)
        {
            int val = Convert.ToInt32(input);



            if (!maxpoints)
            {
                val++;
            }


            switch (val)
            {
                case 8:
                    break;
                case 9:
                    points -= 1;
                    break;
                case 10:
                    points -= 1;
                    break;
                case 11:
                    points -= 1;
                    break;
                case 12:
                    points -= 1;
                    break;
                case 13:
                    points -= 1;
                    break;
                case 14:
                    points -= 2;
                    break;
                case 15:
                    points -= 2;
                    break;
                case 16:
                    val = 15;
                    break;


            }

            if (points > 0)
            {
                maxpoints = false;
            }

            pointbox.Text = points.ToString();

            string newstring = val.ToString();

            return newstring;
        }

    }
}
