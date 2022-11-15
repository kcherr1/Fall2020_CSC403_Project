using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Fall2020_CSC403_Project
{
    public partial class FrmRandomMap : Form
    {
        public FrmRandomMap()
        {
            InitializeComponent();

        }

        private void FrmRandomMap_Load(object sender, EventArgs e)
        {
            int[,] Map = createMap();

            var rowCount = Map.GetLength(0);
            var colCount = Map.GetLength(1);

            // Just so I can see the matrix of walls (1=wall, 0=open)
            label1.Text = "";
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    label1.Text = label1.Text + String.Format("{0}\t", Map[row, col]);
                }
                label1.Text = label1.Text + String.Format("\n");
            }

            this.SuspendLayout();

            // Size SizeOfWall = picWallTemplate.ClientSize;
            // Now I want to loop through my map matrix and place a wall everywhere there is a 1
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (i==0 || i==rowCount-1 || j == 0 || j==colCount-1 || Map[i, j] == 1)
                    {
                        PictureBox picWallCreated = new PictureBox
                        {
                            Name = "pictureWall" + "_" + i.ToString() + "_" + j.ToString(),
                            Image = picWallTemplate.Image,
                            InitialImage = picWallTemplate.InitialImage,
                            SizeMode = picWallTemplate.SizeMode,
                            Size = picWallTemplate.Size,
                            Location = new Point(j * 50, i * 50),
                            Visible = true,
                        };
                        this.Controls.Add(picWallCreated);
                        picWallCreated.BringToFront();
                        //TextBox txtBoxCreated = new TextBox
                        //{
                        //    Multiline = true,
                        //    Size = txtBoxTemplate.Size,
                        //    Location = new Point(j * 50, i * 50),
                        //    Text = Map[i, j].ToString(),
                        //    Visible = true,
                        //    Enabled = true
                        //};
                        //this.Controls.Add(txtBoxCreated);
                        //txtBoxCreated.BringToFront();
                    }
                }
            }
            this.ResumeLayout();
            label1.BringToFront();
        }
        


    private static int[,] createMap()
    {
        int[] dimensions = { 15, 30 };   // rows & columns of map
        int maxTunnels = 80;             // max number of tunnels possible
        int maxLength = 10;              // max length each tunnel can have
         
        int[,] map = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < dimensions[0]; i++)  // Row
            {
                for (int j = 0; j < dimensions[1]; j++)  // Column
                {
                    map[i, j] = 1;
                }
            }
            Random random = new Random();
            //int currentRow = Math.Floor(Math.Random() * dimensions); // our current row - start at a random spot
            int currentRow = random.Next(dimensions[0]);
            //int currentColumn = Math.floor(Math.random() * dimensions); // our current column - start at a random spot
            int currentColumn = random.Next(dimensions[1]);
            //Create a matrix (array) with 4 rows and 2 columns
            //[-1, 0], [1, 0], [0, -1], [0, 1]]; 
            //array to get a random direction from (left,right,up,down)
            int[][] directions = new int[4][];
            directions[0] = new int[2] {-1,0};
            directions[1] = new int[2] {1,0};
            directions[2] = new int[2] {0,-1};
            directions[3] = new int[2] {0,1};

            int [] lastDirection = new int [2]; // save the last direction we went
            int [] randomDirection = new int[2]; // next turn/direction - holds a value from directions

        // lets create some tunnels - while maxTunnels, dimentions, and maxLength  is greater than 0.
        while (maxTunnels>=0 && dimensions[0] >=0 && maxLength>=0 && dimensions[1]>=0)
        {

            // lets get a random direction - until it is a perpendicular to our lastDirection
            // if the last direction = left or right,
            // then our new direction has to be up or down,
            // and vice versa
            do
            {
                randomDirection = directions[random.Next(directions.Length)];
            } while ((randomDirection[0] == -lastDirection[0] && randomDirection[1] == -lastDirection[1]) || 
                     (randomDirection[0] == lastDirection[0] && randomDirection[1] == lastDirection[1]));

            var randomLength = random.Next(maxLength+1); //length the next tunnel will be (max of maxLength)
              int tunnelLength = 0; //current length of tunnel being created

            // lets loop until our tunnel is long enough or until we hit an edge
            while (tunnelLength < randomLength)
            {

                //break the loop if it is going out of the map
                if (((currentRow == 1) && (randomDirection[0] == -1)) ||
                    ((currentColumn == 1) && (randomDirection[1] == -1)) ||
                    ((currentRow == dimensions[0] - 2) && (randomDirection[0] == 1)) ||
                    ((currentColumn == dimensions[1] - 2) && (randomDirection[1] == 1)))
                {
                    break;
                }
                else
                {
                    map[currentRow, currentColumn] = 0; //set the value of the index in map to 0 (a tunnel, making it one longer)
                        //add the value from randomDirection to row and col (-1, 0, or 1) to update our location
                        currentRow += randomDirection[0];
                        currentColumn += randomDirection[1];
                    tunnelLength++; //the tunnel is now one longer, so lets increment that variable
                }
            }

            if (tunnelLength>0)
            { // update our variables unless our last loop broke before we made any part of a tunnel
                lastDirection = randomDirection; //set lastDirection, so we can remember what way we went
                maxTunnels--; // we created a whole tunnel so lets decrement how many we have left to create
            }
        }
        return map; 
    }
}
}
