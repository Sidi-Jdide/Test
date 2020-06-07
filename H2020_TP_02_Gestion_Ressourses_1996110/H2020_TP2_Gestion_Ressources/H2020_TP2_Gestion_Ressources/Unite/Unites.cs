using H2020_TP2_Gestion_Ressources.Terrain;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Unite
{
    public class Unites
    {
        public virtual int VitesseDeplacement { get { return 0;  } }
        public int CoutEntretien { get; } = 1;

        public Unites(int p_coutEntretien)
        {
            if (p_coutEntretien < 0)
            {
                throw new ArgumentException(nameof(p_coutEntretien));
            }

            this.CoutEntretien = p_coutEntretien;
        }
         
        public virtual int TravaillerSur(MorceauTerrain p_morceauTerrain)
        {
            return 0;
        }
    }
}
