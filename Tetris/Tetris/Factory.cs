using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class Factory
    {
        Grid grid;
        PlayManager playManager;
        int gridWidth, gridHeight;

        public Factory(int gridWidth, int gridHeight)
        {
            this.gridWidth = gridWidth;
            this.gridHeight = gridHeight;
        }

        public Grid Grid
        {
            get
            {
                if (grid != null)
                    return grid;
                else
                {
                    grid = new Grid(gridWidth, gridHeight);
                    return grid;
                }
               
            }
        }

        public PlayManager PlayManager
        {
            get
            {
                if (playManager != null)
                    return playManager;
                else
                {
                    playManager = new PlayManager(this.Grid);
                    return playManager;
                }

            }
        }





    }
}
