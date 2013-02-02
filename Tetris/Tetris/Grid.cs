using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Tetris
{
    class Grid
    {
        int width;
        int height;
        Color[,] grid;
        Texture2D gridTexture;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new Color[width, height]; //white 1x1 element: empty, !white: 1x1 element: not empty

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    grid[x, y] = Color.White;

            gridTexture = MediaManager.GetSprite("block");
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            for(int x = 0; x < width; x++)
                for(int y = 0; y < height; y++)
                {
                    spriteBatch.Draw(gridTexture, new Vector2(x * gridTexture.Width, y * gridTexture.Height), grid[x, y]);

                }
        }
    }
}
