using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
	private Player player;

	private Enemy enemyPoisonPacket;
	private Enemy bossKoolaid;
	private Enemy enemyCheeto;
	private Character[] walls;

  private DateTime timeBegin;
	private TimeSpan span;
  private FrmBattle frmBattle;
  private FrmPause frmPause;

	// PictureBox to handle dead Enemy and player
	private Enemy offScreenEnemy; // whenever an enemy dies, set that enemy to this instance (a hidden pictureBox)
	private Player offScreenPlayer;

	public FrmLevel() {
	  InitializeComponent();
	}

	private void FrmLevel_Load(object sender, EventArgs e) {
	  const int PADDING = 7;
	  const int NUM_WALLS = 13;

	  player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
	  bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
	  enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
	  enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

	  // create instance of for dead enemy and player
	  offScreenEnemy = new Enemy(CreatePosition(picOffScreenEnemy), CreateCollider(picOffScreenEnemy, 0));
	  offScreenPlayer = new Player(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0));

	  bossKoolaid.Img = picBossKoolAid.BackgroundImage;
	  enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
	  enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

	  bossKoolaid.Color = Color.Red;
	  enemyPoisonPacket.Color = Color.Green;
	  enemyCheeto.Color = Color.FromArgb(255, 245, 161);

		bossKoolaid.Type = "boss";
		enemyPoisonPacket.Type = "regular";
		enemyCheeto.Type = "regular";

	  walls = new Character[NUM_WALLS];
	  for (int w = 0; w < NUM_WALLS; w++) {
		PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
		walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
	  }

	  Game.player = player;
	  timeBegin = DateTime.Now;

	  // Show player's health bar when the game first loaded
	  PlayerHealthBar();
	}

	private Vector2 CreatePosition(PictureBox pic) {
	  return new Vector2(pic.Location.X, pic.Location.Y);
	}

	private Collider CreateCollider(PictureBox pic, int padding) {
	  Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
	  return new Collider(rect);
	}

	private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
	  player.ResetMoveSpeed();
	}

	private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
	  span = DateTime.Now - timeBegin;
	  string time = span.ToString(@"hh\:mm\:ss");
	  lblInGameTime.Text = "Time: " + time.ToString();
	}

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
		// Remove dead player's image
		if (IsDead(player))
		{
			picPlayer.Hide();
			player = offScreenPlayer;
			player.Die();
		} else
		{
			// move player
			player.Move();

			// check collision with walls
			if (HitAWall(player))
			{
				player.MoveBack();
			}

			// check collision with enemies
			if (HitAChar(player, enemyPoisonPacket))
			{
				Fight(enemyPoisonPacket);
			}
			else if (HitAChar(player, enemyCheeto))
			{
				Fight(enemyCheeto);
			}
			if (HitAChar(player, bossKoolaid))
			{
				Fight(bossKoolaid);
			}

			// update player's picture box
			picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

			// Remove the dead enemies' images
			if (IsDead(enemyPoisonPacket))
			{
				picEnemyPoisonPacket.Hide();
				enemyPoisonPacket = offScreenEnemy;
			}
			else if (IsDead(enemyCheeto))
			{
				picEnemyCheeto.Hide();
				enemyCheeto = offScreenEnemy;
			}
			else if (IsDead(bossKoolaid))
			{
				picBossKoolAid.Hide();
				bossKoolaid = offScreenEnemy;
			}

			// Update player's health while he is moving
			PlayerHealthBar();
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
	  player.ResetMoveSpeed();
	  player.MoveBack();
	  frmBattle = FrmBattle.GetInstance(enemy);
	  frmBattle.Show();
			Console.WriteLine(enemy);

      if (enemy == bossKoolaid) {
		frmBattle.SetupForBossBattle();
	  }
	}

	private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
	  switch (e.KeyCode) {
		case Keys.Left:
		  player.GoLeft();
		  break;

		case Keys.Right:
		  player.GoRight();
		  break;

		case Keys.Up:
		  player.GoUp();
		  break;

		case Keys.Down:
		  player.GoDown();
		  break;

		case Keys.Escape:
			DatabaseHandler.insert_statistics();
			ShowPauseMenu();
      break;

		default:
			player.ResetMoveSpeed();
			break;
	  }
    }

  private void ShowPauseMenu()
  {
    frmPause = new FrmPause();
    tmrUpdateInGameTime.Enabled = false;    // stop updating game clock
    frmPause.ShowDialog();                  // ShowDialog() disables game window
    timeBegin = DateTime.Now - span;        // account for time elapsed during pause
    tmrUpdateInGameTime.Enabled = true;
  }

	//=======================================================================================
	// Function for update the player's health bar on the main map
	public void PlayerHealthBar()
	{
		float playerHealthPer = player.Health / (float)player.MaxHealth;

		const int MAX_HEALTHBAR_WIDTH = 226;
		lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

		lblPlayerHealthFull.Text = player.Health.ToString();
	}

	// Function to check if enemy is dead
	public bool IsDead(BattleCharacter character)
	{
		bool isDead = false;
		if (character.Health <= 0)
		{
			isDead = true;
		}
		return isDead;
	}

	// Function to move enemy infinitely 
	public void MoveInterval(Enemy enemy, string moveCoordinate, int moveSpeed, int moveDistance)
	{
			enemy.Move();
	}
	}
}
