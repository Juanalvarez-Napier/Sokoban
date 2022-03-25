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
    class PopulateGrid
    {

        #region variables
        // here we have the variables
        private MainPage Window { get; set; }
        
        // part of the attempt to store levels in an array
    
        //string gridLevels = new Action[5];
        //GridLevel1 gridlevel1 = new GridLevel1(window);
        //public Action[] gridLevels;
        //gridLevels = new Action[5];
        #endregion

        #region Constructor
        public PopulateGrid(MainPage window) // constructor
        {
            this.Window = window;
            /* the code just below are attempts to make changes to the way the levels are choosen
             * attempted to store levels in an array and with the level counter call the right one each time
             * unsucesful as I needed more time to do extra research
             * GridLevel1 gridlevel1 = new GridLevel1(window);
           // gridLevels = new Action[5];
            gridLevels[0] = gridlevel1.DrawGrid();
            var gridLevels = new string[5];
            {
                gridLevels[0] = GridLevel1.DrawGrid();
                gridLevels[1] = GridLevel2.DrawGrid();
            }
            gridLevels[0] = GridLevel3.DrawGrid();
            gridLevels[0] = GridLevel4.DrawGrid();
            gridLevels[0] = GridLevel5.DrawGrid();*/

        }
        #endregion

        #region add an image to the grid
        public void drawContents(string uriLocation, int row, int column) // method to be able to add images to the grid
        {
            Image img = new Image() { Source = new BitmapImage(new Uri(uriLocation, UriKind.Relative)) };
            Window.AppGrid.Children.Add(img);
            Grid.SetRow(img, row);
            Grid.SetColumn(img, column);
        }
        #endregion
        
        #region Populating the Grid
        // originally we had the different levels as methods in this class
        // but it was too populated, so we made 5 classes (1 per level) as children of this class
        // so this method is here just so it is implemented on the children's classes
        public virtual void DrawGrid() 
        {
            // virtual method to be implemented in children classes

            /* this is old code left behind to show iterations
            //filling the grid with the background image
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    drawContents("Images\\background.PNG", x, y);
                }
            }

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
            */
        }
        #endregion
        
        /* this is old code left behind to show iterations
        #region Populate Grid Level2
        public void DrawGrid2()
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
        #endregion*/
    }
}
