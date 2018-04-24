using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace XMap.Components
{
    public class EventMapClickedEvent: EventArgs
    {
        public Position Position { get; set; }
    }
}
