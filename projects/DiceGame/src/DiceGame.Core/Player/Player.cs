using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.Player
{   [Table("dgplayer")]
    class Player:Entity<int>, ICreationAudited
    {
        public int Score { get; set; }
        public string NickName { get;set }
        public int LevelId { get; set; }
        public virtual Level Level { get; set; }
        public byte DailyPlayedRounds { get; set; }
        public DateTime Last Time Played { get; set; }
        public int UserId { get; set; }
    }
}
