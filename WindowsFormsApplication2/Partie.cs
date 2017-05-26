namespace WindowsFormsApplication2
{
    public class Partie
    {
        public int NbMinesRestantes { get; set; }

        public int NbMinesInitial { get; set; }

        public bool EnCours { get; set; }

        

        public Partie(int nbMinesRestantes, int nbMinesInitial, bool enCours)
        {
            this.NbMinesRestantes = nbMinesRestantes;
            this.NbMinesInitial = nbMinesInitial;
            this.EnCours = enCours;
        }
      
    }
}