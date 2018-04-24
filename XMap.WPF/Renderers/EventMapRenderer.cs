using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsMaps = Microsoft.Maps.MapControl.WPF;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.WPF;
using Xamarin.Forms.Platform.WPF;
using XMap.Components;

[assembly: ExportRenderer(typeof(EventMap), typeof(XMap.WPF.Renderers.EventMapRenderer))]
namespace XMap.WPF.Renderers
{
    public class EventMapRenderer : MapRenderer
    {
        private EventMap _eventMap;
        private MsMaps.Map _nativeMap;

        protected override void OnElementChanged(
            ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                _nativeMap.MouseDoubleClick -= OnDoubleClick;
                _nativeMap = null;
            }

            if (e.NewElement != null)
            {

                _eventMap = e.NewElement as EventMap;

                var c = Control as MsMaps.Map;
                _nativeMap = c;

                if (_nativeMap != null)
                {
                    _nativeMap.MouseDoubleClick += OnDoubleClick;
                }
            }
        }

        private void OnDoubleClick(
            object sender,
            System.Windows.Input.MouseButtonEventArgs e)
        {
            var viewportPos = e.GetPosition(_nativeMap);
            var pos = new MsMaps.Location();
            var ok = _nativeMap.TryViewportPointToLocation(
                viewportPos,
                out pos);

            if (ok)
            {
                _eventMap?.FireDoubleClick(
                    new Xamarin.Forms.Maps.Position(
                        pos.Latitude,
                        pos.Longitude));
                e.Handled = true;
            }
        }
    }
}
