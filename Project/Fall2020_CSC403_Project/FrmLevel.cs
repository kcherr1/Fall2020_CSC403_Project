using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
    private AudioManager audioManager;

    private DateTime timeBegin;
    private FrmBattle frmBattle;

    private DialogueBox dialogueBox;
    private Dialogue defaultDialog;
    private Dialogue koolaidManDialogue;
    private Dialogue poisonKoolaidDialogue;
    private Dialogue cheetoDialogue;
        

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), picBossKoolAid);
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), picEnemyPoisonPacket);
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), picEnemyCheeto);

      dialogueBox = new DialogueBox(CreatePosition(picDialogueBox), CreateCollider(picDialogueBox, PADDING), picDialogueBox, dialogLabel);
      audioManager = AudioManager.Instance;
      audioManager.AddSound("overworld_music", new SoundPlayer(Resources.overworld_music));
      audioManager.AddSound("final_battle", new SoundPlayer(Resources.final_battle));
      audioManager.PlaySoundLoop("overworld_music");

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      dialogueBox.Img = picDialogueBox.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      // The default dialogue is for debugging 
      String[] defaultLines = { "Test Line 1", "Test\nLine 2" };
      int[] defaultLetterSpeeds = { 40, 10 };
      defaultDialog = new Dialogue(defaultLines, defaultLetterSpeeds, null);

      String[] koolaidManLines = { "You hear a a slight rumble...", "Koolaid Man breaks through the wall", "\"OHH, YEAH\"" };
      int[] koolaidManSpeeds = { 40, 40, 120 };
      koolaidManDialogue = new Dialogue(koolaidManLines, koolaidManSpeeds, bossKoolaid);

      String[] poisonKoolaidLines = { "neurotoxins" };
      int[] poisonKoolaidSpeeds = { 40 };
      poisonKoolaidDialogue = new Dialogue(poisonKoolaidLines, poisonKoolaidSpeeds, enemyPoisonPacket);

      String[] cheetoLines = { "HOW DO YOU EXPECT TO FIGHT", "WHEN YOUR HANDS ARE COVERED IN CHEETO DUST!" };
      int[] cheetoSpeeds = { 40, 50 };
      cheetoDialogue = new Dialogue(cheetoLines, cheetoSpeeds, enemyCheeto);

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      if(player.MovementValue() <= 1)
      {
                player.ResetMoveSpeed();
      }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player._movementBools[0] = false;
                    break;

                case Keys.Right:
                    player._movementBools[1] = false;
                    break;

                case Keys.Up:
                    player._movementBools[2] = false;
                    break;

                case Keys.Down:
                    player._movementBools[3] = false;
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        StartDialogueThenBattle(poisonKoolaidDialogue);
      }
      else if (HitAChar(player, enemyCheeto)) {
        StartDialogueThenBattle(cheetoDialogue);
      }
      else if (HitAChar(player, bossKoolaid)) {
        StartDialogueThenBattle(koolaidManDialogue);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

      // update player's main screen health bar
      float playerHealthPer = player.Health / (float)player.MaxHealth;
            
      const int MAX_HEALTHBAR_WIDTH = 226;
      permLblPlayerHealth.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      permLblPlayerHealth.Text = "HP: " + player.Health.ToString();
    }

    // Starts the dialague for an enemy, which in turn will start the battle once it is over
    private void StartDialogueThenBattle(Dialogue d) {
            player.ResetMoveSpeed();
            player.MoveBack();
            dialogueBox.SetCurrentDialogue(d);
            if (!dialogueBox.IsShown)
            {
                dialogueBox.ShowBox();
            }
        }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      // player.ResetMoveSpeed();
      // player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
      audioManager.PlaySound("final_battle");
      frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {

      bool characterMoving = false;
            if (dialogueBox.IsShown)
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        ContinueDialogue();
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
                player.ResetMoveSpeed();
                return;
            }
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
                    player._movementBools[0] = true;
          break;

        case Keys.Right:
          player.GoRight();
                    player._movementBools[1] = true;
                    break;

        case Keys.Up:
          player.GoUp();
                    player._movementBools[2] = true;
                    break;

        case Keys.Down:
          player.GoDown();

                    player._movementBools[3] = true;
                    break;

                case Keys.Space:
                    ContinueDialogue();
                    break;
          
        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void ContinueDialogue()
        {
            // this first if statement prevents the player from spamming the dialogue box, 
            // meaning the current line has to end before going to the next line
            if (dialogueBox.IsTyping)
            {
                ;
            }
            else if (dialogueBox.IsLastLine())
            {
                dialogueBox.HideBox();
                Enemy dialogueEnemy = dialogueBox.getEnemy();
                if (dialogueEnemy != null)
                {
                    Fight(dialogueEnemy);
                }
            }
            else
            {
                dialogueBox.GetNextText();
            }
        }

    // Used to recognize mouse1 clicks 
    private void lblInGameTime_Click(object sender, EventArgs e) {
    }
        private void picDialogueBox_Click(object sender, EventArgs e)
        {
            ContinueDialogue();
        }

        private void dialogLabel_Click(object sender, EventArgs e)
        {
            ContinueDialogue();
        }
    }
}
