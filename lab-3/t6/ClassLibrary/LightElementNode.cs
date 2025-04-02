using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        private TagStyleFlyweight _tagStyle;
        private List<string> _cssClasses;
        private List<LightNode> _children;

        public LightElementNode(TagStyleFlyweight tagStyle)
        {
            _tagStyle = tagStyle;
            _cssClasses = new List<string>();
            _children = new List<LightNode>();
        }

        public LightElementNode AddChild(LightNode child)
        {
            _children.Add(child);
            return this;
        }

        public LightElementNode AddCssClass(string cssClass)
        {
            _cssClasses.Add(cssClass);
            return this;
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{_tagStyle.TagName}");

                if (_cssClasses.Count > 0)
                {
                    sb.Append($" class=\"{string.Join(" ", _cssClasses)}\"");
                }

                if (_tagStyle.ClosingType == "single")
                {
                    sb.Append(" />");
                }
                else
                {
                    sb.Append(">");
                    sb.Append(InnerHTML);
                    sb.Append($"</{_tagStyle.TagName}>");
                }

                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in _children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }

        public override int MemorySize
        {
            get
            {
                int size = 0;
                size += _cssClasses.Capacity * 8;
                foreach (var cls in _cssClasses)
                {
                    size += cls.Length * 2;
                }
                size += _children.Capacity * 8; 
                foreach (var child in _children)
                {
                    size += child.MemorySize;
                }
                return size;
            }
        }
    }
}