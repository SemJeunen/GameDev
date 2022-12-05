using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_Jeunen_Gamedevelopment.Animations;
using System.Drawing.Text;
using SharpDX.MediaFoundation;

namespace Sem_Jeunen_Gamedevelopment
{
    internal class Hero : IGameObject
    {
        private Texture2D heroTexture;
        Animation animatie;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animatie = new Animation();
            animatie.GetFramesFromTextureProperties(heroTexture.Width, heroTexture.Height, 12, 11);
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(heroTexture, new Vector2(0, 0), animatie.currentFrame.SourceRectangle, Color.White);

            Vector2 positie;

            positie = new Vector2(0,0);

            _spriteBatch.Draw(heroTexture, positie, animatie.currentFrame.SourceRectangle, Color.White);
        }

        public void Update(GameTime gametime)
        {
            animatie.Update(gametime);
        }
    }
}
