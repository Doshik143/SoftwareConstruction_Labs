using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        private string _displayType; // "block"|"inline"
        private string _closingType; // "single"|"double"
        private List<string> _cssClasses;
        private List<LightNode> _children;

        public int ChildCount => _children.Count;
        public LightNode GetChild(int index) => _children[index];

        public LightElementNode(string tagName, string displayType, string closingType)
        : base(tagName)
        {
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = new List<string>();
            _children = new List<LightNode>();
        }

        public LightElementNode AddChild(LightNode child)
        {
            _children.Add(child);
            if (this is LifecycleElement lifecycleParent && child is LifecycleElement lifecycleChild)
            {
                lifecycleChild.OnInserted();
            }
            return this;
        }

        public LightElementNode AddCssClass(string cssClass)
        {
            _cssClasses.Add(cssClass);
            return this;
        }

        protected virtual void OnRender()
        {
            Console.WriteLine($"Рендеринг елемента <{TagName}>");
        }

        public override string OuterHTML
        {
            get
            {
                OnRender();

                StringBuilder sb = new StringBuilder();
                sb.Append($"<{TagName}");

                if (_cssClasses.Count > 0)
                {
                    var allClasses = new List<string>(_cssClasses);
                    sb.Append($" class=\"{string.Join(" ", allClasses)}\"");
                }

                if (_closingType == "single")
                {
                    sb.Append(" />");
                }
                else
                {
                    sb.Append(">");
                    sb.Append(InnerHTML);
                    sb.Append($"</{TagName}>");
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