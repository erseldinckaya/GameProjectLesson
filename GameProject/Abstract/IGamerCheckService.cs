using System;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGamerCheckService
    {
        bool Check(Gamer gamer);
    }
}
