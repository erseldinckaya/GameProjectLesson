using System;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void BuyGame(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + ", " + game.GameName + " adlı oyunu satın aldı !");
        }
    }
}
