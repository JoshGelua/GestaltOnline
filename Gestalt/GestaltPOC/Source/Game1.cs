using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GestaltPOC.Source
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _characterTexture;
        private Vector2 _characterPosition;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _characterPosition = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // _characterTexture = Content.Load<Texture2D>("character");

            // TODO: Load additional game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Handle character movement
            //KeyboardState keyboardState = Keyboard.GetState();
            //float movementSpeed = 5f;

            //if (keyboardState.IsKeyDown(Keys.W))
            //    _characterPosition.Y -= movementSpeed;
            //if (keyboardState.IsKeyDown(Keys.S))
            //    _characterPosition.Y += movementSpeed;
            //if (keyboardState.IsKeyDown(Keys.A))
            //    _characterPosition.X -= movementSpeed;
            //if (keyboardState.IsKeyDown(Keys.D))
            //    _characterPosition.X += movementSpeed;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            //_spriteBatch.Begin();

            //// Draw character
            //_spriteBatch.Draw(_characterTexture, _characterPosition, Color.White);

            //// TODO: Add additional drawing code here

            //_spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
