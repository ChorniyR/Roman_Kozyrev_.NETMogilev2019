using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5_1
{
    class Graphics
    {
        Player player;
        Field field;       
        
        public Graphics(Player player,Field field)
        {
            this.player = player;
            this.field = field;
        }

        public void ShowField()
        {
            for(var i = 0;i <= field.cells.GetUpperBound(0); i++)
            {
                for (var j = 0; j <= field.cells.GetUpperBound(1); j++)
                {
                    if (i == player.PosX &&
                        j == player.PosY) Console.Write("*");
                    else Console.Write("O");
                }
                Console.WriteLine();
            }
        }
        
        public void ShowPanel()
        {
            Console.WriteLine("HP: {0} \t STEP: {1}", player.hitPoints, player.step);
        }
    }
}
