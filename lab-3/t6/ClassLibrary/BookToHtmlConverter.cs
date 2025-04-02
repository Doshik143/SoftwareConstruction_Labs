namespace ClassLibrary
{
    public class BookToHtmlConverter
    {
        public static LightNode ConvertTextToHtml(string[] lines)
        {
            var root = new LightElementNode(TagStyleFlyweight.GetStyle("div", "block", "double"));
            bool isFirstNonEmptyLine = true;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                LightElementNode element;
                string trimmedLine = line.Trim();

                if (isFirstNonEmptyLine)
                {
                    element = new LightElementNode(TagStyleFlyweight.GetStyle("h1", "block", "double"));
                    isFirstNonEmptyLine = false;
                }
                else if (trimmedLine.Length < 20)
                {
                    element = new LightElementNode(TagStyleFlyweight.GetStyle("h2", "block", "double"));
                }
                else if (line.StartsWith(" ") || line.StartsWith("\t"))
                {
                    element = new LightElementNode(TagStyleFlyweight.GetStyle("blockquote", "block", "double"));
                }
                else
                {
                    element = new LightElementNode(TagStyleFlyweight.GetStyle("p", "block", "double"));
                }

                element.AddChild(new LightTextNode(trimmedLine));
                root.AddChild(element);
            }

            return root;
        }
    }
}