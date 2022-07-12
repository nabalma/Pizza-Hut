using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsIntroductionAsp.Net_Reprise_2_
{
    public partial class WebPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            txtAdresseLivraison.Visible = false;
            lblAdresseLivraison.Visible=false;
            panCommande.Visible = false;

            if (Page.IsPostBack==false) // Cest sa premiere fois de loader la page
            {
                panPrix.Visible = false;

                remplirPizza();
                remplirTaillePizza();
                remplirGarnitures();
                remplirCroute();
            }

            calculerPrix();
           
        }

        protected void chkLivraison_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLivraison.Checked)
            {
                txtAdresseLivraison.Visible = true;
                lblAdresseLivraison.Visible = true;

            }
        }

        // Remplir la liste des pizzas
        private void remplirPizza()
        {
            ListItem pizza1 = new ListItem("Choisir une pizza", "0");
            lstPizza.Items.Add(pizza1);
            lstPizza.SelectedIndex = 0;

            ListItem pizza2 = new ListItem("La Napolitana", "10");
            lstPizza.Items.Add(pizza2);

            ListItem pizza3 = new ListItem("La Vegetarienne", "8");
            lstPizza.Items.Add(pizza3);

            ListItem pizza4 = new ListItem("La Quebequoise", "12");
            lstPizza.Items.Add(pizza4);

            ListItem pizza5 = new ListItem("La Halal", "5");
            lstPizza.Items.Add(pizza5);
        }


        // Remplir la taille des pizzas
        private void remplirTaillePizza()
        {
            ListItem taille1 = new ListItem("Petite", "1");
            lstTaillePizza.Items.Add(taille1);
            lstTaillePizza.SelectedIndex = 0;

            ListItem taille2 = new ListItem("Moyenne", "1,5");
            lstTaillePizza.Items.Add(taille2);

            ListItem taille3 = new ListItem("Grande", "2");
            lstTaillePizza.Items.Add(taille3);

            
        }

        protected void lstPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPizza.SelectedIndex!=0)
            {
                panPrix.Visible = true;
            }
        }

        private void calculerPrix()
        {
            decimal prixdebase, livraison = 0, garnitures = 0, croute = 0, soustotal, total, taxes;

           // ** Prix de base **
           prixdebase = Convert.ToDecimal(lstPizza.SelectedItem.Value);
           prixdebase *= Convert.ToDecimal(lstTaillePizza.SelectedItem.Value);


            litPrix.Text = "Prix de base : " + prixdebase + " $" + "</br>";

            // ** Livraison **
            if (chkLivraison.Checked)
            {
                livraison =Convert.ToDecimal(5);
                litPrix.Text += "Livraison : " + livraison+ " $" + "</br>";
            }

            // ** Garniture **
            foreach (ListItem garniture in lstChkGarnitures.Items)
            {
                if (garniture.Selected)
                {
                    garnitures += Convert.ToDecimal(garniture.Value);
                }

            }
            litPrix.Text += "Garnitures : " + garnitures + " $" + "</br>";

            // ** Croutes **

            croute = Convert.ToDecimal(lstRadCroute.SelectedItem.Value.Substring(0,1));
            litPrix.Text += "Croute : " + croute + "</br>";


            // ** Sous Total **
            litPrix.Text += "------------------------------" + "</br>";
            soustotal = prixdebase + livraison + garnitures + croute;
            litPrix.Text += "Sous Total : " + soustotal +" $" + "</br>";
            
            // ** Taxes **
            taxes = soustotal * 0.14m;
            litPrix.Text += "Taxes : " + taxes + " $"+ "</br>";

            // ** Total **
            litPrix.Text += "------------------------------"+ "</br>";
            total = soustotal + taxes;
            litPrix.Text += "Total : " + total + " $";

        }


        private void remplirGarnitures() {
            lstChkGarnitures.Items.Add(new ListItem("Champignons (1 $)", "1"));
            lstChkGarnitures.Items.Add(new ListItem("Bacon Halal (2,5 $)", "2,5"));
            lstChkGarnitures.Items.Add(new ListItem("Extra Fromage (1,5 $)", "1,5"));
            lstChkGarnitures.Items.Add(new ListItem("Peperoni (2,5 $)", "2,5"));
        }

        private void remplirCroute() {

            lstRadCroute.Items.Add(new ListItem("Normal ", "0-1"));lstRadCroute.Items[0].Selected = true;
            lstRadCroute.Items.Add(new ListItem("Epaisse ", "0-2"));
            lstRadCroute.Items.Add(new ListItem("Mince ", "0-3"));           

        }
        private void afficherCommande()
        {
            
            litCommande.Text = "La commande d'une " + lstTaillePizza.SelectedItem.ToString()+ "</br>";
            litCommande.Text += "pizza " + lstPizza.SelectedItem.ToString()+ " sur une " + "</br>";
            litCommande.Text += "croûte " + lstRadCroute.SelectedItem + "par " + txtNomComplet.Text+ "</br>";
            if (chkLivraison.Checked)
            {
                litCommande.Text += "A être livré au " + "</br>"; 
                litCommande.Text += txtAdresseLivraison.Text + "</br>";
                litCommande.Text += txtTelephone.Text + "</br>";
            }
            if (true)
            {
                litCommande.Text += "Garnitures : " + "</br>";
                foreach (ListItem garniture in lstChkGarnitures.Items)
                {
                    if (garniture.Selected)
                    {
                        litCommande.Text +="&#9635" +garniture.Text +"</br>";
                    }

                }

            }

           
           



        }



        protected void btnCommande_Click(object sender, EventArgs e)
        {
            panCommande.Visible = true;
            afficherCommande();
        }
    }
}