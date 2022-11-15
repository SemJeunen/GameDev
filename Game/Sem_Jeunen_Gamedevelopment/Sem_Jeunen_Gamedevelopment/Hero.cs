using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_Jeunen_Gamedevelopment.Animations;

namespace Sem_Jeunen_Gamedevelopment
{
    internal class Hero : IGameObject
    {
        private Texture2D heroTexture;
        Animation animatie;
        private int aantalFrames = 24;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animatie = new Animation();
            for (int i = 0; i <= 112 * aantalFrames; i += 112)
            {
                animatie.AddFrame(new AnimationFrame(new Rectangle(i, 0, 112, 133)));
            }
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(heroTexture, new Vector2(0, 0), animatie.currentFrame.SourceRectangle, Color.White);
        }

        public void Update()
        {
            animatie.Update();
        }
    }
}
