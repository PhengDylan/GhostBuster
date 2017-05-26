namespace WindowsFormsApplication2
{
    public class Case
    {
        private bool _decouvert;
        private int _valeurCase;

        public Case(bool decouvert, int valeurCase)
        {
            this.Decouvert = decouvert;
            this.ValeurCase = valeurCase;
        }

        public bool Decouvert
        {
            get { return _decouvert; }
            set { _decouvert = value; }
        }

        public int ValeurCase
        {
            get { return _valeurCase; }
            set { _valeurCase = value; }
        }
    }
}