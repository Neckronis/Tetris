using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    abstract class Block
    {
        protected bool[,] structure = new bool[4, 4];
        protected Vector2 position;

        protected virtual void GenerateStructure()
        {
            for (int x = 0; x < structure.GetLength(0); x++)
                for (int y = 0; y < structure.GetLength(1); y++)
                    structure[x, y] = false;
        }

        public virtual void Rotate()
        { 
        
        }

        public virtual void Move(string direction)
        { 
            
        }

        public virtual void Update(GameTime gameTime)
        { 
            
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Texture2D sprite = MediaManager.GetSprite("block");

            for (int x = 0; x < structure.GetLength(0); x++)
                for (int y = 0; y < structure.GetLength(1); y++)
                {
                    if(structure[x,y])
                        spriteBatch.Draw(sprite, new Vector2(position.X + x * sprite.Width, position.Y + y * sprite.Height), Color.Red);
                }
        }

        public virtual Vector2 Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
    }
}
