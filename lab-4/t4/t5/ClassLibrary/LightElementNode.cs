using System;
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
        private Dictionary<string, List<Action>> _eventListeners;

        public LightElementNode(string tagName, string displayType, string closingType)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = new List<string>();
            _children = new List<LightNode>();
            _eventListeners = new Dictionary<string, List<Action>>();
        }

        public override int MemorySize
        {
            get
            {
                int size = 0;
                size += _tagName.Length * 2 + _displayType.Length * 2 + _closingType.Length * 2;
                size += _cssClasses.Capacity * 8;
                foreach (var cls in _cssClasses) size += cls.Length * 2;
                size += _children.Capacity * 8;
                foreach (var child in _children) size += child.MemorySize;
                size += _eventListeners.Count * 16;
                return size;
            }
        }

        public override void AddEventListener(string eventType, Action handler)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<Action>();
            }
            _eventListeners[eventType].Add(handler);
        }

        public override void TriggerEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                foreach (var handler in _eventListeners[eventType])
                {
                    handler.Invoke();
                }
            }
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

                if (_eventListeners.Count > 0)
                {
                    sb.Append(" data-events=\"");
                    foreach (var eventType in _eventListeners.Keys)
                    {
                        sb.Append($"{eventType} ");
                    }
                    sb.Append("\"");
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