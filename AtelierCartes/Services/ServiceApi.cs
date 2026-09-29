using AtelierCartes.Modeles;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Services
{
    public class ServiceApi
    {
        #region Attributs
        private static ServiceApi instance = new ServiceApi();
        private HttpClient client;
        #endregion

        #region Constructeurs
        private ServiceApi()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api-carte-g1.fldsio/");
            client.Timeout = TimeSpan.FromSeconds(15);
        }
        #endregion

        #region Propriétés
        public static ServiceApi Instance
        {
            get { return instance; }
        }
        #endregion

        #region Méthodes
        private async Task<string> LireReponseAsync(HttpResponseMessage reponse)
        { 
            string json = await reponse.Content.ReadAsStringAsync();
            if (!reponse.IsSuccessStatusCode)
            {
                ErreurApi? erreur = null;
                try
                {
                    erreur = JsonConvert.DeserializeObject<ErreurApi>(json);
                }
                catch (JsonException)
                {
                    
                }
                if (reponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new Exception("Connexion refusé ou expiré. Reconnectez-vous.");
                }
                else
                {
                    throw new Exception(erreur?.Message ?? "Le serveur ne peux pas traiter la demande");
                }
            }
        }
        #endregion
    }
}
