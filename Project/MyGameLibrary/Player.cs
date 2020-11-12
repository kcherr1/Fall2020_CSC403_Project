using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        private float strength;

        //adding the player inventory and item stats to the fields
        private int additional_damage;
        public int damageReduction;
        public Dictionary<string, int> Player_inventory;

        public List<string> EquippedItems;

        public event Action<int> AttackEvent;

        public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
            MaxHealth = 20;
            strength = 2;
            Health = MaxHealth;

            //player starting extra damage and damage reduction from weapons and armor
            additional_damage = 0;
            damageReduction = 0;

            //Player starting inventory
            Player_inventory = new Dictionary<string, int>() {
            {"Small HP potion", 2}, {"Medium HP potion", 0}, {"Large HP potion", 0},
            {"Bronze Armor", 1}, {"Iron Armor", 1}, {"Diamond Armor", 1},
            {"Bronze Sword", 1 }, {"Iron Sword", 1 }, {"Diamond Sword", 1 }
            };

            //armor is the first, weapon is the second
            EquippedItems = new List<string>() { "", "" };
        }

        //gets the amount of something that the player has
        public int GetVal(string name) {
            int val;
            Player_inventory.TryGetValue(name, out val);
            return val;

        }

        //use health potion
        public void AddHealth(string name) {
            //make sure the player has an avaliable health potion, if so, use the appropriate one 
            //and take it out of the inventory
            int amount_owned = GetVal(name);
            if (amount_owned > 0) {

                //if Health is already max, then don't use a health potion
                if (Health < MaxHealth) {

                    //else add the health to the player
                    if (name == "Small HP potion")
                        Health += 5;

                    if (name == "Medium HP potion")
                        Health += 10;

                    if (name == "Large HP potion")
                        Health += 20;

                    //if above max health, reduce the player's health to the max they are allowed
                    if (Health > MaxHealth)
                        Health = MaxHealth;

                    Player_inventory[name] -= 1;
                }
            }
        }

        //use armor
        public void ReduceDamageTaken(string name) {
           
            //make sure the previous one's stats are taken off
           
            damageReduction = 0;
            if (name == "Bronze Armor")
                damageReduction += 1;
            if (name == "Iron Armor")
                damageReduction += 2;
            if (name == "Diamond Armor")
                damageReduction += 3;
            

            
        }

        //use weapons
        public void AddDamage(string name) {
            
            //make sure to take out the previous one's stats from the player's strengh
            strength -= additional_damage;
            additional_damage = 0;

            if (name == "Bronze Sword")
                additional_damage += 1;
            if (name == "Iron Sword")
                additional_damage += 2;
            if (name == "Diamond Sword") 
                additional_damage += 3;
            

            strength += additional_damage;
              
        }

        //Unequip armor
        public void UnequipArmor() {
            damageReduction = 0;
            EquippedItems[0] = "";
        }

        //unequip weapon
        public void UnequipWeapon() {
            strength -= additional_damage;
            additional_damage = 0;
            EquippedItems[1] = "";
        }

        //add the armor stats to the amount, which will cause the player to lose less HP after being attacked
        public void AlterHealth(int amount) {
            Health += amount + damageReduction;
        }


        public void OnAttack(int amount) {
            AttackEvent((int)(amount * strength));
        }
    }
}
