using UnityEngine;

namespace IA.RESOURCES
{
    public enum ResourceType
    {
        Gold,
        None
    }
    public class Resource
    {
        public static Resource CreateResource(ResourceType resourceType)
        {
            Resource res = new Resource();

            switch (resourceType)
            {
                case ResourceType.Gold:
                    res = new Gold();
                    break;
                case ResourceType.None:
                    break;
                default:
                    break;
            }

            return res;
        }
        protected System.Action OnDraw;
    }
}
