using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Fall2020_CSC403_Project.code
{
    public class Item
    {
        public string NAME;
        private string itemType;
        public Vector2 Position { get; set; }
        public Collider Collider { get; set; }
        public Item(Vector2 initPos, Collider collider, string type, string name)
        {
            Position = initPos;
            Collider = collider;
            itemType = type;
            NAME = name;
        }

        public void useItem(Player player)
        {
            switch(itemType)
            {
                case "health":
                    player.AlterHealth(10);
                    break;
                case "sugar":
                    player.turnOffWalls();
                    Thread thread = new Thread(() => Countdown(20, player));
                    thread.Start();
                    break;
            }
        }

        private void Countdown(int timer, Player player)
        {
            DateTime start = DateTime.Now;
            TimeSpan timeSpan = start - start;
            while(timeSpan.Seconds < timer)
            {
                timeSpan = DateTime.Now - start;
            }
            player.turnOnWalls();
        }
        
    }
}
