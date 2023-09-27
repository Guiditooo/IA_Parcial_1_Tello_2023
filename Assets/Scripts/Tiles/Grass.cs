using UnityEngine;

namespace IA.TIlES
{
    public class Grass : Tile
    {
        public Grass(Vector2 pos)
        {
            gridPosition = pos;
            walkable = true;
        }

    }
}
