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
        public int getNoProduit() {  return noProduit; }
        public String getNomProduit() { return nomProduit; }
        public String getDescription() { return description; }
        public double getPrix() {  return prix; }
        public int getQuantite() {  return quantite; }
        public int getQteRupture() {  return qteRupture; }
        public Boolean getTaxable() { return taxable; }

        //setters
        public void setNoProduit(int noProduit) { this.noProduit = noProduit; }
        public void setNomProduit(String nomProduit) { this.nomProduit = nomProduit; }
        public void setDescription(String description) { this.description = description; }
        public void setPrix(double prix) {  this.prix = prix; }
        public void setQuantite(int quantite) { this.quantite = quantite; }
        public void setQteRupture(int qteRupture) { this.qteRupture = qteRupture; }
        public void setTaxable(Boolean taxable) { this.taxable = taxable; }

        public override string ToString()
        {
            return "Numéro du produit: " + noProduit
                + "\nNom du produit: " + nomProduit
                + "\nDescription: " + description
                + "\nPrix: " + prix + "$"
                + "\nQuantité: " + quantite
                + "\nQuantité de la rupture: " + qteRupture
                + "\nTaxable: " + taxable;
        }

        






        static void Main(string[] args)
        {
            Console.WriteLine("=================================Produits=================================");

            Produit rtx = new Produit(1,"RTX4090ti");

            Console.WriteLine(rtx);

        }
    }
}