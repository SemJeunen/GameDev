using Microsoft.Xna.Framework;
using Sem_Jeunen_Gamedevelopment.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Jeunen_Gamedevelopment
{
    internal interface IMoveable
    {
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public IInputReader InputReader { get; set; }

    }
}
