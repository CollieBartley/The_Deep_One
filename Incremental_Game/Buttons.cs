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
    public class Buttons
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ContentManager Content;

        Souls souls;
        DeepOne deepone;

        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        #region BUTTON POS & TICK
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

        #region 1X 5X 10X 50X BUTTON POS & TICK
        public int buttonxtick = 0;

        public Texture2D button1x;
        public Texture2D button1xPressed;
        public Rectangle button1xpos;

        public Texture2D button5x;
        public Texture2D button5xPressed;
        public Rectangle button5xpos;

        public Texture2D button10x;
        public Texture2D button10xPressed;
        public Rectangle button10xpos;

        public Texture2D button50x;
        public Texture2D button50xPressed;
        public Rectangle button50xpos;
        #endregion

        #region +1 +2 +5 +10 +20 +30 BUTTON POS + TICK
        public Texture2D buttonplus1;
        public Texture2D buttonplus1Pressed;
        public Rectangle buttonplus1pos;
        public int buttonplus1Pressedtick = 0;
        public int buttonplus1Releasedtick = 0;

        public Texture2D buttonplus2;
        public Texture2D buttonplus2Pressed;
        public Rectangle buttonplus2pos;
        public int buttonplus2Pressedtick = 0;
        public int buttonplus2Releasedtick = 0;

        public Texture2D buttonplus5;
        public Texture2D buttonplus5Pressed;
        public Rectangle buttonplus5pos;
        public int buttonplus5Pressedtick = 0;
        public int buttonplus5Releasedtick = 0;

        public Texture2D buttonplus10;
        public Texture2D buttonplus10Pressed;
        public Rectangle buttonplus10pos;
        public int buttonplus10Pressedtick = 0;
        public int buttonplus10Releasedtick = 0;

        public Texture2D buttonplus20;
        public Texture2D buttonplus20Pressed;
        public Rectangle buttonplus20pos;
        public int buttonplus20Pressedtick = 0;
        public int buttonplus20Releasedtick = 0;

        public Texture2D buttonplus30;
        public Texture2D buttonplus30Pressed;
        public Rectangle buttonplus30pos;
        public int buttonplus30Pressedtick = 0;
        public int buttonplus30Releasedtick = 0;
        #endregion

        public Buttons()
        {
            Content.RootDirectory = "Content";
        }
        public Buttons(DeepOne p_deepone, GraphicsDeviceManager p_graphics, SpriteBatch p_spriteBatch, ContentManager content, Souls p_souls)
        {
            deepone = p_deepone;
            graphics = p_graphics;
            spriteBatch = p_spriteBatch;
            Content = content;
            souls = p_souls;
        }

        public void LoadButtonContent()
        {
            #region BUTTON LOAD
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
            button11pos.Y = 700;
            button11pos.Width = 250;
            button11pos.Height = 54;
            #endregion

            #region 1X 5X 10X 50X LOAD
            button1x = Content.Load<Texture2D>("button");
            button1xPressed = Content.Load<Texture2D>("buttonPressed");
            button1xpos.X = 1318;
            button1xpos.Y = 5;
            button1xpos.Width = 45;
            button1xpos.Height = 45;

            button5x = Content.Load<Texture2D>("button");
            button5xPressed = Content.Load<Texture2D>("buttonPressed");
            button5xpos.X = 1385;
            button5xpos.Y = 5;
            button5xpos.Width = 45;
            button5xpos.Height = 45;

            button10x = Content.Load<Texture2D>("button");
            button10xPressed = Content.Load<Texture2D>("buttonPressed");
            button10xpos.X = 1455;
            button10xpos.Y = 5;
            button10xpos.Width = 45;
            button10xpos.Height = 45;

            button50x = Content.Load<Texture2D>("button");
            button50xPressed = Content.Load<Texture2D>("buttonPressed");
            button50xpos.X = 1521;
            button50xpos.Y = 5;
            button50xpos.Width = 45;
            button50xpos.Height = 45;
            #endregion

            #region +1 +2 +5 +10 +20 +30 LOAD
            buttonplus1 = Content.Load<Texture2D>("button");
            buttonplus1Pressed = Content.Load<Texture2D>("buttonPressed");
            buttonplus1pos.X = 10;
            buttonplus1pos.Y = 755;
            buttonplus1pos.Width = 90;
            buttonplus1pos.Height = 45;

            buttonplus2 = Content.Load<Texture2D>("button");
            buttonplus2Pressed = Content.Load<Texture2D>("buttonPressed");
            buttonplus2pos.X = 105;
            buttonplus2pos.Y = 755;
            buttonplus2pos.Width = 90;
            buttonplus2pos.Height = 45;

            buttonplus5 = Content.Load<Texture2D>("button");
            buttonplus5Pressed = Content.Load<Texture2D>("buttonPressed");
            buttonplus5pos.X = 200;
            buttonplus5pos.Y = 755;
            buttonplus5pos.Width = 90;
            buttonplus5pos.Height = 45;

            buttonplus10 = Content.Load<Texture2D>("button");
            buttonplus10Pressed = Content.Load<Texture2D>("buttonPressed");
            buttonplus10pos.X = 10;
            buttonplus10pos.Y = 805;
            buttonplus10pos.Width = 90;
            buttonplus10pos.Height = 45;

            buttonplus20 = Content.Load<Texture2D>("button");
            buttonplus20Pressed = Content.Load<Texture2D>("buttonPressed");
            buttonplus20pos.X = 105;
            buttonplus20pos.Y = 805;
            buttonplus20pos.Width = 90;
            buttonplus20pos.Height = 45;

            buttonplus30 = Content.Load<Texture2D>("button");
            buttonplus30Pressed = Content.Load<Texture2D>("buttonPressed");
            buttonplus30pos.X = 200;
            buttonplus30pos.Y = 805;
            buttonplus30pos.Width = 90;
            buttonplus30pos.Height = 45;
            #endregion

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        public void Update(GameTime gameTime, News news, Upgrades upgrades)
        {
            MouseState newState = Mouse.GetState();

            #region Button 1 - Clicker
            switch (deepone.MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button1pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button1Pressedtick == 1 && souls.soulsadd == false && deepone.endstate == 0)
            {
                case true:
                    souls.souls += souls.soulsclick;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 2 - Upgrade 1
            switch (deepone.MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button2pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade1++;
                    souls.souls -= 50;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 250 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade1 += 5;
                    souls.souls -= 250;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade1 += 10;
                    souls.souls -= 500;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1250 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade1 += 50;
                    souls.souls -= 1250;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 3 - Upgrade 2
            switch (deepone.MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button3pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button3Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 250 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade2++;
                    souls.souls -= 250;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button3Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1250 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade2 += 5;
                    souls.souls -= 1250;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button3Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 2500 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade2 += 10;
                    souls.souls -= 2500;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button3Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 12500 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade2 += 50;
                    souls.souls -= 12500;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 4 - Upgrade 3
            switch (deepone.MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button4pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button4Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade3++;
                    souls.souls -= 1000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button4Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 2500 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade3 += 5;
                    souls.souls -= 2500;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button4Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 5000 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade3 += 10;
                    souls.souls -= 5000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button4Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 25000 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade3 += 50;
                    souls.souls -= 25000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 5 - Upgrade 4
            switch (deepone.MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button5pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade4++;
                    souls.souls -= 10000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50000 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade4 += 5;
                    souls.souls -= 50000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade4 += 10;
                    souls.souls -= 100000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500000 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade4 += 50;
                    souls.souls -= 500000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 6 - Upgrade 5
            switch (deepone.MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button6pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button6Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade5++;
                    souls.souls -= 100000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button6Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500000 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade5 += 5;
                    souls.souls -= 500000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button6Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1000000 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade5 += 10;
                    souls.souls -= 1000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button6Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 5000000 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade5 += 50;
                    souls.souls -= 5000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 7 - Upgrade 6
            switch (deepone.MouseDest.Intersects(button7pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button7pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button7Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1000000 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade6++;
                    souls.souls -= 1000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button7Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 5000000 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade6 += 5;
                    souls.souls -= 5000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button7Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000000 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade6 += 10;
                    souls.souls -= 10000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button7Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50000000 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade6 += 50;
                    souls.souls -= 50000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 8 - Upgrade 7
            switch (deepone.MouseDest.Intersects(button8pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button8pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button8Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000000 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade7++;
                    souls.souls -= 10000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button8Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50000000 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade7 += 5;
                    souls.souls -= 50000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button8Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000000 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade7 += 10;
                    souls.souls -= 100000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (button8Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500000000 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade7 += 50;
                    souls.souls -= 500000000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 9 - Upgrade 8
            switch (deepone.MouseDest.Intersects(button9pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button9pos) && (newState.LeftButton == ButtonState.Released))
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

            switch (button9Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000000 && buttonxtick == 0 && completetick == 0)
            {
                case true:
                    upgrades.upgrade8++;
                    souls.souls -= 100000000;
                    deepone.soundEffects[0].CreateInstance().Play();
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button9Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500000000 && buttonxtick == 1)
            {
                case true:
                    upgrades.upgrade8 += 5;
                    souls.souls -= 500000000;
                    deepone.soundEffects[0].CreateInstance().Play();
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button9Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1000000000 && buttonxtick == 2)
            {
                case true:
                    upgrades.upgrade8 += 10;
                    souls.souls -= 1000000000;
                    deepone.soundEffects[0].CreateInstance().Play();
                    souls.soulsadd = true;
                    break;
                default:
                    break;
            }

            switch (button9Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 5000000000 && buttonxtick == 3)
            {
                case true:
                    upgrades.upgrade8 += 50;
                    souls.souls -= 5000000000;
                    deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 10 - Complete Button
            switch (completetick >= 1)
            {
                case true:
                    switch (deepone.MouseDest.Intersects(button10pos) && (newState.LeftButton == ButtonState.Pressed))
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

                    switch (deepone.MouseDest.Intersects(button10pos) && (newState.LeftButton == ButtonState.Released))
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
                            deepone.soundEffects[0].CreateInstance().Play();
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

            #region Button 11 - Reset Button
            switch (deepone.MouseDest.Intersects(button11pos) && (newState.LeftButton == ButtonState.Pressed))
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

            switch (deepone.MouseDest.Intersects(button11pos) && (newState.LeftButton == ButtonState.Released))
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
                    news.newstick = 0;
                    deepone.endstate = 0;
                    souls.souls = 0;
                    upgrades.upgrade1 = 0;
                    upgrades.upgrade2 = 0;
                    upgrades.upgrade3 = 0;
                    upgrades.upgrade4 = 0;
                    upgrades.upgrade5 = 0;
                    upgrades.upgrade6 = 0;
                    upgrades.upgrade7 = 0;
                    upgrades.upgrade8 = 0;
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
                    deepone.soundEffects[0].CreateInstance().Play();
                    SoundEffect.MasterVolume = 0.2f;
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

            #region 1X 5X 10X 50X BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(button1xpos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonxtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(button5xpos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonxtick = 1;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(button10xpos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonxtick = 2;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(button50xpos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonxtick = 3;
                    break;
                default:
                    break;
            }
            #endregion

            #region +1 +2 +5 +10 +20 +30 BUTTON UPDATES
            #region +1 BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(buttonplus1pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonplus1Pressedtick = 1;
                    break;
                case false:
                    buttonplus1Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(buttonplus1pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    buttonplus1Releasedtick = 1;
                    break;
                case false:
                    buttonplus1Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (buttonplus1Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50 && completetick == 0)
            {
                case true:
                    souls.soulsclick += 1;
                    souls.souls -= 50;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (buttonplus1Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region +2 BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(buttonplus2pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonplus2Pressedtick = 1;
                    break;
                case false:
                    buttonplus2Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(buttonplus2pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    buttonplus2Releasedtick = 1;
                    break;
                case false:
                    buttonplus2Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (buttonplus2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100 && completetick == 0)
            {
                case true:
                    souls.soulsclick += 5;
                    souls.souls -= 100;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (buttonplus2Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region +5 BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(buttonplus5pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonplus5Pressedtick = 1;
                    break;
                case false:
                    buttonplus5Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(buttonplus5pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    buttonplus5Releasedtick = 1;
                    break;
                case false:
                    buttonplus5Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (buttonplus5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 250 && completetick == 0)
            {
                case true:
                    souls.soulsclick += 10;
                    souls.souls -= 250;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (buttonplus5Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region +10 BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(buttonplus10pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonplus10Pressedtick = 1;
                    break;
                case false:
                    buttonplus10Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(buttonplus10pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    buttonplus10Releasedtick = 1;
                    break;
                case false:
                    buttonplus10Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (buttonplus10Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500 && completetick == 0)
            {
                case true:
                    souls.soulsclick += 10;
                    souls.souls -= 500;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (buttonplus10Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region +20 BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(buttonplus20pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonplus20Pressedtick = 1;
                    break;
                case false:
                    buttonplus20Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(buttonplus20pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    buttonplus20Releasedtick = 1;
                    break;
                case false:
                    buttonplus20Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (buttonplus20Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1000 && completetick == 0)
            {
                case true:
                    souls.soulsclick += 10;
                    souls.souls -= 1000;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (buttonplus20Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #region +30 BUTTON UPDATES
            switch (deepone.MouseDest.Intersects(buttonplus30pos) && (newState.LeftButton == ButtonState.Pressed))
            {
                case true:
                    buttonplus30Pressedtick = 1;
                    break;
                case false:
                    buttonplus30Pressedtick = 0;
                    break;
                default:
                    break;
            }

            switch (deepone.MouseDest.Intersects(buttonplus30pos) && (newState.LeftButton == ButtonState.Released))
            {
                case true:
                    buttonplus30Releasedtick = 1;
                    break;
                case false:
                    buttonplus30Releasedtick = 0;
                    break;
                default:
                    break;
            }

            switch (buttonplus30Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1500 && completetick == 0)
            {
                case true:
                    souls.soulsclick += 10;
                    souls.souls -= 1500;
                    souls.soulsadd = true;
                    deepone.soundEffects[0].CreateInstance().Play();
                    break;
                default:
                    break;
            }

            switch (buttonplus30Releasedtick == 1 && souls.soulsadd == true)
            {
                case true:
                    souls.soulsadd = false;
                    break;
                default:
                    break;
            }
            #endregion

            #endregion
        }

        public void Draw(GameTime gameTime, Upgrades upgrades)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            #region BUTTON DRAWING
            spriteBatch.Draw(button1, new Rectangle(button1pos.X, button1pos.Y, button1pos.Width, button1pos.Height), Color.White);
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

            switch (souls.souls <= 49)
            {
                case true:
                    spriteBatch.Draw(button2Pressed, new Rectangle(button2pos.X, button2pos.Y, button2pos.Width, button2pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button2, new Rectangle(button2pos.X, button2pos.Y, button2pos.Width, button2pos.Height), Color.White);
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

            switch (souls.souls <= 249)
            {
                case true:
                    spriteBatch.Draw(button3Pressed, new Rectangle(button3pos.X, button3pos.Y, button3pos.Width, button3pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button3, new Rectangle(button3pos.X, button3pos.Y, button3pos.Width, button3pos.Height), Color.White);
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

            switch (souls.souls <= 999)
            {
                case true:
                    spriteBatch.Draw(button4Pressed, new Rectangle(button4pos.X, button4pos.Y, button4pos.Width, button4pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button4, new Rectangle(button4pos.X, button4pos.Y, button4pos.Width, button4pos.Height), Color.White);
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

            switch (souls.souls <= 9999)
            {
                case true:
                    spriteBatch.Draw(button5Pressed, new Rectangle(button5pos.X, button5pos.Y, button5pos.Width, button5pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button5, new Rectangle(button5pos.X, button5pos.Y, button5pos.Width, button5pos.Height), Color.White);
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

            switch (souls.souls <= 99999)
            {
                case true:
                    spriteBatch.Draw(button6Pressed, new Rectangle(button6pos.X, button6pos.Y, button6pos.Width, button6pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button6, new Rectangle(button6pos.X, button6pos.Y, button6pos.Width, button6pos.Height), Color.White);
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

            switch (souls.souls <= 999999)
            {
                case true:
                    spriteBatch.Draw(button7Pressed, new Rectangle(button7pos.X, button7pos.Y, button7pos.Width, button7pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button7, new Rectangle(button7pos.X, button7pos.Y, button7pos.Width, button7pos.Height), Color.White);
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

            switch (souls.souls <= 9999999)
            {
                case true:
                    spriteBatch.Draw(button8Pressed, new Rectangle(button8pos.X, button8pos.Y, button8pos.Width, button8pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button8, new Rectangle(button8pos.X, button8pos.Y, button8pos.Width, button8pos.Height), Color.White);
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

            switch (souls.souls <= 99999999)
            {
                case true:
                    spriteBatch.Draw(button9Pressed, new Rectangle(button9pos.X, button9pos.Y, button9pos.Width, button9pos.Height), Color.White);
                    break;
                case false:
                    spriteBatch.Draw(button9, new Rectangle(button9pos.X, button9pos.Y, button9pos.Width, button9pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (completetick == 1 && deepone.endstate == 0)
            {
                case true:
                    spriteBatch.Draw(button10, new Rectangle(button10pos.X, button10pos.Y, button10pos.Width, button10pos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            #region 1X 5X 10X 50X BUTTON DRAWING
            spriteBatch.Draw(button1x, new Rectangle(button1xpos.X, button1xpos.Y, button1xpos.Width, button1xpos.Height), Color.White);
            spriteBatch.Draw(button5x, new Rectangle(button5xpos.X, button5xpos.Y, button5xpos.Width, button5xpos.Height), Color.White);
            spriteBatch.Draw(button10x, new Rectangle(button10xpos.X, button10xpos.Y, button10xpos.Width, button10xpos.Height), Color.White);
            spriteBatch.Draw(button50x, new Rectangle(button50xpos.X, button50xpos.Y, button50xpos.Width, button50xpos.Height), Color.White);

            switch (buttonxtick)
            {
                case 0:
                    spriteBatch.Draw(button1xPressed, new Rectangle(button1xpos.X, button1xpos.Y, button1xpos.Width, button1xpos.Height), Color.White);
                    break;
                case 1:
                    spriteBatch.Draw(button5xPressed, new Rectangle(button5xpos.X, button5xpos.Y, button5xpos.Width, button5xpos.Height), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(button10xPressed, new Rectangle(button10xpos.X, button10xpos.Y, button10xpos.Width, button10xpos.Height), Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(button50xPressed, new Rectangle(button50xpos.X, button50xpos.Y, button50xpos.Width, button50xpos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            #region +1 +2 +5 +10 +20 +30 BUTTON DRAWING
            spriteBatch.Draw(buttonplus1, new Rectangle(buttonplus1pos.X, buttonplus1pos.Y, buttonplus1pos.Width, buttonplus1pos.Height), Color.White);
            spriteBatch.Draw(buttonplus1, new Rectangle(buttonplus2pos.X, buttonplus2pos.Y, buttonplus2pos.Width, buttonplus2pos.Height), Color.White);
            spriteBatch.Draw(buttonplus5, new Rectangle(buttonplus5pos.X, buttonplus5pos.Y, buttonplus1pos.Width, buttonplus5pos.Height), Color.White);
            spriteBatch.Draw(buttonplus10, new Rectangle(buttonplus10pos.X, buttonplus10pos.Y, buttonplus10pos.Width, buttonplus10pos.Height), Color.White);
            spriteBatch.Draw(buttonplus20, new Rectangle(buttonplus20pos.X, buttonplus20pos.Y, buttonplus20pos.Width, buttonplus20pos.Height), Color.White);
            spriteBatch.Draw(buttonplus30, new Rectangle(buttonplus30pos.X, buttonplus30pos.Y, buttonplus30pos.Width, buttonplus30pos.Height), Color.White);


            switch (buttonplus1Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(buttonplus1Pressed, new Rectangle(buttonplus1pos.X, buttonplus1pos.Y, buttonplus1pos.Width, buttonplus1pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (buttonplus2Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(buttonplus2Pressed, new Rectangle(buttonplus2pos.X, buttonplus2pos.Y, buttonplus2pos.Width, buttonplus2pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (buttonplus5Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(buttonplus5Pressed, new Rectangle(buttonplus5pos.X, buttonplus5pos.Y, buttonplus5pos.Width, buttonplus5pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (buttonplus10Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(buttonplus10Pressed, new Rectangle(buttonplus10pos.X, buttonplus10pos.Y, buttonplus10pos.Width, buttonplus10pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (buttonplus20Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(buttonplus20Pressed, new Rectangle(buttonplus20pos.X, buttonplus20pos.Y, buttonplus20pos.Width, buttonplus20pos.Height), Color.White);
                    break;
                default:
                    break;
            }

            switch (buttonplus30Pressedtick)
            {
                case 1:
                    spriteBatch.Draw(buttonplus30Pressed, new Rectangle(buttonplus30pos.X, buttonplus30pos.Y, buttonplus30pos.Width, buttonplus30pos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            #region BUTTON QUANTITY TEXT
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade1, new Vector2(button2pos.X - 120, button2pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade2, new Vector2(button3pos.X - 120, button3pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade3, new Vector2(button4pos.X - 120, button4pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade4, new Vector2(button5pos.X - 120, button5pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade5, new Vector2(button6pos.X - 120, button6pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade6, new Vector2(button7pos.X - 120, button7pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade7, new Vector2(button8pos.X - 120, button8pos.Y + 13), Color.White);
            spriteBatch.DrawString(fontlarge, "QTY: " + upgrades.upgrade8, new Vector2(button9pos.X - 120, button9pos.Y + 13), Color.White);
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

            #region 1X 5X 10X 50X BUTTON TEXT
            spriteBatch.DrawString(font, "1X", new Vector2(button1xpos.X + 12, button1xpos.Y + 12), Color.White);
            spriteBatch.DrawString(font, "5X", new Vector2(button5xpos.X + 12, button5xpos.Y + 12), Color.White);
            spriteBatch.DrawString(font, "10X", new Vector2(button10xpos.X + 10, button10xpos.Y + 12), Color.White);
            spriteBatch.DrawString(font, "50X", new Vector2(button50xpos.X + 10, button50xpos.Y + 12), Color.White);
            #endregion

            #region +1 +2 +5 +10 +20 +30 BUTTON TEXT
            spriteBatch.DrawString(font, "+1 Clicker", new Vector2(buttonplus1pos.X + 8, buttonplus1pos.Y + 5), Color.White);
            spriteBatch.DrawString(font, "$50", new Vector2(buttonplus1pos.X + 32, buttonplus1pos.Y + 22), Color.White);
            spriteBatch.DrawString(font, "+2 Clicker", new Vector2(buttonplus2pos.X + 8, buttonplus2pos.Y + 5), Color.White);
            spriteBatch.DrawString(font, "$100", new Vector2(buttonplus2pos.X + 28, buttonplus2pos.Y + 22), Color.White);
            spriteBatch.DrawString(font, "+5 Clicker", new Vector2(buttonplus5pos.X + 8, buttonplus5pos.Y + 5), Color.White);
            spriteBatch.DrawString(font, "$250", new Vector2(buttonplus5pos.X + 28, buttonplus5pos.Y + 22), Color.White);
            spriteBatch.DrawString(font, "+10 Clicker", new Vector2(buttonplus10pos.X + 4, buttonplus10pos.Y + 5), Color.White);
            spriteBatch.DrawString(font, "$500", new Vector2(buttonplus10pos.X + 28, buttonplus10pos.Y + 22), Color.White);
            spriteBatch.DrawString(font, "+20 Clicker", new Vector2(buttonplus20pos.X + 4, buttonplus20pos.Y + 5), Color.White);
            spriteBatch.DrawString(font, "$1000", new Vector2(buttonplus20pos.X + 24, buttonplus20pos.Y + 22), Color.White);
            spriteBatch.DrawString(font, "+30 Clicker", new Vector2(buttonplus30pos.X + 4, buttonplus30pos.Y + 5), Color.White);
            spriteBatch.DrawString(font, "$1500", new Vector2(buttonplus30pos.X + 24, buttonplus30pos.Y + 22), Color.White);
            #endregion
        }
    }
}
