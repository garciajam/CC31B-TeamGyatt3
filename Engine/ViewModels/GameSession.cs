using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Player";
            CurrentPlayer.Gold = 100;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Name = "Hometown Square";
            CurrentLocation.Description = "A peaceful village where your journey begins.";
            CurrentLocation.ImageName = "pack://application:,,,/Engine;component/Images/Locations/home.jpg";
            //CurrentLocation.ImageName = "../Engine/Images/Locations/home.jpg";

        }
    }
}
