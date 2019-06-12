using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat.GameStates
{
    public interface IGameState
    {
        void EnterState();
        void LeaveState();
        void Action1();
        void Action2();
        string Action1Label { get; }
        string Action2Label { get; }
    }
}
