using NutGUI;
using UnityEngine.UI;

public class CharacterInfoPanel : PanelBase
{
    //存放面板上一些组件的引用
    private Button closeButton;

    public override void Init(params object[] args)
    {
        base.Init(args);
        //设置面板所属的层级
        panelLayer = PanelLayer.MovablePanel;
        //设置面板模型的路径
        panelPrefabPath = "CharacterInfoPanel";
    }
    public override void OnOpening()
    {
        base.OnOpening();
        //添加别的功能脚本，这些脚本不需要继承PanelBase，一些在此脚本无法完成的功能可以写到别的脚本
        //添加UI拖拽功能脚本
        panelPrefab.AddComponent<UIPanelDrag>();
        //添加MovablePanel的子物体层级控制脚本
        panelPrefab.AddComponent<MovablePanelLayerControl>();
        //找到对应的引用
        closeButton = panelPrefab.transform.Find("CloseButton").GetComponent<Button>();
        //给Button设置监听
        closeButton.onClick.AddListener(CloseButtonOnClick);
    }
    //监听回调
    private void CloseButtonOnClick()
    {
        PanelMgr.Instance.ClosePanel("CharacterInfoPanel");
    }


}
