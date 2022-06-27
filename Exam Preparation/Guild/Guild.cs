using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    class Guild
    {
        private List<Player> roster;
        private string name;
        private int capacity;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return roster.Count;
            }

        }
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            roster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            bool isRemoved = false;

            foreach (Player player in roster)
            {
                if (player.Name == name)
                {
                    roster.Remove(player);
                    isRemoved = true;
                    break;
                }
            }

            return isRemoved;
        }

        public void PromotePlayer(string name)
        {
            foreach (Player player in roster)
            {
                if (player.Name == name)
                {
                    if (player.Rank != "Member")
                    {
                        player.Rank = "Member";
                        break;
                    }
                }
            }
        }

        public void DemotePlayer(string name)
        {
            foreach (Player player in roster)
            {
                if (player.Name == name)
                {
                    if (player.Rank != "Trial")
                    {
                        player.Rank = "Trial";
                        break;
                    }
                }
            }
        }

        public Player[] KickPlayersByClass(string classText)
        {
            int countArr = 0;
            int arrCounter = 0;

            for (int i = 0; i < roster.Count; i++)
            {
                if (roster[i].Class == classText)
                {
                    countArr++;
                }
            }
            Player[] kicked = new Player[countArr];

            for (int i = 0; i < roster.Count; i++)
            {
                if (roster[i].Class == classText)
                {
                    kicked[arrCounter] = roster[i];
                    arrCounter++;
                    roster.RemoveAt(i);
                    i--;
                }
            }

            return kicked;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player in roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
