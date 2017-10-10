using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Quick.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 使用示例
/// </summary>
public class TabTest : MonoBehaviour {

    private TabGroup tabGroup;

    private HomePage homePage;
    public enum TabType
    {
        TabShop,
        TabHome,
        TabBackpack
    }

	void Start () {
        InitUI();
        SetDefaultTab();
	}
	
    private void InitUI()
    {
        tabGroup = transform.Find("TabGroup").GetComponent<TabGroup>();
        tabGroup.AddTabsClickEvent(OnTabClick);
    }

    //设置初始默认页
    private void SetDefaultTab()
    {
        tabGroup.TurnTabOn(TabType.TabHome.ToString(), (Tab defTab) => {
            ShowHomePage(defTab.page);
        });
    }

    //tab点击的响应 
    private void OnTabClick(Tab target,PointerEventData eventDatas)
    {      
        if(tabGroup.curTab == target)
        {
            return;
        }

        string tabTag = target.tag;
        print(tabTag);

        if (tabTag == TabType.TabShop.ToString())
        {
            ShowShopPage(target.page);
        }
        else if (tabTag == TabType.TabHome.ToString())
        {
            ShowHomePage(target.page);
        }
        else if (tabTag == TabType.TabBackpack.ToString())
        {
            ShowBackpackPage(target.page);
        }
    }

    //显示具体页签内容
    private void ShowShopPage(Page page)
    {
        var tip = page.transform.Find("Content").GetComponent<Text>();
        tip.text = "这是商店界面";
    }

    private void ShowHomePage(Page page)
    {
        if(homePage == null)
        {
            homePage = new HomePage(page);
        }

        //从配置或者服务端取数据
        //这里data只是测试
        object data = "这是主页界面";
        homePage.Show(data);
    }

    private void ShowBackpackPage(Page page)
    {
        var tip = page.transform.Find("Content").GetComponent<Text>();
        tip.text = "这是背包界面";
    }

    //具体page的显示，如果内容较多，可以另起一个类
    public class HomePage
    {
        private Page m_Page;
        private Text tip;
        public HomePage(Page page)
        {
            m_Page = page;
            InitUI();
        }

        private void InitUI()
        {
            tip = m_Page.transform.Find("Content").GetComponent<Text>();
        }

        public void Show(object data)
        {
            tip.text = (string)data;
        }
    }
}


