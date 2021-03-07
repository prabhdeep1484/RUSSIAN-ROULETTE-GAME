using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSSIAN_ROULETTE_GAME
{
    public class Game
    {
         public int[] PlayerGun = new int[6] { 0, 0, 0, 0, 0, 0 };// Player and Computer Gun Chambers
        public int PlayerChamber;
        public int ChamberPull;
        public int Shoot_Away = 0;
        public int Game_Round = 1;
        public int Player_Scores = 0;
        public int Bonus_Points = 100;
        public int Seconds = 0;
        public int Win = 0;
        public int Loss = 0;
        public int Bullet_Left = 0, Bullet_Right = 0;
        public bool Game_Status = false;
        public bool Round_Status = false;
        public bool File_Flag = false;
    }
}
