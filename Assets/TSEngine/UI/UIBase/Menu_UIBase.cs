using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{

	public class Menu_UIBase : UIBase
	{
		protected Image m_ImgBG_Img;
		protected Transform m_grid_Trans;
		protected Image m_searchImg_Img;
		protected Text m_Txt_msgCount_Txt;
		protected Text m_Txt_time_Txt;
		protected Image m_Img_plusBtn_Img;
		protected Image m_plusPanel_Img;
		protected Image m_Img_scan_Img;

		private void Start()
		{
			this.m_ImgBG_Img = this.transform.Find("e_ImgBG").GetComponent<Image>();
			this.m_grid_Trans = this.transform.Find("Scroll/e_grid").GetComponent<Transform>();
			this.m_searchImg_Img = this.transform.Find("Scroll/e_grid/e_searchImg").GetComponent<Image>();
			this.m_Txt_msgCount_Txt = this.transform.Find("Head/e_Txt_msgCount").GetComponent<Text>();
			this.m_Txt_time_Txt = this.transform.Find("Head/e_Txt_time").GetComponent<Text>();
			this.m_Img_plusBtn_Img = this.transform.Find("Head/Image/e_Img_plusBtn").GetComponent<Image>();
			this.m_plusPanel_Img = this.transform.Find("Head/Image/e_Img_plusBtn/e_plusPanel").GetComponent<Image>();
			this.m_Img_scan_Img = this.transform.Find("Head/Image/e_Img_plusBtn/e_plusPanel/e_Img_scan").GetComponent<Image>();

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