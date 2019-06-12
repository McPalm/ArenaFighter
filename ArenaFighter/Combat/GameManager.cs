using ArenaFighter.Combat.GameStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class GameManager
    {
        public Career Career { get; set; }
        public Character Player => Career?.Player;
        public Character Enemy => Career?.Enemy;
        IGameState State {get;set;}
        public Action<Career> OnEndCareer { get; set; }
        public Action ClearLogs { get; set; }

        public GameManager()
        {
            EnterState(new GameOver(this));
        }

        public void EnterState(IGameState state)
        {
            if (State != null)
                State.LeaveState();
            State = state;
            state.EnterState();
        }
        public Action<string, Action<string>> RequestString { get; set; }

        public void Action1() => State.Action1();
        public void Action2() => State.Action2();
        public string Label1 => State.Action1Label;
        public string Label2 => State.Action2Label;
        public Action Quit { set; get; }
        public Action<string> Log { get; set; }
    }
}
