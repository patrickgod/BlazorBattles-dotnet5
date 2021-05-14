using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class Battle
    {
        public int Id { get; set; }
        public User Attacker { get; set; }
        public int AttackerId { get; set; }
        public User Opponent { get; set; }
        public int OpponentId { get; set; }
        public User Winner { get; set; }
        public int WinnerId { get; set; }
        public int WinnerDamage { get; set; }
        public int RoundsFought { get; set; }
        public DateTime BattleDate { get; set; } = DateTime.Now;
    }
}
