using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class GridLevel3 : PopulateGrid
    {
        #region Variables
        private MainPage Window { get; set; }
        #endregion

        #region Constructor
        public GridLevel3(MainPage window) : base(window)
        {
            this.Window = window;
        }
        #endregion

        #region Populate Grid Level2
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

            //for this second grid we are placing the lion in row 4, column 9
            drawContents("Images\\lion.png", 8, 5);
            // setup the location of our lion so we can keep track and update it
            Window.LionRow = 8;
            Window.LionColumn = 5;
            // for this second level we are placing the cebra in row 8, column 3
            drawContents("Images\\cebra.png", 1, 3);
            // setup the location of the cebra so we can keep track and update it
            Window.CebraRow = 1;
            Window.CebraColumn = 3;
            //here we set the coordinates for the win condition
            Window.WinLocationRow = 4;
            Window.WinLocationColumn = 3;
            // setup image for win condition
            drawContents("Images\\fire.png", 4, 3);
            // setup image for obstacles
            drawContents("Images\\obstacle.PNG", 3, 1);
            drawContents("Images\\obstacle.PNG", 3, 2);
            drawContents("Images\\obstacle2.png", 3, 3);
            drawContents("Images\\obstacle.PNG", 3, 4);
            drawContents("Images\\obstacle3.png", 3, 5);
            drawContents("Images\\obstacle.PNG", 4, 1);
            drawContents("Images\\obstacle.PNG", 4, 2);
            drawContents("Images\\obstacle2.png", 5, 1);
            drawContents("Images\\obstacle.PNG", 5, 2);
            drawContents("Images\\obstacle3.png", 6, 1);
            drawContents("Images\\obstacle.PNG", 5, 2);
            drawContents("Images\\obstacle.PNG", 7, 1);
            drawContents("Images\\obstacle2.png", 7, 2);
            drawContents("Images\\obstacle.PNG", 8, 3);
            drawContents("Images\\obstacle3.png", 8, 4);
            drawContents("Images\\obstacle3.png", 7, 5);
            drawContents("Images\\obstacle2.png", 4, 4);
            drawContents("Images\\obstacle.PNG", 3, 5);
            drawContents("Images\\obstacle3.png", 5, 4);
            drawContents("Images\\obstacle2.png", 5, 5);
            drawContents("Images\\obstacle3.png", 9, 0);
            drawContents("Images\\obstacle3.png", 9, 1);
            drawContents("Images\\obstacle2.png", 1, 1);
            drawContents("Images\\obstacle.png", 1, 2);
            drawContents("Images\\obstacle2.png", 1, 4);
            drawContents("Images\\obstacle.png", 1, 5);
            drawContents("Images\\obstacle3.png", 1, 8);
            drawContents("Images\\obstacle3.png", 1, 9);
            drawContents("Images\\obstacle2.png", 1, 6);
            drawContents("Images\\obstacle3.png", 3, 6);
            drawContents("Images\\obstacle.png", 3, 8);
            drawContents("Images\\obstacle3.png", 4, 8);
            drawContents("Images\\obstacle2.png", 5, 8);
            drawContents("Images\\obstacle.png", 7, 6);
            drawContents("Images\\obstacle.png", 7, 7);
            drawContents("Images\\obstacle3.png", 7, 8);
            drawContents("Images\\obstacle3.png", 7, 9);
            drawContents("Images\\obstacle.png", 8, 6);
            drawContents("Images\\obstacle2.png", 8, 7);
            drawContents("Images\\obstacle2.png", 8, 8);
            drawContents("Images\\obstacle2.png", 8, 9);
            drawContents("Images\\obstacle.png", 9, 6);
            drawContents("Images\\obstacle3.png", 9, 7);
            drawContents("Images\\obstacle3.png", 9, 8);
            drawContents("Images\\obstacle2.png", 9, 9);

            // setup obtacles into an array
            Window.obstacles[0] = $"{31}";
            Window.obstacles[1] = $"{32}";
            Window.obstacles[2] = $"{33}";
            Window.obstacles[3] = $"{34}";
            Window.obstacles[4] = $"{35}";
            Window.obstacles[5] = $"{41}";
            Window.obstacles[6] = $"{42}";
            Window.obstacles[7] = $"{51}";
            Window.obstacles[8] = $"{52}";
            Window.obstacles[9] = $"{61}";
            Window.obstacles[10] = $"{62}";
            Window.obstacles[11] = $"{71}";
            Window.obstacles[12] = $"{72}";
            Window.obstacles[13] = $"{83}";
            Window.obstacles[14] = $"{84}";
            Window.obstacles[15] = $"{75}";
            Window.obstacles[16] = $"{44}";
            Window.obstacles[17] = $"{45}";
            Window.obstacles[18] = $"{54}";
            Window.obstacles[19] = $"{55}";
            Window.obstacles[20] = $"{90}";
            Window.obstacles[21] = $"{91}";
            Window.obstacles[22] = $"{11}";
            Window.obstacles[23] = $"{12}";
            Window.obstacles[24] = $"{14}";
            Window.obstacles[25] = $"{15}";
            Window.obstacles[26] = $"{18}";
            Window.obstacles[27] = $"{19}";
            Window.obstacles[28] = $"{36}";
            Window.obstacles[29] = $"{16}";
            Window.obstacles[30] = $"{38}";
            Window.obstacles[31] = $"{48}";
            Window.obstacles[32] = $"{58}";
            Window.obstacles[33] = $"{76}";
            Window.obstacles[34] = $"{77}";
            Window.obstacles[35] = $"{78}";
            Window.obstacles[36] = $"{79}";
            Window.obstacles[37] = $"{86}";
            Window.obstacles[38] = $"{87}";
            Window.obstacles[39] = $"{88}";
            Window.obstacles[40] = $"{89}";
            Window.obstacles[41] = $"{96}";
            Window.obstacles[42] = $"{97}";
            Window.obstacles[43] = $"{98}";
            Window.obstacles[44] = $"{99}";
        }
        #endregion
    }
}
