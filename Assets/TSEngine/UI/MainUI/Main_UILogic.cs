using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets
{
    class Main_UILogic : Main_UIBase
    {

        public static bool isGoIn = true;

        public override void OnInit()
        {
            base.OnInit();
        }

        public override void OnShow(System.Object Param)
        {
            base.OnShow(Param);
            isGoIn = true;
            m_Txt_switch_Txt.text = "IN";
        }

        private List<GameObject> gridItem;

        private List<GameObject> destroyList;

        public override void OnHide()
        {
            base.OnHide();
        }

        public override void OnButtonClicked(GameObject go)
        {
            UIAudio.PlayUISound?.Invoke();
            if (go == this.m_Btn_exit_Btn.gameObject)
            {
                Application.Quit();
            }
            else if (go == this.m_Btn_new_Btn.gameObject)
            {
                UIManager.HideUI(Def.UIDef.UI_Main);
                UIManager.ShowUI(Def.UIDef.UI_Loading);
            }
            else if(go== this.m_Btn_load_Btn.gameObject)
            {
                isGoIn = !isGoIn;
                if (isGoIn)
                {
                    m_Txt_switch_Txt.text = "IN";
                }
                else
                {
                    m_Txt_switch_Txt.text = "OUT";
                }
            }
        }
    }
}
