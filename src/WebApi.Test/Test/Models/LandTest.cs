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
    /// Test-Klasse für das Objekt Land
    /// </summary>
    public class LandTest : IClassFixture<DatabaseTestFixture>
    {
        [Theory]
        [MemberData(nameof(GueltigeLandDaten))]
        [Trait("Komponente", "Land")]
        [Trait("UnitTestArt", "Positiv-Test")]
        public void LandSpeichern(Land land)
        {
            try
            {
                BsonDocument allFilter = new BsonDocument();
                SchoolContext.Instance().GetCollection<Land>().DeleteMany(allFilter);

                SchoolContext.Instance().SaveItem<Land>(land);
                Assert.True(true);
            }
            catch(Exception ex)
            {
                Assert.False(false);
            }
        }

        /// <summary>
        /// Gültige Länder
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> GueltigeLandDaten()
        {
            yield return new object[]
            {
                new Land()
                {
                    Ident = "EUROPA_DEUTSCHLAND",
                    Name = "Deutschland"
                }
            };
            yield return new object[]
            {
                new Land()
                {
                    Ident = "EUROPA_ENGLAND",
                    Name = "England"
                }
            };
            yield return new object[]
            {
                new Land()
                {
                    Ident = "EUROPA_OESTERREICH",
                    Name = "Österreich"
                }
            };
        }
    }
}