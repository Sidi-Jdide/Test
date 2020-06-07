using H2020_TP2_Gestion_Ressources.Outils;
using H2020_TP2_Gestion_Ressources.Terrain;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Unite
{
    public class UniteSimple : Unites
    {
        public int Force { get; private set; }
        public int Agilite { get; private set; }
        public override int VitesseDeplacement { get; }


        private Outil m_outil;

        public UniteSimple(int p_force, int p_agilite, Outil p_outil, int p_vitesse, int p_coutEntretien) : base(p_coutEntretien)
        {
            if (p_force < 0)
            {
                throw new ArgumentException(nameof(p_force));
            }
            if (p_agilite < 0)
            {
                throw new ArgumentException(nameof(p_agilite));
            }
            if (p_outil is null)
            {
                throw new ArgumentException(nameof(p_outil));
            }
            if (p_vitesse < 0)
            {
                throw new ArgumentException(nameof(p_vitesse));
            }
            
            this.Force = p_force;
            this.Agilite = p_agilite;
            this.m_outil = p_outil;
            this.VitesseDeplacement = p_vitesse;
        }

        public void ReparerOutil()
        {
            this.m_outil.Reparer();
        }

        public override int TravaillerSur(MorceauTerrain p_morceauTerrain)
        {
            int quantiteCollectee = 0;
            if (this.m_outil.EstCasse)
            {
                this.m_outil.Reparer();
            } 
            else
            {
                quantiteCollectee += this.m_outil.Collecter(p_morceauTerrain, this);
            }

            return quantiteCollectee;
        }
        
    }
}
