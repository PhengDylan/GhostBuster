using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApplication2
{
    public class Plateau
    {
        private int _largeur;
        private int _longueur;
        private Case[,] _casesPlateau;

        public Plateau(int largeur, int longueur)
        {
            this._largeur = largeur;
            this._longueur = longueur;
            this._casesPlateau = new Case[_largeur,_longueur];
        }

        public void GenerateGrille()
        {
            for (int i = 0; i < _largeur; i++)
            {
                for (int j = 0; j < _longueur; j++)
                {
                    _casesPlateau[i,j] = new Case(false, 0);
                }
            }
        }

        public void FillMines(int NbMines)
        {
            int x;
            int y;
            int indice = 0;
            Random rnd = new Random();
            while (indice < NbMines)
            {
                x = rnd.Next(0, _largeur);
                y = rnd.Next(0, _longueur);
                if (_casesPlateau[x,y].ValeurCase == 0)
                {
                    _casesPlateau[x,y].ValeurCase = 1;
                    indice++;
                }
            }
        }

       
        public override String ToString()
        {
            String msg = "";
            for (int i = 0; i < _largeur; i++)
            {
                msg += "\n";
                for (int j = 0; j < _longueur; j++)
                {
                    msg += this._casesPlateau[i,j].ValeurCase.ToString();
                }                
            }
            return msg;
        }
    }
}