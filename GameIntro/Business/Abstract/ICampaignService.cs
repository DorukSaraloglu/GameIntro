using System;
using System.Collections.Generic;
using System.Text;
using GameIntro.Entities;

namespace GameIntro.Business.Abstract
{
    public interface ICampaignService
    {
        public void Add(List<Campaign> campaigns);
        public void Update(List<Campaign> campaigns);
        public void Delete(List<Campaign> campaigns);
    }
}
