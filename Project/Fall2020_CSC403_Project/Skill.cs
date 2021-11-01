namespace Fall2020_CSC403_Project.code
{
	public class Skill
	{
		public string Name 		{ get; private set; }
		public int Level 		{ get; private set; }
		public int MaxLevel 	{ get; private set; }
		public int Experience 	{ get; private set; }
		public int MaxExperience { get; private set; }
		public Skill(string name)
		{
			Name = name;
			Level = 1;
			MaxLevel = 99;
			Experience = 0;
			MaxExperience = 100;
		}

		public void AddExperience(int exp)
		{
			if (Level == MaxLevel)
			{
				return;
			}

			Experience += exp;
			while (Experience > MaxExperience)
			{
				LevelUp();
				Experience -= MaxExperience;
			}
		}

		private void LevelUp()
		{
			Level++;
			MaxExperience = Level * Level * 100;
		}
	}
}