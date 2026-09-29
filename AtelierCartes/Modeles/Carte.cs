using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Carte
    {
        #region attributs
        private int id;
        private string marque;
        private string modele;
        private decimal variante;

        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("brand")]
        public string Marque { get; set; }

        [JsonProperty("model")]
        public string Modele { get; set; }

        [JsonProperty("variant")]
        public decimal Variante { get; set; }
        #endregion

    }
}
