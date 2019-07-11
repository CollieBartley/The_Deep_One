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
        News news;
        Upgrades upgrades;

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

        public Buttons()
        {
            Content.RootDirectory = "Content";
        }
        public Buttons(DeepOne p_deepone, GraphicsDeviceManager p_graphics, SpriteBatch p_spriteBatch, ContentManager content, Souls p_souls, Upgrades p_upgrades)
        {
            deepone = p_deepone;
            graphics = p_graphics;
            spriteBatch = p_spriteBatch;
            Content = content;
            souls = p_souls;
            upgrades = p_upgrades;
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
            button11pos.Y = 500;
            button11pos.Width = 250;
            button11pos.Height = 54;
            #endregion

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        public void Update(GameTime gameTime)
        {
            MouseState newState = Mouse.GetState();

            #region BUTTON UPDATES
            // Button 1 - Clicker
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

            // Button 2 - Upgrade 1
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

            switch (button2Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 50)
            {
                case true:
                    upgrades.upgrade1++;
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

            // Button 3 - Upgrade 2
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

            switch (button3Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 250)
            {
                case true:
                    upgrades.upgrade2++;
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

            // Button 4 - Upgrade 3
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

            switch (button4Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 500)
            {
                case true:
                    upgrades.upgrade3++;
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

            // Button 5 - Upgrade 4
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

            switch (button5Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000)
            {
                case true:
                    upgrades.upgrade4++;
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

            // Button 6 - Upgrade 5
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

            switch (button6Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000)
            {
                case true:
                    upgrades.upgrade5++;
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

            // Button 7 - Upgrade 6
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

            switch (button7Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 1000000)
            {
                case true:
                    upgrades.upgrade6++;
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

            // Button 8 - Upgrade 7
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

            switch (button8Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 10000000)
            {
                case true:
                    upgrades.upgrade7++;
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

            // Button 9 - Upgrade 8
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

            switch (button9Pressedtick == 1 && souls.soulsadd == false && souls.souls >= 100000000)
            {
                case true:
                    upgrades.upgrade8++;
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

            //Button 10 - Complete Button
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

            // Button 11 - Reset Button
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
        }

        public void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

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

            upgrades.Draw(gameTime);

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
        }
    }
}
