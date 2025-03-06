using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCreatorLib.ContentPipeline.TXT
{
    public class TXTAsset
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public TXTAsset()
        {
            Name = string.Empty;
            Content = string.Empty;
        }
        public TXTAsset(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
