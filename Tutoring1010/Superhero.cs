using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring1010
{
    class Superhero
    {
        //fields
        private string secretIdentity;
        private bool hasCape;
        private int strengthLevel;
        private string archnemesis;
        ////private string planetOfOrigin under invisibility cloak

        //Properties
        public string SecretIdentity { get; set; }
        public bool HasCape { get; set; }
        //public string PlanetOfOrigin { get; set; }
        public int StrengthLevel { get; set; }
        public string Archnemesis { get; set; }

        //Constructors
        public Superhero()
        {

        }

        public Superhero(string secretIdentity, bool hasCape)
        {
            this.secretIdentity = secretIdentity;
            this.hasCape = hasCape;
            strengthLevel = 16;
            archnemesis = "Lex Luthor";
        }

        public Superhero(string secretIdentity, bool hasCape, int strengthLevel, string archnemesis)
        {
            this.secretIdentity = secretIdentity;
            this.hasCape = hasCape;
            this.strengthLevel = strengthLevel;
            this.archnemesis = archnemesis;
        }


    }
}
