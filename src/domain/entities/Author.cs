using System.Collections.Generic;

namespace domain.entities
{
    public class Author
    {
        private readonly string FullName;
        public IEnumerable<string> SpecialSecondLastNames { get; }
        public string FormatedName { get; }
        public IEnumerable<string> Prepositions { get; }

        public Author(
            string fullName,
            IEnumerable<string> specialSecondLastNames = null,
            IEnumerable<string> prepositions = null)
        {
            this.FullName = fullName;
            this.SpecialSecondLastNames = specialSecondLastNames ?? (new[] {
                "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR"
            });

            this.Prepositions = prepositions ?? (new[] {
                "da", "de", "do", "das", "dos"
            });
        }

    }
}