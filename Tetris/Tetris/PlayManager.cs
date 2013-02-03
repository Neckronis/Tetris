using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class PlayManager
    {
        Grid playingGrid;
        List<Block> Blocks = new List<Block>();

        public PlayManager(Grid playingGrid)
        {
            this.playingGrid = playingGrid;         
        }

        public void Update(GameTime gameTime)
        {
    
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            playingGrid.Draw(spriteBatch, gameTime);
        }
    }
}
