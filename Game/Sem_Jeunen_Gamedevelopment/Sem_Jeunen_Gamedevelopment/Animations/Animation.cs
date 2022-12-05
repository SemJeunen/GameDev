﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

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


        private double secondCounter = 0;
        public void Update(GameTime gametime)
        {
            

            currentFrame = frames[counter];

            secondCounter += gametime.ElapsedGameTime.TotalSeconds;
            int fps = 48;

            if(secondCounter >= 1d/ fps)
            {
                counter++;
                secondCounter = 0;
            }
            

            if (counter >= frames.Count)
                counter = 0;
        }

        public void GetFramesFromTextureProperties(int width, int height, int numberOfWitdhSprites, int numberOfHeightSprites)
        {
            int widthOfFrame = width / numberOfWitdhSprites;
            int heightOfFrame = height / numberOfHeightSprites;

            for (int y = 0; y <= height - heightOfFrame; y += heightOfFrame)
            {
                for (int x = 0; x <= width - widthOfFrame; x += widthOfFrame)
                {
                    frames.Add(new AnimationFrame(new Rectangle(x, y, widthOfFrame, heightOfFrame)));
                }
            }
        }
    }
}
