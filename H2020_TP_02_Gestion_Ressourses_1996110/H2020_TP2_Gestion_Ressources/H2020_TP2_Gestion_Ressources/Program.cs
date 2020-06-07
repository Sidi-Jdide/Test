using H2020_TP2_Gestion_Ressources.Terrain;
using H2020_TP2_Gestion_Ressources.Unite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2020_TP2_Gestion_Ressources
{
    class Program
    {
        static void Main(string[] args)
        {
            UniteSimple unite1 = new Bucheron(2);
            UniteSimple unite2 = new Bucheron(10);
            UniteSimple unite3 = new Bucheron(2);
            UniteSimple unite4 = new Mineur(8);
            UniteSimple unite5 = new Agriculteur(7);
            UniteSimple unite6 = new Bucheron(6);
            UniteSimple unite7 =  new Bucheron (5);
            UniteSimple unite8 = new Bucheron(2);
            List<Unites> unites = new List<Unites>() {unite1, unite2, unite3, unite4, unite5, unite6, unite6, unite8 };

            GroupeUnites groupeUnites = new GroupeUnites(unites);

            MorceauTerrain morceau = new MorceauTerrain(33,20,10);
            Console.WriteLine("Quantite ressource collectés : "+groupeUnites.TravaillerSur(morceau));
            Console.WriteLine();
            Console.WriteLine(groupeUnites.ToString());
        
        }
    }
}
