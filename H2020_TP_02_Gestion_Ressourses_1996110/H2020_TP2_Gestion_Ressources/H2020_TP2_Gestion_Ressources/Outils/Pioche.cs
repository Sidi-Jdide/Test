using H2020_TP2_Gestion_Ressources.Terrain;
using H2020_TP2_Gestion_Ressources.Unite;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Outils
{
    public class Pioche : Outil
    {
        private int m_force;

        public Pioche(int p_force) : base(0.2)
        {
            if (p_force <= 0)
            {
                throw new ArgumentException(nameof(p_force));
            }

            this.m_force = p_force;
        }

        public override int Collecter(MorceauTerrain p_morceauTerrain, UniteSimple p_uniteSimple)
        {
            if (p_morceauTerrain is null)
            {
                throw new ArgumentNullException(nameof(p_morceauTerrain));
            }
            if (p_uniteSimple is null)
            {
                throw new ArgumentNullException(nameof(p_uniteSimple));
            }

            if (this.EstCasse)
            {
                throw new InvalidOperationException();
            }

            int quantiteCollectee = p_morceauTerrain.CollecterMinerai((p_uniteSimple.Force + p_uniteSimple.Agilite) * this.m_force);

            this.AppliqueProbabiliteDeSeCasser();

            return quantiteCollectee;
        }
    }
}
