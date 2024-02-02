namespace Produits
{
    internal class Produit
    {
        public int noProduit;
        public String nomProduit;
        public String description;
        public double prix;
        public int quantite;
        public int qteRupture;
        public Boolean taxable;

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






        static void Main(string[] args)
        {
            Console.WriteLine("=================================Produits=================================");

        }
    }
}