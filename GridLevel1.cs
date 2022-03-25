using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sokoban
{
    class GridLevel1 : PopulateGrid
    {
        #region Variables
        private MainPage Window { get; set; }
        #endregion

        #region Constructor
        public GridLevel1(MainPage window) : base(window)
        {
            this.Window = window;
        }
        #endregion

        #region Grid for Level 1
        public override void DrawGrid() // implementing inherited method
        {

            //filling the grid with the background image
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    drawContents("Images\\background.PNG", x, y);
                }
            }

            // Initialize levelcounter back to 0
            // in case all levels have been done and the player restarts the game
            Window.LevelCounter = 0;

            //for this initial grid we are placing the lion in row 4, column 4
            drawContents("Images\\lion.png", 0, 0);
            // setup the location of our lion so we can keep track and update it
            Window.LionRow = 0;
            Window.LionColumn = 0;
            // for this initial grid we are placing the cebra in row 6, column 6
            drawContents("Images\\cebra.png", 3, 1);
            // setup the location of the cebra so we can keep track and update it
            Window.CebraRow = 3;
            Window.CebraColumn = 1;
            Window.WinLocationRow = 9;
            Window.WinLocationColumn = 9;
            // setup image for win condition
            drawContents("Images\\fire.png", 9, 9);
            // setup image for obstacles
            drawContents("Images\\obstacle.PNG", 1, 0);
            drawContents("Images\\obstacle.PNG", 1, 1);
            drawContents("Images\\obstacle2.png", 1, 2);
            drawContents("Images\\obstacle.PNG", 1, 3);
            drawContents("Images\\obstacle3.png", 1, 4);
            drawContents("Images\\obstacle2.png", 1, 9);
            drawContents("Images\\obstacle3.PNG", 2, 0);
            drawContents("Images\\obstacle.PNG", 2, 3);
            drawContents("Images\\obstacle2.PNG", 2, 6);
            drawContents("Images\\obstacle2.PNG", 2, 7);
            drawContents("Images\\obstacle3.PNG", 2, 8);
            drawContents("Images\\obstacle3.PNG", 2, 9);
            drawContents("Images\\obstacle.PNG", 5, 2);
            drawContents("Images\\obstacle3.png", 5, 3);
            drawContents("Images\\obstacle3.png", 5, 4);
            drawContents("Images\\obstacle3.PNG", 5, 5);
            drawContents("Images\\obstacle.PNG", 6, 3);
            drawContents("Images\\obstacle2.PNG", 6, 4);
            drawContents("Images\\obstacle2.PNG", 6, 5);
            drawContents("Images\\obstacle.PNG", 7, 2);
            drawContents("Images\\obstacle3.PNG", 7, 3);
            drawContents("Images\\obstacle2.PNG", 7, 4);
            drawContents("Images\\obstacle3.PNG", 7, 5);
            drawContents("Images\\obstacle2.PNG", 4, 8);
            drawContents("Images\\obstacle3.PNG", 5, 8);
            drawContents("Images\\obstacle.PNG", 6, 8);
            drawContents("Images\\obstacle3.PNG", 8, 8);
            drawContents("Images\\obstacle.PNG", 9, 8);
            drawContents("Images\\obstacle3.PNG", 4, 0);
            drawContents("Images\\obstacle2.PNG", 5, 0);
            drawContents("Images\\obstacle3.PNG", 6, 0);
            drawContents("Images\\obstacle3.PNG", 9, 0);
            drawContents("Images\\obstacle.PNG", 9, 1);
            drawContents("Images\\obstacle3.PNG", 9, 2);
            drawContents("Images\\obstacle2.PNG", 9, 3);
            drawContents("Images\\obstacle3.PNG", 9, 4);
            drawContents("Images\\obstacle3.PNG", 9, 5);
            

            // setup obtacles into an array
            Window.obstacles[0] = $"{10}";
            Window.obstacles[1] = $"{11}";
            Window.obstacles[2] = $"{12}";
            Window.obstacles[3] = $"{13}";
            Window.obstacles[4] = $"{14}";
            Window.obstacles[5] = $"{19}";
            Window.obstacles[6] = $"{20}";
            Window.obstacles[7] = $"{23}";
            Window.obstacles[8] = $"{26}";
            Window.obstacles[9] = $"{27}";
            Window.obstacles[10] = $"{28}";
            Window.obstacles[11] = $"{29}";
            Window.obstacles[12] = $"{52}";
            Window.obstacles[13] = $"{53}";
            Window.obstacles[14] = $"{54}";
            Window.obstacles[15] = $"{55}";
            Window.obstacles[16] = $"{63}";
            Window.obstacles[17] = $"{64}";
            Window.obstacles[18] = $"{65}";
            Window.obstacles[19] = $"{72}";
            Window.obstacles[20] = $"{73}";
            Window.obstacles[21] = $"{74}";
            Window.obstacles[22] = $"{75}";
            Window.obstacles[23] = $"{48}";
            Window.obstacles[24] = $"{58}";
            Window.obstacles[25] = $"{68}";
            Window.obstacles[26] = $"{88}";
            Window.obstacles[27] = $"{98}";
            Window.obstacles[28] = $"{40}";
            Window.obstacles[29] = $"{50}";
            Window.obstacles[30] = $"{60}";
            Window.obstacles[31] = $"{90}";
            Window.obstacles[32] = $"{91}";
            Window.obstacles[33] = $"{92}";
            Window.obstacles[34] = $"{93}";
            Window.obstacles[35] = $"{94}";
            Window.obstacles[36] = $"{95}";
            
        }
#endregion
    }
}
