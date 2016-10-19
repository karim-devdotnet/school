/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using System.Collections.Generic;
using System.Diagnostics;
using WebApi.Models;
using Xunit;
using Xunit.Extensions;

namespace WebApi.Test.Models
{
    [Collection("E-Mail-Adressen")]
    public class EMailAdresseTest : IClassFixture<DatabaseTestFixture>
    {
        DatabaseTestFixture _fixture;
        public EMailAdresseTest(DatabaseTestFixture fixture)
        {
            _fixture = fixture;
            _fixture.TestClassName = nameof(EMailAdresseTest);
        }

        /// <summary>
        /// Eine Theorie für gültige E-Mail-Adresse
        /// </summary>
        /// <param name="emailadresse"></param>
        [Theory, MemberData(nameof(GueltigeEMailAdressdaten))]
        [Trait("Komponente", "EMailAdresse")]
        [Trait("UnitTestArt", "Positiv-Test")]
        public void GueltigeEMailAdressen(string emailadresse)
        {
            EMailAdresse adresse = new EMailAdresse();
            adresse.Adresse = emailadresse;
            Assert.True(adresse.IstGueltig);
        }

        /// <summary>
        /// Gültige E-Mail-Adressen
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> GueltigeEMailAdressdaten()
        {
            yield return new object[] { "test@test.de" };
            yield return new object[] { "test-test@test.de" };
            yield return new object[] { "test@test-test.de" };
            yield return new object[] { "test-test@test-test.de" };
        }

        /// <summary>
        /// Eine Theorie für ungültige EMail-Adresse
        /// </summary>
        /// <param name="emailadresse"></param>
        [Theory, MemberData(nameof(UngueltigeEMailAdressdaten))]
        [Trait("Komponente", "EMailAdresse")]
        [Trait("UnitTestArt", "Negativ-Test")]
        public void UngueltigeEMailAdressen(string emailadresse)
        {
            EMailAdresse adresse = new EMailAdresse();
            adresse.Adresse = emailadresse;
            Assert.False(adresse.IstGueltig);
        }

        /// <summary>
        /// Ungültige E-Mail-Adressen
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> UngueltigeEMailAdressdaten()
        {
            yield return new object[] { "test@testde" };
            yield return new object[] { "test-test.de" };
            yield return new object[] { "test-testde" };
            yield return new object[] { "test@@testde" };
            yield return new object[] { "test@@test.de" };
            yield return new object[] { "testattest.de" };
        }
    }
}
