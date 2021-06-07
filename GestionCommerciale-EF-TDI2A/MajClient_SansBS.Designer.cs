namespace GestionCommerciale_EF_TDI2A
{
    partial class MajClient_SansBS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label NoJoueurLabel;
            System.Windows.Forms.Label NomJoueurLabel;
            System.Windows.Forms.Label SexeLabel;
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.CmdRechercher = new System.Windows.Forms.Button();
            this.CmdSuivant = new System.Windows.Forms.Button();
            this.CmdPrecedent = new System.Windows.Forms.Button();
            this.CmdAjouter = new System.Windows.Forms.Button();
            this.CmdModifier = new System.Windows.Forms.Button();
            this.CmdDernier = new System.Windows.Forms.Button();
            this.CmdSupprimer = new System.Windows.Forms.Button();
            this.CmdPremier = new System.Windows.Forms.Button();
            this.TxtCodeCl = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtVille = new System.Windows.Forms.TextBox();
            Label1 = new System.Windows.Forms.Label();
            NoJoueurLabel = new System.Windows.Forms.Label();
            NomJoueurLabel = new System.Windows.Forms.Label();
            SexeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(547, 402);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(149, 41);
            this.btnQuitter.TabIndex = 222;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 32);
            this.label2.TabIndex = 221;
            this.label2.Text = "Mise à jour Client";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(395, 372);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(104, 19);
            Label1.TabIndex = 219;
            Label1.Text = "Code Client :";
            // 
            // TxtFind
            // 
            this.TxtFind.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFind.Location = new System.Drawing.Point(523, 365);
            this.TxtFind.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(200, 26);
            this.TxtFind.TabIndex = 220;
            // 
            // CmdRechercher
            // 
            this.CmdRechercher.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercher.Location = new System.Drawing.Point(545, 284);
            this.CmdRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.CmdRechercher.Name = "CmdRechercher";
            this.CmdRechercher.Size = new System.Drawing.Size(149, 41);
            this.CmdRechercher.TabIndex = 218;
            this.CmdRechercher.Text = "Rechercher";
            this.CmdRechercher.UseVisualStyleBackColor = true;
            // 
            // CmdSuivant
            // 
            this.CmdSuivant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSuivant.Location = new System.Drawing.Point(177, 284);
            this.CmdSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSuivant.Name = "CmdSuivant";
            this.CmdSuivant.Size = new System.Drawing.Size(100, 41);
            this.CmdSuivant.TabIndex = 217;
            this.CmdSuivant.Text = ">";
            this.CmdSuivant.UseVisualStyleBackColor = true;
            this.CmdSuivant.Click += new System.EventHandler(this.CmdSuivant_Click);
            // 
            // CmdPrecedent
            // 
            this.CmdPrecedent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPrecedent.Location = new System.Drawing.Point(289, 284);
            this.CmdPrecedent.Margin = new System.Windows.Forms.Padding(4);
            this.CmdPrecedent.Name = "CmdPrecedent";
            this.CmdPrecedent.Size = new System.Drawing.Size(100, 41);
            this.CmdPrecedent.TabIndex = 216;
            this.CmdPrecedent.Text = "<";
            this.CmdPrecedent.UseVisualStyleBackColor = true;
            this.CmdPrecedent.Click += new System.EventHandler(this.CmdPrecedent_Click);
            // 
            // CmdAjouter
            // 
            this.CmdAjouter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAjouter.Location = new System.Drawing.Point(547, 102);
            this.CmdAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAjouter.Name = "CmdAjouter";
            this.CmdAjouter.Size = new System.Drawing.Size(149, 41);
            this.CmdAjouter.TabIndex = 215;
            this.CmdAjouter.Text = "Nouveau";
            this.CmdAjouter.UseVisualStyleBackColor = true;
            // 
            // CmdModifier
            // 
            this.CmdModifier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdModifier.Location = new System.Drawing.Point(547, 157);
            this.CmdModifier.Margin = new System.Windows.Forms.Padding(4);
            this.CmdModifier.Name = "CmdModifier";
            this.CmdModifier.Size = new System.Drawing.Size(149, 41);
            this.CmdModifier.TabIndex = 214;
            this.CmdModifier.Text = "Modifier";
            this.CmdModifier.UseVisualStyleBackColor = true;
            // 
            // CmdDernier
            // 
            this.CmdDernier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDernier.Location = new System.Drawing.Point(405, 284);
            this.CmdDernier.Margin = new System.Windows.Forms.Padding(4);
            this.CmdDernier.Name = "CmdDernier";
            this.CmdDernier.Size = new System.Drawing.Size(100, 41);
            this.CmdDernier.TabIndex = 213;
            this.CmdDernier.Text = ">>";
            this.CmdDernier.UseVisualStyleBackColor = true;
            this.CmdDernier.Click += new System.EventHandler(this.CmdDernier_Click);
            // 
            // CmdSupprimer
            // 
            this.CmdSupprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSupprimer.Location = new System.Drawing.Point(547, 210);
            this.CmdSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSupprimer.Name = "CmdSupprimer";
            this.CmdSupprimer.Size = new System.Drawing.Size(149, 41);
            this.CmdSupprimer.TabIndex = 212;
            this.CmdSupprimer.Text = "Supprimer";
            this.CmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // CmdPremier
            // 
            this.CmdPremier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPremier.Location = new System.Drawing.Point(64, 284);
            this.CmdPremier.Margin = new System.Windows.Forms.Padding(4);
            this.CmdPremier.Name = "CmdPremier";
            this.CmdPremier.Size = new System.Drawing.Size(100, 41);
            this.CmdPremier.TabIndex = 211;
            this.CmdPremier.Text = "<<";
            this.CmdPremier.UseVisualStyleBackColor = true;
            this.CmdPremier.Click += new System.EventHandler(this.CmdPremier_Click);
            // 
            // NoJoueurLabel
            // 
            NoJoueurLabel.AutoSize = true;
            NoJoueurLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NoJoueurLabel.Location = new System.Drawing.Point(120, 126);
            NoJoueurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NoJoueurLabel.Name = "NoJoueurLabel";
            NoJoueurLabel.Size = new System.Drawing.Size(109, 19);
            NoJoueurLabel.TabIndex = 205;
            NoJoueurLabel.Text = "Code Client  :";
            // 
            // TxtCodeCl
            // 
            this.TxtCodeCl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeCl.Location = new System.Drawing.Point(244, 123);
            this.TxtCodeCl.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodeCl.Name = "TxtCodeCl";
            this.TxtCodeCl.Size = new System.Drawing.Size(200, 26);
            this.TxtCodeCl.TabIndex = 206;
            // 
            // NomJoueurLabel
            // 
            NomJoueurLabel.AutoSize = true;
            NomJoueurLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NomJoueurLabel.Location = new System.Drawing.Point(120, 158);
            NomJoueurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NomJoueurLabel.Name = "NomJoueurLabel";
            NomJoueurLabel.Size = new System.Drawing.Size(52, 19);
            NomJoueurLabel.TabIndex = 207;
            NomJoueurLabel.Text = "Nom :";
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(244, 155);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(200, 26);
            this.TxtNom.TabIndex = 208;
            // 
            // SexeLabel
            // 
            SexeLabel.AutoSize = true;
            SexeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SexeLabel.Location = new System.Drawing.Point(120, 190);
            SexeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SexeLabel.Name = "SexeLabel";
            SexeLabel.Size = new System.Drawing.Size(49, 19);
            SexeLabel.TabIndex = 209;
            SexeLabel.Text = "Ville :";
            // 
            // TxtVille
            // 
            this.TxtVille.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVille.Location = new System.Drawing.Point(244, 187);
            this.TxtVille.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(200, 26);
            this.TxtVille.TabIndex = 210;
            // 
            // MajClient_SansBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 463);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(Label1);
            this.Controls.Add(this.TxtFind);
            this.Controls.Add(this.CmdRechercher);
            this.Controls.Add(this.CmdSuivant);
            this.Controls.Add(this.CmdPrecedent);
            this.Controls.Add(this.CmdAjouter);
            this.Controls.Add(this.CmdModifier);
            this.Controls.Add(this.CmdDernier);
            this.Controls.Add(this.CmdSupprimer);
            this.Controls.Add(this.CmdPremier);
            this.Controls.Add(NoJoueurLabel);
            this.Controls.Add(this.TxtCodeCl);
            this.Controls.Add(NomJoueurLabel);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(SexeLabel);
            this.Controls.Add(this.TxtVille);
            this.Name = "MajClient_SansBS";
            this.Text = "MajClient_SansBS";
            this.Load += new System.EventHandler(this.MajClient_SansBS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox TxtFind;
        internal System.Windows.Forms.Button CmdRechercher;
        internal System.Windows.Forms.Button CmdSuivant;
        internal System.Windows.Forms.Button CmdPrecedent;
        internal System.Windows.Forms.Button CmdAjouter;
        internal System.Windows.Forms.Button CmdModifier;
        internal System.Windows.Forms.Button CmdDernier;
        internal System.Windows.Forms.Button CmdSupprimer;
        internal System.Windows.Forms.Button CmdPremier;
        internal System.Windows.Forms.TextBox TxtCodeCl;
        internal System.Windows.Forms.TextBox TxtNom;
        internal System.Windows.Forms.TextBox TxtVille;
    }
}