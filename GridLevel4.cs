using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class GridLevel4 : PopulateGrid
    {
        #region Variables
        private MainPage Window { get; set; }
        #endregion

        #region Constructor
        public GridLevel4(MainPage window) : base(window)
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
            drawContents("Images\\lion.png", 9, 0);
            // setup the location of our lion so we can keep track and update it
            Window.LionRow = 9;
            Window.LionColumn = 0;
            // for this second level we are placing the cebra in row 8, column 3
            drawContents("Images\\cebra.png", 8, 8);
            // setup the location of the cebra so we can keep track and update it
            Window.CebraRow = 8;
            Window.CebraColumn = 8;
            //here we set the coordinates for the win condition
            Window.WinLocationRow = 0;
            Window.WinLocationColumn = 9;
            // setup image for win condition
            drawContents("Images\\fire.png", 0, 9);
            // setup image for obstacles
            drawContents("Images\\obstacle.PNG", 8, 0);
            drawContents("Images\\obstacle.PNG", 8, 1);
            drawContents("Images\\obstacle2.png", 7, 3);
            drawContents("Images\\obstacle.png", 8, 3);
            drawContents("Images\\obstacle3.png", 9, 3);
            drawContents("Images\\obstacle2.png", 6, 3);
            drawContents("Images\\obstacle3.PNG", 6, 2);
            drawContents("Images\\obstacle.PNG", 6, 1);
            drawContents("Images\\obstacle.PNG", 5, 1);
            drawContents("Images\\obstacle3.png", 4, 1);
            drawContents("Images\\obstacle2.png", 3, 1);
            drawContents("Images\\obstacle3.PNG", 2, 1);
            drawContents("Images\\obstacle.PNG", 1, 1);
            drawContents("Images\\obstacle2.PNG", 1, 3);
            drawContents("Images\\obstacle2.PNG", 1, 4);
            drawContents("Images\\obstacle.PNG", 1, 5);
            drawContents("Images\\obstacle3.PNG", 1, 6);
            drawContents("Images\\obstacle2.PNG", 1, 7);
            drawContents("Images\\obstacle3.PNG", 1, 9);
            drawContents("Images\\obstacle2.PNG", 1, 9);
            drawContents("Images\\obstacle3.PNG", 2, 9);
            drawContents("Images\\obstacle.PNG", 3, 9);
            drawContents("Images\\obstacle3.PNG", 4, 9);
            drawContents("Images\\obstacle.PNG", 5, 9);
            drawContents("Images\\obstacle3.PNG", 6, 9);
            drawContents("Images\\obstacle2.PNG", 9, 9);
            drawContents("Images\\obstacle.PNG", 9, 8);
            drawContents("Images\\obstacle3.PNG", 9, 7);
            drawContents("Images\\obstacle.PNG", 9, 6);
            drawContents("Images\\obstacle3.PNG", 7, 5);
            drawContents("Images\\obstacle2.PNG", 7, 6);
            drawContents("Images\\obstacle.PNG", 7, 7);
            drawContents("Images\\obstacle3.PNG", 3, 4);
            drawContents("Images\\obstacle.PNG", 5, 5);
            drawContents("Images\\obstacle2.PNG", 5, 6);
            drawContents("Images\\obstacle3.PNG", 5, 7);
            drawContents("Images\\obstacle.PNG", 6, 5);
            drawContents("Images\\obstacle2.PNG", 6, 6);
            drawContents("Images\\obstacle.PNG", 6, 7);
            drawContents("Images\\obstacle2.PNG", 3, 5);
            drawContents("Images\\obstacle3.PNG", 3, 6);
            drawContents("Images\\obstacle2.PNG", 3, 7);
            drawContents("Images\\obstacle2.PNG", 3, 3);
            drawContents("Images\\obstacle3.PNG", 5, 2);
            drawContents("Images\\obstacle2.PNG", 5, 3);

            // setup obtacles into an array
            Window.obstacles[0] = $"{80}";
            Window.obstacles[1] = $"{81}";
            Window.obstacles[2] = $"{73}";
            Window.obstacles[3] = $"{83}";
            Window.obstacles[4] = $"{93}";
            Window.obstacles[5] = $"{63}";
            Window.obstacles[6] = $"{62}";
            Window.obstacles[7] = $"{61}";
            Window.obstacles[8] = $"{51}";
            Window.obstacles[9] = $"{41}";
            Window.obstacles[10] = $"{31}";
            Window.obstacles[11] = $"{21}";
            Window.obstacles[12] = $"{11}";
            Window.obstacles[13] = $"{13}";
            Window.obstacles[14] = $"{14}";
            Window.obstacles[15] = $"{15}";
            Window.obstacles[16] = $"{16}";
            Window.obstacles[17] = $"{17}";
            Window.obstacles[18] = $"{19}";
            Window.obstacles[19] = $"{19}";
            Window.obstacles[20] = $"{29}";
            Window.obstacles[21] = $"{39}";
            Window.obstacles[22] = $"{49}";
            Window.obstacles[23] = $"{59}";
            Window.obstacles[24] = $"{69}";
            Window.obstacles[25] = $"{99}";
            Window.obstacles[26] = $"{98}";
            Window.obstacles[27] = $"{97}";
            Window.obstacles[28] = $"{96}";
            Window.obstacles[29] = $"{75}";
            Window.obstacles[30] = $"{76}";
            Window.obstacles[31] = $"{77}";
            Window.obstacles[32] = $"{34}";
            Window.obstacles[33] = $"{55}";
            Window.obstacles[34] = $"{56}";
            Window.obstacles[35] = $"{57}";
            Window.obstacles[36] = $"{65}";
            Window.obstacles[37] = $"{66}";
            Window.obstacles[38] = $"{67}";
            Window.obstacles[39] = $"{35}";
            Window.obstacles[40] = $"{36}";
            Window.obstacles[41] = $"{37}";
            Window.obstacles[42] = $"{33}";
            Window.obstacles[43] = $"{52}";
            Window.obstacles[44] = $"{53}";

        }
        #endregion
    }
}
