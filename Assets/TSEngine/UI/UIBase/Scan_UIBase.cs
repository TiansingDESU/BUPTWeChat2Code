using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{

	public class Scan_UIBase : UIBase
	{
		protected RawImage m_CameraImg_RImg;
		protected Image m_Img_back_Img;

		private void Start()
		{
			this.m_CameraImg_RImg = this.transform.Find("e_CameraImg").GetComponent<RawImage>();
			this.m_Img_back_Img = this.transform.Find("CameraUpPanel/e_Img_back").GetComponent<Image>();

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