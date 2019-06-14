using ArenaFighter.Combat.RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat.GameStates
{
    public class GameOver : IGameState
    {
        GameManager GameManager { get; set; }
        public string Action1Label => "New Character";

        public string Action2Label => "Quit";

        public GameOver(GameManager gameManager)
        {
            GameManager = gameManager;
        }
        public void Action1()
        {
            GameManager.RequestString("Name", EnterName);
        }
        void EnterName(string name)
        {
            var player = new CharacterBuilder()
                .Name.Is(name)
                .Attributes.StrenghtIs(6)
                .Attributes.MaxHealthIs(10);
            var career = new Career(player);
            GameManager.Career = career;
            GameManager.EnterState(new Town(GameManager));
        }

        public void Action2()
        {
            GameManager.Quit?.Invoke();
        }

        public void EnterState()
        {
            if (GameManager.Career != null)
                GameManager.OnEndCareer?.Invoke(GameManager.Career);
        }

        public void LeaveState()
        {

        }
    }
}
