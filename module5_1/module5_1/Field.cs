using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5_1
{
    class Field
    {
        int trapCount;
        int sizeX, sizeY;
        public int[,] cells;

        public Field(int trapCount,int sizeX,int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.trapCount = trapCount;

        }
        public void Create()
        {
            cells = new int[sizeX, sizeY];
        }
        public void SetTraps()
        {
            int posX, posY;
            var rnd = new Random();
            for(var i = 0; i <= trapCount; i++)
            {
                posX = rnd.Next(0, sizeX);
                posY = rnd.Next(0, sizeY);
                if (cells[posX, posY] != 1)
                {
                    cells[posX, posY] = 1;
                }
            }
        }

        public void DestroyTrap(int posX,int posY)
        {
            cells[posX, posY] = 0;
        }        
    }
}
