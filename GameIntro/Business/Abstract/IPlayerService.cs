using System;
using System.Collections.Generic;
using System.Text;
using GameIntro.Entities;

namespace GameIntro.Business.Abstract
{
    public interface IPlayerService
    {
        public void Add(List<Player> players);
        public void Update(List<Player> players);
        public void Delete(List<Player> players);
    }
}
