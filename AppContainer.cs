using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador819
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new FrmMain
                {
                    Text = "Nueva Pestaña"
                }
            };
        }
    }
}
