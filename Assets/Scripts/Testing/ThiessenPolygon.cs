using System.Collections.Generic;
using UnityEngine;

namespace IA.VORONOI
{
    public class ThiessenPolygon 
    {
        private List<Line> polygonLineList = new List<Line>();
        public List<Line> GetLines() => polygonLineList;
        public void AddLine(Line line)
        {
            polygonLineList.Add(line);
        }
    }
}
