using System;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.NationalId == "12345678901")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
