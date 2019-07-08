using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Incremental_Game
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Texture2D rect;

        // Mouse
        public Rectangle MouseDest;
        public int MouseX, MouseY;
        private MouseState oldState;

        private SpriteFont font;
        public Rectangle Screen;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1600; // Window Width
            graphics.PreferredBackBufferHeight = 900;// Window Height

            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Screen.Width = GraphicsDevice.Viewport.Width;
            Screen.Height = GraphicsDevice.Viewport.Height;
            Screen.X = 0;
            Screen.Y = 0;

            base.Initialize();
        }

        protected override void LoadContent()
        {



            spriteBatch = new SpriteBatch(GraphicsDevice);



        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Mouse position state
            MouseY = Mouse.GetState().Y;
            MouseX = Mouse.GetState().X;

            //Mouse clicking
            MouseState newState = Mouse.GetState();

            if (newState.LeftButton == ButtonState.Pressed)
            {
                MouseDest.X = MouseX;
                MouseDest.Y = MouseY;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);



            base.Draw(gameTime);
        }
    }
}
