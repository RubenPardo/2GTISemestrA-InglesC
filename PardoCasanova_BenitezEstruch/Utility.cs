using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PardoCasanova_BenitezEstruch
{
    class Utility
    {
        // text -> Text
        public static string normalizeText(String textToNormalize)
        {
            textToNormalize = textToNormalize.ToLower();
            if (textToNormalize.Length == 0)
                return "";
            else if (textToNormalize.Length == 1)
                return char.ToUpper(textToNormalize[0]) + "";
            else
                return (char.ToUpper(textToNormalize[0]) + textToNormalize.Substring(1));

        }

        /**
         * a GUID will never be generated twice by any computer or group of computers in existence. 
         * The total number of unique keys (2^128 or 3.4×10^38 - in relation there are about 1.33×10^50 atoms on earth) 
         * is so large that the probability of the same number being generated twice is extremely small, 
         * and certain techniques have been developed to help ensure that numbers are not duplicated
         */
        public static string generateID()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool isTextEmpty(string text)
        {
            text = text.Trim();
            if (text.Equals(""))
            {
                return true;
            }

            return false;
        }

        public static void showDialogError(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
