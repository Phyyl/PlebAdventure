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
    }
}
