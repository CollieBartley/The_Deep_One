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
    public class Incremental : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Texture2D rect;

        #region BUTTON TEX2D, RECT & TICK
        public Texture2D button1;
        public Texture2D button1Pressed;
        public Rectangle button1pos;
        public int button1Pressedtick = 0;

        public Texture2D button2;
        public Texture2D button2Pressed;
        public Rectangle button2pos;
        public int button2Pressedtick = 0;

        public Texture2D button3;
        public Texture2D button3Pressed;
        public Rectangle button3pos;
        public int button3Pressedtick = 0;

        public Texture2D button4;
        public Texture2D button4Pressed;
        public Rectangle button4pos;
        public int button4Pressedtick = 0;

        public Texture2D button5;
        public Texture2D button5Pressed;
        public Rectangle button5pos;
        public int button5Pressedtick = 0;

        public Texture2D button6;
        public Texture2D button6Pressed;
        public Rectangle button6pos;
        public int button6Pressedtick = 0;
        #endregion 



        public Texture2D temp;

        // Mouse
        public Rectangle MouseDest;
        public int MouseX, MouseY;
        private MouseState oldState;

        private SpriteFont font;
        public Rectangle Screen;

        public Incremental()
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

            temp = Content.Load<Texture2D>("temp");

            #region BUTTONS POS AND LOAD
            button1 = Content.Load<Texture2D>("button");
            button1Pressed = Content.Load<Texture2D>("buttonPressed");
            button1pos.X = 1318;
            button1pos.Y = 56;
            button1pos.Width = 213;
            button1pos.Height = 54;

            button2 = Content.Load<Texture2D>("button");
            button2Pressed = Content.Load<Texture2D>("buttonPressed");
            button2pos.X = 1318;
            button2pos.Y = 122;
            button2pos.Width = 213;
            button2pos.Height = 54;

            button3 = Content.Load<Texture2D>("button");
            button3Pressed = Content.Load<Texture2D>("buttonPressed");
            button3pos.X = 1318;
            button3pos.Y = 187;
            button3pos.Width = 213;
            button3pos.Height = 54;

            button4 = Content.Load<Texture2D>("button");
            button4Pressed = Content.Load<Texture2D>("buttonPressed");
            button4pos.X = 1318;
            button4pos.Y = 254;
            button4pos.Width = 213;
            button4pos.Height = 54;

            button5 = Content.Load<Texture2D>("button");
            button5Pressed = Content.Load<Texture2D>("buttonPressed");
            button5pos.X = 1318;
            button5pos.Y = 320;
            button5pos.Width = 213;
            button5pos.Height = 54;

            button6 = Content.Load<Texture2D>("button");
            button6Pressed = Content.Load<Texture2D>("buttonPressed");
            button6pos.X = 1318;
            button6pos.Y = 386;
            button6pos.Width = 213;
            button6pos.Height = 54;
            #endregion 

            font = Content.Load<SpriteFont>("arial");
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

            if (MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                button1Pressedtick = 1;
            }
            else
            {
                button1Pressedtick = 0;
            }

            if (MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                button2Pressedtick = 1;
            }
            else
            {
                button2Pressedtick = 0;
            }

            if (MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                button3Pressedtick = 1;
            }
            else
            {
                button3Pressedtick = 0;
            }

            if (MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                button4Pressedtick = 1;
            }
            else
            {
                button4Pressedtick = 0;
            }

            if (MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                button5Pressedtick = 1;
            }
            else
            {
                button5Pressedtick = 0;
            }

            if (MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                button6Pressedtick = 1;
            }
            else
            {
                button6Pressedtick = 0;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            spriteBatch.Begin();

            //spriteBatch.Draw(temp, new Rectangle(0, 0, Screen.Width, Screen.Height), Color.White);
            spriteBatch.Draw(button1, new Rectangle(button1pos.X, button1pos.Y, button1pos.Width, button1pos.Height), Color.White);
            spriteBatch.Draw(button2, new Rectangle(button2pos.X, button2pos.Y, button2pos.Width, button2pos.Height), Color.White);
            spriteBatch.Draw(button3, new Rectangle(button3pos.X, button3pos.Y, button3pos.Width, button3pos.Height), Color.White);
            spriteBatch.Draw(button4, new Rectangle(button4pos.X, button4pos.Y, button4pos.Width, button4pos.Height), Color.White);
            spriteBatch.Draw(button5, new Rectangle(button5pos.X, button5pos.Y, button5pos.Width, button5pos.Height), Color.White);
            spriteBatch.Draw(button6, new Rectangle(button6pos.X, button6pos.Y, button6pos.Width, button6pos.Height), Color.White);

            if (button1Pressedtick == 1)
            {
                spriteBatch.Draw(button1Pressed, new Rectangle(button1pos.X, button1pos.Y, button1pos.Width, button1pos.Height), Color.White);
            }

            if (button2Pressedtick == 1)
            {
                spriteBatch.Draw(button2Pressed, new Rectangle(button2pos.X, button2pos.Y, button2pos.Width, button2pos.Height), Color.White);
            }

            if (button3Pressedtick == 1)
            {
                spriteBatch.Draw(button3Pressed, new Rectangle(button3pos.X, button3pos.Y, button3pos.Width, button3pos.Height), Color.White);
            }

            if (button4Pressedtick == 1)
            {
                spriteBatch.Draw(button4Pressed, new Rectangle(button4pos.X, button4pos.Y, button4pos.Width, button4pos.Height), Color.White);
            }

            if (button5Pressedtick == 1)
            {
                spriteBatch.Draw(button5Pressed, new Rectangle(button5pos.X, button5pos.Y, button5pos.Width, button5pos.Height), Color.White);
            }

            if (button6Pressedtick == 1)
            {
                spriteBatch.Draw(button6Pressed, new Rectangle(button6pos.X, button6pos.Y, button6pos.Width, button6pos.Height), Color.White);
            }

            #region DEBUG MOUSE

            spriteBatch.DrawString(font, "Mouse X: " + MouseX, new Vector2(0, 0), Color.White);
            spriteBatch.DrawString(font, "Mouse Y: " + MouseY, new Vector2(0, 15), Color.White);

            if (newState.LeftButton == ButtonState.Pressed)
            {
                spriteBatch.DrawString(font, "Mouse Pressed", new Vector2(0, 30), Color.White);
            }
            else
            {
                spriteBatch.DrawString(font, "Mouse Released", new Vector2(0, 30), Color.White);
            }
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
