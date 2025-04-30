using System;

namespace ClassLibrary
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public abstract void AddEventListener(string eventType, Action handler);
        public abstract void TriggerEvent(string eventType);
        public abstract int MemorySize { get; }
    }
}