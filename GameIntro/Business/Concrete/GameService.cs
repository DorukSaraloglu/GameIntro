using System;
using System.Collections.Generic;
using System.Text;
using GameIntro.Business.Abstract;
using GameIntro.Entities;

namespace GameIntro.Business.Concrete
{
    public class GameService : IGameService
    {
        private string _playerTcNo = "";
        private string _playerFirstName = "";
        private string _playerLastName = "";
        private string _playerBirthOfDate = "";
        private int _buyGameId = 0;
        private int _buyCampaignId = 0;

        public List<Game> games { get; set; }

        public GameService()
        {
            games = new List<Game>();

            Game game1 = new Game()
            {
                GameId = 1,
                GameName = "Grand Thieft Auto V",
                GameType = "Role-Playing",
                GamePlatform = "Windows",
                GamePrice = 70
            };

            Game game2 = new Game()
            {
                GameId = 2,
                GameName = "Star Wars Galaxy Of Heroes",
                GameType = "Strategy",
                GamePlatform = "Mobile",
                GamePrice = 10
            };

            Game game3 = new Game()
            {
                GameId = 3,
                GameName = "Fortnite",
                GameType = "Battle Royale",
                GamePlatform = "Windows",
                GamePrice = 30
            };

            Game game4 = new Game()
            {
                GameId = 4,
                GameName = "Tom Clancy's Rainbow Six: Siege",
                GameType = "Action",
                GamePlatform = "Windows",
                GamePrice = 50
            };

            Game game5 = new Game()
            {
                GameId = 5,
                GameName = "Last Of Us 2",
                GameType = "Role-Playing",
                GamePlatform = "PS4",
                GamePrice = 100
            };

            games.Add(game1);
            games.Add(game2);
            games.Add(game3);
            games.Add(game4);
            games.Add(game5);
        }

        public void Buy(List<Player> players, List<Campaign> campaigns)
        {
            Console.WriteLine("----------------------");
            Console.Write("Oyun satın alacak kullanıcının Tc nosunu giriniz: ");
            _playerTcNo = Console.ReadLine();
            Console.Write("Oyun satın alacak kullanıcının adını giriniz: ");
            _playerFirstName = Console.ReadLine();
            Console.Write("Oyun satın alacak kullanıcının soyadını giriniz: ");
            _playerLastName = Console.ReadLine();
            Console.Write("Oyun satın alacak kullanıcının doğum yılını giriniz: ");
            _playerBirthOfDate = Console.ReadLine();

            foreach (var player in players)
            {
                if (player.PlayerTcNo == _playerTcNo && player.PlayerFirstName == _playerFirstName && player.PlayerLastName == _playerLastName && player.PlayerBirthOfYear == _playerBirthOfDate)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Giriş başarılı.");
                    Console.Write("Satın alınacak oyunun id sini giriniz: ");
                    _buyGameId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kampanya id sini giriniz: ");
                    _buyCampaignId = Convert.ToInt32(Console.ReadLine());

                    foreach (var game in games)
                    {
                        if (game.GameId == _buyGameId)
                        {
                            foreach (var campaign in campaigns)
                            {
                                if (campaign.CampaignId == _buyCampaignId)
                                {
                                    Console.WriteLine(game.GameName);
                                    Console.WriteLine(game.GamePlatform);
                                    Console.WriteLine(game.GameType);
                                    Console.WriteLine(game.GamePrice);
                                    Console.WriteLine("Oyunun yeni tutarı: {0}", game.GamePrice = game.GamePrice - campaign.CampaignDiscount);
                                }
                            }
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı bilgileri bulunamadı !");
                    break;
                }
            }
        }
    }
}