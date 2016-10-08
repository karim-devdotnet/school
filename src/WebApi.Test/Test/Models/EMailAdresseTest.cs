/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using WebApi.Models;
using Xunit;

namespace WebApi.Test.Models
{
    public class EMailAdresseTest : IClassFixture<TestFixture>
    {
        /// <summary>
        /// Testen der E-Mail-Adresse auf ihre Gültigkeit
        /// </summary>
        [Fact]
        public void ValidEMailAdresse()
        {
            EMailAdresse adresse = new EMailAdresse();
            adresse.Adresse = "test@test.de";
            Assert.True(adresse.IsValid);
        }

        /// <summary>
        /// Testen der E-Mail-Adresse auf ihre Ungültigkeit
        /// </summary>
        [Fact]
        public void InvalidEMailAdresse()
        {
            EMailAdresse adresse = new EMailAdresse();
            adresse.Adresse = "test-test.de";
            Assert.False(adresse.IsValid);
        }
    }
}
