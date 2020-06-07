using H2020_TP2_Gestion_Ressources.Outils;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Unite
{
   public  class Agriculteur:UniteSimple
    {

        public Agriculteur(int p_agilite, int p_force = 5) : base(p_force, p_agilite, new Faux(2), 8, 1)
        {
            ;
        }
        public override string ToString()
        {
            return $"Agricultur : vitesse de déplacement :   {this.VitesseDeplacement} .";
        }
    }
}
