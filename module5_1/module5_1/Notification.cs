using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5_1
{
    class Notification
    {
        Player player;
        public Notification(Player player)
        {
            this.player = player;
        }
        public void ShowInfo(string info)
        {
            Console.Clear();
            Console.WriteLine("You {0}, count of steps {1}", info,player.step);
            Console.WriteLine("Press 1 to play one more time.\nPress 2 to excit");            
        }        
    }
}
