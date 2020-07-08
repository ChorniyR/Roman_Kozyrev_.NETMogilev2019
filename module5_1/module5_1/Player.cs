using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5_1
{
    class Player
    {        
        public int hitPoints = 10;
        public int step = 0;
        Field field;        
        int posX , posY;

        public int PosX
        {
            get
            {
                return posX;
            }
            set
            {
                if (value <= field.cells.GetUpperBound(0) &&
                    value >= 0)
                {
                    posX = value;
                }                
            }
        }

        public int PosY
        {
            get
            {
                return posY;
            }
            set
            {
                if (value <= field.cells.GetUpperBound(1) &&
                    value >=0 ) posY = value;                
            }
        }

        public Player(Field field)
        {
            this.field = field;
        }

        public void Move(char key)
        {
            {
                switch (key)
                {
                    case 'w':                        
                        PosX -= 1;
                        step++;
                        if (BombChek())
                        {
                            GetDamage();
                            field.DestroyTrap(posX,posY);
                        }
                        break;

                    case 's':
                        PosX += 1;
                        step++;
                        if (BombChek())
                        {
                            GetDamage();
                            field.DestroyTrap(posX, posY);
                        }
                        break;

                    case 'a':
                        PosY -= 1;
                        step++;
                        if (BombChek())
                        {
                            GetDamage();
                            field.DestroyTrap(posX, posY);
                        }
                        break;

                    case 'd':
                        PosY += 1;
                        step++;
                        if (BombChek())
                        {
                            GetDamage();
                            field.DestroyTrap(posX, posY);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        public void GetDamage()
        {
            Random rnd = new Random();
            hitPoints -= rnd.Next(0, 10);
        }

        public bool BombChek()
        {
            if (field.cells[posX, posY] == 1)
            {
                return true;
            }
            return false;
        }

        public bool IsDead()
        {
            if (hitPoints <= 0) return true;
            else return false;
        }
    }
}
