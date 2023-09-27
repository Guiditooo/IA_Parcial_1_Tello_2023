using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using IA.TIlES;
using IA.RESOURCES;

namespace IA.STRUCTURE
{
    public class MapController : MonoBehaviour
    {
        private List<Tile> tileList = new List<Tile>();
        [SerializeField] private int gridWitdh = 10;
        [SerializeField] private int gridHeight = 10;
        [SerializeField] private List<Vector2> minePos = null;
        [SerializeField] private bool IgnoreTCPos = false;
        [SerializeField] private Vector2 TCPos = default;
        private void Awake()
        {
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWitdh; j++)
                {
                    tileList.Add(Tile.CreateTile(new Vector2(i, j), TileType.Grass));
                }
            }
            tileList[4].SetResource(Resource.CreateResource(ResourceType.Gold));
            Debug.Log("Hay "+tileList.Count+" tiles en total :)");
        }
    }
}