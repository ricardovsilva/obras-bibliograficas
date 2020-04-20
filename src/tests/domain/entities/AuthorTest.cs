using Microsoft.VisualStudio.TestTools.UnitTesting;

using FluentAssertions;

using domain.entities;

namespace tests.domain.entities
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void GetFormatedName_GivenSingleName_ReturnsNameUppercased()
        {
            var author = new Author("Guimaraes");
            author.FormatedName.Should().Be("GUIMARAES");
        }

        [TestMethod]
        public void GetFormatedName_GivenFullNameWithSpecialSecondLast_ReturnsSecondLastAndLastTogether()
        {
            var author = new Author("Joao Silva Neto");
            author.FormatedName.Should().Be("SILVA NETO, Joao");
        }

        [TestMethod]
        public void GetFormatedName_GivenASimpleFullName_ReturnsLastNameUppercasedInFront()
        {
            var author = new Author("Ricardo Verdade Silva");
            author.FormatedName.Should().Be("SILVA, Ricardo Verdade");
        }

        [TestMethod]
        public void GetFormatedName_GivenFullNameInLowerCase_ReturnsFirstLetterUppercased()
        {
            var author = new Author("ricardo verdade silva");
            author.FormatedName.Should().Be("SILVA, Ricardo Verdade");
        }

        [TestMethod]
        public void GetFormatedName_GivenFullNameWithPreposition_PrepositionShouldNotBeUppercased()
        {
            var author = new Author("Ricardo da Verdade Silva");
            author.FormatedName.Should().Be("SILVA, Ricardo da Verdade");
        }

        [TestMethod]
        public void GetFormatedName_GivenFullNameEntirelyInLowerCase_ReturnsFormatedName()
        {
            var author = new Author("ricardo da verdade silva");
            author.FormatedName.Should().Be("SILVA, Ricardo da Verdade");
        }

        [TestMethod]
        public void GetSpecialSecondLastNames_WithoutProvideAnyInConstructor_ReturnsDefaultList()
        {
            var author = new Author("foo");
            author.SpecialSecondLastNames.Should().BeEquivalentTo(new string[] {
                "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR"
            });
        }

        [TestMethod]
        public void GetSpecialSecondLastNames_ProvidingNamesInConstructor_ReturnsProvidenNames()
        {
            var author = new Author("foo", new string[] { "FOO", "GEEZ" });
            author.SpecialSecondLastNames.Should().BeEquivalentTo(new string[] {
                "FOO", "GEEZ"
            });
        }

        [TestMethod]
        public void GetPrepositions_WithoutProvideAnyInConstructor_ReturnsDefaultList()
        {
            var author = new Author("foo");
            author.Prepositions.Should().BeEquivalentTo(new string[] {
                "da", "de", "do", "das", "dos"
            });
        }

        [TestMethod]
        public void GetPrepositions_ProvidingPrepositionsInConstructor_ReturnsProvidenPrepositions()
        {
            var author = new Author("foo", prepositions: new string[] { "bar", "geez" });
            author.Prepositions.Should().BeEquivalentTo(new string[] {
                "bar", "geez"
            });
        }
    }
}