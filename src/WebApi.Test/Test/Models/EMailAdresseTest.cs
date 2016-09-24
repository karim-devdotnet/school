/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using WebApi.Models;
using Xunit;

namespace WebApi.Test.Models
{
    public static class EMailAdresseTest
    {
        /// <summary>
        /// Testen der E-Mail-Adresse auf ihre Gültigkeit
        /// </summary>
        [Fact]
        public static void ValidEMailAdresse()
        {
            EMailAdresse adresse = new EMailAdresse();
            adresse.Adresse = "test@test.de";
            Assert.True(adresse.IsValid);
        }

        /// <summary>
        /// Testen der E-Mail-Adresse auf ihre Ungültigkeit
        /// </summary>
        [Fact]
        public static void InvalidEMailAdresse()
        {
            EMailAdresse adresse = new EMailAdresse();
            adresse.Adresse = "test-test.de";
            Assert.False(adresse.IsValid);
        }
    }
}
