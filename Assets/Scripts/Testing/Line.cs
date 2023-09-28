using UnityEngine;

namespace IA
{
    public struct Line 
    {
        public Vector2 A;
        public Vector2 B;
        public void ShowLine()
        {
            Gizmos.DrawLine(A, B);
        }
    }
}
