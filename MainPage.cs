using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Sokoban
{
    class MainPage : Window
    {
        #region Declaring variables
        // declaring variables
        private Canvas WindowCanvas { get; set; }
        private Button ReturnButton { get; set; }
        private TextBlock InstructionBlock { get; set; }
        private Border GridBorder { get; set; }
        public Grid AppGrid { get; set; }
        //private PopulateGrid PopulateGrid { get; set; }
        private GridLevel1 GridLevel1 { get; set; }
        private GridLevel2 GridLevel2 { get; set; }
        private GridLevel3 GridLevel3 { get; set; }
        private GridLevel4 GridLevel4 { get; set; }
        private GridLevel5 GridLevel5 { get; set; }
        public int LionRow { get; set; }
        public int LionColumn { get; set; }
        public int CebraRow { get; set; }
        public int CebraColumn { get; set; }
        private Movement mover { get; set; }
        //private TextBlock WinBlock { get; set; }
        private int Counter { get; set; }
        private TextBlock TxtCounter { get; set; }
        public string[] obstacles = new string[100];
        public int WinLocationRow { get; set; }
        public int WinLocationColumn { get; set; }
        //public Action[] GridLevels;
        public int LevelCounter { get; set; }
       
        #endregion

        #region Constructor
        // constructor
        public MainPage(string windowName)
        {
            this.Title = windowName;
            initializeWindow();
        }
        #endregion

        #region initializeWindow method
        private void initializeWindow() //create and position window elements
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            WindowCanvas = new Canvas();
            createGrid();
            CreateSidePanel();
            AppGrid.Focus();

            // initializing the level counter
            LevelCounter = 0;
            //PopulateGrid = new PopulateGrid(this);

            // creating instances of the level classes
            GridLevel1 = new GridLevel1(this);
            GridLevel2 = new GridLevel2(this);
            GridLevel3 = new GridLevel3(this);
            GridLevel4 = new GridLevel4(this);
            GridLevel5 = new GridLevel5(this);

            // starting the game in level 1
            GridLevel1.DrawGrid();
            //GridLevels = new GridLevels(this);
            //GridLevels[LevelCounter]();

            this.Content = this.WindowCanvas;

            mover = new Movement(this);

            SetupPageEvents();
        }
        #endregion

        /*#region Populating list  with different levels
         * part of the attempt to store levels in an array that finally wasn't implemented
        delegate void Levels();
        void CreateList()
        {
            List<Levels> GridLevels = new List<Levels>();
            GridLevels.Add(GridLevel1.DrawGrid);
            GridLevels.Add(GridLevel2.DrawGrid);
            //GridLevels.Add(GridLevel3.DrawGrid);
            //GridLevels.Add(GridLevel5.DrawGrid);
            //GridLevels.Add(GridLevel5.DrawGrid);
            
            GridLevels = new Action[5];
            GridLevels[0] = GridLevel1.DrawGrid;
            GridLevels[1] = GridLevel2.DrawGrid;
            GridLevels[2] = GridLevel2.DrawGrid;
            GridLevels[3] = GridLevel2.DrawGrid;
            GridLevels[4] = GridLevel2.DrawGrid;
            
        }
        #endregion*/

        #region Creating the Grid
            // creating the grid
        private void createGrid()
        {
            GridBorder = new Border();
            GridBorder.BorderThickness = new Thickness(11.00);
            GridBorder.BorderBrush = Brushes.Black;

            AppGrid = new Grid();
            AppGrid.Width = AppGrid.Height = 400;
            AppGrid.HorizontalAlignment = HorizontalAlignment.Left;
            AppGrid.VerticalAlignment = VerticalAlignment.Top;
            AppGrid.Focusable = true;
            GridBorder.Child = AppGrid;

            for (int i = 0; i < 10; i++)
                AppGrid.ColumnDefinitions.Add(new ColumnDefinition());
            for (int i = 0; i < 10; i++)
                AppGrid.RowDefinitions.Add(new RowDefinition());
        }
        #endregion

        #region Side Panel
        // creating the side panel
        private void CreateSidePanel()
        {
            InstructionBlock = new TextBlock();
            InstructionBlock.FontSize = 25;
            InstructionBlock.Text = "Welcome to Sokoban " + MainWindow.UserName + "\nUse the arrow keys to move around the board";

            // part of the original way to show when level was completed
            //obsolete code left to show iteration
            //WinBlock = new TextBlock();
            //WinBlock.FontSize = 25;
            //WinBlock.Text = ("Lunch is ready! Enjoy");

            TxtCounter = new TextBlock();
            TxtCounter.FontSize = 25;
            TxtCounter.Text = ("Moves: " + Counter);

            ReturnButton = new Button();
            ReturnButton.Height = 30;
            ReturnButton.Width = 245;
            ReturnButton.FontSize = 15;
            ReturnButton.Focusable = false;
            ReturnButton.Content = "Back to Start";

            ArrangeOnCanvas();
        }
        #endregion

        #region Add and position elements in canvas

        // positioning elements in canvas
        private void ArrangeOnCanvas()
        {
            WindowCanvas.Children.Add(InstructionBlock);
            WindowCanvas.Children.Add(ReturnButton);
            WindowCanvas.Children.Add(GridBorder);
            WindowCanvas.Children.Add(TxtCounter);

            Canvas.SetLeft(InstructionBlock, 490);
            Canvas.SetTop(InstructionBlock, 100);

            Canvas.SetLeft(TxtCounter, 490);
            Canvas.SetTop(TxtCounter, 250);

            Canvas.SetLeft(ReturnButton, 490);
            Canvas.SetTop(ReturnButton, 380);
        }
        #endregion

        #region Return to start page button
        // button returning to the start page
        protected void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        #endregion

        #region Event handler for return button
        private void SetupPageEvents()
        {
            ReturnButton.Click += ReturnButton_Click; //event for returning to start page
            AppGrid.KeyDown += AppGrid_KeyDown; // event for a key being depressed
        }
        #endregion

        #region event handler for moving the lion
        // event handler for moving the lion
        protected void AppGrid_KeyDown(object sender, KeyEventArgs e)
        {
            mover.MoveLion(e);
        }
        #endregion

        
        #region Win Condition
        // method to determine if the level has been won and what happens after
        public void WinCondition()
        {
            //message box to show the player
            if (MessageBox.Show("Do you want to hunt again?", "Lunch is ready. Enjoy!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // reseting the move counter and displaying it
                Counter = 0;
                TxtCounter.Text = ("Moves: " + Counter);
                // we add a level to the level counter
                LevelCounter++;
                // depending on the level counter we go to a different level
                if (LevelCounter == 1)
                {
                    GridLevel2.DrawGrid();
                }
                else if (LevelCounter == 2)
                {
                    GridLevel3.DrawGrid();
                }
                else if (LevelCounter == 3)
                {
                    GridLevel4.DrawGrid();
                }
                else if (LevelCounter == 4)
                {
                    GridLevel5.DrawGrid();
                }
                // once lvl 5 is finished sends you back to the beggining.
                else if (MessageBox.Show("Let's go back to the beggining", "No more levels", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                    
                }

                // part of the attempts to store levels on an array and use it to call the levels
                //GridLevels[LevelCounter]();

                // Once level 1 is complete we move to lvl 2
                // been able to create more levels working progress
                //GridLevel2.DrawGrid();
            }
            else
            {
                // going back to the main window
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            
            // originally instead of a pop up I had the win condition embeded on the side panel.
            // obsolete code left to show itterations
           // WindowCanvas.Children.Add(WinBlock);

            //Canvas.SetLeft(WinBlock, 490);
            //Canvas.SetTop(WinBlock, 200);
        }
        #endregion

        #region counter display
        // updating the move counter and displaying it in the screen
        public void CounterDisplay()
        {
            Counter = Counter + 1;

            TxtCounter.Text = ("Moves: " + Counter);
            
        }
        #endregion
    }
}
