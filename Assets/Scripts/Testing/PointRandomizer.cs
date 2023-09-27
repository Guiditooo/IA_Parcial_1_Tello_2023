using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace IA
{
    public class PointRandomizer : MonoBehaviour
    {
        [SerializeField] private int pointCount;
        [SerializeField] private int maxAttempts = 100;
        [SerializeField] private Vector2[] bounds = new Vector2[2];
        [SerializeField] private float minimumNeighborDistance = 0.5f;

        private List<Vector2> pointPosList = new List<Vector2>();

        Vector3[] points;

        private void Start()
        {
            points = new Vector3[8]
            {
                new Vector3(bounds[0].x, bounds[0].y, 0),
                new Vector3(bounds[0].x, bounds[1].y, 0),
                new Vector3(bounds[0].x, bounds[0].y, 0),
                new Vector3(bounds[1].x, bounds[0].y, 0),

                new Vector3(bounds[1].x, bounds[1].y, 0),
                new Vector3(bounds[1].x, bounds[0].y, 0),
                new Vector3(bounds[1].x, bounds[1].y, 0),
                new Vector3(bounds[0].x, bounds[1].y, 0)
            };
            RandomizePointsPos();
        }
        public void RandomizePointsPos()
        {
            pointPosList.Clear();
            for (int i = 0; i < pointCount; i++)
            {
                Vector2 point;
                int attempts = 0;

                do
                {
                    float x = Random.Range(bounds[0].x, bounds[1].x);
                    float y = Random.Range(bounds[0].y, bounds[1].y);
                    point = new Vector2(x, y);
                    attempts++;
                } while (!IsNearNeighbors(point) && attempts < maxAttempts);
                if (attempts < maxAttempts)
                {
                    pointPosList.Add(point);
                }
                else
                {
                    return;
                    Debug.LogWarning("Me pase de rosca");
                }
            }
        }
        private bool IsNearNeighbors(Vector3 point)
        {
            foreach (Vector3 puntoGenerado in pointPosList)
            {
                if (Vector3.Distance(point, puntoGenerado) < minimumNeighborDistance)
                {
                    return false;
                }
            }

            return true;
        }
        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLineList(points);
            foreach (Vector3 p in pointPosList)
            {
                Gizmos.DrawSphere(p, 0.07f);
            }
        }
        public List<Vector2> GetPoints() => pointPosList;

    }
}
