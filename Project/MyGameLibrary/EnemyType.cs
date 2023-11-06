using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class EnemyType : Enemy
{
    // Creates enemy class variable to determine how all future calls are performed. Also forms the random call for later used
    private int enemyClass = 0;
    Random rnd = new Random();

    
    // Enemy class is the set at the beginning of the battle instance which will determine all future actions
    public void setEnemyClass()
    {
        enemyClass = rnd.Next(1, 4);
    }

    // resetsEnemyClass for next instance
    public void resetEnemyClass()
    {
        enemyClass = 0;
    }

    public void setClassHealth()
    {
        if (enemyClass == 1)
        {
            this.setHealth(20);
        } else if (enemyClass == 2)
        {
            this.setHealth(60);
        } else if (enemyClass == 3)
        {
            this.setHealth(rnd.Next(20, 41));
        } else if (enemyClass == 4)
        {
            this.setHealth(100);
        }
    }

    // Sets boss class specifically to brute
    public void setBossClass(int given)
    {
        enemyClass = given;
    }

    // All three classes have unique attacks to choose from each turn
    private void Assasin()
    {
        int attack = rnd.Next(1, 4);
        if (attack == 1)
        {
           this.OnAttack(-1);
        } else if (attack == 2)
        {
            this.OnAttack(-3);
        } else if (attack == 3)
        {
            this.OnAttack(-4);
        }
    }

    private void Brute()
    {
        int attack = rnd.Next(1, 4);
        if (attack == 1)
        {
            if ((this.Health + 2) > 60)
            {
                this.OnHeal(60 - this.Health);
            }
            else
            {
                this.OnHeal(2);
            }
        } else if (attack == 2)
        {
            this.OnAttack(-2);
        } else if (attack == 3)
        {
            this.OnAttack(-3);
        }
    }

    private void Boss()
    {
        int attack = rnd.Next(1, 4);
        if (attack == 1)
        {
            if ((this.Health + 5) > 60)
            {
                this.OnHeal(60 - this.Health);
            }
            else
            {
                this.OnHeal(5);
            }
        }
        else if (attack == 2)
        {
            this.OnAttack(-3);
        }
        else if (attack == 3)
        {
            this.OnAttack(-4);
        }
    }

    private void OddBall()
    {
        int attack = rnd.Next(1, 11);
        if (attack == 1)
        {
            this.OnAttack(-2);
        }
        else if (attack == 2)
        {
            this.OnAttack(-2);
        }
        else if (attack == 3)
        {
            this.OnAttack(-2);
        }
        else if (attack == 4)
        {
            this.OnAttack(-4);
        }
        else if (attack == 5)
        {
            this.OnAttack(2);
        }
        else if (attack == 6)
        {
            this.OnAttack(4);
        }
        else if (attack == 7)
        {
            if ((this.Health + 4) > this.MaxHealth)
            {
                this.OnHeal(this.MaxHealth - this.Health);
            }
            else
            {
                this.OnHeal(4);
            }
        } else if (attack == 8)
        {
            if ((this.Health + 8) > this.MaxHealth)
            {
                this.OnHeal(this.MaxHealth - this.Health);
            }
            else
            {
                this.OnHeal(8);
            }
        } else if (attack == 9)
        {
            this.AlterHealth(-20);
        } else if (attack == 10)
        {
            this.OnAttack(-8);
        }
    }

    // Picks attack pool based on which class enemy has
    public void determineAttack()
    {
        if (enemyClass == 1)
        {
            Assasin();
        } else if (enemyClass == 2)
        {
            Brute();
        } else if (enemyClass == 3)
        {
            OddBall();
        } else if (enemyClass == 4)
        {
            Boss();
        }
    }






    public EnemyType(Vector2 initPos, Collider collider) : base(initPos, collider)
    {
    }


}
