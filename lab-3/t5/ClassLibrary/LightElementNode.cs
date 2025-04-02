using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private string _displayType; // "block"|"inline"
        private string _closingType; // "single"|"double"
        private List<string> _cssClasses;
        private List<LightNode> _children;

        public LightElementNode(string tagName, string displayType, string closingType)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
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
                sb.Append($"<{_tagName}");

                if (_cssClasses.Count > 0)
                {
                    sb.Append($" class=\"{string.Join(" ", _cssClasses)}\"");
                }

                if (_closingType == "single")
                {
                    sb.Append(" />");
                }
                else
                {
                    sb.Append(">");
                    sb.Append(InnerHTML);
                    sb.Append($"</{_tagName}>");
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
    }
}