using System;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private GamerCheckManager gamerCheckService;

        public GamerManager(GamerCheckManager gamerCheckService) {
            this.gamerCheckService = gamerCheckService;
        }


        

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " için silme işlemi gerçekleştirildi.");
        }

        public void Save(Gamer gamer)
        {
            
            if (gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " için kaydolma işlemi gerçekleştirildi.");
            } else
            {
                Console.WriteLine("Hata ! " + gamer.FirstName + " için kaydolma işlemi gerçekleştirilemedi.");
            }
            
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " için güncelleme işlemi gerçekleştirildi.");
        }
    }
}
