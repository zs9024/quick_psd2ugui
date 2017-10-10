using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Quick.UI
{
    [AddComponentMenu("UI/Page")]
    [System.Serializable]
    public class Page : UIBehaviour
    {
        // 摘要: 
        //     Is the Page on.
        private bool isOn;
        public bool IsOn
        {      
            get{return isOn;}
            set
            {
                isOn = value;
                gameObject.SetActive(isOn);
            }           
        }
    }
}