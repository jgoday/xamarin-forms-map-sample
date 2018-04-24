using System;
using Xamarin.Forms.Maps;

namespace XMap.Components
{
    public class EventMap: Map
    {
        public event EventHandler<EventMapClickedEvent> DoubleClick;

        public void FireDoubleClick(Position pos)
        {
            DoubleClick?.Invoke(this, new EventMapClickedEvent
            {
                Position = pos
            });
        }
    }
}
