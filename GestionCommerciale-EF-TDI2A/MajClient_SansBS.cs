using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommerciale_EF_TDI2A
{
    public partial class MajClient_SansBS : Form
    {
        public VenteEntities db = new VenteEntities();
        public int p = 0;

        public MajClient_SansBS()
        {
            InitializeComponent();
        }

        private void MajClient_SansBS_Load(object sender, EventArgs e)
        {
            Aficher(p);
        }

        private void Aficher(int k)
        {
            var clients = (from cl in db.Clients select cl).ToList();
            TxtCodeCl.Text = clients[k].CodeCl;
            TxtNom.Text = clients[k].Nom;
            TxtVille.Text = clients[k].Ville;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdPremier_Click(object sender, EventArgs e)
        {
            p = 0;
            Aficher(p);
        }

        private void CmdDernier_Click(object sender, EventArgs e)
        {
            p = db.Clients.Count() - 1;
            Aficher(p);
        }

        private void CmdSuivant_Click(object sender, EventArgs e)
        {
            if (p < db.Clients.Count() - 1)
            {
            Aficher(++p);
            }
        }

        private void CmdPrecedent_Click(object sender, EventArgs e)
        {
            if (p > 0)
            {
                Aficher(--p);
            }
        }
    }
}
