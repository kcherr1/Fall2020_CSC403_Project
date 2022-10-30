using System;
using System.Timers;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Character {
    public const int expression = 0;
    public int GO_INC = 3;
    public int characterSpeed = 2;
    public int[] charPosition = new int[8];

    public Vector2 MoveSpeed { get; private set; }
    public Vector2 LastPosition { get; private set; }
    public Vector2 Position { get; private set; }
    public Vector2 Velocity { get; private set; }

    public Collider Collider;

    public Character(Vector2 initPos, Collider collider)
    {
            Position = initPos;
            Collider = collider;
    }

    public void Move() {
      LastPosition = Position;
      Position = new Vector2(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
      Collider.MovePosition((int)Position.x, (int)Position.y);
    }

    public void MoveBack() {
      Position = LastPosition;
    }
    public void CharacterSelectedSpeed(int s)
    {
        characterSpeed = s;
    }
   
        public void CountUpAndDown(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Inside CountUpAndDown Method");
        }
        public void KeysPressed(KeyEventArgs e, int up_key_down, int left_key_down, int down_key_down, int right_key_down, int up_key_up, int left_key_up, int down_key_up, int right_key_up)
    {       // Track directional key presses and diagonal decisions
            Console.WriteLine("CharacterCall\n"+e.KeyCode + "\n  " + up_key_down + "        " + left_key_down + "        " +
                "\n" + down_key_down + "   " + right_key_down + "    " + left_key_up + "   " + right_key_up + "    " + "   " +
                "\n  " + down_key_up + "        " + right_key_up + "        \n");
            for(int i = 0; i <= 7; i++)
            {
                Console.Write(charPosition[i]+"  ");
            }
            Console.WriteLine("\n");
            // String representation of keys
            KeysConverter converter = new KeysConverter();
            string keyPressed = converter.ConvertToString(e.KeyValue);
            string stockLeftKey = converter.ConvertToString(Keys.Left);
            string stockRightKey = converter.ConvertToString(Keys.Right);
            string stockUpKey = converter.ConvertToString(Keys.Up);
            string stockDownKey = converter.ConvertToString(Keys.Down);
            
            if (keyPressed == stockLeftKey)
            {
                MoveSpeed = new Vector2(-characterSpeed, 0);
                if (e.KeyCode == Keys.Left && charPosition[0] == 1) // Left and Up
                    MoveSpeed = new Vector2(-characterSpeed,-characterSpeed);
                else if (e.KeyCode == Keys.Left && charPosition[2] == 1) // Left and Down
                    MoveSpeed = new Vector2(-characterSpeed,characterSpeed);
            }
            else if (keyPressed == stockRightKey)
            {
                MoveSpeed = new Vector2(characterSpeed, 0);
                if (e.KeyCode == Keys.Right && charPosition[0] == 1) // Right and Up
                    MoveSpeed = new Vector2(characterSpeed, -characterSpeed);
                else if (e.KeyCode == Keys.Right && charPosition[2] == 1) // Right and Down
                    MoveSpeed = new Vector2(characterSpeed, characterSpeed);
            }
            else if (keyPressed == stockUpKey)
            {
                MoveSpeed = new Vector2(0,-characterSpeed);
                if (e.KeyCode == Keys.Up && charPosition[1] == 1) // Up and Left
                    MoveSpeed = new Vector2(-characterSpeed, -characterSpeed);
                else if (e.KeyCode == Keys.Up && charPosition[3] == 1) // Up and Right
                    MoveSpeed = new Vector2(characterSpeed, -characterSpeed);
            }
            else if (keyPressed == stockDownKey)
            {
                MoveSpeed = new Vector2(0,characterSpeed);
                if (e.KeyCode == Keys.Down && charPosition[1] == 1) // Down and Left
                    MoveSpeed = new Vector2(-characterSpeed, characterSpeed);
                else if (e.KeyCode == Keys.Down && charPosition[3] == 1) // Down and Right
                    MoveSpeed = new Vector2(characterSpeed, characterSpeed);
            }
            else
            {
                ResetMoveSpeed();
            }
    }
        public void ResetMoveSpeed() {
      MoveSpeed = new Vector2(0, 0);
    }
  }
}
