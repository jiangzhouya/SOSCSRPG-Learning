using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        internal Player _currentPlayer;

        Player CurrentPlayer { get => _currentPlayer; set => _currentPlayer = value; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.Gold = 100000;
        }
    }
}
