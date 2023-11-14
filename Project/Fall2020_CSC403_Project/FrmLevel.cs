using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Fall2020_CSC403_Project
{
  public partial class FrmLevel : Level
  {
    public Player player;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private Weapon ak;
    private Character healthPack;

    private DateTime timeStart;
    private FrmBattle frmBattle;
    private BossDefeatedWrapper bossIsDefeated = new BossDefeatedWrapper(false);

    private DateTime soundTime = DateTime.Now;

    public SoundPlayer walk_sand;
    public SoundPlayer akSound;

    public FrmLevel() : base()
    {
      //added this to keep track of whether or not the boss is defeated
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e)
    {

      //added this to keep track of which level has specifically been saved
      //to a file
      levelID = 1;

      const int PADDING = 0;
      const int NUM_WALLS = 13;

      player = new Player(
        base.CreatePosition(picPlayer),
        base.CreateCollider(picPlayer, PADDING)
      );
      bossKoolaid = new Enemy(
        base.CreatePosition(picBossKoolAid),
        base.CreateCollider(picBossKoolAid, PADDING),
        70
      );
      enemyPoisonPacket = new Enemy(
        base.CreatePosition(picEnemyPoisonPacket),
        base.CreateCollider(picEnemyPoisonPacket, PADDING)
      );
      enemyCheeto = new Enemy(
        base.CreatePosition(picEnemyCheeto),
        base.CreateCollider(picEnemyCheeto, PADDING),
        30
      );

      new GameState(player);
      timeStart = GameState.timeStart;

      //added these to keep track of which entity has been
      //saved to the file
      bossKoolaid.Name = "bossKoolaid";
      enemyCheeto.Name = "enemyCheeto";
      enemyPoisonPacket.Name = "enemyPoisonPacket";

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      ak = new Weapon(CreatePosition(weapon1), CreateCollider(weapon1, PADDING));
      ak.setStrength(4);
      ak.Name = "ak";

      healthPack = new Character(CreatePosition(healthPackLvl1), CreateCollider(healthPackLvl1, PADDING));

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++)
      {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;

      objectsToSave.Add(player);
      objectsToSave.Add(bossKoolaid);
      objectsToSave.Add(enemyCheeto);
      objectsToSave.Add(enemyPoisonPacket);
      objectsToSave.Add(ak);

      if (GameState.saveToLoadFrom != null)
      {
        LoadData(GameState.saveToLoadFrom);
      }


      InitializeSounds();
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
    {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
    {
      if (!GameState.isGamePaused)
      {

        TimeSpan span;

        //GameState.totalPausedTime acts as a correcting factor for when
        //players pause the game
        /*if (GameState.saveTime != default(DateTime))
        {
          span = DateTime.Now.Subtract(GameState.saveTime) - GameState.totalPausedTime;
        }
        else
        {*/
        span = DateTime.Now - timeStart - GameState.totalPausedTime;
        //}
        string time = span.ToString(@"hh\:mm\:ss");
        lblInGameTime.Text = "Time: " + time.ToString();
      }
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e)
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
      if (HitAChar(player, ak))
      {
        walk_sand.Stop();

        if (player.WeaponStrength < ak.getStrength())
        {
          player.WeaponStrength = ak.getStrength();
          player.WeaponEquiped = 1;
          weapon1.Visible = false;
          akSound.Play();
          ak.RemoveCollider();
          akSound.Dispose();

        }
      }
      if (HitAChar(player, healthPack))
      {
        player.HealthPackCount++;
        healthPack.RemoveCollider();
        healthPackLvl1.Visible = false;
      }

      if (HitAChar(player, bossKoolaid) && bossIsDefeated.bossIsDefeated)
      {
        SoundPlayer simpleSound = new SoundPlayer(Resources.nether_portal_enter);
        simpleSound.Play();
        Thread.Sleep(3000);
        //this closes the current form and returns to main
        GameState.isLevelOneCompleted = true;
        GameState.levelToLoad = 2;
        GameState.NextLevel();
      }

      else if (HitAChar(player, bossKoolaid))
      {
        Fight(bossKoolaid);
      }

      // check state of each enemy
      if (!enemyPoisonPacket.IsAlive)
      {
        RemoveEnemy(enemyPoisonPacket, picEnemyPoisonPacket);
      }
      if (!enemyCheeto.IsAlive)
      {
        RemoveEnemy(enemyCheeto, picEnemyCheeto);
      }
      if (!bossKoolaid.IsAlive)
      {
        RemoveBoss(bossKoolaid, picBossKoolAid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c)
    {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++)
      {
        if (c.Collider.Intersects(walls[w].Collider))
        {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other)
    {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy)
    {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, 1);
      frmBattle.Show();

      if (enemy == bossKoolaid)
      {

        // this gives the frmBattle object a reference to this level's bossIsDefeated bool
        frmBattle.bossIsDefeatedReference = this.bossIsDefeated;
        frmBattle.SetupForBossBattle(1);
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
    {
      //this.walk_sand.Load();
      //System.Diagnostics.Debug.WriteLine(soundTime.Second);
      if ((DateTime.Now.Second - soundTime.Second) > 1)
      {
        //walk_sand.Play();
        soundTime = DateTime.Now;
      }
      switch (e.KeyCode)
      {
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
          FrmStartScreen.displayStartScreen();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void RemoveEnemy(Enemy enemy, PictureBox picEnemy)
    {
      enemy.RemoveCollider();
      //picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gravestone;
      picEnemy.BackgroundImage = null;
    }

    private void RemoveBoss(Enemy enemy, PictureBox picEnemy)
    {
      //enemy.RemoveCollider();
      picEnemy.BackgroundImage = null;
      picEnemy.Image = global::Fall2020_CSC403_Project.Properties.Resources.Nether_portal1;
      picEnemy.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void InitializeSounds()
    {
      walk_sand = new SoundPlayer(Resources.walk_sand);
      walk_sand.Load();
      akSound = new SoundPlayer(Resources.ak_Sound);
      akSound.Load();
    }

    public override void LoadData(string fileName)
    {
      foreach (Character character in objectsToSave)
      {
        character.Load(fileName);
      }

      if (player.WeaponEquiped == 0)
      {
        player.WeaponStrength = ak.getStrength();
        player.WeaponEquiped = 1;
        weapon1.Visible = false;
      }

      GameState.saveToLoadFrom = null;
    }
  }
}
