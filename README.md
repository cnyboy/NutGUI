# NutGUI<br>
NutGUI设计的出发点是代码和资源分离<br>

# 这样做有什么好处呢？<br>
	1.美术人员只负责界面的设计和制作，程序员只负责界面功能的实现，工作互不干扰<br>
	2.代买能够重复利用，如果界面不同功能相同，只需要一套代码<br>
	3.为热更新做准备，如果游戏要更新界面图案，只需要下载新的界面资源就OK<br>
# 大概结构<br>
	1.NutGUI由面板基类PanelBase，面板管理类PanelMgr，面板层级类PanelLayer组成<br>
	2.PanelBase存有，面板的模型，面板模型的路径，面板的层级，初始化面板的参数，<br>
	  面板生命周期<br>
	（Init(初始化，处理参数)-<br>
	   OnOpening(打开前处理，设置一些监听)-<br>
	   OnOpened(打开后处理，一些动画的播放)-<br>
	   Update(每帧更新)-<br>
	   OnClosing(关闭前的处理)-<br>
	   OnClosed(关闭后的处理，一些动画)<br>
	3.PanelMgr是一个单例类，他存有场景画布的引用，已经打开的面板，每个面板层级的父物体，和打开面板关闭面板的方法<br>
	4.PanelLayer是枚举类，保存所有面板的层级，与UI_Root下的子物体名字对应<br>
# 如何使用？<br>
	1.创建Canvas，重命名为UI_Root<br>
	2.定义面板的层级，NutGUI/Core下的枚举类PanelLayer中定义，在UI_Root下创建对应的空UI物体，枚举类中的名字和物体名字保持一致<br>
	3.制作面板模型，放到Resources目录下<br>
	4.创建与面板模型名字相同的脚本，该脚本继承PanelBase<br>
	5.在该脚本中覆写Init方法，指定层级例如panelLaye=PanelLayer.FullPanel，指定路径例如panelPrefabPath="MenuPanel",如果打开面板时传递有参数，需要在这里处理<br>
	6.覆写Opening方法，在这里获取面板中一些控件的引用，设置监听<br>
	7.把PanelMgr脚本挂载到UI_Root下<br>
	8.在脚本中打开面板PanelMgr.Instance.OpenPanel<面板脚本>("路径参数","初始化参数")，面板脚本是继承PanelBase的脚本，路径参数如模型修改了路径需要指定，否则为空，初始化参数为多参数，不需要可以不写<br>
	9.关闭面板PanelMgr.Instance.ClosePanel("面板名字")<br>
# PS：在example中已经使用的非常详细了，可以复制example中的脚本，在脚本上做些修改。或者可以直接修改示例，示例涵盖了大部分的游戏界面类型，FullPanel是那种覆盖全屏的，不如一些设置之类的界面，WarningPanel是一种警告界面，他一旦弹出来就必须关闭或者点击确定才能继续与其他界面交互，MovablePanel是游戏中非全屏，可以活动的几面类型，例如，背包界面，角色信息界面，组队，帮派，聊天界面等等，还有提示类的几面，例如你在游戏中的到一个物品，会有一行红色的小消息弹出来，或者播放一些系统的公告。<br>

NUtGUI  v1.0<br>
Author  Mongo<br>
E-mail  gdqxyq2@163.com<br>
