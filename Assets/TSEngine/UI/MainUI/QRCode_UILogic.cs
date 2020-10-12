﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class QRCode_UILogic : QRCode_UIBase
    {
        public override void OnInit()
        {
            base.OnInit();
            UIHelper.AddClickCallBack(m_Img_back_Img.gameObject, delegate
            {
                UIManager.HideUI(Def.UIDef.UI_QRCode);
                UIManager.ShowUI(Def.UIDef.UI_Menu);
            });
        }

        public override void OnShow(object param)
        {
            base.OnShow(param);
            TSTime.TimeChangeBySeconds += OnChangeTime;

            m_Txt_opTime_Txt.text = TSTime.CurTime.ToString("yyyy-MM-dd HH:mm:ss");

            bool isGoIn = Main_UILogic.isGoIn;
            m_Txt_status_Txt.text = isGoIn ? "允许入校" : "允许出校" ;
            if (String.IsNullOrEmpty(Main_UILogic.College))
                m_Txt_college_Txt.text = Main_UILogic.College;
            if (String.IsNullOrEmpty(Main_UILogic.Name))
                m_Txt_name_Txt.text = Main_UILogic.Name;
            if (String.IsNullOrEmpty(Main_UILogic.StuNo))
                m_Txt_stuNo_Txt.text = Main_UILogic.StuNo;
        }

        public override void OnHide()
        {
            base.OnHide();
            TSTime.TimeChangeBySeconds -= OnChangeTime;
        }

        private void OnChangeTime(DateTime dateTime)
        {
            m_Txt_time_Txt.text = dateTime.GetDateTimeFormats('t')[0].ToString();
        }
    }
}
