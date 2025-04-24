using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class LightImageNode : LightNode
    {
        private string _href;
        private IImageLoadingStrategy _loadingStrategy;
        private byte[] _imageData;
        private Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();

        public LightImageNode(string href, IImageLoadingStrategy loadingStrategy)
        {
            _href = href;
            _loadingStrategy = loadingStrategy;
            LoadImage();
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

        public override void AddEventListener(string eventType, Action handler)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<Action>();
            }
            _eventListeners[eventType].Add(handler);
        }

        private void LoadImage()
        {
            try
            {
                _imageData = _loadingStrategy.LoadImage(_href);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"IMG Upload Error: {ex.Message}");
                _imageData = Array.Empty<byte>();
            }
        }

        public override string OuterHTML
        {
            get
            {
                string base64Data = _imageData.Length > 0
                    ? Convert.ToBase64String(_imageData)
                    : string.Empty;

                return $"<img src=\"{_href}\" alt=\"IMG\" />";
            }
        }
        public string GetSourceInfo() => _href;

        public override string InnerHTML => string.Empty;

        public override int MemorySize => _imageData.Length + _href.Length * 2 + 32 + _eventListeners.Count * 16;
    }
}