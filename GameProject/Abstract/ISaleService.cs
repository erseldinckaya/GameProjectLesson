using System;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void SaleService(Gamer gamer, Game game, Campaign campaign);
    }
}
