using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public string GamePlatform { get; set; }
        public decimal GamePrice { get; set; }
    }
}
