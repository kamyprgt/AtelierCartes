using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    public class ErreurApi
    {
        #region attributs
        private string message = "Erreur API";

        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("message")]
        public string Message { get; set; }
        #endregion
    }
}
