using System;
using System.Text.Json;

namespace Fall2020_CSC403_Project.code
{

	public struct SaveStruct
	{
		public int health;
		public int maxHealth;
		public int experience;
        public float playerStrength;
        public float playerDefense;
        public float playerSpeed;
		public float level;
		public Vector2 playerPos;
		public BattleCharacter[] enemies;


		public SaveStruct(Player player, Vector2 playerPos, BattleCharacter[] enemies)
		{
			this.health = player.Health;
			this.maxHealth = player.MaxHealth;
			this.playerStrength = player.playerStrength;
			this.playerDefense = player.playerDefense;
			this.playerSpeed = player.playerSpeed;
			this.level = player.level;
			this.playerPos = playerPos;
			this.enemies =	enemies;
		}

	}

	public class SaveSystem
	{

		public SaveSystem()
		{

		}


		
	}
}