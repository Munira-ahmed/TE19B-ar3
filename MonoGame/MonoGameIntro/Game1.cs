using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameIntro
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D normalTexture;
        private Texture2D jumpingTexture;
        private Texture2D crouchTexture;
        private Texture2D fireballTexture;
        private Vector2 position;
        private List<Vector2> fireballs;
        private Vector2 speed;
        private bool isJumping;
        private bool isCrouching;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            position = new Vector2(300, 200);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            normalTexture = Content.Load<Texture2D>("normal");
            jumpingTexture = Content.Load<Texture2D>("jump");
            crouchTexture = Content.Load<Texture2D>("crouch");
            fireballTexture = Content.Load<Texture2D>("fireball");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            position += speed;
            if (position.Y > 200)
            {
                position = new Vector2(position.X, 200);
                speed = Vector2.Zero;
                isJumping = false;
            }
            speed += new Vector2(0, 0.2f); //+ betyder en hastighet ner 
            var state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.W) && !isJumping)
            {
                speed = new Vector2(0, -5.0f); // f visar att det är float
                isJumping = true;
            }
            if (state.IsKeyDown(Keys.S) && !isJumping)
            {
                isCrouching = true;
            }
            else
            {
                isCrouching = false;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            if (isJumping)
            {
                _spriteBatch.Draw(jumpingTexture, position, Color.White);
            }
            else if (isCrouching)
            {
                _spriteBatch.Draw(crouchTexture, position, Color.White);
            }
            else
            {
                _spriteBatch.Draw(normalTexture, position, Color.White);
            }

            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
