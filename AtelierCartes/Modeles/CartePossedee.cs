using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    public class CartePossedee
    {
        #region attributs
        private int id;
        private Carte carte = new Carte();
        private decimal valeurActuelle = 0;

        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("card")]
        public Carte Carte { get; set; }

        [JsonProperty("currentValue")]
        public decimal ValeurActuelle { get; set; }
        #endregion
    }
}
