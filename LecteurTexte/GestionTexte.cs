using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecteurTexte
{

    public class GestionTexte
    {

        public static void ListeMots(ListBox Box,TextBox Text,string path)
        {

            FileStream Texte = new FileStream(path, FileMode.Open);
            StreamReader RTexte = new StreamReader(Texte, Encoding.GetEncoding(1252));

            List<string> Mots = new List<string>();
            string strline = RTexte.ReadLine();
            Regex regmot = new Regex(@"^[a-zA-Z0-9'-]*$");
            string[] MotsLigne;
            bool nonpresent;

            while (strline != null)
            {
                Text.Text += strline;
                MotsLigne = strline.Split(' ');
                foreach (string mot in MotsLigne)
                {
                    nonpresent = true;
                    string rmot = mot.Replace(",", "").Replace(".", "");             
                    if (regmot.IsMatch(rmot)&&(rmot!=""))
                    {
                        foreach (string tm in Mots)
                        {
                            if (String.Equals(rmot,tm,StringComparison.OrdinalIgnoreCase)) { nonpresent = false; ; }
                        }
                        if (nonpresent) { Mots.Add(rmot.ToLower()); }
                    }
                }
                strline = RTexte.ReadLine();
            }
            Box.DataSource = Mots;
            RTexte.Close();
            Texte.Close();
        }
    }
}
