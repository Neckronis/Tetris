using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Tetris
{
    class TetrisFacade
    {
        Factory factory;
        PlayManager playManager;

        public TetrisFacade(Factory factory)
        { 
            this.factory = factory;
            this.playManager = factory.PlayManager;
        }

        public void Update(GameTime gameTime)
        {
            playManager.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            playManager.Draw(spriteBatch, gameTime);
        }
    }
}
