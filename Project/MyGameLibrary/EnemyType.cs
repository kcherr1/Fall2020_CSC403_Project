using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class EnemyType : Enemy
{
    // Creates enemy class variable to determine how all future calls are performed. Also forms the random call for later used
    private int enemyClass = 0;
    Random rnd = new Random();
    private int charged = 0;

    
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

    // Sets boss class specifically to unique boss instance
    public void setBossClass(int given)
    {
        enemyClass = given;
    }

    // All three classes have unique attacks to choose from each turn
    private string Assasin()
    {
        String Log = "store";
        int attack = rnd.Next(1, 4);
        if (attack == 1)
        {
           this.OnAttack(-1);
           Log = " strikes with a flurry of little baby slices, dealing 2 damage";
        } else if (attack == 2)
        {
            this.OnAttack(-3);
            Log = " ripostes, recalling their years studying the blade while others interacted with people, dealing 6 cringe damage";
        } else if (attack == 3)
        {
            this.OnAttack(-4);
            Log = " lunges with their hidden shanking knife, giving you a good shank. The shank shanks for 8 damage";
        }
        return Log;
    }

    private string Brute()
    {
        String Log = "store";
        int attack = rnd.Next(1, 4);
        if (attack == 1)
        {
            if ((this.Health + 3) > 60)
            {
                int heal = (60 - this.Health);
                this.OnHeal(heal);
                Log = string.Format(" is fueled by pure, unbridled rage. This anger is only getting more intense and heals it for {0}", heal);
            }
            else
            {
                this.OnHeal(3);
                Log = " is fueled by pure, unbridled rage. This anger is only gettign more intense and heas it for 3";
            }
        } else if (attack == 2)
        {
            this.OnAttack(-2);
            Log = " charges at you and smashes you into the ground, dealing 4 damage";
        } else if (attack == 3)
        {
            this.OnAttack(-3);
            Log = " breaks out the hammer to end all hammers and swings to cracks you like it is at Texas Roadhouse. Your shell fractures and you take 6 damage.";
        }
        return Log;
    }

    private string Boss()
    {
        String Log = "store";
        int attack = rnd.Next(1, 4);
        if (charged == 1)
        {
            this.OnAttack(-10);
            charged = 0;
            Log = " releases a gutteral OH YEAH and charges at you with it's full force. The impact shatters space and time itself and you see the horrible koolaid truth. You take 20 damage from the physical and pyschic trauma";
        }
        else if (attack == 1)
        {
            if ((this.Health + 5) > 100)
            {
                int heal = (100 - this.Health);
                this.OnHeal(heal);
                Log = string.Format(" Drinks it's own sweet, sweet koolaid which mends it's wounds and staunches the leaking koolaid like you would the wound of a comrade. It heals {0}", heal);
            }
            else
            {
                this.OnHeal(5);
                Log = " Drinks it's own sweet, sweet koolaid which mends it's wounds and staunches the leaking koolaid like you would the wound of a comrade. It heals 5";
            }
        }
        else if (attack == 2)
        {
            this.OnAttack(-4);
            Log = " waves their hand at you, their raw energy warping space itself as an attack that deals 8 damage";
        }
        else if (attack == 3)
        {
            charged = 1;
            Log = "The boss is preparing for something truly horrible.....";
            
        }
        return Log;
    }

    private string OddBall()
    {
        String Log = "store";
        int attack = rnd.Next(1, 11);
        if (attack == 1)
        {
            this.OnAttack(-2);
            Log = (" breaks out it's actual, literal shotgun and blasts you which deals 4 damage");
        }
        else if (attack == 2)
        {
            this.OnAttack(-2);
            Log = (" breaks out it's actual, literal shotgun and blasts you which deals 4 damage");
        }
        else if (attack == 3)
        {
            this.OnAttack(-2);
            Log = (" breaks out it's actual, literal shotgun and blasts you which deals 4 damage");
        }
        else if (attack == 4)
        {
            this.OnAttack(-4);
            Log = (" quick draws it's emergency pistol-sized fully automatic shotgun and sprays every shell it has, deaing 8 damage");
        }
        else if (attack == 5)
        {
            this.OnAttack(2);
            Log = (" accidentally made the common mistake of firing it's mending shells at you. You heal 2 health");
        }
        else if (attack == 6)
        {
            this.OnAttack(4);
            Log = (" accidentally made the less common mistake of firing it's super ultra mending shells at you. You heal 4 health");
        }
        else if (attack == 7)
        {
            if ((this.Health + 4) > this.MaxHealth)
            {
                int heal = (this.MaxHealth - this.Health);
                this.OnHeal(heal);
                Log = string.Format(" has busted out the old sharpie and fills in a portion of it's health bar. I have been advised for my own safety not to call them out on this blatant cheating or they will come for me. They heal {0}", heal);
            }
            else
            {
                this.OnHeal(4);
                Log = string.Format(" has busted out the old sharpie and fills in a portion of it's health bar. I have been advised for my own safety not to call them out on this blatant cheating or they will come for me. They heal 4");
            }
        } else if (attack == 8)
        {
            if ((this.Health + 8) > this.MaxHealth)
            {
                int heal = (this.MaxHealth - this.Health);
                this.OnHeal(heal);
                Log = string.Format(" has busted out the old giga sharpie and fills in a portion of it's health bar. I have been advised for my own safety not to call them out on this blatant cheating or they will come for me. They heal {0}", heal);
            }
            else
            {
                this.OnHeal(8);
                Log = string.Format(" has busted out the old giga sharpie and fills in a portion of it's health bar. I have been advised for my own safety not to call them out on this blatant cheating or they will come for me. They heal 8");
            }
        } else if (attack == 9)
        {
            this.AlterHealth(-(this.Health));
            Log = " just flat out explodes. Like in a horrible way, not the quick and easy way. It seems the infinite grenade pouch was through with their shennanigans and detonated prematurely. Let this be a lesson of the dangers of bringing such infinite weaponry";
        } else if (attack == 10)
        {
            this.OnAttack(-8);
            Log = " unleashes a grenade from it's infinite grenade pouch, which we aren't even going to touch on right now. It deals 16 damage. It's a grenade, what did you expect?";
        }
        return Log;
    }

    // Picks attack pool based on which class enemy has
    public string determineAttack(int dodge)
    {
        string log = "This is storage";
        // Checks to see if player had dodged and makes a roll from 1-100, if the roll is greater than 20 the enemy does no damage, else they attack as normal
        if (dodge == 1)
        {
            int dodgeChance = rnd.Next(1, 101);
            if (dodgeChance > 20)
            {
                log = " is in awe. Your sick nasty moves are a total success, distracting the foe from taking their turn. They must now wait, as is the divine rules of R.P.G.";
                this.OnAttack(0);
                charged = 0;
                return log;
            }
            else
            {
                if (enemyClass == 1)
                {
                    log = (Assasin() + " It seems the gods take offense at a mere mortal attempting such heresy and has ennacted divine punishment");
                }
                else if (enemyClass == 2)
                {
                    log = (Brute() + " It seems the gods take offense at a mere mortal attempting such heresy and has ennacted divine punishment");
                }
                else if (enemyClass == 3)
                {
                    log = (OddBall() + " It seems the gods take offense at a mere mortal attempting such heresy and has ennacted divine punishment");
                }
                else if (enemyClass == 4)
                {
                   log = (Boss() + " It seems the gods take offense at a mere mortal attempting such heresy and has ennacted divine punishment");
                }
                return log;
            }
        }
        else
        {
            if (enemyClass == 1)
            {
               log = Assasin();
            }
            else if (enemyClass == 2)
            {
               log = Brute();
            }
            else if (enemyClass == 3)
            {
               log = OddBall();
            }
            else if (enemyClass == 4)
            {
               log = Boss();
            }
            return log;
        }
    }






    public EnemyType(Vector2 initPos, Collider collider) : base(initPos, collider)
    {
    }


}
