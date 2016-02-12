using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void LecteurTexte_Load(object sender, EventArgs e)
        {
         GestionTexte.ListeMots(listBoxMots,textBoxTexte);
        }
    }
}
