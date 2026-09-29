using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Portfeuille : ObservableObject
    {
        #region attributs
        private ObservableCollection<CartePossedee> cartesPossedees;
        #endregion

        #region constructeurs
        #endregion

        #region propriétés
        [JsonProperty("positions")]
        public ObservableCollection<CartePossedee> CartesPossedees { get; set; }
        #endregion
    }
}
