using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro.Business.Abstract;
using GameIntro.Entities;

namespace GameIntro.Business.Concrete
{
    public class CampaignService : ICampaignService
    {
        #region Fields

        private int _campaignId = 0;
        private string _campaignName = "";
        private decimal _campaignDiscount = 0;

        #endregion

        public void Add(List<Campaign> campaigns)
        {
            Console.WriteLine("----------------------");
            Console.Write("Kampanya id giriniz: ");
            _campaignId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kampanya adı giriniz: ");
            _campaignName = Console.ReadLine();
            Console.Write("İndirim tutarı giriniz: ");
            _campaignDiscount = Convert.ToDecimal(Console.ReadLine());

            Campaign campaign = new Campaign()
            {
                CampaignId = _campaignId,
                CampaignName = _campaignName,
                CampaignDiscount = _campaignDiscount
            };

            campaigns.Add(campaign);

            Console.WriteLine("Kampanya Eklendi !");
        }

        public void Delete(List<Campaign> campaigns)
        {
            Console.WriteLine("----------------------");
            Console.Write("Silinecek kampanyanın id sini giriniz: ");
            _campaignId = Convert.ToInt32(Console.ReadLine());

            foreach (var campaign in campaigns)
            {
                if (campaign.CampaignId == _campaignId)
                {
                    campaigns.Remove(campaign);
                    break;
                }
            }

            Console.WriteLine("Kampanya Silindi !");
        }

        public void Update(List<Campaign> campaigns)
        {
            Console.WriteLine("----------------------");
            Console.Write("Güncellenecek kampanyanın id sini giriniz: ");
            _campaignId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni kampanya adını giriniz: ");
            _campaignName = Console.ReadLine();
            Console.Write("Yeni kampanya indirim tutarını giriniz: ");
            _campaignDiscount = Convert.ToDecimal(Console.ReadLine());

            foreach (var campaign in campaigns)
            {
                if (campaign.CampaignId == _campaignId)
                {
                    campaign.CampaignName = _campaignName;
                    campaign.CampaignDiscount = _campaignDiscount;
                }
            }

            Console.WriteLine("Kampanya Güncellendi !");
        }
    }
}
