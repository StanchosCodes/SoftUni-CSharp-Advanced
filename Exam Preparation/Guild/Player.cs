using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";

        public Player(string name, string classText)
        {
            this.Name = name;
            this.Class = classText;
        }

        public override string ToString()
        {
            return $"Player {this.Name}: {this.Class}{Environment.NewLine}Rank: {this.Rank}{Environment.NewLine}Description: { Description}";

        }
    }
}
