using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{

	public class Main_UIBase : UIBase
	{
		protected Transform m_grid_Trans;
		protected Image m_InputStuNo_Img;
		protected InputField m_InputStuNo1_IptField;
		protected Image m_InputName_Img;
		protected InputField m_InputName2_IptField;
		protected Image m_InputCollege_Img;
		protected InputField m_InputCollege3_IptField;
		protected Button m_Btn_new_Btn;
		protected Button m_Btn_load_Btn;
		protected Text m_Txt_switch_Txt;
		protected Button m_Btn_exit_Btn;

		private void Start()
		{
			this.m_grid_Trans = this.transform.Find("LeftPanel/ScrollView/Viewport/e_grid").GetComponent<Transform>();
			this.m_InputStuNo_Img = this.transform.Find("LeftPanel/e_InputStuNo").GetComponent<Image>();
			this.m_InputStuNo1_IptField = this.transform.Find("LeftPanel/e_InputStuNo").GetComponent<InputField>();
			this.m_InputName_Img = this.transform.Find("LeftPanel/e_InputName").GetComponent<Image>();
			this.m_InputName2_IptField = this.transform.Find("LeftPanel/e_InputName").GetComponent<InputField>();
			this.m_InputCollege_Img = this.transform.Find("LeftPanel/e_InputCollege").GetComponent<Image>();
			this.m_InputCollege3_IptField = this.transform.Find("LeftPanel/e_InputCollege").GetComponent<InputField>();
			this.m_Btn_new_Btn = this.transform.Find("RightPanel/e_Btn_new").GetComponent<Button>();
			this.m_Btn_load_Btn = this.transform.Find("RightPanel/e_Btn_load").GetComponent<Button>();
			this.m_Txt_switch_Txt = this.transform.Find("RightPanel/e_Btn_load/e_Txt_switch").GetComponent<Text>();
			this.m_Btn_exit_Btn = this.transform.Find("RightPanel/e_Btn_exit").GetComponent<Button>();

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
			this.m_InputStuNo1_IptField.onValueChanged.AddListener(this.Onm_InputStuNo1_IptFieldValueChanged);
			this.m_InputName2_IptField.onValueChanged.AddListener(this.Onm_InputName2_IptFieldValueChanged);
			this.m_InputCollege3_IptField.onValueChanged.AddListener(this.Onm_InputCollege3_IptFieldValueChanged);
			this.m_Btn_new_Btn.onClick.AddListener(this.Onm_Btn_new_BtnClicked);
			this.m_Btn_load_Btn.onClick.AddListener(this.Onm_Btn_load_BtnClicked);
			this.m_Btn_exit_Btn.onClick.AddListener(this.Onm_Btn_exit_BtnClicked);

		}

		private void Onm_InputStuNo1_IptFieldValueChanged(string arg)
		{

		}

		private void Onm_InputName2_IptFieldValueChanged(string arg)
		{

		}

		private void Onm_InputCollege3_IptFieldValueChanged(string arg)
		{

		}

		private void Onm_Btn_new_BtnClicked()
		{
			OnButtonClicked(m_Btn_new_Btn.gameObject);
		}

		private void Onm_Btn_load_BtnClicked()
		{
			OnButtonClicked(m_Btn_load_Btn.gameObject);
		}

		private void Onm_Btn_exit_BtnClicked()
		{
			OnButtonClicked(m_Btn_exit_Btn.gameObject);
		}

	}
}