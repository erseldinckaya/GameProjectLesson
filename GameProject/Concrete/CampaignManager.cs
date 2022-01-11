using System;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Sisteme yeni kampanya eklendi !");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Sistemden kampanya silindi !");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi !");
        }
    }
}
