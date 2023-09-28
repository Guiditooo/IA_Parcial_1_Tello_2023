using UnityEngine;

namespace IA.VORONOI
{
    public enum VoronoiNodeType
    {
        Light = 1,
        Normal = 5,
        Heavy = 10,
        Impossible = int.MaxValue
    }
    public class VoronoiNode 
    {
        public Vector2 Pos { get; private set; }
        public int Weight { get; private set; }

        private ThiessenPolygon poly = new ThiessenPolygon();
        public VoronoiNode(VoronoiNodeType type, Vector2 position)
        {
            Pos = position;
            Weight = (int)type;
        }
    }
}
