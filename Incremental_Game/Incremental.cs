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

        int millisecondsPerFrame = 1000; //Update every 1 second
        int timeSinceLastUpdate = 0; //Accumulate the elapsed time

        public Texture2D rect;

        #region BUTTON TEX2D, RECT & TICK
        public Texture2D button1;
        public Texture2D button1Pressed;
        public Rectangle button1pos;
        public int button1Pressedtick = 0;
        public int button1Releasedtick = 0;

        public Texture2D button2;
        public Texture2D button2Pressed;
        public Rectangle button2pos;
        public int button2Pressedtick = 0;
        public int button2Releasedtick = 0;

        public Texture2D button3;
        public Texture2D button3Pressed;
        public Rectangle button3pos;
        public int button3Pressedtick = 0;
        public int button3Releasedtick = 0;

        public Texture2D button4;
        public Texture2D button4Pressed;
        public Rectangle button4pos;
        public int button4Pressedtick = 0;
        public int button4Releasedtick = 0;

        public Texture2D button5;
        public Texture2D button5Pressed;
        public Rectangle button5pos;
        public int button5Pressedtick = 0;
        public int button5Releasedtick = 0;

        public Texture2D button6;
        public Texture2D button6Pressed;
        public Rectangle button6pos;
        public int button6Pressedtick = 0;
        public int button6Releasedtick = 0;

        public Texture2D button7;
        public Texture2D button7Pressed;
        public Rectangle button7pos;
        public int button7Pressedtick = 0;
        public int button7Releasedtick = 0;

        public Texture2D button8;
        public Texture2D button8Pressed;
        public Rectangle button8pos;
        public int button8Pressedtick = 0;
        public int button8Releasedtick = 0;

        public Texture2D button9;
        public Texture2D button9Pressed;
        public Rectangle button9pos;
        public int button9Pressedtick = 0;
        public int button9Releasedtick = 0;
        #endregion 

        public Texture2D temp;

        // Mouse
        public Rectangle MouseDest;
        public int MouseX, MouseY;
        private MouseState oldState;

        public int souls = 0;
        public bool soulsadd = false;
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

            button7 = Content.Load<Texture2D>("button");
            button7Pressed = Content.Load<Texture2D>("buttonPressed");
            button7pos.X = 1318;
            button7pos.Y = 452;
            button7pos.Width = 213;
            button7pos.Height = 54;

            button8 = Content.Load<Texture2D>("button");
            button8Pressed = Content.Load<Texture2D>("buttonPressed");
            button8pos.X = 1318;
            button8pos.Y = 518;
            button8pos.Width = 213;
            button8pos.Height = 54;

            button9 = Content.Load<Texture2D>("button");
            button9Pressed = Content.Load<Texture2D>("buttonPressed");
            button9pos.X = 1318;
            button9pos.Y = 584;
            button9pos.Width = 213;
            button9pos.Height = 54;
            #endregion 

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            timeSinceLastUpdate += (int)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (timeSinceLastUpdate >= millisecondsPerFrame)
            {
                timeSinceLastUpdate = 0;

                #region UPGRADES
                if (upgrade1 > 0)
                {
                    souls += (upgrade1 * 5);

                }

                if (upgrade2 > 0)
                {
                    souls += (upgrade1 * 10);

                }

                if (upgrade3 > 0)
                {
                    souls += (upgrade1 * 50);

                }

                if (upgrade4 > 0)
                {
                    souls += (upgrade1 * 100);

                }

                if (upgrade5 > 0)
                {
                    souls += (upgrade1 * 1000);

                }

                if (upgrade6 > 0)
                {
                    souls += (upgrade1 * 10000);

                }

                if (upgrade7 > 0)
                {
                    souls += (upgrade1 * 100000);

                }

                if (upgrade8 > 0)
                {
                    souls += (upgrade1 * 1000000);

                }
                #endregion

            }

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

                #region BUTTON 1 INTERACTION - Clicker

                if (MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button1Pressedtick = 1;
                }
                else
                {
                    button1Pressedtick = 0;
                }

                if (MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button1Releasedtick = 1;
                }
                else
                {
                    button1Releasedtick = 0;
                }

                if (button1Pressedtick == 1 && soulsadd == false)
                {
                    souls++;
                    soulsadd = true;
                }

                if (button1Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 2 INTERACTION - Upgrade 1
                if (MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button2Pressedtick = 1;
                }
                else
                {
                    button2Pressedtick = 0;
                }

                if (MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button2Releasedtick = 1;
                }
                else
                {
                    button2Releasedtick = 0;
                }

                if (button2Pressedtick == 1 && soulsadd == false)
                {
                    upgrade1++;
                    soulsadd = true;
                }

                if (button2Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 3 INTERACTION - Upgrade 2
                if (MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button3Pressedtick = 1;
                }
                else
                {
                    button3Pressedtick = 0;
                }

                if (MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button3Releasedtick = 1;
                }
                else
                {
                    button3Releasedtick = 0;
                }

                if (button3Pressedtick == 1 && soulsadd == false)
                {
                    upgrade2++;
                    soulsadd = true;
                }

                if (button3Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 4 INTERACTION - Upgrade 3
                if (MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button4Pressedtick = 1;
                }
                else
                {
                    button4Pressedtick = 0;
                }

                if (MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button4Releasedtick = 1;
                }
                else
                {
                    button4Releasedtick = 0;
                }

                if (button4Pressedtick == 1 && soulsadd == false)
                {
                    upgrade3++;
                    soulsadd = true;
                }

                if (button4Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 5 INTERACTION - Upgrade 4
                if (MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button5Pressedtick = 1;
                }
                else
                {
                    button5Pressedtick = 0;
                }

                if (MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button5Releasedtick = 1;
                }
                else
                {
                    button5Releasedtick = 0;
                }

                if (button5Pressedtick == 1 && soulsadd == false)
                {
                    upgrade4++;
                    soulsadd = true;
                }

                if (button5Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 6 INTERACTION - Upgrade 5
                if (MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button6Pressedtick = 1;
                }
                else
                {
                    button6Pressedtick = 0;
                }

                if (MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button6Releasedtick = 1;
                }
                else
                {
                    button6Releasedtick = 0;
                }

                if (button6Pressedtick == 1 && soulsadd == false)
                {
                    upgrade5++;
                    soulsadd = true;
                }

                if (button6Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
            #endregion

                #region BUTTON 7 INTERACTION - Upgrade 6
                if (MouseDest.Intersects(button7pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button7Pressedtick = 1;
                }
                else
                {
                    button7Pressedtick = 0;
                }

                if (MouseDest.Intersects(button7pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button7Releasedtick = 1;
                }
                else
                {
                    button7Releasedtick = 0;
                }

                if (button7Pressedtick == 1 && soulsadd == false)
                {
                    upgrade6++;
                    soulsadd = true;
                }

                if (button7Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 8 INTERACTION - Upgrade 7
                if (MouseDest.Intersects(button8pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button8Pressedtick = 1;
                }
                else
                {
                    button8Pressedtick = 0;
                }

                if (MouseDest.Intersects(button8pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button8Releasedtick = 1;
                }
                else
                {
                    button8Releasedtick = 0;
                }

                if (button8Pressedtick == 1 && soulsadd == false)
                {
                    upgrade7++;
                    soulsadd = true;
                }

                if (button8Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

                #region BUTTON 9 INTERACTION - Upgrade 8
                if (MouseDest.Intersects(button9pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                    button9Pressedtick = 1;
                }
                else
                {
                    button9Pressedtick = 0;
                }

                if (MouseDest.Intersects(button9pos) && (newState.LeftButton == ButtonState.Released))
                {
                    button9Releasedtick = 1;
                }
                else
                {
                    button9Releasedtick = 0;
                }

                if (button9Pressedtick == 1 && soulsadd == false)
                {
                    upgrade8++;
                    soulsadd = true;
                }

                if (button9Releasedtick == 1 && soulsadd == true)
                {
                    soulsadd = false;
                }
                #endregion

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            spriteBatch.Begin();

            //spriteBatch.Draw(temp, new Rectangle(0, 0, Screen.Width, Screen.Height), Color.White);

            spriteBatch.DrawString(fontlarge, "Souls: " + souls, new Vector2(15, 15), Color.White);

            #region BUTTON DRAWING
            spriteBatch.Draw(button1, new Rectangle(button1pos.X, button1pos.Y, button1pos.Width, button1pos.Height), Color.White);
            spriteBatch.Draw(button2, new Rectangle(button2pos.X, button2pos.Y, button2pos.Width, button2pos.Height), Color.White);
            spriteBatch.Draw(button3, new Rectangle(button3pos.X, button3pos.Y, button3pos.Width, button3pos.Height), Color.White);
            spriteBatch.Draw(button4, new Rectangle(button4pos.X, button4pos.Y, button4pos.Width, button4pos.Height), Color.White);
            spriteBatch.Draw(button5, new Rectangle(button5pos.X, button5pos.Y, button5pos.Width, button5pos.Height), Color.White);
            spriteBatch.Draw(button6, new Rectangle(button6pos.X, button6pos.Y, button6pos.Width, button6pos.Height), Color.White);
            spriteBatch.Draw(button7, new Rectangle(button7pos.X, button7pos.Y, button7pos.Width, button7pos.Height), Color.White);
            spriteBatch.Draw(button8, new Rectangle(button8pos.X, button8pos.Y, button8pos.Width, button8pos.Height), Color.White);
            spriteBatch.Draw(button9, new Rectangle(button9pos.X, button9pos.Y, button9pos.Width, button9pos.Height), Color.White);

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

            if (button7Pressedtick == 1)
            {
                spriteBatch.Draw(button7Pressed, new Rectangle(button7pos.X, button7pos.Y, button7pos.Width, button7pos.Height), Color.White);
            }

            if (button8Pressedtick == 1)
            {
                spriteBatch.Draw(button8Pressed, new Rectangle(button8pos.X, button8pos.Y, button8pos.Width, button8pos.Height), Color.White);
            }

            if (button9Pressedtick == 1)
            {
                spriteBatch.Draw(button9Pressed, new Rectangle(button9pos.X, button9pos.Y, button9pos.Width, button9pos.Height), Color.White);
            }
            #endregion

            #region DEBUG MOUSE

            spriteBatch.DrawString(font, "Mouse X: " + MouseX, new Vector2(0, 860), Color.White);
            spriteBatch.DrawString(font, "Mouse Y: " + MouseY, new Vector2(0, 880), Color.White);

            if (newState.LeftButton == ButtonState.Pressed)
            {
                spriteBatch.DrawString(font, "Mouse Pressed", new Vector2(0, 840), Color.White);
            }
            else
            {
                spriteBatch.DrawString(font, "Mouse Released", new Vector2(0, 840), Color.White);
            }
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
