/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using MongoDB.Bson;
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
    public class AdresseTest : IClassFixture<DatabaseTestFixture>
    {
        [Theory, MemberData(nameof(GueltigeAdresseDaten))]
        [Trait("Komponente", "Adresse")]
        [Trait("UnitTestArt", "Positiv-Test")]
        public void AdresseSpeichern(Adresse adresse)
        {
            try
            {
                BsonDocument allFilter = new BsonDocument();
                SchoolContext.Instance().GetCollection<Adresse>().DeleteMany(allFilter);

                SchoolContext.Instance().SaveItem<Adresse>(adresse);
                Assert.True(true);
            }
            catch(Exception)
            {
                Assert.False(false);
            }
        }

        /// <summary>
        /// Test für gültige Adressen
        /// </summary>
        /// <param name="adresse"></param>
        [Theory, MemberData(nameof(GueltigeAdresseDaten))]
        [Trait("Komponente", "Adresse")]
        [Trait("UnitTestArt", "Positiv-Test")]
        public void GueltigeAdresse(Adresse adresse)
        {
            Assert.True(adresse.IstGueltig);
        }

        /// <summary>
        /// Gültige E-Mail-Adressen
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> GueltigeAdresseDaten()
        {
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = "Musterstraße",
                    Hausnummer = "42",
                    Bundesland = new Bundesland() { Ident = "EUROPA_DEUTSCHLAND_SACHSEN", Name = "Sachsen", Land = new WebApi.Models.Land() { Ident = "EUROPA_DEUTSCHLAND", Name = "Deutschland" } },
                    Ort = "Musterhausen",
                    Postleitzahl = "12345"
                }
            };
        }


        /// <summary>
        /// Test für ungültige Adressen
        /// </summary>
        /// <param name="adresse"></param>
        [Theory, MemberData(nameof(UngueltigeAdresseDaten))]
        [Trait("Komponente", "Adresse")]
        [Trait("UnitTestArt", "Negativ-Test")]
        public void UngueltigeAdresse(Adresse adresse)
        {
            Assert.False(adresse.IstGueltig);
        }

        /// <summary>
        /// Ungültige E-Mail-Adressen
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> UngueltigeAdresseDaten()
        {
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = "Musterstraße",
                    Bundesland = new Bundesland() { Ident = "EUROPA_DEUTSCHLAND_SACHSEN", Name = "Sachsen", Land = new Land() { Ident = "EUROPA_DEUTSCHLAND", Name = "Deutschland" } },
                    Ort = "Musterhausen",
                    Postleitzahl = "12345"
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Bundesland = new Bundesland() { Ident = "EUROPA_DEUTSCHLAND_SACHSEN", Name = "Sachsen", Land = new Land() { Ident = "EUROPA_DEUTSCHLAND", Name = "Deutschland" } },
                    Ort = "Musterhausen",
                    Postleitzahl = "12345"
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Bundesland = new Bundesland() { Ident = "EUROPA_DEUTSCHLAND_SACHSEN", Name = "Sachsen", Land = new Land() { Ident = "EUROPA_DEUTSCHLAND", Name = "Deutschland" } },
                    Postleitzahl = "12345"
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Bundesland = new Bundesland() { Ident = "EUROPA_DEUTSCHLAND_SACHSEN", Name = "Sachsen", Land = new Land() { Ident = "EUROPA_DEUTSCHLAND", Name = "Deutschland" } }
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = "Musterstraße",
                    Hausnummer = "42",
                    Ort = "Musterhausen",
                    Postleitzahl = "12345"
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = "Musterstraße",
                    Hausnummer = "42",
                    Ort = "Musterhausen",
                    Postleitzahl = "1234"
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = "",
                    Hausnummer = "",
                    Ort = "",
                    Postleitzahl = ""
                }
            };
            yield return new object[]
            {
                new Adresse()
                {
                    Strasse = " ",
                    Hausnummer = " ",
                    Bundesland = new Bundesland() { Ident = "EUROPA_DEUTSCHLAND_SACHSEN", Name = "Sachsen", Land = new WebApi.Models.Land() { Ident = "EUROPA_DEUTSCHLAND", Name = "Deutschland" } },
                    Ort = " ",
                    Postleitzahl = " "
                }
            };
        }
    }
}
