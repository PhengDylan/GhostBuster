using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainFrame());*/
           // Partie p = new Partie(1,2,true);
            Plateau plateau = new Plateau(10, 7);
            plateau.GenerateGrille();
            plateau.FillMines(15);
            Console.WriteLine(plateau.ToString());
        }

    }
}
