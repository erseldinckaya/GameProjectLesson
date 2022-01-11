using System;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void SaleService(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " adlı kişi " + game.GameName + " adlı oyunu " + campaign.CampaignName + " indirimiyle aldı !");
        }
    }
}
