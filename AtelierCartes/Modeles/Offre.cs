using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Offre
    {
        #region attributs
        private int id;
        private int idExemplaire;
        private decimal prix = 0;
        private string statut;
        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("copyId")]
        public int IdExemplaire { get; set; }
        [JsonProperty("price")]
        public decimal Prix { get; set; }
        [JsonProperty("status")]
        public string Statut { get; set; }
        #endregion
    }
}
