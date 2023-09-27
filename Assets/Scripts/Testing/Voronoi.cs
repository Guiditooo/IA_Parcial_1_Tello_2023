using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace IA.VORONOI
{
    public class Voronoi 
    {
        List<VoronoiNode> hotSpotList = new List<VoronoiNode>();
        public Voronoi(List<VoronoiNode> newPointsList)
        {
            hotSpotList = newPointsList;
            //
        }
    }
}
