using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Scan_UILogic : Scan_UIBase
    {
        public override void OnInit()
        {
            base.OnInit();
            UIHelper.AddClickCallBack(m_Img_back_Img.gameObject, delegate { OnClickBackBtn(); }) ;
        }

        private void OnClickBackBtn()
        {
            UIManager.HideUI(Def.UIDef.UI_Scan);
            UIManager.ShowUI(Def.UIDef.UI_Menu);
        }
    }
}
