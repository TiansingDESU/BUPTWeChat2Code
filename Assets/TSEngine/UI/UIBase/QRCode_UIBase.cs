using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{

	public class QRCode_UIBase : UIBase
	{
		protected Text m_Txt_name_Txt;
		protected Text m_Txt_college_Txt;
		protected Text m_Txt_status_Txt;
		protected Text m_Txt_stuNo_Txt;
		protected Text m_Txt_opTime_Txt;
		protected Text m_Txt_time_Txt;
		protected Image m_Img_back_Img;
		protected Image m_Img_more_Img;

		private void Start()
		{
			this.m_Txt_name_Txt = this.transform.Find("Scroll/grid/NamePanel/e_Txt_name").GetComponent<Text>();
			this.m_Txt_college_Txt = this.transform.Find("Scroll/grid/CollegePanel/e_Txt_college").GetComponent<Text>();
			this.m_Txt_status_Txt = this.transform.Find("Scroll/grid/StatusPanel/e_Txt_status").GetComponent<Text>();
			this.m_Txt_stuNo_Txt = this.transform.Find("Scroll/grid/StuNoPanel/e_Txt_stuNo").GetComponent<Text>();
			this.m_Txt_opTime_Txt = this.transform.Find("Scroll/grid/TimePanel/e_Txt_opTime").GetComponent<Text>();
			this.m_Txt_time_Txt = this.transform.Find("TitlePanel/e_Txt_time").GetComponent<Text>();
			this.m_Img_back_Img = this.transform.Find("TitlePanel/e_Img_back").GetComponent<Image>();
			this.m_Img_more_Img = this.transform.Find("BottomPanel/e_Img_more").GetComponent<Image>();

			this.AddEventListener();
		}
		public override void OnInit()
		{
			base.OnInit();
		}

		public override void OnShow(System.Object param)
		{
			base.OnShow(param);
		}

		public override void OnHide()
		{
			base.OnHide();
		}

		public virtual void OnButtonClicked(GameObject go)
		{

		}
		private void AddEventListener()
		{

		}

	}
}