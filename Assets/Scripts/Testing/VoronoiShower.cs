using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace IA.VORONOI
{
    public class VoronoiShower : MonoBehaviour
    {
       private List<VoronoiNode> hotSpotList = new List<VoronoiNode>();

        Voronoi voronoiDiagram = null;

        private void Start()
        {
            foreach (Vector2 pos in PointRandomizer.GetPoints())
            {
                hotSpotList.Add(new VoronoiNode(VoronoiNodeType.Normal, pos));
            }
            voronoiDiagram = new Voronoi(hotSpotList);
        }

    }
}
