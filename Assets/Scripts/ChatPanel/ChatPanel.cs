using NutGUI;
using UnityEngine.UI;

public class ChatPanel : PanelBase
{
    private Button closeButton;

    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.MovablePanel;
        panelPrefabPath = "ChatPanel";
    }
    public override void OnOpening()
    {
        base.OnOpening();
        closeButton = panelPrefab.transform.Find("CloseButton").GetComponent<Button>();
        closeButton.onClick.AddListener(CloseButtonOnClick);
    }
    private void CloseButtonOnClick()
    {
        PanelMgr.Instance.ClosePanel("ChatPanel");
    }


}

