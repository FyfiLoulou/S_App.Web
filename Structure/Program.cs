namespace Structure
{

    public struct rvb
    {
        private int rouge, vert, bleu;
        private String nom;

        public void Init(int r, int v, int b, string n)
        {
            R = r;
            V = v;
            B = b;
            N = n;
        }

        public int R
        {
            get { return rouge; }
            set
            {
                R = value;
            }
        }

        public int V
        {
            get { return vert; }
            set
            {
                V = value;
            }
        }

        public int B
        {
            get { return bleu; }
            set
            {
                B = value;
            }
        }

        public string N
        {
            get { return nom; }
            set
            {
                nom = value;
            }
        }


        internal class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("A");
                Console.WriteLine("-----------------------------------------");
                List<rvb> list = new List<rvb>();
                rvb couleur0 = new rvb();
                couleur0.Init(100, 100, 100, "100 partout");
                rvb couleur1 = new rvb();
                couleur1.Init(200, 200, 200, "200 partout");
                list.Add(couleur0);
                Console.WriteLine(list[0].R);
            }


        }
    }
}