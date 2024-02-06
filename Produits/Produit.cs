using System.Reflection.Metadata;

namespace Produits
{
    internal class Produit
    {
        //attributs
        private int noProduit;
        private String nomProduit;
        private String description;
        private double prix;
        private int quantite;
        private int qteRupture;
        private Boolean taxable;

        private double PRIX_MIN = 0;
        private double PRIX_MAX = 500;
        private int QTE_MIN = 0;
        private int QTE_MAX = 200;

        //constructor
        public Produit(int noProduits, String nomProduits)
        {
            noProduit = noProduits;
            nomProduit = nomProduits;
            description = "";
            prix = 0;
            quantite = 0;
            qteRupture = 0;
            taxable = false;
        }

        //getters
        public int getNoProduit() { return noProduit; }
        public String getNomProduit() { return nomProduit; }
        public String getDescription() { return description; }
        public double getPrix() { return prix; }
        public int getQuantite() { return quantite; }
        public int getQteRupture() { return qteRupture; }
        public Boolean getTaxable() { return taxable; }

        //setters
        public void setNoProduit(int noProduit) { this.noProduit = noProduit; }
        public void setNomProduit(String nomProduit) { this.nomProduit = nomProduit; }
        public void setDescription(String description) { this.description = description; }
        public void setPrix(double prix) 
        { 
            if (prix >= PRIX_MIN && prix <= PRIX_MAX) { this.prix = prix; }

            else if (prix < PRIX_MIN) { Console.WriteLine("\n!!!prix trop petit!!!\n");}

            else if (prix > PRIX_MAX){ Console.WriteLine("\n!!!prix trop grand!!!\n");}

            else { Console.WriteLine("\n!!!Erreur!!!\n");}
             
        }
        public void setQuantite(int quantite) 
        {
            if (quantite >= QTE_MIN && quantite <= QTE_MAX) { this.quantite = quantite; }

            else if (quantite < QTE_MIN) { Console.WriteLine("\n!!!quantite trop petit!!!\n"); }

            else if (quantite > QTE_MAX) { Console.WriteLine("\n!!!quantite trop grand!!!\n"); }

            else { Console.WriteLine("\n!!!Erreur!!!\n"); }
        }
        public void setQteRupture(int qteRupture) { this.qteRupture = qteRupture; }
        public void setTaxable(Boolean taxable) { this.taxable = taxable; }

        //toString
        public override string ToString()
        {
            return "Numéro du produit: " + noProduit
                + "\nNom du produit: " + nomProduit
                + "\nDescription: " + description
                + "\nPrix: " + prix + "$"
                + "\nQuantité: " + quantite
                + "\nQuantité de la rupture: " + qteRupture
                + "\nTaxable: " + taxable
                + "\nValeur en stock: " + total() + "$";
        }

        //méthodes
        public double total()
        {
            return this.quantite * this.prix;
        }





        static void Main(string[] args)
        {
            Console.WriteLine("=================================Produits=================================");

            Produit rtx = new Produit(1, "RTX4090ti");
            rtx.setDescription("Carte graphique");
            rtx.setPrix(500);
            rtx.setQuantite(20);
            rtx.setTaxable(true);


            Console.WriteLine(rtx);
            
            


        }
    }
}