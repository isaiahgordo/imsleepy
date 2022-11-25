using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace imsleepy
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager grap;
        private SpriteBatch sB;
        SpriteFont sprite;
        Texture2D wioe, dowd ;
        Vector2 cheskers=new Vector2(80,80);
        Rectangle chessy = new Rectangle(0, 0, 80, 80);
        Random r = new Random();
        List<Color> colors = new List<Color> { Color.Red,Color.Green,Color.Blue,Color.Yellow};
        int rum;        
        public Game1()
        {            
            grap = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            grap.PreferredBackBufferWidth = 640;
            grap.PreferredBackBufferHeight = 640;
            grap.ApplyChanges();           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            sB = new SpriteBatch(GraphicsDevice);
            sprite = Content.Load<SpriteFont>("Arial");
            wioe = Content.Load<Texture2D>("woodside");
            dowd = Content.Load<Texture2D>("wooddown");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();                            
            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            rum = r.Next(colors.Count);
            // TODO: Add your drawing code here
            sB.Begin();
            while(chessy.Y+(int)cheskers.Y!= grap.PreferredBackBufferHeight)
            { 
                while (chessy.X + (int)cheskers.X != grap.PreferredBackBufferWidth)
                {
                    sB.Draw(dowd, chessy, Color.White);
                    chessy.X += (int)cheskers.X;
                    sB.Draw(wioe, chessy, Color.White);                    
                }
                chessy.Y +=(int) cheskers.Y;
                chessy.X = 0;              
            }
            sB.End();
            base.Draw(gameTime);
        }
        
    }
}