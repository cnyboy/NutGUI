# NutGUI<br>
NutGUI设计的出发点是代码和资源分离<br>

## 这样做有什么好处呢？<br>
	1.美术人员只负责界面的设计和制作，程序员只负责界面功能的实现，工作互不干扰
	2.代码能够重复利用，如果界面不同功能相同，只需要一套代码
	3.为热更新做准备，如果游戏要更新界面图案，只需要下载新的界面资源就可以
## 结构
	1.NutGUI由面板基类PanelBase，面板管理类PanelManager，面板层级类PanelLayer组成
	2.PanelBase存有，面板的模型，面板模型的路径，面板的层级，初始化面板的参数，面板生命周期
	   Init(初始化，处理参数)-
	   OnOpening(打开前处理，设置一些监听)-
	   OnOpened(打开后处理，一些动画的播放)-
	   Update(每帧更新)-
	   OnClosing(关闭前的处理)-
	   OnClosed(关闭后的处理，一些动画)
	3.PanelManager是一个单例类，他存有场景画布的引用，已经打开的面板，每个面板层级的父物体，和打开面板关闭面板的方法
	4.PanelLayer是枚举类，保存所有面板的层级，与UI_Root下的子物体名字对应
	![Image text](NutGUI/img-folder/ClassDiagram.PNG )
## 如何使用？
	1.创建Canvas，重命名为UI_Root
	2.定义面板的层级，NutGUI/Core下的枚举类PanelLayer中定义，在UI_Root下创建对应的空UI物体，枚举类中的名字和物体名字保持一致
	3.制作面板模型，放到Resources目录下
	4.创建与面板模型名字相同的脚本，该脚本继承PanelBase
	5.在该脚本中覆写Init方法，指定层级例如panelLaye=PanelLayer.xxx，指定路径例如panelPrefabPath="xxx",如果打开面板时传递有参数，需要在Init方法中处理
	6.覆写Opening方法，在这里获取面板中一些控件的引用，设置监听
	7.把PanelManager脚本挂载到UI_Root下
	8.在脚本中打开面板PanelManager.Instance.OpenPanel<面板脚本>("路径参数","初始化参数")，面板脚本是继承PanelBase的脚本，路径参数如模型修改了路径需要指定，否则为空，初始化参数为多参数，不需要可以不写
	9.关闭面板PanelManager.Instance.ClosePanel("面板名字")

<br>
NutGUI    v1.1<br>
Author    Mongo<br>
E-mail    gdqxyq2@163.com<br>
