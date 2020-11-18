using MyGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
    public class Player : BattleCharacter
    {

        private Inventory inventory;
        private Stats _stats;
        public Stats Stats { get => _stats; }
        public IWeapon EquippedWeapon;

        public Player(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            strength = 1;
            inventory = new Inventory();
            _stats = new Stats(1, 1);
        }

        public Inventory GetInventory()
        {
            return inventory;
        }

        new public void OnAttack(int amount)
        {
            amount -= _stats.Levels.attack;
            base.OnAttack(amount);
        }

        new public void AlterHealth(int amount)
        {
            if (amount < 0)
            {
                amount = Math.Min((amount + _stats.Levels.defence),-1);
                base.AlterHealth(amount);
            }
            else
            {
                base.AlterHealth(amount);
            }
        }
    }
}
