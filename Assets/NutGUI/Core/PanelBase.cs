using UnityEngine;

namespace NutGUI
{
    /// <summary>
    /// 面板基类
    /// </summary>
    public abstract class PanelBase : MonoBehaviour
    {
        //存放面板模型的路径
        public  string panelPrefabPath;
        //存放面板模型
        public GameObject panelPrefab;
        //存放面板的层级
        public PanelLayer panelLayer;
        //存放接收的参数
        public object[] args;
        
        //打开面板前的处理方法
        public abstract void OnOpening();
        //打开面板后的处理方法
        public abstract void OnOpened();
        //关闭面板前的处理方法
        public abstract void OnClosing();
        //关闭面板后的处理方法
        public abstract void OnClosed();


        //面板初始化
        public virtual void Init(params object[] args)
        {
            this.args = args;
        }
        //面板每帧更新
        public virtual void Update() { }
    }
    
}


