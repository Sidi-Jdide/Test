using System;
using System.Collections.Generic;
using System.Text;

namespace H2020_TP2_Gestion_Ressources.Terrain
{
    public class MorceauTerrain
    {
        public int QuantiteBois { get; private set; }
        public int QuantiteMinerai { get; private set; }
        public int QuantiteCereales { get; private set; }

        public MorceauTerrain(int p_quantiteBois, int p_quantiteMinerai, int p_quantiteCereale)
        {
            if (p_quantiteBois < 0)
            {
                throw new ArgumentException(nameof(p_quantiteBois));
            }
            if (p_quantiteMinerai < 0)
            {
                throw new ArgumentException(nameof(p_quantiteMinerai));
            }
            if (p_quantiteCereale < 0)
            {
                throw new ArgumentException(nameof(p_quantiteCereale));
            }
            this.QuantiteBois = p_quantiteBois;
            this.QuantiteMinerai = p_quantiteMinerai;
            this.QuantiteCereales = p_quantiteCereale;
        }

        public int CollecterBois(int p_quantiteCollectee)
        {
            if (p_quantiteCollectee < 0)
            {
                throw new ArgumentException(nameof(p_quantiteCollectee));
            }

            if (p_quantiteCollectee > this.QuantiteBois)
            {
                p_quantiteCollectee = this.QuantiteBois;
            }

            this.QuantiteBois -= p_quantiteCollectee;

            return p_quantiteCollectee;
        }

        public int CollecterMinerai(int p_quantiteCollectee)
        {
            if (p_quantiteCollectee < 0)
            {
                throw new ArgumentException(nameof(p_quantiteCollectee));
            }

            if (p_quantiteCollectee > this.QuantiteMinerai)
            {
                p_quantiteCollectee = this.QuantiteMinerai;
            }

            this.QuantiteMinerai -= p_quantiteCollectee;

            return p_quantiteCollectee;
        }

        public int CollecterCereales(int p_quantiteCollectee)
        {
            if (p_quantiteCollectee < 0)
            {
                throw new ArgumentException(nameof(p_quantiteCollectee));
            }

            if (p_quantiteCollectee > this.QuantiteCereales)
            {
                p_quantiteCollectee = this.QuantiteCereales;
            }

            this.QuantiteCereales -= p_quantiteCollectee;

            return p_quantiteCollectee;
        }
    }
}
