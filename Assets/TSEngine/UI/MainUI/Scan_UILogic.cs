using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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

        Action ScanSuccess;

        WebCamTexture webCamTexture;

        bool isCameraOpen = false;

        Action CameraOpenAct;

        public override void OnShow(object param)
        {
            base.OnShow(param);
            ScanSuccess = OnScanSuccess;
            m_CameraImg_RImg.color = Color.grey;
            isCameraOpen = false;
            UIHelper.RemoveAllClick(m_CameraImg_RImg.gameObject);

           StartCoroutine(CallWebCam());

            CameraOpenAct = delegate
            {
                if (!isCameraOpen)
                    OpenCamera();
                else
                    CameraOpenAct = null;
            };
            TimeDelay.SetTimeInterval(CameraOpenAct, 0.5f);
        }

        IEnumerator CallWebCam()
        {
            //请求使用权限，并等待
            yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);

            //如果有权限就打开
            if (Application.HasUserAuthorization(UserAuthorization.WebCam) && WebCamTexture.devices.Length > 0)
            {
                OpenCamera();
            }
        }

        private void OpenCamera()
        {
            if (isCameraOpen)
            {
                return;
            }
            if (Application.HasUserAuthorization(UserAuthorization.WebCam) && WebCamTexture.devices.Length > 0)
            {
                isCameraOpen = true;
                WebCamDevice[] devices = WebCamTexture.devices;
                //if (devices == null || devices.Length <= 0)
                //{
                //    TS.error("无法获得此设备的摄像机");
                //    OnClickBackBtn();
                //    yield break;
                //}
                webCamTexture = new WebCamTexture(WebCamTexture.devices[0].name, Screen.width, Screen.height, 60);
                webCamTexture.deviceName = devices[0].name;
                m_CameraImg_RImg.texture = webCamTexture;
                m_CameraImg_RImg.color = Color.white;
                webCamTexture.Play();
               // m_CameraImg_RImg.rectTransform.localEulerAngles = new Vector3(0, 0, -webCamTexture.videoRotationAngle);

                UIHelper.AddClickCallBack(m_CameraImg_RImg.gameObject, delegate
                {
                    ScanSuccess();
                });
                //TimeDelay.SetTimeout(ScanSuccess, 6f);
            }
        }

        public override void OnHide()
        {
            base.OnHide();
            ScanSuccess = null;
            webCamTexture.Stop();
        }

        public void OnScanSuccess()
        {
            UIManager.HideUI(Def.UIDef.UI_Scan);
            UIManager.ShowUI(Def.UIDef.UI_QRCode);
        }
    }
}
