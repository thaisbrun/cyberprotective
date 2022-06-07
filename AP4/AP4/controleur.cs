using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    public static class controleur
    {
        private static Modele vmodele;
        public static Modele Vmodele { get => vmodele; }

        public static void init()
        {
            vmodele = new Modele();
        }
    }
}
