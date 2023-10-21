using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Entity {
    private const int GO_INC = 3;

    public Position MoveSpeed { get; private set; }
    public Position LastPosition { get; private set; }
    public Collider Collider { get; private set; }


    public Rectangle Size { get; private set; }
    public Position Position { get; private set; }

    public string Name { get; private set; }


    public Entity(string Name, Position initPos, Collider collider) {
        Position = initPos;
        Collider = collider;
    }

    public void Move() {
      LastPosition = Position;
      Position = new Position(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
      Collider.MovePosition((int)Position.x, (int)Position.y);
    }

    public void MoveBack() {
      Position = LastPosition;
    }

    public void GoLeft() {
      MoveSpeed = new Position(-GO_INC, 0);
    }
    public void GoRight() {
      MoveSpeed = new Position(+GO_INC, 0);
    }
    public void GoUp() {
      MoveSpeed = new Position(0, -GO_INC);
    }
    public void GoDown() {
      MoveSpeed = new Position(0, +GO_INC);
    }

    public void ResetMoveSpeed() {
      MoveSpeed = new Position(0, 0);
    }
  }
}
