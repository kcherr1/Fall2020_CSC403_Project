using System.Drawing;


namespace Fall2020_CSC403_Project.code
{
    public class Boss : Enemy
    {
        public bool showBoss;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        /// <param name="toughness">this is the damage reduction from projectiles</param>
        public Boss(Vector2 initPos, Collider collider, float toughness) : base(initPos, collider, toughness)
        {
            showBoss = false;
        }




        public void setupBoss()
        {
            showBoss = true;
        }
    }
}
