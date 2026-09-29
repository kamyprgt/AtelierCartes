using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AtelierCartes.Modeles
{
    public class ReponseOffres
    {
        #region attributs
        private ObservableCollection<Offre> offres;
        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("items")]
        public ObservableCollection<Offre> Offres { get; set; }
        #endregion
    }
}
