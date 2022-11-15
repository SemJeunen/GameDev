using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Jeunen_Gamedevelopment.Animations
{
    internal class Animation
    {
        public AnimationFrame currentFrame { get; set; }

        private List<AnimationFrame> frames;
        private int counter;

        public Animation()
        {
            frames = new List<AnimationFrame>();
        }

        public void AddFrame(AnimationFrame animationFrame)
        {
            frames.Add(animationFrame);
            currentFrame = frames[0];
        }

        public void Update()
        {
            currentFrame = frames[counter];
            counter++;

            if (counter >= frames.Count)
                counter = 0;
        }
    }
}
