using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Jeunen_Gamedevelopment.Animations
{
    internal class AnimationFrame
    {
        public AnimationFrame(Rectangle rectangle)
        {
            SourceRectangle = rectangle;
        }

        public Rectangle SourceRectangle { get; set; }
    }
}
