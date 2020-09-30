using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Loading_UILogic : Loading_UIBase
    {
        public override void OnShow(object param)
        {
            base.OnShow(param);
            TimeDelay.SetTimeout(delegate
            {
                UIManager.HideUI(Def.UIDef.UI_Loading);
                UIManager.ShowUI(Def.UIDef.UI_Menu);
            }, 3f);
        }
    }
}
