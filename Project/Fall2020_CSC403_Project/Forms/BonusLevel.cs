using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Fall2020_CSC403_Project.Forms
{
    public partial class BonusLevel : Form
    {

        private Player player;
        private Character floor;
        public BonusLevel()
        {
            InitializeComponent();
            Image originalImage = Properties.Resources.brick;

            // Resize the image to a new width and height
            Image resizedImage = ResizeImage(originalImage, new Size(50, 50)); // Replace with your desired width and height

            // Set the resized image to the PictureBox
            SetImage(floor1, resizedImage, 28);

            player = new Player(FrmLevel.CreatePosition(character), FrmLevel.CreateCollider(character, -20));
            /*player.KeysPressed.Add("gravity", new Vector2(0, 3));*/
            floor = new Character(FrmLevel.CreatePosition(floor1), FrmLevel.CreateCollider(floor1, -50));
        }

        private void BonusLevel_tick(object sender, EventArgs e)
        {
            bool isOnFloor = FrmLevel.HitAChar(player, floor);
            player.Move(true); 
            player.IsGrounded = isOnFloor;
            character.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.KeysPressed["left"] = new Vector2(-Player.GO_INC * 2, 0);
                    break;

                case Keys.Right:
                    player.KeysPressed["right"] = new Vector2(Player.GO_INC * 2, 0);
                    break;

                case Keys.Space:
                    if (player.IsGrounded)
                    {
                        player.KeysPressed["jump"] = new Vector2(0, -player.jumpSpeed);
                    }
                    break;

                default:
                    break;
            }
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.KeysPressed.Remove("left");
                    break;

                case Keys.Right:
                    player.KeysPressed.Remove("right");
                    break;

                case Keys.Space:
                    player.KeysPressed.Remove("jump");
                    break;

                default:
                    break;
            }
        }


        public void SetImage(PictureBox pic, Image image, int repeatX)
        {
            Bitmap bm = new Bitmap(image.Width * repeatX, image.Height);
            Graphics gp = Graphics.FromImage(bm);
            for (int x = 0; x <= bm.Width - image.Width; x += image.Width)
            {
                gp.DrawImage(image, new Point(x, 0));
            }
            pic.Image = bm;
        }

        public Image ResizeImage(Image image, Size newSize)
        {
            if (image != null)
            {
                return new Bitmap(image, newSize);
            }
            return null;
        }

    }
}
