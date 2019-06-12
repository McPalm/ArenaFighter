using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat.GameStates
{
    public class Town : IGameState
    {
        GameManager GameManager { get; set; }

        public Town(GameManager gameManager)
        {
            GameManager = gameManager;
        }

        public string Action1Label => "Enter a Fight";

        public string Action2Label => "Retire";

        public void Action1()
        {
            GameManager.EnterState(new Fight(GameManager));
        }

        public void Action2()
        {
            GameManager.EnterState(new GameOver(GameManager));
        }

        public void EnterState() { }

        public void LeaveState() { }
    }
}
