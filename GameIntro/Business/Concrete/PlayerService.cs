using System;
using System.Collections.Generic;
using System.Text;
using GameIntro.Business.Abstract;
using GameIntro.Entities;

namespace GameIntro.Business.Concrete
{
    public class PlayerService : IPlayerService
    {
        #region Fields

        private int _playerId = 0;
        private string _playerTcNo = "";
        private string _playerFirstName = "";
        private string _playerLastName = "";
        private string _playerBirthOfDate = "";

        #endregion

        public void Add(List<Player> players)
        {
            Console.WriteLine("----------------------");
            Console.Write("Oyuncu Id no giriniz: ");
            _playerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu Tc no giriniz: ");
            _playerTcNo = Console.ReadLine();
            Console.Write("Oyuncu adı giriniz: ");
            _playerFirstName = Console.ReadLine();
            Console.Write("Oyuncu soyadı no giriniz: ");
            _playerLastName = Console.ReadLine();
            Console.Write("Oyuncu doğum yılı giriniz: ");
            _playerBirthOfDate = Console.ReadLine();

            Player player = new Player()
            {
                PlayerId = _playerId,
                PlayerTcNo = _playerTcNo,
                PlayerFirstName = _playerFirstName,
                PlayerLastName = _playerLastName,
                PlayerBirthOfYear = _playerBirthOfDate
            };

            players.Add(player);

            Console.WriteLine("Oyuncu Eklendi !");
        }

        public void Delete(List<Player> players)
        {
            Console.WriteLine("----------------------");
            Console.Write("Silinecek oyuncunun Id nosunu giriniz: ");
            _playerId = Convert.ToInt32(Console.ReadLine());

            foreach (var player in players)
            {
                if (player.PlayerId == _playerId)
                {
                    players.Remove(player);
                    break;
                }
            }

            Console.WriteLine("Oyuncu Silindi !");
        }

        public void Update(List<Player> players)
        {
            Console.WriteLine("----------------------");
            Console.Write("Güncellenecek oyuncunun Tc nosunu giriniz: ");
            _playerTcNo = Console.ReadLine();
            Console.Write("Güncellenecek oyuncunun adını giriniz: ");
            _playerFirstName = Console.ReadLine();
            Console.Write("Güncellenecek oyuncunun soyadını giriniz: ");
            _playerLastName = Console.ReadLine();
            Console.Write("Güncellenecek oyuncunun doğum yılını giriniz: ");
            _playerBirthOfDate = Console.ReadLine();

            foreach (var player in players)
            {
                if (player.PlayerTcNo == _playerTcNo)
                {
                    player.PlayerTcNo = _playerTcNo;
                    player.PlayerFirstName = _playerFirstName;
                    player.PlayerLastName = _playerLastName;
                    player.PlayerBirthOfYear = _playerBirthOfDate;
                }
            }

            Console.WriteLine("Oyuncu Güncellendi !");
        }
    }
}
