using Fall2020_CSC403_Project.code;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel2 : Level {
    public GameState gameState { get; private set; }
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
    private FrmBattle frmBattle;
    private DateTime time;
    
    public FrmLevel2(GameState gameState) : base() {
      this.gameState = gameState;
      InitializeComponent();
    }

    private void LoadLevel(object send, EventArgs e) {
      const int WALL_COUNT = 13;
      const int PADDING = 0;
      //bossKoolaid = new Enemy(
      //base.CreatePosition(picBossKoolAid),
      //base.CreateCollider(picBossKoolAid, PADDING)
      //);
      //enemyPoisonPacket = new Enemy(
      //  base.CreatePosition(picEnemyPoisonPacket),
      //  base.CreateCollider(picEnemyPoisonPacket, PADDING)
      //);
      //enemyCheeto = new Enemy(
      //  base.CreatePosition(picEnemyCheeto),
      //  base.CreateCollider(picEnemyCheeto, PADDING)
      //);
      time = gameState.timeStart;

      //bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      //enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      //enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[WALL_COUNT];
      for (int w = 0; w < WALL_COUNT; w++) {
        PictureBox pic = Controls.Find("Wall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = gameState.player;
    }

    private void pictureBox2_Click(object sender, EventArgs e) {

    }

    private void pictureBox20_Click(object sender, EventArgs e) {

    }

    private void pictureBox14_Click(object sender, EventArgs e) {

    }

    private void pictureBox21_Click(object sender, EventArgs e) {

    }

    private void pictureBox19_Click(object sender, EventArgs e) {

    }

    private void pictureBox25_Click(object sender, EventArgs e) {

    }

    private void pictureBox32_Click(object sender, EventArgs e) {

    }

    private void pictureBox24_Click(object sender, EventArgs e) {

    }

    private void pictureBox39_Click(object sender, EventArgs e) {

    }
  }
}
