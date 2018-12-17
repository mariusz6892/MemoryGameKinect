using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.ViewModels
{
    public class StartMenuViewModel
    {
        private MainWindow _mainWindow;
        public StartMenuViewModel(MainWindow main)
        {
            _mainWindow = main;
        }

        public void StartNewGame(int slidecount)
        {
            GameViewModel newGame = new GameViewModel(slidecount);
            _mainWindow.DataContext = newGame;
        }
    }
}
