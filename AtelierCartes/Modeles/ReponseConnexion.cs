using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    public class ReponseConnexion
    {
        #region attributs
        private string jetonAcces;

        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("accessToken")]
        public string JetonAcces { get; set; }
        #endregion
    }
}
