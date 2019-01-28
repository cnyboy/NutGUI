using NutGUI;
using UnityEngine.UI;

public class TipsPanel : PanelBase
{
    private Text tipsText;
    private string arg;

    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.MIDDLE;
        panelPrefabPath = "TipsPanel";
        arg = (string)args[0];
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
       // throw new System.NotImplementedException();
    }

    public override void OnOpening()
    {
        //base.OnOpening();
        panelPrefab.AddComponent<UIPanelDrag>();
        panelPrefab.AddComponent<TipsPanelDelaySestroy>();
        panelPrefab.AddComponent<MovablePanelLayerControl>();
        tipsText = panelPrefab.transform.Find("Text").GetComponent<Text>();
        tipsText.text = arg;

    }
    
}

