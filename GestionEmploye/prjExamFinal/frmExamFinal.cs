using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjExamFinal
{
    public partial class frmExamFinal : Form
    {
        public frmExamFinal()
        {
            InitializeComponent();
        }
        struct Employe
        {
            public string numero;
            public string nom;
            public string fonction;
            public Int64 salaire;
        }
        List<Employe> tabEmployes = new List<Employe>();

        private void frmExamFinal_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader file = new StreamReader("Compagnie.txt"))
                {
                    while (!file.EndOfStream)
                    {
                        Employe employe = new Employe
                        {
                            numero = file.ReadLine(),
                            nom = file.ReadLine(),
                            fonction = file.ReadLine(),
                            salaire = Int64.Parse(file.ReadLine())
                        };
                        tabEmployes.Add(employe);
                        lstnumero.Items.Add(employe.numero);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier : {ex.Message}");
            }
        }


        private void lstnumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstnumero.SelectedItem != null)
            {
                string selectedEmploye = lstnumero.SelectedItem.ToString();
                var employe = tabEmployes.Find(emp => emp.numero == selectedEmploye);
                lblinfonum.Text = "Numéro : " + employe.numero;
                lblinfonom.Text = "Nom : " + employe.nom;
                lblinfofonction.Text = "Fonction : " + employe.fonction;
                lblinfosalaire.Text = "Salaire : " + employe.salaire;
            }
        }


        private void btnpremier_Click(object sender, EventArgs e)
        {
            if (tabEmployes.Count > 0)
            {
                var employe = tabEmployes.First();
                txtnumero.Text = tabEmployes[0].numero.ToString();
                txtnom.Text = tabEmployes[0].nom.ToString();
                txtfonction.Text = tabEmployes[0].fonction.ToString();
                txtsalaire.Text = tabEmployes[0].salaire.ToString();
                lblnbemploye.Text = "Employé 1 sur un total de 8 ";
            }

        }

        private void btndernier_Click(object sender, EventArgs e)
        {
            if (tabEmployes.Count > 0)
            {
                var employe = tabEmployes.First();
                txtnumero.Text = tabEmployes[nbemploye-1].numero.ToString();
                txtnom.Text = tabEmployes[nbemploye-1].nom.ToString();
                txtfonction.Text = tabEmployes[nbemploye-1].fonction.ToString();
                txtsalaire.Text = tabEmployes[nbemploye-1].salaire.ToString();
                lblnbemploye.Text = "Employé 8 sur un total de 8 ";
            }
        }

        private void btnprecedent_Click(object sender, EventArgs e)
        {

           
            
                if (txtnumero.Text != tabEmployes[0].numero)
                {
                    

                    for (int i = 0; i < nbemploye; i++)
                    {
                        if (txtnumero.Text == tabEmployes[i].numero)
                        {
                        txtnumero.Text = tabEmployes[i - 1].numero.ToString();
                        txtnom.Text = tabEmployes[i - 1].nom.ToString();
                        txtfonction.Text = tabEmployes[i - 1].fonction.ToString();
                        txtsalaire.Text = tabEmployes[i - 1].salaire.ToString();
                        lblnbemploye.Text= "Employé "+i+" sur un total de  "+nbemploye;
                    }
                    }
                }
                else
                {

                    txtnumero.Text = tabEmployes[0].numero.ToString();
                    txtnom.Text = tabEmployes[0].nom.ToString();
                    txtfonction.Text = tabEmployes[0].fonction.ToString();
                    txtsalaire.Text = tabEmployes[0].salaire.ToString();
                    lblnbemploye.Text = "Employé 1 sur un total de  "+nbemploye;

                }

        }

        private void btnsuivant_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text != tabEmployes[8].numero)
            {
                for (int i = 0; i < nbemploye+1; i++)
                {
                    if (txtnumero.Text == tabEmployes[i].numero)
                    {
                        txtnumero.Text = tabEmployes[i+1].numero.ToString();
                        txtnom.Text = tabEmployes[i+1].nom.ToString();
                        txtfonction.Text = tabEmployes[i+1].fonction.ToString();
                        txtsalaire.Text = tabEmployes[i+1].salaire.ToString();
                        lblnbemploye.Text = "Employé "+i+ "sur un total de  "+nbemploye;

                    }
                }
            }
            else
            {
                txtnumero.Text = tabEmployes[nbemploye].numero.ToString();
                txtnom.Text = tabEmployes[nbemploye].nom.ToString();
                txtfonction.Text = tabEmployes[nbemploye].fonction.ToString();
                txtsalaire.Text = tabEmployes[nbemploye].salaire.ToString();
                lblnbemploye.Text = "Employé 8 sur un total de  "+nbemploye;

            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            btnsauvegarder.Enabled = btnannuler.Enabled = true;
            Employe newEmploye = new Employe
            {
                numero = txtnumero.Text,
                nom = txtnom.Text,
                fonction = txtfonction.Text,
                salaire = Int64.Parse(txtsalaire.Text)
            };
            if (nbemploye < 25)
            {
                tabEmployes[nbemploye] = newEmploye;
                nbemploye++;
                lstnumero.Items.Add(newEmploye.numero);
            }
            else
            {
                lstnumero.Items.Add(txtnumero.Text);
            }
            txtnumero.Focus();
            txtsalaire.Text = "";
            txtnumero.Text = "";
            txtnom.Text = "";
            txtfonction.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            
            if (txtnumero.Text == "")
            {
                string msg = "Vous devez selectionner un employe pour avoir le modifier";
                string tit = "Attention ";

                if (MessageBox.Show(msg, tit, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Run();
                }
            }
            else
            {
                int index = Array.IndexOf(tabEmployes, txtnumero.Text);
                lstnumero.Items.RemoveAt(index);

                for (int i = 0; i < nbemploye; i++)
                {
                    if (txtnumero.Text == tabEmployes[i].numero)
                    {
                        tabEmployes[i].numero= txtnumero.Text;
                        tabEmployes[i].nom = txtnom.Text;
                        tabEmployes[i].salaire = Convert.ToInt64(txtsalaire.Text);
                        tabEmployes[i].fonction = txtfonction.Text;
                    } 
                }
            }
        }

        private void btnsauvegarder_Click(object sender, EventArgs e)
        {
            lstnumero.Items.Add(txtnumero.Text);
        }

        private void frmExamFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter fichier = new StreamWriter("Compagnie.txt");
            // for (int i = 0; i < nbemploye; i++)
            // {
            //     fichier.WriteLine(tabEmployes[i].numero);
            //     fichier.WriteLine(tabEmployes[i].nom);
            //     fichier.WriteLine(tabEmployes[i].fonction);
            //     if (i == nbemploye - 1)
            //     {
            //         fichier.Write(tabEmployes[i].salaire);
            //     }
            //     else
            //     {
            //         fichier.WriteLine(tabEmployes[i].salaire);
            //     }
            // }
            try
            {
                using (StreamWriter file = new StreamWriter("Compagnie.txt"))
                {
                    foreach (var employe in tabEmployes)
                    {
                        file.WriteLine(employe.numero);
                        file.WriteLine(employe.nom);
                        file.WriteLine(employe.fonction);
                        file.WriteLine(employe.salaire);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'écriture dans le fichier : {ex.Message}");
            }
            fichier.Close();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            // int indexToRemove = 1;
            // tabEmployes = tabEmployes.Where((source, index) => index != indexToRemove).ToArray();
            if (lstnumero.SelectedItem != null)
            {
                string selectedEmploye = lstnumero.SelectedItem.ToString();
                
                int removed = tabEmployes.RemoveAll(emp => emp.numero == selectedEmploye);
                
                if (removed > 0)  // Vérifier si un employé correspondant a été trouvé et supprimé
                {
                    lstnumero.Items.Remove(selectedEmploye);
                    
                    // Mettre à jour le compteur nbemploye 
                    nbemploye = tabEmployes.Count;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un employé à supprimer.");
            }
        }
    }
}
