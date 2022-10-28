using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
        public int Health;
        public int MaxHealth;
        public int Experience;
    public float playerStrength;
    public float playerDefense;
    public float enemyStrength;
    public float enemyDefense;
    public float playerSpeed;
    public float enemySpeed;
    public float level;
        public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 25;
      playerStrength = 5;
      playerDefense = 2;
      playerSpeed = 2;
      enemyStrength = 2;
      enemyDefense = 1;
      enemySpeed = 1;
      Health = MaxHealth;
      Experience = 0;
      level = 1;
      
    }

    public void PlayerAttack(int amount) {
      AttackEvent((int)((amount * playerStrength)/enemyDefense));
    }
    public void EnemyAttack(int amount)
    {
      AttackEvent((int)((amount * enemyStrength) / playerDefense));
    }
    public void RewardExperience(int amount)
        {
            Experience += amount;
        }
        public void AlterHealth(int amount) {
      Health += amount;
    }
    public void LevelUp()
        {
            MaxHealth += 2;
            playerStrength += 1;
            playerDefense += 1;
            playerSpeed += 1;
            Health = MaxHealth;
            level += 1;
        }
  }
}
