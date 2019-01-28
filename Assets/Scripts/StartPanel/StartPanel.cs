using NutGUI;
using UnityEngine.UI;

public class StartPanel : PanelBase
{
    //存放面板上一些组件的引用
    private Button closeButton;
    private Button getItemButton;
    private Button openCharInfoButton;
    private Button openChatButton;
    private Button openKnapsackButton;
    private Button shoppingButton;

    //覆写Init方法
    public override void Init(params object[] args)
    {
        base.Init(args);
        //设置面板模型的路径
        panelLayer = PanelLayer.MIDDLE;
        //设置面板所属的层级
        panelPrefabPath = "StartPanel";
    }
    public override void OnOpening()
    {
        //base.OnOpening();
        //找到对应的引用
        closeButton = panelPrefab.transform.Find("CloseButton").GetComponent<Button>();
        getItemButton = panelPrefab.transform.Find("GetItemButton").GetComponent<Button>();
        openCharInfoButton = panelPrefab.transform.Find("OpenCharInfoButton").GetComponent<Button>();
        openChatButton = panelPrefab.transform.Find("OpenChatButton").GetComponent<Button>();
        openKnapsackButton = panelPrefab.transform.Find("OpenKnapsackButton").GetComponent<Button>();
        shoppingButton = panelPrefab.transform.Find("ShoppingButton").GetComponent<Button>();

        //给Button设置监听
        closeButton.onClick.AddListener(CloseButtonOnClick);
        getItemButton.onClick.AddListener(GetItemButtonOnClick);
        openCharInfoButton.onClick.AddListener(OpenCharInfoButtonOnClick);
        openChatButton.onClick.AddListener(OpenChatButtonOnClick);
        openKnapsackButton.onClick.AddListener(OpenKnapsackButtonOnClick);
        shoppingButton.onClick.AddListener(ShoppingButtonOnClick);
    }

    //监听回调
    private void ShoppingButtonOnClick()
    {
        PanelManager.Instance.OpenPanel<WarnPanel>("","Warning:You dont have enough money!");
    }

    private void OpenChatButtonOnClick()
    {
        PanelManager.Instance.OpenPanel<ChatPanel>("");
    }

    private void OpenKnapsackButtonOnClick()
    {
        PanelManager.Instance.OpenPanel<KnapsackPanel>("");
    }

    private void OpenCharInfoButtonOnClick()
    {
        PanelManager.Instance.OpenPanel<CharacterInfoPanel>("");
    }

    private void GetItemButtonOnClick()
    {
        PanelManager.Instance.OpenPanel<TipsPanel>("","Tips:GetItem,666!666!");
    }

    private void CloseButtonOnClick()
    {

        //Dictionary<string, PanelBase> dict = PanelMgr.Instance.openedPanelDict;
        //foreach (var item in dict)
        //{
        //    if (item.Key.ToString()!= "StartPanel")
        //    {
        //        PanelMgr.Instance.ClosePanel(item.Key.ToString());
        //    }
        //}
        PanelManager.Instance.ClosePanel("TipsPanel");
        PanelManager.Instance.ClosePanel("ChatPanel");
        PanelManager.Instance.ClosePanel("CharacterInfoPanel");
        PanelManager.Instance.ClosePanel("KnapsackPanel");

        PanelManager.Instance.OpenPanel<MenuPanel>("");
        PanelManager.Instance.ClosePanel("StartPanel");
    }

    public override void OnOpened()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnClosing()
    {
       // throw new System.NotImplementedException();
    }

    public override void OnClosed()
    {
       //throw new System.NotImplementedException();
    }
}
