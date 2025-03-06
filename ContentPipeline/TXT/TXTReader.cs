using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCreatorLib.ContentPipeline.TXT
{
    public class TXTReader : ContentTypeReader<TXTAsset>
    {
        protected override TXTAsset Read(ContentReader input, TXTAsset existingInstance)
        {
            string Name = input.ReadString();
            string Content = input.ReadString();

            TXTAsset asset = new TXTAsset(Name, Content);

            return asset;
        }
    }
}
