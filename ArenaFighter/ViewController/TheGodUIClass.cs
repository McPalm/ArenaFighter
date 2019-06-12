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
        Form1 Form { get; }
        GameManager GameManager { get; set; }


        public TheGodUIClass( Form1 form)
        {
            Form = form;
            GameManager = new GameManager();
            GameManager.Log += form.Log;
            GameManager.Quit += form.Close;
            GameManager.RequestString += RequestName;
            GameManager.OnEndCareer += EndCareer;
            GameManager.ClearLogs += form.ClearLogs;
            Form.button1.Click += (o, e) => Press1();
            Form.button2.Click += (o, e) => Press2();
            Display();
        }

        void EndCareer(Career c)
        {
            new ScoreView().ShowCarieer(c);
        }

        void Display()
        {
            Form.button1.Text = GameManager.Label1;
            Form.button2.Text = GameManager.Label2;
            Form.FormatLabels(GameManager.Player, GameManager.Enemy);
        }

        void Press1()
        {
            GameManager.Action1();
            Display();
        }

        void Press2()
        {
            GameManager.Action2();
            Display();
        }

        void RequestName(string label, Action<string> action)
        {
            action += (s) => Display();
            new NameQuerry().ShowQuestion(label, action);
        }
    }
}
