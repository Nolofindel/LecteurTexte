using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecteurTexte
{
    public partial class LecteurTexte : Form
    {
        public LecteurTexte()
        {
            InitializeComponent();
        }
        private string mot;
        private int indexmot;
        private void LecteurTexte_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonChercher_Click(object sender, EventArgs e)
        {
            indexmot = textBoxTexte.Text.IndexOf(mot,indexmot,StringComparison.OrdinalIgnoreCase);
            if (indexmot != -1)
            {
                if (textBoxTexte.Text[indexmot+ mot.Length] == ' '|| textBoxTexte.Text[indexmot + mot.Length]==','|| textBoxTexte.Text[indexmot + mot.Length]=='.')
                {
                    textBoxTexte.Focus();
                    textBoxTexte.SelectionStart = indexmot;
                    textBoxTexte.SelectionLength = mot.Length;
                    textBoxTexte.ScrollToCaret();
                    indexmot += mot.Length;
                }
                else
                {
                    indexmot += mot.Length;
                    buttonChercher.PerformClick();
                }
                
                
            }
            else { buttonChercher.Enabled = false; }
        }

        private void listBoxMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            mot = (string)listBoxMots.SelectedItem;
            indexmot = 0;
            buttonChercher.Enabled = true;
        }

        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            
            openFileDialogTexte = new OpenFileDialog();
            if (openFileDialogTexte.ShowDialog() == DialogResult.OK)
            {
                textBoxTexte.Clear();
                textBox1.Text = openFileDialogTexte.FileName;
                GestionTexte.ListeMots(listBoxMots, textBoxTexte,openFileDialogTexte.FileName);
            }
        }

        private void buttonApercu_Click(object sender, EventArgs e)
        {
            printPreviewTexte = new PrintPreviewDialog();
            PrintDocument printText = new PrintDocument();
            printText.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
              {
                  e1.Graphics.DrawString(textBoxTexte.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, printText.DefaultPageSettings.PrintableArea.Width, printText.DefaultPageSettings.PrintableArea.Height));
              };
            printPreviewTexte.Document = printText;
            printPreviewTexte.ShowDialog();
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            printDialogTexte = new PrintDialog();
            PrintDocument printText = new PrintDocument();
            printText.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(textBoxTexte.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, printText.DefaultPageSettings.PrintableArea.Width, printText.DefaultPageSettings.PrintableArea.Height));
            };
            printDialogTexte.Document = printText;
            if (printDialogTexte.ShowDialog() == DialogResult.OK)
            {
                printDialogTexte.Document.Print();
            }
        }
    }
}
