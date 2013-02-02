using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace Tetris
{
    public static class MediaManager
    {
        static ContentManager content;

        // These list will contain the game assets.
        static Dictionary<string, Texture2D> sprites;
        static Dictionary<string, Song> songs;
        static Dictionary<string, Video> videos;
        static Dictionary<string, SoundEffect> soundEffects;
        static Dictionary<string, SpriteFont> fonts;
        static Dictionary<string, List<string>> lines;

        /// <summary>
        /// Initializes the member lists.
        /// </summary>
        static public void Initialize(ContentManager contentManager)
        {
            content = contentManager;

            sprites = new Dictionary<string, Texture2D>();
            songs = new Dictionary<string, Song>();
            videos = new Dictionary<string, Video>();
            soundEffects = new Dictionary<string, SoundEffect>();
            fonts = new Dictionary<string, SpriteFont>();
            lines = new Dictionary<string, List<string>>();
        }

        static public Texture2D GetSprite(string name)
        {
            if (name == "") 
                return null;
            if (sprites.ContainsKey(name)) 
                return sprites[name];
            else
            {
                Texture2D temp = null;
                if (content.Load<Texture2D>(name) != null)
                {
                    temp = content.Load<Texture2D>(name);
                    sprites.Add(name, temp);
                }
                return temp;
            }
        }





    }
}
