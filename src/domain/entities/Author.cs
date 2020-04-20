using System.Collections.Generic;
using System.Linq;
using domain.utils;

namespace domain.entities
{
    public class Author
    {
        private readonly string FullName;
        public IEnumerable<string> SpecialLastnames { get; }
        public string FormatedName
        {
            get
            {
                var nameFragments = new Stack<string>(FullName.Split(' '));
                if (nameFragments.Count == 1)
                {
                    return nameFragments.Pop().ToUpper();
                }

                var lastName = nameFragments.Pop().ToUpper();
                lastName = SpecialLastnames.Contains(lastName) ? $"{nameFragments.Pop().ToUpper()} {lastName}" : lastName;

                var firstNames = nameFragments.Reverse().Select(_ => Prepositions.Contains(_) ? _.ToLower() : _.Capitalize());

                return $"{lastName.ToUpper()}, {string.Join(" ", firstNames)}";
            }
        }
        public IEnumerable<string> Prepositions { get; }

        public Author(
            string fullName,
            IEnumerable<string> SpecialLastnames = null,
            IEnumerable<string> prepositions = null)
        {
            this.FullName = fullName;
            this.SpecialLastnames = SpecialLastnames ?? (new[] {
                "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR"
            });

            this.Prepositions = prepositions ?? (new[] {
                "da", "de", "do", "das", "dos"
            });
        }

    }
}