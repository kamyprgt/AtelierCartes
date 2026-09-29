using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    public class DemandeCreationOffre
    {
        #region attributs
        private int idExemplaire;
        private decimal prix;

        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("copyId")]
        public int Id { get; set; }

        [JsonProperty("price")]
        public decimal Prix { get; set; }
        #endregion
    }
}
