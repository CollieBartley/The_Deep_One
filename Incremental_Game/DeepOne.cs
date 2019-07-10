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
    public class DeepOne : Game
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

        public Texture2D button10;
        public Texture2D button10Pressed;
        public Rectangle button10pos;
        public int button10Pressedtick = 0;
        public int button10Releasedtick = 0;
        public int completetick = 0;

        public Texture2D button11;
        public Texture2D button11Pressed;
        public Rectangle button11pos;
        public int button11Pressedtick = 0;
        public int button11Releasedtick = 0;
        #endregion 

        public Texture2D temp;
        public Texture2D logo;

        // Mouse
        public Rectangle MouseDest;
        public int MouseX, MouseY;
        public int debug = 0;

        // Souls
        Souls souls = new Souls();
        

        // Upgrades
        public int upgrade1 = 0;
        public int upgrade2 = 0;
        public int upgrade3 = 0;
        public int upgrade4 = 0;
        public int upgrade5 = 0;
        public int upgrade6 = 0;
        public int upgrade7 = 0;
        public int upgrade8 = 0;

        // News
        public int newstick = 0;
        public Rectangle newspos;
        public Texture2D news1;
        public Texture2D news2;
        public Texture2D news3;
        public Texture2D news4;
        public Texture2D news5;
        public Texture2D news6;
        public Texture2D news7;
        public Texture2D news8;

        // Images
        public int imagetick = 0;
        public Texture2D image1;
        public Rectangle image1pos;
        public Texture2D image2;
        public Rectangle image2pos;
        public Texture2D image3;
        public Rectangle image3pos;
        public Texture2D image4;
        public Rectangle image4pos;
        public Texture2D image5;
        public Rectangle image5pos;
        public Texture2D image6;
        public Rectangle image6pos;
        public Texture2D image7;
        public Rectangle image7pos;
        public Texture2D image8;
        public Rectangle image8pos;

        public int endstate = 0;

        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        public DeepOne()
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
            logo = Content.Load<Texture2D>("logo");
            rect = Content.Load<Texture2D>("rect");

            #region BUTTONS POS AND LOAD
            button1 = Content.Load<Texture2D>("button");
            button1Pressed = Content.Load<Texture2D>("buttonPressed");
            button1pos.X = 1318;
            button1pos.Y = 56;
            button1pos.Width = 250;
            button1pos.Height = 54;

            button2 = Content.Load<Texture2D>("button");
            button2Pressed = Content.Load<Texture2D>("buttonPressed");
            button2pos.X = 1318;
            button2pos.Y = 122;
            button2pos.Width = 250;
            button2pos.Height = 54;

            button3 = Content.Load<Texture2D>("button");
            button3Pressed = Content.Load<Texture2D>("buttonPressed");
            button3pos.X = 1318;
            button3pos.Y = 187;
            button3pos.Width = 250;
            button3pos.Height = 54;

            button4 = Content.Load<Texture2D>("button");
            button4Pressed = Content.Load<Texture2D>("buttonPressed");
            button4pos.X = 1318;
            button4pos.Y = 254;
            button4pos.Width = 250;
            button4pos.Height = 54;

            button5 = Content.Load<Texture2D>("button");
            button5Pressed = Content.Load<Texture2D>("buttonPressed");
            button5pos.X = 1318;
            button5pos.Y = 320;
            button5pos.Width = 250;
            button5pos.Height = 54;

            button6 = Content.Load<Texture2D>("button");
            button6Pressed = Content.Load<Texture2D>("buttonPressed");
            button6pos.X = 1318;
            button6pos.Y = 386;
            button6pos.Width = 250;
            button6pos.Height = 54;

            button7 = Content.Load<Texture2D>("button");
            button7Pressed = Content.Load<Texture2D>("buttonPressed");
            button7pos.X = 1318;
            button7pos.Y = 452;
            button7pos.Width = 250;
            button7pos.Height = 54;

            button8 = Content.Load<Texture2D>("button");
            button8Pressed = Content.Load<Texture2D>("buttonPressed");
            button8pos.X = 1318;
            button8pos.Y = 518;
            button8pos.Width = 250;
            button8pos.Height = 54;

            button9 = Content.Load<Texture2D>("button");
            button9Pressed = Content.Load<Texture2D>("buttonPressed");
            button9pos.X = 1318;
            button9pos.Y = 584;
            button9pos.Width = 250;
            button9pos.Height = 54;

            button10 = Content.Load<Texture2D>("button");
            button10Pressed = Content.Load<Texture2D>("buttonPressed");
            button10pos.X = 675;
            button10pos.Y = 800;
            button10pos.Width = 250;
            button10pos.Height = 54;

            button11 = Content.Load<Texture2D>("button");
            button11Pressed = Content.Load<Texture2D>("buttonPressed");
            button11pos.X = 675;
            button11pos.Y = 500;
            button11pos.Width = 250;
            button11pos.Height = 54;
            #endregion

            #region NEWS
            news1 = Content.Load<Texture2D>("News1");
            news2 = Content.Load<Texture2D>("News2");
            news3 = Content.Load<Texture2D>("News3");
            news4 = Content.Load<Texture2D>("News4");
            news5 = Content.Load<Texture2D>("News5");
            news6 = Content.Load<Texture2D>("News6");
            news7 = Content.Load<Texture2D>("News7");
            news8 = Content.Load<Texture2D>("News8");
            newspos.X = 15;
            newspos.Y = 55;
            newspos.Width = 368;
            newspos.Height = 551;
            #endregion

            #region IMAGES LOAD
            image1 = Content.Load<Texture2D>("1");
            image1pos.X = 340;
            image1pos.Y = 130;
            image1pos.Width = 850;
            image1pos.Height = 601;
            image2 = Content.Load<Texture2D>("2");
            image2pos.X = 352;
            image2pos.Y = 140;
            image2pos.Width = 832;
            image2pos.Height = 514;
            image3 = Content.Load<Texture2D>("3");
            image3pos.X = 340;
            image3pos.Y = 140;
            image3pos.Width = 855;
            image3pos.Height = 486;
            image4 = Content.Load<Texture2D>("4");
            image4pos.X = 320;
            image4pos.Y = 140;
            image4pos.Width = 855;
            image4pos.Height = 486;
            image5 = Content.Load<Texture2D>("5");
            image5pos.X = 320;
            image5pos.Y = 140;
            image5pos.Width = 855;
            image5pos.Height = 486;
            image6 = Content.Load<Texture2D>("6");
            image6pos.X = 320;
            image6pos.Y = 140;
            image6pos.Width = 855;
            image6pos.Height = 486;
            image7 = Content.Load<Texture2D>("7");
            image7pos.X = 420;
            image7pos.Y = 10;
            image7pos.Width = 596;
            image7pos.Height = 850;
            image8 = Content.Load<Texture2D>("8");
            image8pos.X = 500;
            image8pos.Y = 70;
            image8pos.Width = 601;
            image8pos.Height = 768;
            #endregion

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            //Changes Time
            timeSinceLastUpdate += (int)gameTime.ElapsedGameTime.TotalMilliseconds;
            switch (timeSinceLastUpdate >= millisecondsPerFrame)
            {
                case true:
                    timeSinceLastUpdate = 0;
                    #region UPGRADES
                    switch (upgrade1 > 0)
                    {
                        case true:
                            souls.souls += (upgrade1 *2);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade2 > 0)
                    {
                        case true:
                            souls.souls += (upgrade2 * 10);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade3 > 0)
                    {
                        case true:
                            souls.souls += (upgrade3 * 50);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade4 > 0)
                    {
                        case true:
                            souls.souls += (upgrade4 * 100);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade5 > 0)
                    {
                        case true:
                            souls.souls += (upgrade5 * 1000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade6 > 0)
                    {
                        case true:
                            souls.souls += (upgrade6 * 10000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade7 > 0)
                    {
                        case true:
                            souls.souls += (upgrade7 * 100000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade8 > 0)
                    {
                        case true:
                            souls.souls += (upgrade8 * 1000000);
                            break;
                        default:
                            break;
                    }
                        #endregion
                    break;
                default:
                    break;
            }

            #region LOOPS
            switch (souls.souls < 0)
            {
                case true:
                    souls.souls = 0;
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

            switch (souls.souls >= 10000000000)
            {
                case true:
                    completetick = 1;
                    break;
                default:
                    break;
            }

            switch (button10Pressedtick == 1)
            {
                case true:
                    endstate = 1;
                    break;
                default:
                    break;
            }
            #endregion

            //Mouse position state
            MouseY = Mouse.GetState().Y;
                MouseX = Mouse.GetState().X;

            // Mouse clicking
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

            switch (button1Pressedtick == 1 && souls.soulsadd == false)
            {
                case true:
                    souls.souls++;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button1Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50)
            {
                case true:
                    upgrade1++;
                    souls.souls -= 50;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button2Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button3Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 250)
            {
                case true:
                    upgrade2++;
                    souls.souls -= 250;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button3Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button4Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500)
            {
                case true:
                    upgrade3++;
                    souls.souls -= 1000;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button4Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000)
            {
                case true:
                    upgrade4++;
                    souls.souls -= 10000;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button5Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button6Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000)
            {
                case true:
                    upgrade5++;
                    souls.souls -= 100000;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button6Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button7Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1000000)
            {
                case true:
                    upgrade6++;
                    souls.souls -= 1000000;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button7Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button8Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000000)
            {
                case true:
                    upgrade7++;
                    souls.souls -= 10000000;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button8Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
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

            switch (button9Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000000)
            {
                case true:
                    upgrade8++;
                    souls.souls -= 100000000;
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button9Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region COMPLETE BUTTON
            switch (completetick >= 1)
            {
                case true:
                    switch (MouseDest.Intersects(button10pos) && (newState.LeftButton == ButtonState.Pressed))
                    {
                        case true:
                            button10Pressedtick = 1;
                            break;
                        case false:
                            button10Pressedtick = 0;
                            break;
                        default:
                            break;
                    }

                    switch (MouseDest.Intersects(button10pos) && (newState.LeftButton == ButtonState.Released))
                    {
                        case true:
                            button10Releasedtick = 1;
                            break;
                        case false:
                            button10Releasedtick = 0;
                            break;
                        default:
                            break;
                    }

                    switch (button10Pressedtick == 1 && souls.soulsadd == false)
                    {
                        case true:
                            completetick = 2;
                            break;
                        default:
                            break;
                    }

                    switch (button10Releasedtick == 1 && souls.soulsadd == true)
                    {
                        case true:
                            souls.soulsadd = false;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion

            #region RESET BUTTON
            switch (MouseDest.Intersects(button11pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    button11Pressedtick = 1;
                    break;
                case false:
                    button11Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (MouseDest.Intersects(button11pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    button11Releasedtick = 1;
                    break;
                case false:
                    button11Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (button11Pressedtick == 1 && souls.soulsadd == false)
            {
                case true:
                    completetick = 0;
                    newstick = 0;
                    endstate = 0;
                    souls.souls = 0;
                    upgrade1 = 0;
                    upgrade2 = 0;
                    upgrade3 = 0;
                    upgrade4 = 0;
                    upgrade5 = 0;
                    upgrade6 = 0;
                    upgrade7 = 0;
                    upgrade8 = 0;
                    button1Pressedtick = 0;
                    button1Releasedtick = 0;
                    button2Pressedtick = 0;
                    button2Releasedtick = 0;
                    button3Pressedtick = 0;
                    button3Releasedtick = 0;
                    button4Pressedtick = 0;
                    button4Releasedtick = 0;
                    button5Pressedtick = 0;
                    button5Releasedtick = 0;
                    button6Pressedtick = 0;
                    button6Releasedtick = 0;
                    button7Pressedtick = 0;
                    button7Releasedtick = 0;
                    button8Pressedtick = 0;
                    button8Releasedtick = 0;
                    button9Pressedtick = 0;
                    button9Releasedtick = 0;
                    button10Pressedtick = 0;
                    button10Releasedtick = 0;
                    button11Pressedtick = 0;
                    button11Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (button11Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region NEWS
            switch (souls.souls)
            {
                case 1:
                    newstick = 1;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 200 && newstick == 1)
            {
                case true:
                    newstick = 2;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 1000 && newstick == 2)
            {
                case true:
                    newstick = 3;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 10000 && newstick == 3)
            {
                case true:
                    newstick = 4;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 1000000 && newstick == 4)
            {
                case true:
                    newstick = 5;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 10000000 && newstick == 5)
            {
                case true:
                    newstick = 6;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 1000000000 && newstick == 6)
            {
                case true:
                    newstick = 7;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 10000000000 && newstick == 7)
            {
                case true:
                    newstick = 8;
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
            spriteBatch.Draw(logo, new Rectangle(1100, 445, 655, 655), Color.White);


            #region NEWS DRAWING
            switch (newstick)
            {
                case 1:
                    spriteBatch.Draw(news1, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(news2, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(news3, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 4:
                    spriteBatch.Draw(news4, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 5:
                    spriteBatch.Draw(news5, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 6:
                    spriteBatch.Draw(news6, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 7:
                    spriteBatch.Draw(news7, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                case 8:
                    spriteBatch.Draw(news8, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            #region IMAGES DRAWING
            switch (newstick)
            {
                case 1:
                    spriteBatch.Draw(image1, new Rectangle(image1pos.X, image1pos.Y, image1pos.Width, image1pos.Height), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(image2, new Rectangle(image2pos.X, image2pos.Y, image2pos.Width, image2pos.Height), Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(image3, new Rectangle(image3pos.X, image3pos.Y, image3pos.Width, image3pos.Height), Color.White);
                    break;
                case 4:
                    spriteBatch.Draw(image4, new Rectangle(image4pos.X, image4pos.Y, image4pos.Width, image4pos.Height), Color.White);
                    break;
                case 5:
                    spriteBatch.Draw(image5, new Rectangle(image5pos.X, image5pos.Y, image5pos.Width, image5pos.Height), Color.White);
                    break;
                case 6:
                    spriteBatch.Draw(image6, new Rectangle(image6pos.X, image6pos.Y, image6pos.Width, image6pos.Height), Color.White);
                    break;
                case 7:
                    spriteBatch.Draw(image7, new Rectangle(image7pos.X, image7pos.Y, image7pos.Width, image7pos.Height), Color.White);
                    break;
                case 8:
                    spriteBatch.Draw(image8, new Rectangle(image8pos.X, image8pos.Y, image8pos.Width, image8pos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

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

            switch (completetick == 1)
            {
                case true:
                    spriteBatch.Draw(button10, new Rectangle(button10pos.X, button10pos.Y, button10pos.Width, button10pos.Height), Color.White);
                    break;
                default:
                    break;
            }


            #endregion

            #region BUTTON QUANTITY TEXT
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade1, new Vector2(button2pos.X - 120, button2pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade2, new Vector2(button3pos.X - 120, button3pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade3, new Vector2(button4pos.X - 120, button4pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade4, new Vector2(button5pos.X - 120, button5pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade5, new Vector2(button6pos.X - 120, button6pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade6, new Vector2(button7pos.X - 120, button7pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade7, new Vector2(button8pos.X - 120, button8pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrade8, new Vector2(button9pos.X - 120, button9pos.Y + 13), Color.White);
            #endregion

            #region BUTTON TEXT
            spriteBatch.DrawString(font, "Slaughter in the name of", new Vector2(button1pos.X + 35, button1pos.Y + 9), Color.White);
            spriteBatch.DrawString(font, "The Deep One", new Vector2(button1pos.X + 75, button1pos.Y + 28), Color.White);
            spriteBatch.DrawString(font, "50 - Servitors of Cthulhu", new Vector2(button2pos.X + 10, button2pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "250 - Shoggoth", new Vector2(button3pos.X + 10, button3pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "1K - Dark Young", new Vector2(button4pos.X + 10, button4pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "10K - Star-Spawn of Cthulhu", new Vector2(button5pos.X + 10, button5pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "100K - Dimensional Shambler", new Vector2(button6pos.X + 10, button6pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "1M - Moon-Beast", new Vector2(button7pos.X + 10, button7pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "10M - Chthonian", new Vector2(button8pos.X + 10, button8pos.Y + 18), Color.White);
            spriteBatch.DrawString(font, "100M - Cthulhu", new Vector2(button9pos.X + 10, button9pos.Y + 18), Color.White);

            #endregion

            spriteBatch.DrawString(fontlarge, "10 Billion is required to please The Deep One", new Vector2(15, 860), Color.White);

            #region END
            switch (souls.souls >= 10000000000)
            {
                case true:
                    spriteBatch.DrawString(fontlarge, "Souls: 10000000000", new Vector2(15, 15), Color.White);
                    spriteBatch.DrawString(fontlarge, "Continue?", new Vector2(button10pos.X + 70, button10pos.Y + 12), Color.White);
                    break;
                case false:
                    spriteBatch.DrawString(fontlarge, "Souls: " + souls.souls, new Vector2(15, 15), Color.White);
                    break;
                default:
                    break;
            }

            switch (endstate >= 1)
            {
                case true:
                    spriteBatch.Draw(rect, new Rectangle(0, 0, 1600, 900), Color.Black);
                    spriteBatch.DrawString(fontlarge, "The Deep One is pleased", new Vector2(665, 400), Color.White);
                    break;
                default:
                    break;
            }

            switch (endstate == 1)
            {
                case true:
                    spriteBatch.Draw(button11, new Rectangle(button11pos.X, button11pos.Y, button11pos.Width, button11pos.Height), Color.White);
                    spriteBatch.DrawString(fontlarge, "Reset", new Vector2(button11pos.X + 95, button11pos.Y + 12), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            //#region DEBUG MOUSE
            //spriteBatch.DrawString(font, "Mouse X: " + MouseX, new Vector2(0, 820), Color.White);
            //spriteBatch.DrawString(font, "Mouse Y: " + MouseY, new Vector2(0, 840), Color.White);

            //switch (newState.LeftButton == ButtonState.Pressed)
            //{
            //    case true:
            //        spriteBatch.DrawString(font, "Mouse Pressed", new Vector2(0, 800), Color.White);
            //        break;
            //    case false:
            //        spriteBatch.DrawString(font, "Mouse Released", new Vector2(0, 800), Color.White);
            //        break;
            //    default:
            //        break;
            //}
            //#endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
