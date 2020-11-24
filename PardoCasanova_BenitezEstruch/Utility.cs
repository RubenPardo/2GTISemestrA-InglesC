using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PardoCasanova_BenitezEstruch
{
    class Utility
    {

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


        public static string generateID()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool isTextEmpty(string text)
        {
            if (text != null)
            {
                text = text.Trim();
                if (text.Equals(""))
                {
                    return true;
                }
            }


            return false;
        }

        public static void showDialogError(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void showDialogWarning(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static String readFile(String fileName)
        {
            String line;
            StringBuilder sb = new StringBuilder();


            using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("utf-8")))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                    }
                }
            }
            return sb.ToString();
        }

    }
}
