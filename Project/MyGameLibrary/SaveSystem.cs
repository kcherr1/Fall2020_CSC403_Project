using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Fall2020_CSC403_Project.code
{

	//centralize the data that needs to be saved
	public struct SaveStruct
	{
		public int Health;
		public int maxHealth;
		public int experience;
        public float playerStrength;
        public float playerDefense;
        public float playerSpeed;
		public float level;
		public float playerPosX;
		public float playerPosY;
		public float poisonHealth;
        public float cheetoHealth;
        public float koolaidHealth;

		//constructor
        public SaveStruct(Player player, Enemy poison, Enemy cheeto, Enemy koolaid)
		{
			this.Health = player.Health;
			this.maxHealth = player.MaxHealth;
            this.experience = player.Experience;
            this.playerStrength = player.playerStrength;
			this.playerDefense = player.playerDefense;
			this.playerSpeed = player.playerSpeed;
			this.level = player.level;
			this.playerPosX = player.Position.x;
            this.playerPosY = player.Position.y;
            this.poisonHealth = poison.Health;
            this.cheetoHealth = cheeto.Health;
            this.koolaidHealth = koolaid.Health;

        }

	}

	public static class SaveSystem
	{
		public static void SaveGame(string savename, Player player, Enemy poison, Enemy cheeto, Enemy koolaid)
		{
			SaveStruct save = new SaveStruct(player, poison, cheeto, koolaid);
			string[] data =
			{
				save.Health.ToString(),
				save.maxHealth.ToString(),
				save.experience.ToString(),
                save.playerStrength.ToString(),
                save.playerDefense.ToString(),
                save.playerSpeed .ToString(),
                save.level.ToString(),
                save.playerPosX.ToString(),
                save.playerPosY.ToString(),
                save.poisonHealth.ToString(),
                save.cheetoHealth.ToString(),
                save.koolaidHealth.ToString(),
			};

			File.WriteAllLines(savename, data);

			string[] texts = File.ReadAllLines(savename);
			foreach(string text in texts)
			{
				Console.WriteLine(text);
			};
        }

		public static bool IsSaveFileValid(string saveName)
		{
			if (File.Exists(saveName))
			{
				string[] texts = File.ReadAllLines(saveName);
				if(texts.Length != 12)
				{
					return false;
				}
				foreach (string text in texts)
				{
					double val;
					if (!double.TryParse(text, out val))
					{
						return false;
					}
				}
				return true;
			}
			else
			{
				return false;
			}
		}

        public static void LoadGame(string savename, Player player, Enemy poison, Enemy cheeto, Enemy koolaid)
        {
			string[] texts = File.ReadAllLines(savename);
			player.Health = int.Parse(texts[0]);
			player.MaxHealth = int.Parse(texts[1]);
			player.Experience = int.Parse(texts[2]);
			player.playerStrength = float.Parse(texts[3]);
			player.playerDefense = float.Parse(texts[4]);
			player.playerSpeed = float.Parse(texts[5]);
			player.level = float.Parse(texts[6]);
			player.Position = new Vector2(float.Parse(texts[7]), float.Parse(texts[8]));
			poison.Health = int.Parse(texts[9]);
			cheeto.Health = int.Parse(texts[10]);
			koolaid.Health = int.Parse(texts[11]);
        }
    }
}