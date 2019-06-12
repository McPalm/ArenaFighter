using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat.GameStates
{
    public class Fight : IGameState
    {
        public Battle Battle => Career.battle;
        public GameManager Manager { get; set; }
        public Career Career => Manager.Career;

        public Fight(GameManager manager)
        {
            Manager = manager;
        }

        public string Action1Label => "Fight!";

        public string Action2Label => "";

        public void Action1()
        {
            Battle.SimulateRound();
            Manager.Log?.Invoke(Battle.LastRoundDescription);
            if(Battle.FightIsOver)
            {
                if (Career.Player.Alive)
                    Manager.EnterState(new Town(Manager));
                else
                    Manager.EnterState(new GameOver(Manager));
            }
        }

        public void Action2() { }

        public void EnterState()
        {
            Career.StartFight();
            Manager.ClearLogs?.Invoke();
        }

        public void LeaveState()
        {
            
        }
    }
}
