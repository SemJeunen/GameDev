using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sem_Jeunen_Gamedevelopment.Animations;

namespace Sem_Jeunen_Gamedevelopment
{
    internal class Hero : IGameObject
    {
        private Texture2D heroTexture;
        Animation animatie;
        Vector2 positie;
        Vector2 snelheid;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animatie = new Animation();
            animatie.GetFramesFromTextureProperties(heroTexture.Width, heroTexture.Height, 12, 11);
            snelheid = new Vector2(1, 1);
            positie = new Vector2(0, 0);
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(heroTexture, positie, animatie.currentFrame.SourceRectangle, Color.White);
        }

        public void Update(GameTime gametime)
        {
            animatie.Update(gametime);
            Move();
        }

        private void Move()
        {
            positie += snelheid;
            if (positie.X >  GraphicsDeviceManager.DefaultBackBufferWidth - (heroTexture.Width / 12) || positie.X < 0)
            {
                snelheid.X *= -1;
            }
            if (positie.Y > GraphicsDeviceManager.DefaultBackBufferHeight - (heroTexture.Height / 11) || positie.Y < 0)
            {
                snelheid.Y *= -1;
            }

        }
    }
}
