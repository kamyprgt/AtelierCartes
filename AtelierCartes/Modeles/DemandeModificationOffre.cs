using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    public class DemandeModificationOffre
    {
        #region attributs
        private decimal prix;

        #endregion

        #region constructeurs
        #endregion

        #region propriétés

        [JsonProperty("price")]
        public decimal Prix { get; set; }
        #endregion
    }
}
