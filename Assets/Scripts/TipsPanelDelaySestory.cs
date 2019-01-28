using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NutGUI;

public class TipsPanelDelaySestroy : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DelayDestory());
    }
    IEnumerator DelayDestory()
    {
        yield return new WaitForSeconds(2.0f);
        PanelManager.Instance.ClosePanel("TipsPanel");
    }

}
