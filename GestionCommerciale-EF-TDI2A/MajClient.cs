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
    public partial class MajClient : Form
    {

        public VenteEntities db = new VenteEntities();
        public BindingSource bsClient = new BindingSource();
        public Client ClientActuel;


        public MajClient()
        {
            InitializeComponent();
        }

        private void MajClient_Load(object sender, EventArgs e)
        {
            bsClient.DataSource = db.Clients.ToList();

            Afficher();
        }

        private void Afficher()
        {
            ClientActuel = (Client)bsClient.Current;
            TxtCodeCl.Text = ClientActuel.CodeCl;
            TxtNom.Text = ClientActuel.Nom;
            TxtVille.Text = ClientActuel.Ville;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdPremier_Click(object sender, EventArgs e)
        {
            bsClient.MoveFirst();
            Afficher();
        }

        private void CmdSuivant_Click(object sender, EventArgs e)
        {
            bsClient.MoveNext();
            Afficher();
        }

        private void CmdPrecedent_Click(object sender, EventArgs e)
        {
            bsClient.MovePrevious();
            Afficher();
        }

        private void CmdDernier_Click(object sender, EventArgs e)
        {
            bsClient.MoveLast();
            Afficher();
        }

        private void CmdRechercher_Click(object sender, EventArgs e)
        {
            //Client cl = db.Clients.Find(TxtFind.Text);
            bsClient.Position = bsClient.IndexOf(Chercher(TxtFind.Text));
            Afficher();
        }

        private Client Chercher(String Code)
        {
            return (from cl in db.Clients
                    where cl.CodeCl == Code
                    select cl).First();
            //return db.Clients.Find(TxtFind.Text);
        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {
            if (CmdAjouter.Text == "Nouveau")
            {
                CmdAjouter.Text = "Ajouter";
                Effacer();
            }
            else
            {
                CmdAjouter.Text = "Nouveau";
                Client cl = new Client();
                cl.CodeCl = TxtCodeCl.Text;
                cl.Nom = TxtNom.Text;
                cl.Ville = TxtVille.Text;
                db.Clients.Add(cl);  // Ajouter dans la table Client
                db.SaveChanges(); // Enregistrer dans la BD
                ActualiserBS();
                bsClient.MoveLast();
            }
        }

        private void ActualiserBS()
        {
            bsClient.DataSource = db.Clients.ToList();
        }

        private void Effacer()
        {
            TxtCodeCl.Clear();
            TxtNom.Clear();
            TxtVille.Clear();
            TxtCodeCl.Focus();
        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {
            db.Clients.Remove(Chercher(TxtCodeCl.Text));
            db.SaveChanges();
            ActualiserBS();
            Afficher();
        }

        private void CmdModifier_Click(object sender, EventArgs e)
        {
            Client cl = Chercher(TxtCodeCl.Text);
            cl.Nom = TxtNom.Text;
            cl.Ville = TxtVille.Text;
            db.SaveChanges();
            ActualiserBS();
        }
    }
}
