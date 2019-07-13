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
        public Song backgroundMusic;

        int millisecondsPerFrame = 1000; //Update every 1 second
        int timeSinceLastUpdate = 0; //Accumulate the elapsed time

        public Texture2D rect;
        public Texture2D temp;
        public Texture2D logo;

        // Mouse
        public Rectangle MouseDest;
        public int MouseX, MouseY;
        public int debug = 0;

        Souls souls = new Souls();
        Buttons buttons;
        News news;
        Images images;
        Upgrades upgrades;
        public Texture2D end;
        public Rectangle endpos;


        public int endstate = 0;

        //public List<SoundEffect> soundEffects;
        public SoundEffect roar, neWs;
        public SoundEffectInstance roarinst, neWsInst;
        public List<SoundEffect> soundEffects;

        public int roartick = 0;

        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        public DeepOne()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1600; // Window Width
            graphics.PreferredBackBufferHeight = 900;// Window Height

            soundEffects = new List<SoundEffect>();

            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Screen.Width = GraphicsDevice.Viewport.Width;
            Screen.Height = GraphicsDevice.Viewport.Height;
            Screen.X = 0;
            Screen.Y = 0;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            upgrades = new Upgrades(this, graphics, spriteBatch, Content, souls, news, images);
            buttons = new Buttons(this, graphics, spriteBatch, Content, souls);
            news = new News(this, graphics, spriteBatch, Content, souls, buttons);
            images = new Images(this, graphics, spriteBatch, Content, souls, buttons, news);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            temp = Content.Load<Texture2D>("temp");
            logo = Content.Load<Texture2D>("logo");
            rect = Content.Load<Texture2D>("rect");

            buttons.LoadButtonContent();

            news.LoadNewsContent();

            images.LoadImagesContent();

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");

            // Music & Sound Effects
            backgroundMusic = Content.Load<Song>("background");
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Volume -= 0.6f;
            MediaPlayer.Play(backgroundMusic);

            soundEffects.Add(Content.Load<SoundEffect>("click"));

            roar = Content.Load<SoundEffect>("roar");
            roarinst = roar.CreateInstance();

            neWs = Content.Load<SoundEffect>("news");
            neWsInst = neWs.CreateInstance();

            SoundEffect.MasterVolume = 0.2f;

            end = Content.Load<Texture2D>("9");
            endpos.X = 480;
            endpos.Y = 70;
            endpos.Width = 640;
            endpos.Height = 811;
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
                    upgrades.Update(gameTime, buttons);
                    break;
                default:
                    break;
            }

            // LOOPS
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

            switch (souls.souls >= 10000000000 && buttons.completetick == 0)
            {
                case true:
                    buttons.completetick = 1;
                    break;
                default:
                    break;
            }

            switch (buttons.button10Pressedtick == 1)
            {
                case true:
                    endstate = 1;
                    break;
                default:
                    break;
            }

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

            buttons.Update(gameTime, news, upgrades);

            news.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            spriteBatch.Begin();

            //spriteBatch.Draw(temp, new Rectangle(0, 0, Screen.Width, Screen.Height), Color.White);
            spriteBatch.Draw(logo, new Rectangle(1100, 445, 655, 655), Color.White);

            news.Draw(gameTime);

            images.Draw(gameTime);

            buttons.Draw(gameTime, upgrades);

            upgrades.Draw(gameTime);

            spriteBatch.DrawString(fontlarge, "10 Billion is required to please The Deep One", new Vector2(15, 860), Color.White);

            switch (souls.souls >= 10000000000)
            {
                case true:
                    spriteBatch.DrawString(fontlarge, "Souls: 10000000000", new Vector2(15, 15), Color.White);
                    spriteBatch.DrawString(fontlarge, "Continue?", new Vector2(buttons.button10pos.X + 70, buttons.button10pos.Y + 12), Color.White);
                    break;
                case false:
                    spriteBatch.DrawString(fontlarge, "Souls: " + souls.souls, new Vector2(15, 15), Color.White);
                    break;
                default:
                    break;
            }

            switch (endstate)
            {
                case 1:
                    spriteBatch.Draw(rect, new Rectangle(0, 0, 1600, 900), Color.Black);
                    spriteBatch.Draw(end, new Rectangle(endpos.X, endpos.Y, endpos.Width, endpos.Height), Color.White);
                    break;
            }

            switch (endstate >= 1)
            {
                case true:
                    spriteBatch.DrawString(fontlarge, "The Deep One is pleased", new Vector2(665, 50), Color.White);
                    switch (roarinst.State == SoundState.Stopped && roartick == 0)
                    {
                        case true:
                            roarinst.Play();
                            roartick = 1;
                            SoundEffect.MasterVolume = 0.9f;
                            break;
                        case false:
                            roartick = 0;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            switch (endstate == 1)
            {
                case true:
                    spriteBatch.Draw(buttons.button11, new Rectangle(buttons.button11pos.X, buttons.button11pos.Y, buttons.button11pos.Width, buttons.button11pos.Height), Color.White);
                    spriteBatch.DrawString(fontlarge, "Reset", new Vector2(buttons.button11pos.X + 95, buttons.button11pos.Y + 12), Color.White);
                    break;
                default:
                    break;
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
