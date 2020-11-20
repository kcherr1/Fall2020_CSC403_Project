﻿using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// This is the class for an enemy
    /// </summary>
    public class Enemy : BattleCharacter
    {
        /// <summary>
        /// THis is the image for an enemy
        /// </summary>
        public Image Img { get; set; }

        /// <summary>
        /// this is the background color for the fight form for this enemy
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// this boolean sets whether the enemy is meant to be a boss enemy or not
        /// </summary>
        public bool IsBoss { get; set; }

        /// <summary>
        /// boolean tracks whether enemy is still alive, prevents player from farming xp off dead enemies
        /// </summary>
        public bool IsAlive { get; set; }

        /// <summary>
        /// int stores how many experience points will be awarded to the player upon defeating enemy
        /// </summary>
        public int ExpReward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        public Enemy(Vector2 initPos, Collider collider, int ExpReward, int maxHealth = 20) : base(initPos, collider, maxHealth)
        {
            this.ExpReward = ExpReward;
            IsAlive = true;
        }
    }
}
