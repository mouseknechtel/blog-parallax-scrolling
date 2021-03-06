﻿namespace ParallaxScrolling
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public struct Sprite
    {
        public Texture2D Texture;
        
        public Vector2 Position;

        public void Draw(SpriteBatch spriteBatch)
        {
            if(Texture != null)
                spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
