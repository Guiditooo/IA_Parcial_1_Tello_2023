using UnityEngine;
using IA.RESOURCES;

namespace IA.TIlES
{
    public enum TileType
    {
        //None = default,
        Grass,
        //Water,
        //Road
    }

    public class Tile
    {
        protected Vector2 gridPosition = Vector2.zero;
        protected TileType type = default;
        protected Resource resource = null;
        protected bool walkable = true;

        public Tile()
        {

        }
        public static Tile CreateTile(Vector2 pos, TileType tileType, Resource newResource = null)
        {
            Tile newTile = new Tile();
            
            switch (tileType)
            {
                case TileType.Grass:
                    newTile = new Grass(pos);
                    break;
                //case TileType.Water:
                //    break;
                //case TileType.Road:
                //    break;
                //case TileType.None:
                default:
                    break;
            }

            if(newResource!=null) newTile.SetResource(newResource);

            return newTile;
        }
        public TileType GetTileType() => type;
        public Vector2 GetGridPos() => gridPosition;

        public void SetResource(Resource newResource)
        {
            resource = newResource;
            walkable = false;
        }


    }
}