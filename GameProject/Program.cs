using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gamer

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Ersel";
            gamer1.LastName = "Dinçkaya";
            gamer1.DateOfBirth = "24.07.2001";
            gamer1.NationalId = "12345678901";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Kaan";
            gamer2.LastName = "Kamaşak";
            gamer2.DateOfBirth = "24.07.2001";
            gamer2.NationalId = "98765432101";

            GamerManager gamerManager = new GamerManager( new GamerCheckManager());
            gamerManager.Save(gamer1);
            gamerManager.Save(gamer2);

            Console.WriteLine("-------------------------------------------");

            // Game

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Fifa 22";
            game1.Price = "550";

            GameManager gameManager = new GameManager();
            gameManager.BuyGame(gamer1, game1);

            Console.WriteLine("-------------------------------------------");


            //Campaign

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yeni Yıl Kampanyası";
            campaign1.Discount = "0,2";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);

            Console.WriteLine("-------------------------------------------");


            //Sales

            SaleManager saleManager = new SaleManager();
            saleManager.SaleService(gamer1, game1, campaign1);



        }
    }
}
