using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sem_Jeunen_Gamedevelopment.Animations;
using Microsoft.Xna.Framework.Input;
using Sem_Jeunen_Gamedevelopment.Input;

namespace Sem_Jeunen_Gamedevelopment
{
    internal class Hero : IGameObject, IMoveable
    {
        private MovementManager movementManager = new MovementManager();
        private Texture2D heroTexture;
        Animation animatie;
        Vector2 direction;
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public IInputReader InputReader { get; set; }

        public Hero(Texture2D texture, IInputReader inputReader2)
        {
            heroTexture = texture;
            InputReader = inputReader2;
            animatie = new Animation();
            animatie.GetFramesFromTextureProperties(heroTexture.Width, heroTexture.Height, 12, 11);
            Speed = new Vector2(2, 1);
            Position = new Vector2(0, 0);
        }


        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(heroTexture, Position, animatie.currentFrame.SourceRectangle, Color.White);
        }

        public void Update(GameTime gametime)
        {
            Move();
            animatie.Update(gametime);
        }

        private void Move()
        {
            movementManager.Move(this);
        }
    }
}
