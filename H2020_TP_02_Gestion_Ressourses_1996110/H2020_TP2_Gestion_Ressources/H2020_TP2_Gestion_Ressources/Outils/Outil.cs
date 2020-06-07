using H2020_TP2_Gestion_Ressources.Terrain;
using H2020_TP2_Gestion_Ressources.Unite;
using System;

namespace H2020_TP2_Gestion_Ressources.Outils
{
    public class Outil
    {
        private static Random generateurAleatoire = new Random(DateTime.Now.Millisecond);

        public bool EstCasse { get; private set; } = false;
        public double m_probabiliteDefaillance;

        public Outil(double p_probabiliteDefaillance)
        {
            if (p_probabiliteDefaillance < 0 || p_probabiliteDefaillance > 1)
            {
                throw new ArgumentException(nameof(p_probabiliteDefaillance));
            }

            this.m_probabiliteDefaillance = p_probabiliteDefaillance;
        }

        public virtual int Collecter(MorceauTerrain p_morceauTerrain, UniteSimple p_uniteSimple)
        {
            if (p_morceauTerrain is null)
            {
                throw new ArgumentNullException(nameof(p_morceauTerrain));
            }
            if (p_uniteSimple is null)
            {
                throw new ArgumentNullException(nameof(p_uniteSimple));
            }

            return 0;
        }

        public bool AppliqueProbabiliteDeSeCasser()
        {
            this.EstCasse = generateurAleatoire.NextDouble() < this.m_probabiliteDefaillance;

            return this.EstCasse;
        }

        public void Reparer()
        {
            this.EstCasse = false;
        }
    }
}