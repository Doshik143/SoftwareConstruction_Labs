using System.Collections.Generic;

namespace ClassLibrary
{
    public class TagStyleFlyweight
    {
        private static Dictionary<string, TagStyleFlyweight> _sharedStyles = new Dictionary<string, TagStyleFlyweight>();

        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }

        private TagStyleFlyweight(string tagName, string displayType, string closingType)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
        }

        public static TagStyleFlyweight GetStyle(string tagName, string displayType, string closingType)
        {
            string key = $"{tagName}_{displayType}_{closingType}";
            if (!_sharedStyles.ContainsKey(key))
            {
                _sharedStyles[key] = new TagStyleFlyweight(tagName, displayType, closingType);
            }
            return _sharedStyles[key];
        }

        public static int GetSharedStylesCount()
        {
            return _sharedStyles.Count;
        }
    }
}