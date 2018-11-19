using NutGUI;
using UnityEngine.UI;

public class KnapsackPanel : PanelBase
{
    private Button closeButton;

    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.MovablePanel;
        panelPrefabPath = "KnapsackPanel";
    }
    public override void OnOpening()
    {
        base.OnOpening();
        panelPrefab.AddComponent<UIPanelDrag>();
        panelPrefab.AddComponent<MovablePanelLayerControl>();
        closeButton = panelPrefab.transform.Find("CloseButton").GetComponent<Button>();
        closeButton.onClick.AddListener(CloseButtonOnClick);
    }
    private void CloseButtonOnClick()
    {
        PanelMgr.Instance.ClosePanel("KnapsackPanel");
    }


}
