using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class GridLevel5 : PopulateGrid
    {
        #region Variables
        private MainPage Window { get; set; }
        #endregion

        #region Constructor
        public GridLevel5(MainPage window) : base(window)
        {
            this.Window = window;
        }
        #endregion

        #region Populate Grid Level5
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
            drawContents("Images\\lion.png", 6, 9);
            // setup the location of our lion so we can keep track and update it
            Window.LionRow = 6;
            Window.LionColumn = 9;
            // for this second level we are placing the cebra in row 8, column 3
            drawContents("Images\\cebra.png", 8, 6);
            // setup the location of the cebra so we can keep track and update it
            Window.CebraRow = 8;
            Window.CebraColumn = 6;
            //here we set the coordinates for the win condition
            Window.WinLocationRow = 0;
            Window.WinLocationColumn = 9;
            // setup image for win condition
            drawContents("Images\\fire.png", 0, 9);
            // setup image for obstacles
            drawContents("Images\\obstacle.PNG", 8, 9);
            drawContents("Images\\obstacle.PNG", 8, 8);
            drawContents("Images\\obstacle2.png", 7, 8);
            drawContents("Images\\obstacle.PNG", 6, 8);
            drawContents("Images\\obstacle3.png", 5, 8);
            drawContents("Images\\obstacle2.png", 4, 8);
            drawContents("Images\\obstacle3.PNG", 3, 8);
            drawContents("Images\\obstacle.PNG", 1, 9);
            drawContents("Images\\obstacle.PNG", 1, 8);
            drawContents("Images\\obstacle3.png", 3, 7);
            drawContents("Images\\obstacle3.png", 3, 6);
            drawContents("Images\\obstacle3.PNG", 3, 5);
            drawContents("Images\\obstacle.PNG", 3, 4);
            drawContents("Images\\obstacle2.PNG", 3, 3);
            drawContents("Images\\obstacle2.PNG", 4, 7);
            drawContents("Images\\obstacle.PNG", 4, 6);
            drawContents("Images\\obstacle3.PNG", 4, 5);
            drawContents("Images\\obstacle2.PNG", 4, 4);
            drawContents("Images\\obstacle3.PNG", 4, 3);
            drawContents("Images\\obstacle2.PNG", 6, 3);
            drawContents("Images\\obstacle3.PNG", 6, 4);
            drawContents("Images\\obstacle.PNG", 6, 5);
            drawContents("Images\\obstacle3.PNG", 6, 6);
            drawContents("Images\\obstacle.PNG", 7, 3);
            drawContents("Images\\obstacle3.PNG", 7, 4);
            drawContents("Images\\obstacle2.PNG", 7, 5);
            drawContents("Images\\obstacle3.PNG", 7, 6);
            drawContents("Images\\obstacle3.PNG", 1, 1);
            drawContents("Images\\obstacle.PNG", 2, 1);
            drawContents("Images\\obstacle3.PNG", 3, 1);
            drawContents("Images\\obstacle2.PNG", 4, 1);
            drawContents("Images\\obstacle3.PNG", 5, 1);
            drawContents("Images\\obstacle3.PNG", 6, 1);
            drawContents("Images\\obstacle.PNG", 7, 1);
            drawContents("Images\\obstacle2.PNG", 8, 1);
            drawContents("Images\\obstacle3.PNG", 9, 3);
            drawContents("Images\\obstacle.PNG", 9, 4);
            drawContents("Images\\obstacle2.PNG", 9, 5);
            drawContents("Images\\obstacle.PNG", 9, 6);
            drawContents("Images\\obstacle2.PNG", 9, 7);
            drawContents("Images\\obstacle.PNG", 9, 8);
            drawContents("Images\\obstacle2.PNG", 9, 9);
            drawContents("Images\\obstacle3.PNG", 1, 4);
            drawContents("Images\\obstacle3.PNG", 1, 5);
            drawContents("Images\\obstacle.PNG", 1, 6);
            drawContents("Images\\obstacle2.PNG", 1, 7);
            drawContents("Images\\obstacle3.PNG", 1, 8);
            drawContents("Images\\obstacle.PNG", 1, 3);

            // setup obtacles into an array
            Window.obstacles[0] = $"{89}";
            Window.obstacles[1] = $"{88}";
            Window.obstacles[2] = $"{78}";
            Window.obstacles[3] = $"{68}";
            Window.obstacles[4] = $"{58}";
            Window.obstacles[5] = $"{48}";
            Window.obstacles[6] = $"{38}";
            Window.obstacles[7] = $"{19}";
            Window.obstacles[8] = $"{18}";
            Window.obstacles[9] = $"{37}";
            Window.obstacles[10] = $"{36}";
            Window.obstacles[11] = $"{35}";
            Window.obstacles[12] = $"{34}";
            Window.obstacles[13] = $"{33}";
            Window.obstacles[14] = $"{47}";
            Window.obstacles[15] = $"{46}";
            Window.obstacles[16] = $"{45}";
            Window.obstacles[17] = $"{44}";
            Window.obstacles[18] = $"{43}";
            Window.obstacles[19] = $"{63}";
            Window.obstacles[20] = $"{64}";
            Window.obstacles[21] = $"{65}";
            Window.obstacles[22] = $"{66}";
            Window.obstacles[23] = $"{73}";
            Window.obstacles[24] = $"{74}";
            Window.obstacles[25] = $"{75}";
            Window.obstacles[26] = $"{76}";
            Window.obstacles[27] = $"{11}";
            Window.obstacles[28] = $"{21}";
            Window.obstacles[29] = $"{31}";
            Window.obstacles[30] = $"{41}";
            Window.obstacles[31] = $"{51}";
            Window.obstacles[32] = $"{61}";
            Window.obstacles[33] = $"{71}";
            Window.obstacles[34] = $"{81}";
            Window.obstacles[35] = $"{93}";
            Window.obstacles[36] = $"{94}";
            Window.obstacles[37] = $"{95}";
            Window.obstacles[38] = $"{96}";
            Window.obstacles[39] = $"{97}";
            Window.obstacles[40] = $"{98}";
            Window.obstacles[41] = $"{99}";
            Window.obstacles[42] = $"{14}";
            Window.obstacles[43] = $"{15}";
            Window.obstacles[44] = $"{16}";
            Window.obstacles[45] = $"{17}";
            Window.obstacles[46] = $"{18}";
            Window.obstacles[47] = $"{13}";

        }
        #endregion
    }
}
