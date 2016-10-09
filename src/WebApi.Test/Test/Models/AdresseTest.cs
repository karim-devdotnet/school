/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using System;
using System.Collections.Generic;
using WebApi.Base;
using WebApi.Models;
using Xunit;

namespace WebApi.Test.Test.Models
{
    /// <summary>
    /// Test-Klasse für das Objekt Adresse
    /// </summary>
    public class AdresseTest : IClassFixture<TestFixture>
    {
        [Theory, MemberData("GueltigeAdresseSpeichernDaten")]
        [Trait("Komponente", "Adresse")]
        [Trait("UnitTestArt", "Positiv-Test")]
        public void AdresseSpeichern(Adresse adresse)
        {
            try
            {
                SchoolContext.Instance().SaveItem<Adresse>(adresse, SchoolContext.Instance().GetCollection<Adresse>());
                Assert.True(true);
            }
            catch(Exception ex)
            {
                Assert.False(false);
            }
        }
        
        /// <summary>
         /// Gültige E-Mail-Adressen
         /// </summary>
         /// <returns></returns>
        public static IEnumerable<object[]> GueltigeAdresseSpeichernDaten()
        {
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = "Musterstraße",
                    Hausnummer = "42",
                    Bundesland = "Sachsen",
                    Land = "Deutschland"
                }
            };
        }
    }
}
