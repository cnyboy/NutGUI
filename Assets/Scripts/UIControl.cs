﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NutGUI;

public class UIControl : MonoBehaviour
{
    private void Start()
    {
        PanelManager.Instance.OpenPanel<MenuPanel>("");
    }

}
