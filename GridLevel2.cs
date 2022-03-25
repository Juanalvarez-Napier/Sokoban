using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class GridLevel2 : PopulateGrid
    {
        #region Variables
        private MainPage Window { get; set; }
        #endregion

        #region Constructor
        public GridLevel2(MainPage window) : base(window)
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
            drawContents("Images\\lion.png", 4, 9);
            // setup the location of our lion so we can keep track and update it
            Window.LionRow = 4;
            Window.LionColumn = 9;
            // for this second level we are placing the cebra in row 8, column 3
            drawContents("Images\\cebra.png", 8, 3);
            // setup the location of the cebra so we can keep track and update it
            Window.CebraRow = 8;
            Window.CebraColumn = 3;
            //here we set the coordinates for the win condition
            Window.WinLocationRow = 0;
            Window.WinLocationColumn = 0;
            // setup image for win condition
            drawContents("Images\\fire.png", 0, 0);
            // setup image for obstacles
            drawContents("Images\\obstacle.PNG", 1, 0);
            drawContents("Images\\obstacle.PNG", 1, 1);
            drawContents("Images\\obstacle2.png", 1, 2);
            drawContents("Images\\obstacle.PNG", 1, 3);
            drawContents("Images\\obstacle3.png", 1, 4);
            drawContents("Images\\obstacle2.png", 1, 6);
            drawContents("Images\\obstacle3.PNG", 1, 7);
            drawContents("Images\\obstacle.PNG", 1, 9);
            drawContents("Images\\obstacle.PNG", 5, 2);
            drawContents("Images\\obstacle3.png", 5, 3);
            drawContents("Images\\obstacle3.png", 5, 4);
            drawContents("Images\\obstacle3.PNG", 5, 5);
            drawContents("Images\\obstacle.PNG", 6, 3);
            drawContents("Images\\obstacle2.PNG", 6, 4);
            drawContents("Images\\obstacle2.PNG", 6, 5);
            drawContents("Images\\obstacle.PNG", 7, 1);
            drawContents("Images\\obstacle3.PNG", 7, 3);
            drawContents("Images\\obstacle2.PNG", 7, 4);
            drawContents("Images\\obstacle3.PNG", 7, 5);
            drawContents("Images\\obstacle2.PNG", 4, 8);
            drawContents("Images\\obstacle3.PNG", 5, 8);
            drawContents("Images\\obstacle.PNG", 6, 8);
            drawContents("Images\\obstacle3.PNG", 7, 8);
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
            drawContents("Images\\obstacle.PNG", 4, 6);
            drawContents("Images\\obstacle2.PNG", 2, 7);
            drawContents("Images\\obstacle3.PNG", 7, 6);
            drawContents("Images\\obstacle.PNG", 2, 4);
            drawContents("Images\\obstacle2.PNG", 3, 4);
            drawContents("Images\\obstacle.PNG", 3, 2);
            drawContents("Images\\obstacle2.PNG", 4, 2);

            // setup obtacles into an array
            Window.obstacles[0] = $"{10}";
            Window.obstacles[1] = $"{11}";
            Window.obstacles[2] = $"{12}";
            Window.obstacles[3] = $"{13}";
            Window.obstacles[4] = $"{14}";
            Window.obstacles[5] = $"{16}";
            Window.obstacles[6] = $"{17}";
            Window.obstacles[7] = $"{19}";
            Window.obstacles[8] = $"{52}";
            Window.obstacles[9] = $"{53}";
            Window.obstacles[10] = $"{54}";
            Window.obstacles[11] = $"{55}";
            Window.obstacles[12] = $"{63}";
            Window.obstacles[13] = $"{64}";
            Window.obstacles[14] = $"{65}";
            Window.obstacles[15] = $"{71}";
            Window.obstacles[16] = $"{73}";
            Window.obstacles[17] = $"{74}";
            Window.obstacles[18] = $"{75}";
            Window.obstacles[19] = $"{48}";
            Window.obstacles[20] = $"{58}";
            Window.obstacles[21] = $"{68}";
            Window.obstacles[22] = $"{78}";
            Window.obstacles[23] = $"{98}";
            Window.obstacles[24] = $"{40}";
            Window.obstacles[25] = $"{50}";
            Window.obstacles[26] = $"{60}";
            Window.obstacles[27] = $"{90}";
            Window.obstacles[28] = $"{91}";
            Window.obstacles[29] = $"{92}";
            Window.obstacles[30] = $"{93}";
            Window.obstacles[31] = $"{94}";
            Window.obstacles[32] = $"{95}";
            Window.obstacles[33] = $"{46}";
            Window.obstacles[34] = $"{27}";
            Window.obstacles[35] = $"{76}";
            Window.obstacles[36] = $"{24}";
            Window.obstacles[37] = $"{34}";
            Window.obstacles[38] = $"{32}";
            Window.obstacles[39] = $"{42}";

        }
        #endregion
    }
}
