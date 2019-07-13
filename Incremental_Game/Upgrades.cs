using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;
using System.Linq;

namespace The_Deep_One
{
    public class Upgrades
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ContentManager Content;

        Souls souls;
        DeepOne deepone;
        News news;
        Images images;

        public int upgrade1 = 0;
        public int upgrade2 = 0;
        public int upgrade3 = 0;
        public int upgrade4 = 0;
        public int upgrade5 = 0;
        public int upgrade6 = 0;
        public int upgrade7 = 0;
        public int upgrade8 = 0;

        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        public Upgrades()
        {
            Content.RootDirectory = "Content";
        }
        public Upgrades(DeepOne p_deepone, GraphicsDeviceManager p_graphics, SpriteBatch p_spriteBatch, ContentManager content, Souls p_souls, News p_news, Images p_images)
        {
            Content = content;
            deepone = p_deepone;
            graphics = p_graphics;
            spriteBatch = p_spriteBatch;
            souls = p_souls;
            news = p_news;
            images = p_images;
        }

        public void Update(GameTime gameTime, Buttons buttons)
        {
            MouseState newState = Mouse.GetState();

            #region UPGRADES
            switch (upgrade1 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade1 * 2);
                    break;
                default:
                    break;
            }

            switch (upgrade2 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade2 * 10);
                    break;
                default:
                    break;
            }

            switch (upgrade3 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade3 * 50);
                    break;
                default:
                    break;
            }

            switch (upgrade4 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade4 * 100);
                    break;
                default:
                    break;
            }

            switch (upgrade5 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade5 * 1000);
                    break;
                default:
                    break;
            }

            switch (upgrade6 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade6 * 10000);
                    break;
                default:
                    break;
            }

            switch (upgrade7 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade7 * 100000);
                    break;
                default:
                    break;
            }

            switch (upgrade8 > 0 && buttons.completetick == 0)
            {
                case true:
                    souls.souls += (upgrade8 * 1000000);
                    break;
                default:
                    break;
            }
            #endregion
        }

        public void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();
        }
    }
}