using System;
using System.Collections.Generic;
using GameIntro.Business.Abstract;
using GameIntro.Business.Concrete;
using GameIntro.Entities;

namespace GameIntro
{
    public class Program
    {

        static void Main(string[] args)
        {
            #region InnerClass

            List<Player> playerList = new List<Player>();
            List<Campaign> campaignList = new List<Campaign>();

            while (true)
            {
                var process = Intro();

                switch (process)
                {
                    case 1:
                        //oyuncu ekle
                        PlayerService playerServiceAdd = new PlayerService();
                        playerServiceAdd.Add(playerList);

                        break;
                    case 2:
                        //oyuncu güncelle
                        PlayerService playerServiceUpdate = new PlayerService();
                        playerServiceUpdate.Update(playerList);
                        break;
                    case 3:
                        //oyuncu sil
                        PlayerService playerServiceDelete = new PlayerService();
                        playerServiceDelete.Delete(playerList);
                        break;
                    case 4:
                        //kampanya ekle
                        CampaignService campaignServiceAdd = new CampaignService();
                        campaignServiceAdd.Add(campaignList);
                        break;
                    case 5:
                        //kampanya güncelle
                        CampaignService campaignServiceUpdate = new CampaignService();
                        campaignServiceUpdate.Update(campaignList);

                        break;
                    case 6:
                        //kampanya sil
                        CampaignService campaignServiceDelete = new CampaignService();
                        campaignServiceDelete.Delete(campaignList);

                        break;
                    case 7:
                        //oyun satın al
                        GameService gameServiceBuy = new GameService();
                        gameServiceBuy.Buy(playerList,campaignList);
                        break;
                    case 8:
                        //oyuncuları listele
                        Console.WriteLine("---Oyuncular---");
                        foreach (var player in playerList)
                        {
                            Console.WriteLine("----------------------");
                            Console.WriteLine(player.PlayerTcNo);
                            Console.WriteLine(player.PlayerFirstName);
                            Console.WriteLine(player.PlayerLastName);
                            Console.WriteLine(player.PlayerBirthOfYear);
                        }
                        break;
                    case 9:
                        //kampanyaları listele
                        Console.WriteLine("---Kampanyalar---");
                        foreach (var campaign in campaignList)
                        {
                            Console.WriteLine("----------------------");
                            Console.WriteLine(campaign.CampaignName);
                            Console.WriteLine(campaign.CampaignDiscount);
                        }
                        break;
                    case 10:
                        //oyunları listele
                        GameService gameService = new GameService();
                        Console.WriteLine("---Oyunlar---");
                        foreach (var game in gameService.games)
                        {
                            Console.WriteLine("----------------------");
                            Console.WriteLine(game.GameName);
                            Console.WriteLine(game.GameType);
                            Console.WriteLine(game.GamePlatform);
                            Console.WriteLine(game.GamePrice);
                        }
                        break;
                }
            }

            #endregion
        }

        #region Methods

        private static int Intro()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("1) Oyuncu Ekle");
            Console.WriteLine("2) Oyuncu Güncelle");
            Console.WriteLine("3) Oyuncu Sil");
            Console.WriteLine("4) Kampanya Ekle");
            Console.WriteLine("5) Kampanya Güncelle");
            Console.WriteLine("6) Kampanya Sil");
            Console.WriteLine("7) Oyun Satın Al");
            Console.WriteLine("8) Oyuncuları Listele");
            Console.WriteLine("9) Kampanyaları Listele");
            Console.WriteLine("10) Oyunları Listele");
            Console.Write("İşlem Seçiniz: ");
            int process = Convert.ToInt32(Console.ReadLine());
            return process;
        }

        #endregion
    }
}
