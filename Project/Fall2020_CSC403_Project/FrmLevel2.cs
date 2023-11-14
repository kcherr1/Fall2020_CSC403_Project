using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using Microsoft.CSharp.RuntimeBinder;
using MyGameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel2 : Level {
    //public GameState gameState { get; private set; }
    private Player player;
    private Enemy goose;
    private Enemy alligator;
    private Enemy bossSquirrels;
    private Character[] walls;
    private Character[] hedges;
    private Character[] obstacles;
    private FrmBattle frmBattle;
    private DateTime timeStart;
    private BossDefeatedWrapper bossIsDefeated = new BossDefeatedWrapper(false);
    private Character healthPack;
    private Weapon rpg;

    private DateTime soundTime = DateTime.Now;

    public SoundPlayer walk_grass;

    public FrmLevel2() : base() {

      //this.picPlayer.Location = new System.Drawing.Point(159, 628);
      InitializeComponent();
    }

    private void LoadLevel(object send, EventArgs e) {
      levelID = 2;

      if (GameState.player == null)
      {
        player = new Player(
        base.CreatePosition(picPlayer),
        base.CreateCollider(picPlayer, 0)
        );

        new GameState(player);
        timeStart = GameState.timeStart;
      }

      this.player = GameState.player;
      this.player.MoveTo(119, 510);
      this.player.ResetMoveSpeed();

      const int WALL_COUNT = 46;
      const int HEDGE_COUNT = 23;
      const int OBSTACLE_COUNT = 16;
      const int PADDING = 0;
      goose = new Enemy(
      base.CreatePosition(picGoose),
      base.CreateCollider(picGoose, PADDING)
      );
      alligator = new Enemy(
        base.CreatePosition(picAlligator),
        base.CreateCollider(picAlligator, PADDING),
        50
      );
      bossSquirrels = new Enemy(
        base.CreatePosition(picSquirrel3),
        base.CreateCollider(picSquirrel3, PADDING),
        100
      );

      bossSquirrels.Name = "bossSquirrels";
      goose.Name = "goose";
      alligator.Name = "alligator";

      timeStart = GameState.timeStart;
      player = GameState.player;

      goose.Img = picGoose.BackgroundImage;
      alligator.Img = picAlligator.BackgroundImage;
      bossSquirrels.Img = picSquirrel3.BackgroundImage;

      goose.Color = Color.LightGray;
      alligator.Color = Color.DarkOliveGreen;
      bossSquirrels.Color = Color.SaddleBrown;

      healthPack = new Character(CreatePosition(healthPackLvl2), CreateCollider(healthPackLvl2, PADDING));
      rpg = new Weapon(CreatePosition(rpgPic), CreateCollider(rpgPic, PADDING));
      rpg.setStrength(7);

      walls = new Character[WALL_COUNT];
      for (int w = 1; w <= WALL_COUNT; w++) {
        PictureBox pic = Controls.Find("wall" + w.ToString(), true)[0] as PictureBox;
        walls[w-1] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      obstacles = new Character[OBSTACLE_COUNT];
      for (int o = 1; o <= OBSTACLE_COUNT; o++) {
        PictureBox pic = Controls.Find("obstacle" + o.ToString(), true)[0] as PictureBox;
        obstacles[o - 1] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      hedges = new Character[HEDGE_COUNT];
      for (int h = 1; h <= HEDGE_COUNT; h++) {
        PictureBox pic = Controls.Find("hedge" + h.ToString(), true)[0] as PictureBox;
        hedges[h - 1] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      Game.player = GameState.player;

      SoundPlayer simpleSound = new SoundPlayer(Resources.nether_portal_exit);
      simpleSound.Play();

      InitializeSounds();

      objectsToSave.Add(player);
      objectsToSave.Add(goose);
      objectsToSave.Add(alligator);
      objectsToSave.Add(bossSquirrels);

      if (GameState.saveToLoadFrom != null)
      {
        LoadData(GameState.saveToLoadFrom);
      }
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeStart;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
        //Debug.WriteLine("hit a wall!");
      }

      if (HitAHedge(player)) {
        player.MoveBack();
        //Debug.WriteLine("hit a hedge!");
      }

      if (HitAnObstacle(player)) {
        player.MoveBack();
        //Debug.WriteLine("hit a obstacle!");
      }

      // check collision with enemies
      if (HitAChar(player, goose)) {
        Fight(goose);
      }
      else if (HitAChar(player, alligator)) {
        Fight(alligator);
      }

      if (HitAChar(player, bossSquirrels) && bossIsDefeated.bossIsDefeated) {
        // this closes the current form and returns to main
        GameState.isLevelTwoCompleted = true;
        GameState.levelToLoad = 3;
        GameState.NextLevel();
      }
      else if (HitAChar(player, bossSquirrels)) {
        Fight(bossSquirrels);
      }
      if (HitAChar(player, rpg)) {
        if (player.WeaponStrength < rpg.getStrength()){
          player.WeaponStrength = rpg.getStrength();
          player.WeaponEquiped = 2;
          rpgPic.Visible = false;
        }
      }
      if (HitAChar(player, healthPack)){
        player.HealthPackCount++;
        healthPack.RemoveCollider();
        healthPackLvl2.Visible = false;
      }

      // check state of each enemy
      if (!goose.IsAlive) {
        RemoveEnemy(goose, picGoose);
      }
      if (!alligator.IsAlive) {
        RemoveEnemy(alligator, picAlligator);
      }
      if (!bossSquirrels.IsAlive) {
        RemoveEnemy(bossSquirrels, picSquirrel3);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
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

    private bool HitAnObstacle(Character c) {
      bool hitAnObstacle = false;
      for (int o = 0; o < obstacles.Length; o++) {
        if (c.Collider.Intersects(obstacles[o].Collider)) {
          hitAnObstacle = true;
          break;
        }
      }
      return hitAnObstacle;
    }

    private bool HitAHedge(Character c) {
      bool hitAHedge = false;
      for (int h = 0; h < hedges.Length; h++) {
        if (c.Collider.Intersects(hedges[h].Collider)) {
          hitAHedge = true;
          break;
        }
      }
      return hitAHedge;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy)
    {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, 2);
      frmBattle.Show();

      if (enemy == bossSquirrels)
      {
        frmBattle.bossIsDefeatedReference = this.bossIsDefeated;
        frmBattle.SetupForBossBattle(2);
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      if ((DateTime.Now.Second - soundTime.Second) > 1)
      {
        //walk_sand.Play();
        soundTime = DateTime.Now;
      }
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
          FrmStartScreen.displayStartScreen();
          break;
        default:
          player.ResetMoveSpeed();
          break;
      }
    }



    private void RemoveEnemy(Enemy enemy, PictureBox picEnemy) {
      enemy.RemoveCollider();
      //picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gravestone;
      picEnemy.BackgroundImage = null;
    }

    private void hedge13_Click(object sender, EventArgs e) {

    }

    private void InitializeSounds()
    {
      //walk_grass = new SoundPlayer(Resources.walk_grass);
      //walk_grass.Load();
    }

    private void MenuButton_Click(object sender, EventArgs e)
    {
      FrmStartScreen.displayStartScreen();
    }

    public override void LoadData(string fileName)
    {
      foreach (Character character in objectsToSave)
      {
        character.Load(fileName);
      }

      GameState.saveToLoadFrom = null;
    }
  }
}
