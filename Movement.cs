using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;


namespace Sokoban
{
    class Movement
    {
        // This class needs to know about the window where the movement
        // is going to be applyed

            // variables
        #region Declaring variables
        private MainPage Window { get; set; }
        private PopulateGrid populateGrid { get; set; }
        private int targetCellRow, targetCellColumn;
        private int CebraCellRow { get; set; }
        private int CebraCellColumn { get; set; }
        // private TextBlock WinBlock { get; set; }
        private string LionTargetMove { get; set; }
        private string CebraTargetMove { get; set; }
        #endregion

        #region Constructor passing window as a parameter
        public Movement(MainPage window) // Constructor
        {
            this.Window = window;
        }
        #endregion

        #region Moving Lion
        public void MoveLion(KeyEventArgs e) // method to move the lion
        {
            switch (e.Key)
            {
                case Key.Left: move("left"); break;
                case Key.Up: move("up"); break;
                case Key.Right: move("right"); break;
                case Key.Down: move("down"); break;
                default: break;
            }
        }
        #endregion

        #region Move method
        private void move(string direction) // Move method
        {
            int i = 0, j = 0;

            switch (direction)
            {
                case "left": i = 0; j = -1; break;
                case "up": i = -1; j = 0; break;
                case "right": i = 0; j = 1; break;
                case "down": i = 1; j = 0; break;
                default: break;
            }
            // checks if the lion's movement is beteween the grid
            if (((targetCellRow = Window.LionRow + i) < 10) && ((targetCellRow = Window.LionRow + i) >= 0) && ((targetCellColumn = Window.LionColumn + j) < 10) && ((targetCellColumn = Window.LionColumn + j) >= 0))
            {
                // combines row and colum into a single variable storing the Lion's movement
                LionTargetMove = $"{ targetCellRow}{ targetCellColumn}";
                //check if the LiontargetMove is contained between the obstacles array
                if ((Window.obstacles.Contains(LionTargetMove) == false))
                {
                   // checks if lion is going to move into the cebra's coordinates
                    if ((targetCellRow == Window.CebraRow) && (targetCellColumn == Window.CebraColumn))
                    {
                        // Makes sure that where we move the zebra is between boundaries
                        if (((CebraCellRow = Window.CebraRow + i) < 10) && ((CebraCellRow = Window.CebraRow + i) >= 0) && ((CebraCellColumn = Window.CebraColumn + j) < 10) && ((CebraCellColumn = Window.CebraColumn + j) >= 0))
                        {
                            // combines row and column into a single variable storing cebrá's movement
                            CebraTargetMove = $"{ CebraCellRow}{ CebraCellColumn}";
                            // checks if there are obstacles in the cebra's way
                            if ((Window.obstacles.Contains(CebraTargetMove) == false))
                            {
                                populateGrid = new PopulateGrid(Window);

                                // draw a cebra in the new coordinates
                                populateGrid.drawContents("Images\\cebra.png", CebraCellRow, CebraCellColumn);

                                // update the original cell where the zebra was to a background image
                                populateGrid.drawContents("Images\\background.PNG", Window.CebraRow, Window.CebraColumn);

                                // update the original cell where the lion was to a background image
                                populateGrid.drawContents("Images\\background.PNG", Window.LionRow, Window.LionColumn);
                                // setup image for win condition (in case lion has been there and deleted it)
                                populateGrid.drawContents("Images\\fire.png", Window.WinLocationRow, Window.WinLocationColumn);

                                // draw a lion in the new coordinates
                                populateGrid.drawContents("Images\\lion.png", targetCellRow, targetCellColumn);

                                // Updating and displaying the lion move counter
                                Window.CounterDisplay();

                                // update the location of the cebra and the lion to the new coordinates
                                UpdateCebraLocation();
                                UpdateLionLocation();
                                // Winning condition and action, sends to a method in MainPage
                                if ((CebraCellRow == Window.WinLocationRow) && (CebraCellColumn == Window.WinLocationColumn))
                                {
                                    Window.WinCondition();
                                    
                                }
                            }
                        }


                    }
                    // if the lion is between boundaries and there are no obstacles in the way
                    // but is not going to colide with the zebra this will take effect.
                    else
                    {
                        populateGrid = new PopulateGrid(Window);
                        // update the original cell where the lion was to a background image
                        populateGrid.drawContents("Images\\background.PNG", Window.LionRow, Window.LionColumn);
                        // setup image for win condition (in case lion has been in that field and deleted it)
                        populateGrid.drawContents("Images\\fire.png", Window.WinLocationRow, Window.WinLocationColumn);
                        // draw a lion in the new coordinates
                        populateGrid.drawContents("Images\\lion.png", targetCellRow, targetCellColumn);
                        // update the location of the lion to the new coordinates
                        UpdateLionLocation();
                        // Updating and displaying the lion move counter
                        Window.CounterDisplay();
                    }
                }

                
            }
            
        }
        #endregion

        #region Update Lion Location
        private void UpdateLionLocation() // once the Lion moved we have to update the variables where we store the lion's location
        {
            Window.LionRow = targetCellRow;
            Window.LionColumn = targetCellColumn;
        }
        #endregion

        #region Update Cebra Location
        private void UpdateCebraLocation() // once the zebra moved we need to update the variables where we store its location
        {
            Window.CebraRow = CebraCellRow;
            Window.CebraColumn = CebraCellColumn;
        }
        #endregion
    }
}
