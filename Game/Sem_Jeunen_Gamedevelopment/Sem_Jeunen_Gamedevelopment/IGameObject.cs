﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sem_Jeunen_Gamedevelopment
{
    internal interface IGameObject
    {
        void Update(GameTime gametime);

        void Draw(SpriteBatch _spriteBatch);
    }
}
