using H2020_TP2_Gestion_Ressources.Terrain;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Unite
{
   public class GroupeUnites: Unites
    {
        
        public List<Unites> GroupesUnites { get; set; }
        public override int VitesseDeplacement { get;}

        public GroupeUnites(List<Unites> p_groupeUnites,int p_coutEntretien=1) : base(p_coutEntretien)
        {
            if (p_groupeUnites==null)
            {
                throw new ArgumentNullException("La liste des unites ne doit pas être nul",nameof(p_groupeUnites));
            }
            this.GroupesUnites = p_groupeUnites;
        }
        public override int TravaillerSur(MorceauTerrain p_morceauTerrain)
        {
            if (p_morceauTerrain==null)
            {
                throw new ArgumentNullException("Le morceau terrain ne doit pas etre négative ",nameof(p_morceauTerrain));
            }
            int quantiteCollecte = 0;
            foreach (Unites unite in this.GroupesUnites)
            {
               quantiteCollecte+= unite.TravaillerSur(p_morceauTerrain);
            }

            return quantiteCollecte;
        }
        public override string ToString()
        {
            string unite = "";
            int nombreUnites = GroupesUnites.Count;
            foreach (var uniteCourant in this.GroupesUnites)
            {
                unite +=uniteCourant +"\n";
            }
            return $"Nombre d'unités ({nombreUnites})\n{unite.ToString()}Fin group";
        }
// voir l'exempe d'utilisation dans main 
    }
}
