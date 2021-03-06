﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NutGUI;
using UnityEngine.UI;
using System;

public class WarnPanel : PanelBase
{
    private Button okButton;
    private Text text;
    private string arg;

    public override void Init(params object[] args)
    {
        base.Init(args);
        panelLayer = PanelLayer.TOP;
        panelPrefabPath = "WarnPanel";
        arg = (string)args[0];

    }

    public override void OnClosed()
    {
        //throw new NotImplementedException();
    }

    public override void OnClosing()
    {
        //throw new NotImplementedException();
    }

    public override void OnOpened()
    {
        //throw new NotImplementedException();
    }

    public override void OnOpening()
    {
        //base.OnOpening();
        okButton = panelPrefab.transform.Find("OkButton").GetComponent<Button>();
        text= panelPrefab.transform.Find("Text").GetComponent<Text>();
        text.text = arg;

        okButton.onClick.AddListener(OkButtonOnClick);
    }

    private void OkButtonOnClick()
    {
        PanelManager.Instance.ClosePanel("WarnPanel");
    }
}
