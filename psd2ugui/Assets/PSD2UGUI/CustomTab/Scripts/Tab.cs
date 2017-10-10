using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Quick.UI
{
    /// <summary>
    /// A new component for switch page/sheet on or off comfortably
    /// </summary>
    [AddComponentMenu("UI/Tab")]
    [System.Serializable]
    public class Tab : Toggle
    {
        // 摘要: 
        //     The page this tab controls
        [SerializeField]
        private Page m_Page;
        public Page page { get { return m_Page; } set { m_Page = value; } }

        // 摘要: 
        //     The tag of tab
        [SerializeField]
        private string m_Tag;
        public string tag { get { return m_Tag; } set { m_Tag = value; } }

        public TabGroup tabGroup { get; set; }

        public delegate void PointerTabFunc(Tab target, PointerEventData eventData);
        public event PointerTabFunc onTabClick;

        protected override void Start()
        {
            base.Start();
            onValueChanged.AddListener(OnValueChanged);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            
            if(group != null)
            {
                tabGroup = group as TabGroup;
                tabGroup.RegisterTab(this,false);
            }
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            onValueChanged.RemoveListener(OnValueChanged);

            if(tabGroup != null)
            {
                tabGroup.UnregisterTab(this,false);
            }
        }

        private void OnValueChanged(bool isOn)
        {
            if (page != null)
            {
                page.IsOn = isOn;
            }
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);

            if(onTabClick != null)
            {
                onTabClick(this, eventData);
            }

            if (tabGroup != null)
            {
                tabGroup.curTab = this;
            }
        }

        public void AddTabClickEvent(PointerTabFunc func)
        {
            //onTabClick -= func;
            onTabClick += func;
        }

        public void RemoveTabClickEvent(PointerTabFunc func)
        {
            onTabClick -= func;
        }
    }
}