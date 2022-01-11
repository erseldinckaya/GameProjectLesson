using System;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void BuyGame(Gamer gamer, Game game); 
    }
}
