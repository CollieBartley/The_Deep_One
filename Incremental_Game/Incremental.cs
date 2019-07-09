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
            switch (timeSinceLastUpdate >= millisecondsPerFrame)
            {
                case true:
                    timeSinceLastUpdate = 0;
                    #region UPGRADES
                    switch (upgrade1 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 5);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade2 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 10);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade3 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 50);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade4 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 100);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade5 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 1000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade6 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 10000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade7 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 100000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade8 > 0)
                    {
                        case true:
                            souls += (upgrade1 * 1000000);
                            break;
                        default:
                            break;
                    }
                        #endregion
                    break;
                default:
                    break;
            }

            switch (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                case true:
                    Exit();
                    break;
                default:
                    break;
            }
            
                //Mouse position state
                MouseY = Mouse.GetState().Y;
                MouseX = Mouse.GetState().X;

                //Mouse clicking
                MouseState newState = Mouse.GetState();

                switch (newState.LeftButton == ButtonState.Pressed)
                {
                case true:
                    MouseDest.X = MouseX;
                    MouseDest.Y = MouseY;
                    break;
                default:
                    break;
                }

                #region BUTTON 1 INTERACTION - Clicker

                switch (MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button1Pressedtick = 1;
                    break;
                case false:
                    button1Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button1Releasedtick = 1;
                    break;
                case false:
                    button1Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button1Pressedtick == 1 && soulsadd == false)
                {
                case true:
                    souls++;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button1Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 2 INTERACTION - Upgrade 1
                switch (MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button2Pressedtick = 1;
                    break;
                case false:
                    button2Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button2Releasedtick = 1;
                    break;
                case false:
                    button2Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button2Pressedtick == 1 && soulsadd == false && souls >= 50)
                {
                case true:
                    upgrade1++;
                    souls -= 50;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button2Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 3 INTERACTION - Upgrade 2
                switch (MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button3Pressedtick = 1;
                    break;
                case false:
                    button3Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button3Releasedtick = 1;
                    break;
                case false:
                    button3Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button3Pressedtick == 1 && soulsadd == false && souls >= 150)
                {
                case true:
                    upgrade2++;
                    souls -= 150;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button3Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 4 INTERACTION - Upgrade 3
                switch (MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button4Pressedtick = 1;
                    break;
                case false:
                    button4Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button4Releasedtick = 1;
                    break;
                case false:
                    button4Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button4Pressedtick == 1 && soulsadd == false && souls >= 500)
                {
                case true:
                    upgrade3++;
                    souls -= 1000;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button4Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 5 INTERACTION - Upgrade 4
                switch (MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button5Pressedtick = 1;
                    break;
                case false:
                    button5Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button5Releasedtick = 1;
                    break;
                case false:
                    button5Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button5Pressedtick == 1 && soulsadd == false && souls >= 10000)
                {
                case true:
                    upgrade4++;
                    souls -= 10000;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button5Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 6 INTERACTION - Upgrade 5
                switch (MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button6Pressedtick = 1;
                    break;
                case false:
                    button6Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button6Releasedtick = 1;
                    break;
                case false:
                    button6Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button6Pressedtick == 1 && soulsadd == false && souls >= 100000)
                {
                case true:
                    upgrade5++;
                    souls -= 100000;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button6Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
            #endregion

                #region BUTTON 7 INTERACTION - Upgrade 6
                switch (MouseDest.Intersects(button7pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button7Pressedtick = 1;
                    break;
                case false:
                    button7Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button7pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button7Releasedtick = 1;
                    break;
                case false:
                    button7Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button7Pressedtick == 1 && soulsadd == false && souls >= 1000000)
                {
                case true:
                    upgrade6++;
                    souls -= 1000000;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button7Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 8 INTERACTION - Upgrade 7
                switch (MouseDest.Intersects(button8pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button8Pressedtick = 1;
                    break;
                case false:
                    button8Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button8pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button8Releasedtick = 1;
                    break;
                case false:
                    button8Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button8Pressedtick == 1 && soulsadd == false && souls >= 10000000)
                {
                case true:
                    upgrade7++;
                    souls -= 10000000;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button8Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
                }
                #endregion

                #region BUTTON 9 INTERACTION - Upgrade 8
                switch (MouseDest.Intersects(button9pos) && (newState.LeftButton == ButtonState.Pressed))
                {
                case true:
                    button9Pressedtick = 1;
                    break;
                case false:
                    button9Pressedtick = 0;
                    break;
                default:
                    break;
                }

                switch (MouseDest.Intersects(button9pos) && (newState.LeftButton == ButtonState.Released))
                {
                case true:
                    button9Releasedtick = 1;
                    break;
                case false:
                    button9Releasedtick = 0;
                    break;
                default:
                    break;
                }

                switch (button9Pressedtick == 1 && soulsadd == false && souls >= 1000000000)
                {
                case true:
                    upgrade8++;
                    souls -= 1000000000;
                    soulsadd = true;
                    break;
                default:
                    break;
                }

                switch (button9Releasedtick == 1 && soulsadd == true)
                {
                case true:
                    soulsadd = false;
                    break;
                default:
                    break;
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

            switch (button1Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button1Pressed, new Rectangle(button1pos.X, button1pos.Y, button1pos.Width, button1pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button2Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button2Pressed, new Rectangle(button2pos.X, button2pos.Y, button2pos.Width, button2pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button3Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button3Pressed, new Rectangle(button3pos.X, button3pos.Y, button3pos.Width, button3pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button4Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button4Pressed, new Rectangle(button4pos.X, button4pos.Y, button4pos.Width, button4pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button5Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button5Pressed, new Rectangle(button5pos.X, button5pos.Y, button5pos.Width, button5pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button6Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button6Pressed, new Rectangle(button6pos.X, button6pos.Y, button6pos.Width, button6pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button7Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button7Pressed, new Rectangle(button7pos.X, button7pos.Y, button7pos.Width, button7pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button8Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button8Pressed, new Rectangle(button8pos.X, button8pos.Y, button8pos.Width, button8pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (button9Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(button9Pressed, new Rectangle(button9pos.X, button9pos.Y, button9pos.Width, button9pos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            #region DEBUG MOUSE

            spriteBatch.DrawString(font, "Mouse X: " + MouseX, new Vector2(0, 860), Color.White);
            spriteBatch.DrawString(font, "Mouse Y: " + MouseY, new Vector2(0, 880), Color.White);

            switch (newState.LeftButton == ButtonState.Pressed)
            {
                case true:
                    spriteBatch.DrawString(font, "Mouse Pressed", new Vector2(0, 840), Color.White);
                    break;
                case false:
                spriteBatch.DrawString(font, "Mouse Released", new Vector2(0, 840), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
