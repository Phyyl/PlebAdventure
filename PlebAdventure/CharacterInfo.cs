using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure
{
    public record CharacterInfo
    {
        public CharacterClass Class { get; init; }
        public string FirstName { get; init; }
        public string MiddleName { get; init; }
        public string LastName { get; init; }

        public CharacterInfo(CharacterClass @class, string firstName, string middleName, string lastName)
        {
            Class = @class ?? throw new ArgumentNullException(nameof(@class));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
    }
}
