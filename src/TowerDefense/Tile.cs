using SFML.Graphics;
using SFML.System;

namespace TowerDefense
{
    public class Tile : Transformable, Drawable
    {
        public const int TILE_SIZE = 60;

        public Shape Shape { get; init; }

        public Tile()
        {
            Shape = new RectangleShape(new Vector2f(TILE_SIZE, TILE_SIZE));
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(Shape, states);
        }
    }
}
