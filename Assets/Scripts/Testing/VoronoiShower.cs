using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace IA.VORONOI
{
    public class VoronoiShower : MonoBehaviour
    {
        [SerializeField] private List<VoronoiNode> hotSpotList = new List<VoronoiNode>();

        Voronoi voronoiDiagram = null;

        private void Awake()
        {
            voronoiDiagram = new Voronoi(hotSpotList);
        }

    }
}
