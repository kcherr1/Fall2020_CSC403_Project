using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
    public class Character {
        private const int GO_INC = 3;
        private int gold = 0;

        public Vector2 MoveSpeed { get; private set; }
        public Vector2 LastPosition { get; private set; }
        public Vector2 Position { get; private set; }
        public Collider Collider { get; private set; }

        public Character(Vector2 initPos, Collider collider) {
            Position = initPos;
            Collider = collider;
        }
        // accepts an int and adds that to the players gold.
        public void updateGold(int gUpdate) {
            if (gUpdate == 0) return;

            if (gUpdate < 0) {
                if (Math.Abs(gUpdate) >= this.gold)
                    this.gold = 0;
                else 
                    this.gold += gUpdate;
            }
            else 
                this.gold += gUpdate;

        }

        public void Move() {
            LastPosition = Position;
            Position = new Vector2(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
            Collider.MovePosition((int)Position.x, (int)Position.y);
        }

        public void MoveBack() {
            Position = LastPosition;
        }

        public void GoLeft() {
            MoveSpeed = new Vector2(-GO_INC, 0);
        }
        public void GoRight() {
            MoveSpeed = new Vector2(+GO_INC, 0);
        }
        public void GoUp() {
            MoveSpeed = new Vector2(0, -GO_INC);
        }
        public void GoDown() {
            MoveSpeed = new Vector2(0, +GO_INC);
        }

        public void ResetMoveSpeed() {
            MoveSpeed = new Vector2(0, 0);
        }
    }
}
