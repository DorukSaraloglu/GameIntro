using System;
using System.Collections.Generic;
using System.Text;
using GameIntro.Entities;

namespace GameIntro.Business.Abstract
{
    public interface IGameService
    {
        public void Buy(List<Player> players, List<Campaign> campaigns);
    }
}
