using System;
using System.Collections.Generic;

namespace Jmelosegui.Mvc.Googlemap.Objects
{
    public class KmlLayerSerializer : LayerSerializer<KmlLayer>
    {
        public KmlLayerSerializer(KmlLayer layer) : base(layer)
        {
            
        }

        protected override IDictionary<string, object> LayerSerialize()
        {
            IDictionary<string, object> layerDictionary = new Dictionary<string, object>();
            FluentDictionary.For(layerDictionary)
                .Add("clickable", Layer.Clickable)
                .Add("preserveViewport", Layer.PreserveViewport)
                .Add("screenOverlays", Layer.ScreenOverlays)
                .Add("suppressInfoWindows", Layer.SuppressInfoWindows)
                .Add("url", Layer.Url);

            return layerDictionary;
        }
    }
}