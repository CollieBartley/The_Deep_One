using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace The_Deep_One
{
    public class Images
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ContentManager Content;

        Souls souls;
        DeepOne deepone;
        Buttons buttons;
        News news;

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


        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        public Images()
        {
            Content.RootDirectory = "Content";
        }
        public Images(DeepOne p_deepone, GraphicsDeviceManager p_graphics, SpriteBatch p_spriteBatch, ContentManager content, Souls p_souls, Buttons p_buttons, News p_news)
        {
            Content = content;
            deepone = p_deepone;
            graphics = p_graphics;
            spriteBatch = p_spriteBatch;
            souls = p_souls;
            buttons = p_buttons;
            news = p_news;
        }

        public void LoadImagesContent()
        {
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


            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        public void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            switch (news.newstick)
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
        }
    }
}