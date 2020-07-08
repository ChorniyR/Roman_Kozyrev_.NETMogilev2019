using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5_1
{
    class Game
    {
        Field field;
        Player player;
        Princess princess = new Princess();        

        public void Start()
        { 
            Console.Clear();

            field = new Field(10, 10, 10);
            player = new Player(field);

            field.Create();
            field.SetTraps();

            Console.WriteLine("Press ENTER to start");

            Process();
        }

        public bool Process()
        {
            Graphics graphics = new Graphics(player, field);

            char key = Console.ReadKey().KeyChar;

            player.Move(key);

            Console.Clear();

            graphics.ShowField();
            graphics.ShowPanel();

            if (player.PosX == princess.posX &&
                player.PosY == princess.posY) Finish();
            if (player.IsDead()) Finish();

            return Process();
        }

        public void Finish()
        {
            Notification notification = new Notification(player);

            if (player.IsDead())
            {
                notification.ShowInfo("FAIL");

                var ans = Console.ReadKey().KeyChar;
                switch (ans)
                {
                    case '1':
                        Start();
                        break;
                    case '2':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }

            else
            {
                notification.ShowInfo("WIN");

                var ans = Console.ReadKey().KeyChar;
                switch (ans)
                {
                    case '1':
                        Start();
                        break;
                    case '2':
                        Environment.Exit(0);
                        break;
                }
            }
        }


    }        
}
