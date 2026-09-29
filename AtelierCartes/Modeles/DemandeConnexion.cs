using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class DemandeConnexion
    {
        #region attributs
        private int identifiant;
        private string motDePasse;

        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("username")]
        public int Id { get; set; }

        [JsonProperty("password")]
        public string MotDePasse { get; set; }
        #endregion
    }
}
