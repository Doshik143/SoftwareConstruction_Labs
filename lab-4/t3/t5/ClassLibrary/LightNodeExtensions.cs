using System.Collections.Generic;

namespace ClassLibrary
{
    public static class LightNodeExtensions
    {
        public static IEnumerable<LightNode> GetChildren(this LightElementNode node)
        {
            //ToSimplifyDemonstration
            var field = typeof(LightElementNode).GetField("_children",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            return (List<LightNode>)field.GetValue(node);
        }
    }
}