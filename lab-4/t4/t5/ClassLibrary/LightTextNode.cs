using System;

namespace ClassLibrary
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string OuterHTML => _text;
        public override string InnerHTML => _text;
        public override void AddEventListener(string eventType, Action handler)
        {
            //TextNodeDoesn`tSupportEvents
        }

        public override void TriggerEvent(string eventType)
        {
            //TextNodeDoesn`tSupportEvents
        }
    }
}