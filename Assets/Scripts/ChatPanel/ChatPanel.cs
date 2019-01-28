using System;
using NutGUI;
using UnityEngine.UI;

public class ChatPanel : PanelBase
{
    private Button closeButton;
    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.MIDDLE;
        panelPrefabPath = "ChatPanel";

    }


    public override void OnClosed()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnClosing()
    {
       // throw new System.NotImplementedException();
    }

    public override void OnOpened()
    {
        //throw new System.NotImplementedException();
    }

    public override void OnOpening()
    {
        //throw new System.NotImplementedException();
        closeButton = panelPrefab.transform.Find("CloseButton").GetComponent<Button>();
        closeButton.onClick.AddListener(CloseButtonOnClick);

    }

    private void CloseButtonOnClick()
    {
        //throw new NotImplementedException();
        PanelManager.Instance.ClosePanel("ChatPanel");
    }
}

