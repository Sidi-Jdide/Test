using H2020_TP2_Gestion_Ressources.Outils;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Unite
{
   public  class Mineur:UniteSimple
    {
        public Mineur(int p_agilite, int p_force = 5) : base(p_force, p_agilite, new Pioche(4), 5, 1)
        {
            ;
        }
        public override string ToString()
        {
            return $"Mineur : vitesse de déplacement :  { this.VitesseDeplacement} .";
        }
    }
}
