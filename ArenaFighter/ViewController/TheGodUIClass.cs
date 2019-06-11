using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaFighter.Combat;

namespace ArenaFighter.Controller
{
    /// <summary>
    /// Quick and Dirty, because I cannot be arsed to think too hard about it.
    /// Its not even a part of the assginment.
    /// </summary>
    public class TheGodUIClass
    {
        public Career Career { get; set; }
        Form1 Form { get; }

        bool pressed1;
        bool pressed2;

        public TheGodUIClass( Form1 form)
        {
            Form = form;
            Form.button1.Click += (o, e) => Press1();
            Form.button2.Click += (o, e) => Press2();
            Career = new Career();
            Display();
        }

        void Display()
        {
            Form.FormatLabels(Career.Player, Career.Enemy);
            switch(state)
            {
                case  TOWN:
                    Form.button1.Text = "Start a fight";
                    Form.button2.Text = "Retire";
                    break;
                case COMBAT:
                    Form.button1.Text = "Attack!";
                    Form.button2.Text = "";
                    break;
                case NOTHING:
                case GAME_OVER:
                    Form.button1.Text = "New Character";
                    Form.button2.Text = "Quit";
                    break;

            }
        }

        void Press1()
        {
            pressed1 = true;
            GameLoop();
        }

        void Press2()
        {
            pressed2 = true;
            GameLoop();
        }

        const int COMBAT = 0;
        const int TOWN = 1;
        const int GAME_OVER = 2;
        const int NOTHING = 3;
        int state = NOTHING;

        public void GameLoop()
        {
            switch (state)
            {
                case TOWN:
                    if (pressed1)
                    {
                        state = COMBAT;
                        Form.ClearLogs();
                        Career.StartFight();
                    }
                    else if (pressed2)
                    {
                        new ScoreView().ShowCarieer(Career);
                        state = GAME_OVER;
                    }
                    break;
                case COMBAT:
                    if (pressed1)
                    {
                        Career.battle.SimulateRound();
                        var desc = Career.battle.LastRoundDescription;
                        Form.Log(desc);
                        if (Career.battle.FightIsOver)
                        {
                            state = Career.Player.Alive ? TOWN : GAME_OVER;
                        }
                        if (state == GAME_OVER)
                            new ScoreView().ShowCarieer(Career);

                    }
                    break;
                case GAME_OVER:
                case NOTHING:
                    if (pressed1)
                    {
                        var query = new NameQuerry();
                        query.onSubmit += (name) =>
                        {
                            Career = new Career(new Character(name)
                            {
                                Strenght = 6,
                                MaxHealth = 10,
                            });
                            state = TOWN;
                            Display();
                        };
                        query.Show();
                    }
                    if (pressed2)
                    {
                        Form.Close();
                    }
                    break;
            }
            Display();
            pressed1 = false;
            pressed2 = false;

        }
    }
}
