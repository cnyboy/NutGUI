using System;
using System.Collections.Generic;
using UnityEngine;
namespace NutGUI
{
    /// <summary>
    /// 面板的管理类
    /// </summary>
    public class PanelManager : MonoBehaviour
    {
        private static PanelManager _instance;
        public static PanelManager Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new PanelManager();
                }
                return _instance;
            }
        }
        //获取UI_Root
        private GameObject UI_Root;
        //存放已经打开的面板
        public Dictionary<string, PanelBase> openedPanelDict;
        //存放所有面板层级的父物体
        private Dictionary<PanelLayer, Transform> panelLayerDict;

        public void Awake()
        {
            _instance = this;
            openedPanelDict = new Dictionary<string, PanelBase>();
            InitPanelLayer();
            //openedPanelDict = new Dictionary<string, PanelBase>();
        }
        //获取面板层级
        private void InitPanelLayer()
        {
            UI_Root = GameObject.Find("UI_Root");
            if (UI_Root==null)
            {
                Debug.LogError("[ERROR]private void InitPanelLayer():UI_Root = GameObject.Find(\"UI_Root\")");
            }
            panelLayerDict = new Dictionary<PanelLayer, Transform>();
            foreach (PanelLayer p in Enum.GetValues(typeof(PanelLayer)))
            {
                string name = p.ToString();
                Transform transform = UI_Root.transform.Find(name);
                panelLayerDict.Add(p,transform);
            }


        }
        //打开面板方法
        public void OpenPanel<T>(string panelPrefabPath,params object[] args)where T:PanelBase
        {
            string name = typeof(T).ToString();
            if (openedPanelDict.ContainsKey(name)) return;
            PanelBase panel = UI_Root.AddComponent<T>();
            //PanelBase panel = new GameObject().AddComponent<T>();
            panel.Init(args);
            openedPanelDict.Add(name,panel);
            if (panelPrefabPath!="")
            {
                
            }
            else
            {
                panelPrefabPath = panel.panelPrefabPath;
            }
            GameObject panelPrefab = Resources.Load<GameObject>(panelPrefabPath);
            //panelPrefab.AddComponent<T>();
            if (panelPrefab==null)
            {
                Debug.LogError("[ERROR]OpenPanel<T>():GameObject panelPrefab = Resources.Load<GameObject>(panelPrefabPath)");
            }
            panel.panelPrefab = (GameObject)Instantiate(panelPrefab);
            Transform transform = panel.panelPrefab.transform;
            PanelLayer panelLayer = panel.panelLayer;
            Transform parent = panelLayerDict[panelLayer];
            transform.SetParent(parent, false);
            panel.OnOpening();
            panel.OnOpened();
        }
        //关闭面板方法
        public void ClosePanel(string name)
        {
            if (!openedPanelDict.ContainsKey(name)) return;
            PanelBase panel = (PanelBase)openedPanelDict[name];
            if (panel == null) return;

            openedPanelDict.Remove(name);

            panel.OnClosing();
            //openedPanelDict.Remove(name);
            panel.OnClosed();
            
            GameObject.Destroy(panel.panelPrefab);
            Component.Destroy(panel);
        }

    }

}