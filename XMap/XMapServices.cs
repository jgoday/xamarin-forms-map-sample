using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMap
{
    public static class XMapServices
    {
        public static void Init()
        {
            Xamarin.Forms.DependencyService.Register<Services.CadastralService>();
        }
    }
}
