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
        Vector2 v=new Vector2(0,0);
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
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            v.X += 10;
            if (v.X > grap.PreferredBackBufferWidth)
            { v.X = 0; v.Y += 10; }
            else if (v.Y > grap.PreferredBackBufferHeight)
                v.Y = 0;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            rum = r.Next(colors.Count);
            // TODO: Add your drawing code here
            sB.Begin();
            sB.DrawString(sprite, "so sleepy",v, colors[rum]);
            sB.End();
            base.Draw(gameTime);
        }
        
    }
}