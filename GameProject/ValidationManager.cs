using GameProject.Entities;
using GameProject.PlayerDetails;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class ValidationManager : IValidationService
    {
        public bool Validate(Player player)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(86087626722, Ad: "ALİ", Soyad: "YILMAZ", DogumYili: 1650))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
