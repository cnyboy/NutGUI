using UnityEngine;

namespace NutGUI
{
    /// <summary>
    /// 面板基类
    /// </summary>
    public class PanelBase : MonoBehaviour
    {
        //存放面板模型的路径
        public string panelPrefabPath;
        //存放面板模型
        public GameObject panelPrefab;
        //存放面板的层级
        public PanelLayer panelLayer;
        //存放接收的参数
        public object[] args;
        //接收参数
        public virtual void Init(params object[] args)
        {
            this.args = args;
        }
        //虚方法，打开面板前的处理
        public virtual void OnOpening() { }
        //虚方法，打开面板后的处理
        public virtual void OnOpened() { }
        //虚方法，面板更新处理
        public virtual void Update() { }
        //虚方法，关闭面板前的处理
        public virtual void OnClosing() { }
        //虚方法，关闭面板后的处理
        public virtual void OnClosed() { }

    }
    
}


