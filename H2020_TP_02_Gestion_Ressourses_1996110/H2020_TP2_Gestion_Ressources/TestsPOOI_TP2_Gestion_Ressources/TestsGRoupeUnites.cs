using H2020_TP2_Gestion_Ressources.Terrain;
using H2020_TP2_Gestion_Ressources.Unite;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestsPOOI_TP2_Gestion_Ressources
{
    public class TestsGRoupeUnites
    {
        [Fact]
        public void TravaillerSur_CasMorceauTerrainNull_Exception()
        {
            //Agir
            UniteSimple unite1 = new Agriculteur(5);
            UniteSimple unite2= new Mineur(3);
            UniteSimple unite3 = new Bucheron(2);
            UniteSimple unite4 = new Mineur(5);
            
            List<Unites> GroupeUnites = new List<Unites>() { unite1,unite2,unite3,unite4};
            MorceauTerrain morceauTerrain = null;
            //Arranger 
            GroupeUnites groupeUnites = new GroupeUnites(GroupeUnites);
            //
            Assert.Throws<ArgumentNullException>(() => { groupeUnites.TravaillerSur(morceauTerrain); }) ;
            

        }
        [Fact]
        public void TravaillerSur_CasGroupeUniteNull_Exception()
        {
            //Agir


            List<Unites> GroupeUnites = null;
            MorceauTerrain morceauTerrain =new MorceauTerrain(20,20,20);
            //Arranger 
            //
            Assert.Throws<ArgumentNullException>(() => { GroupeUnites groupeUnites = new GroupeUnites(GroupeUnites); });


        }


        [Fact]
        public void TravaillerSur_CasNormal_Int()
        {
            //Agir
            UniteSimple unite1 = new Bucheron(2);
            UniteSimple unite2 = new Bucheron(10);
            UniteSimple unite3 = new Bucheron(2);
            UniteSimple unite4 = new Mineur(8);
            UniteSimple unite5 = new Agriculteur(7);
            UniteSimple unite6 = new Bucheron(6);
            UniteSimple unite7 = new Bucheron(5);
            UniteSimple unite8 = new Bucheron(2);
            List<Unites> unites = new List<Unites>() { unite1, unite2, unite3, unite4, unite5, unite6, unite6, unite8 };

            GroupeUnites groupeUnites = new GroupeUnites(unites);

            MorceauTerrain morceau = new MorceauTerrain(33, 20, 10);
            int quantiteCollecteAttendu = 63;
            //Arranger 

            //
            Assert.Equal(quantiteCollecteAttendu,groupeUnites.TravaillerSur(morceau));


        }

    }
}
