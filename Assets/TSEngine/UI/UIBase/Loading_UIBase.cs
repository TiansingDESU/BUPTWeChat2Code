using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{

	public class Loading_UIBase : UIBase
	{

		private void Start()
		{

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
