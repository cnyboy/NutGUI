using NutGUI;
using UnityEngine.UI;

public class SettingPanel : PanelBase
{
    private Button saveButton;
    private Button backButton;

    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.BOTTOM;
        panelPrefabPath = "SettingPanel";
    }

    public override void OnClosed()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnClosing()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnOpened()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnOpening()
    {
        //base.OnOpening();
        saveButton = panelPrefab.transform.Find("SaveButton").GetComponent<Button>();
        backButton = panelPrefab.transform.Find("BackButton").GetComponent<Button>();

        saveButton.onClick.AddListener(SaveButtonOnClick);
        backButton.onClick.AddListener(BackButtonOnClick);
    }

    private void BackButtonOnClick()
    {
        PanelManager.Instance.ClosePanel("SettingPanel");
        PanelManager.Instance.OpenPanel<MenuPanel>("");
    }

    private void SaveButtonOnClick()
    {
        PanelManager.Instance.ClosePanel("SettingPanel");
        PanelManager.Instance.OpenPanel<MenuPanel>("");
        PanelManager.Instance.OpenPanel<TipsPanel>("","Tips:Save is OK!!!");
    }

}

