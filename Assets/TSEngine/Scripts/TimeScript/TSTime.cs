using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class TSTime : MonoBehaviour
    {
        public static TSTime inst;

        private void Awake()
        {
            inst = this;
        }

        public static DateTime CurTime;

        public static Action<DateTime> TimeChangeBySeconds;

        private void Start()
        {
            TimeDelay.SetTimeInterval(delegate
            {
                DateTime NowTime = DateTime.Now.ToLocalTime();
                CurTime = NowTime;
                TimeChangeBySeconds?.Invoke(NowTime);
            }, 1f, false);
        }

        
    }
}
