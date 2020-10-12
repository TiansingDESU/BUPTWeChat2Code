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
        public static string StuNo;
        public static string Name;
        public static string College;

        public override void OnInit()
        {
            base.OnInit();
        }

        public override void OnShow(System.Object Param)
        {
            base.OnShow(Param);
            isGoIn = true;
            m_Txt_switch_Txt.text = "IN";
            //read
            TS.log("Read");
            if (PlayerPrefs.HasKey("StuNo"))
                StuNo = PlayerPrefs.GetString("StuNo");
            if (PlayerPrefs.HasKey("Name"))
                Name = PlayerPrefs.GetString("Name");
            if (PlayerPrefs.HasKey("College"))
                College = PlayerPrefs.GetString("College");
            m_InputStuNo1_IptField.text = StuNo;
            m_InputName2_IptField.text = Name;
            m_InputCollege3_IptField.text = College;
        }

        private List<GameObject> gridItem;

        private List<GameObject> destroyList;

        public override void OnHide()
        {
            base.OnHide();
            StuNo = m_InputStuNo1_IptField.text;
            Name = m_InputName2_IptField.text;
            College = m_InputCollege3_IptField.text;
            //save
            TS.log("Save");
            PlayerPrefs.SetString("StuNo", StuNo);
            PlayerPrefs.SetString("Name", Name);
            PlayerPrefs.SetString("College", College);
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
