using NutGUI;
using UnityEngine.UI;

public class SettingPanel : PanelBase
{
    private Button saveButton;
    private Button backButton;

    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.FullPanel;
        panelPrefabPath = "SettingPanel";
    }
    public override void OnOpening()
    {
        base.OnOpening();
        saveButton = panelPrefab.transform.Find("SaveButton").GetComponent<Button>();
        backButton = panelPrefab.transform.Find("BackButton").GetComponent<Button>();

        saveButton.onClick.AddListener(SaveButtonOnClick);
        backButton.onClick.AddListener(BackButtonOnClick);
    }

    private void BackButtonOnClick()
    {
        PanelMgr.Instance.ClosePanel("SettingPanel");
        PanelMgr.Instance.OpenPanel<MenuPanel>("");
    }

    private void SaveButtonOnClick()
    {
        PanelMgr.Instance.ClosePanel("SettingPanel");
        PanelMgr.Instance.OpenPanel<MenuPanel>("");
        PanelMgr.Instance.OpenPanel<TipsPanel>("","Tips:Save is OK!!!");
    }

}

