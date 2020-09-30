using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    class Menu_UILogic : Menu_UIBase
    {
        List<string> ChatName;
        public override void OnShow(object param)
        {
            base.OnShow(param);
            TSTime.TimeChangeBySeconds += OnChangeTime;
            ChatName = new List<string>();
            ChatName.Add("switch通关关关关关");
            ChatName.Add("马宗");
            ChatName.Add("礼品卡出售群");
            ChatName.Add("周大佬");
            ChatName.Add("酷儿");
            ChatName.Add("吃了一鲸");
            ChatName.Add("电管9班王娇");
            ChatName.Add("蜀黍の•ェ");
            ChatName.Add("金工实验室");
            ChatName.Add("2019届老司机");
            ChatName.Add("李旦");

            m_plusPanel_Img.gameObject.SetActive(false);
           UpdateChatContent();
        }

        public override void OnHide()
        {
            base.OnHide();
            TSTime.TimeChangeBySeconds -= OnChangeTime;
        }

        private void UpdateChatContent()
        {
            for(int i = 0; i < 30; i++)
            {
                UIHelper.AddTemplateChild(m_grid_Trans.gameObject, (go)=> {
                    Image headImg = go.transform.Find("Img_head").GetComponent<Image>();
                    Text chatTxt = go.transform.Find("Txt_title").GetComponent<Text>();
                    int headNo = (i % 12) + 1;
                    UIHelper.SetSprite(headImg, "Sprite/" + headNo);
                    chatTxt.text = ChatName[i % ChatName.Count];
                });
            }
        }

        private void OnChangeTime(DateTime dateTime)
        {
            m_Txt_time_Txt.text = dateTime.GetDateTimeFormats('t')[0].ToString();
        }

        public override void OnInit()
        {
            base.OnInit();
            UIHelper.AddClickCallBack(m_Img_plusBtn_Img.gameObject, OnClickPlusBtn);
            UIHelper.AddClickCallBack(m_Img_scan_Img.gameObject, OnClickScanBtn);
        }

        private void OnClickPlusBtn()
        {
            m_plusPanel_Img.gameObject.SetActive(!m_plusPanel_Img.gameObject.activeSelf);
        }

        private void OnClickScanBtn()
        {
            UIManager.HideUI(Def.UIDef.UI_Menu);
            UIManager.ShowUI(Def.UIDef.UI_Scan);
        }

        
    }
}
