using NutGUI;
using UnityEngine.UI;
/// <summary>
/// 每个面板对应一个和面板模型相同名字的脚本，继承PanelBase
/// </summary>
public class MenuPanel : PanelBase
{
    //存放面板上一些组件的引用
    private Button startButton;
    private Button settingButton;
    //覆写Init方法
    public override void Init(params object[] args)
    {
        base.Init(args);
        //设置面板所属的层级
        panelLayer = PanelLayer.FullPanel;
        //设置面板模型的路径
        panelPrefabPath = "MenuPanel";
    }
    //覆写OnOpening方法，做打开面板前的处理
    public override void OnOpening()
    {
        base.OnOpening();
        //找到对应的引用
        startButton = panelPrefab.transform.Find("StartButton").GetComponent<Button>();
        settingButton = panelPrefab.transform.Find("SettingButton").GetComponent<Button>();

        //给Button设置监听
        startButton.onClick.AddListener(StartButtonOnClick);
        settingButton.onClick.AddListener(SettingButtonOnClick);

    }

    //监听回调
    private void StartButtonOnClick()
    {
        PanelMgr.Instance.OpenPanel<StartPanel>("");
        PanelMgr.Instance.ClosePanel("MenuPanel");
    }

    private void SettingButtonOnClick()
    {
        PanelMgr.Instance.OpenPanel<SettingPanel>("");
        PanelMgr.Instance.ClosePanel("MenuPanel");
    }
}
