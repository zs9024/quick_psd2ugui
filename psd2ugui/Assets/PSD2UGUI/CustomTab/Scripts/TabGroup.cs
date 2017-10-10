using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Quick.UI
{
    [AddComponentMenu("UI/TabGroup")]
    public class TabGroup : ToggleGroup
    {
        // 摘要: 
        //     The current seleced tab
        private Tab m_CurTab;
        public Tab curTab {
            get { return m_CurTab; }
            set { m_CurTab = value; }
        }

        private List<Tab> m_Tabs = new List<Tab>();

        public void RegisterTab(Tab tab, bool registerToggle = true)
        {
            if (registerToggle) RegisterToggle(tab);
            if (!m_Tabs.Contains(tab))
            {
                m_Tabs.Add(tab);
            }
        }

        public void UnregisterTab(Tab tab, bool unregisterToggle = true)
        {
            if (unregisterToggle) UnregisterToggle(tab);
            if (m_Tabs.Contains(tab))
            {
                m_Tabs.Remove(tab);
            }
        }

        public void AddSingleTabClickEvent(Tab tab, Tab.PointerTabFunc onTabClick = null)
        {
            if (tab != null)
            {
                tab.AddTabClickEvent(onTabClick);
            }
        }

        public void RemoveSingleTabClickEvent(Tab tab, Tab.PointerTabFunc onTabClick = null)
        {
            if (tab != null)
            {
                tab.RemoveTabClickEvent(onTabClick);
            }
        }

        public void AddTabsClickEvent(Tab.PointerTabFunc onTabClick = null)
        {
            foreach (Tab tab in m_Tabs)
            {
                if (tab != null)
                {
                    AddSingleTabClickEvent(tab, onTabClick);
                }
            }
        }

        public void RemoveTabsClickEvent(Tab.PointerTabFunc onTabClick = null)
        {
            foreach (Tab tab in m_Tabs)
            {
                if (tab != null)
                {
                    RemoveSingleTabClickEvent(tab, onTabClick);
                }
            }
        }

        public void TurnTabOn(Tab tab,System.Action<Tab> onTurnOn = null)
        {
            m_CurTab = tab;           
            if (m_CurTab != null)
            {
                m_CurTab.isOn = true;
                NotifyToggleOn(m_CurTab);
            }

            if (onTurnOn != null) onTurnOn(tab);
        }

        public void TurnTabOn(string tabTag, System.Action<Tab> onTurnOn = null)
        {
            Tab tabTemp = null;
            foreach(Tab tab in m_Tabs)
            {
                if(tab.tag == tabTag)
                {
                    tabTemp = tab;
                    break;
                }
            }

            TurnTabOn(tabTemp,onTurnOn);
        }

        public void SetTabTag(string tag,Tab tab)
        {
            tab.tag = tag;
        }

    }
}