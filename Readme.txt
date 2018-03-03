设计模式(是经验复用，而非代码复用)：
http://blog.csdn.net/wyxhd2008/article/category/689340
http://www.cnblogs.com/justinw/archive/2007/02/06/641414.html Head First Design Patterns
http://www.cnblogs.com/hegezhou_hot/category/260424.html
http://blog.csdn.net/lovelion/article/details/17517213 
http://blog.csdn.net/zhengzhb/article/category/926691


第一章、策略模式
策略模式Strategy Pattern，定义了算法族；

Q：鸭子实现了继承，想让鸭子飞？
A：1、在父类中添加飞的方法......所有的鸭子都会飞了，虽然可以重写子类的方法使其不会飞，但麻烦！
2、定义一个飞的接口，实现该接口......Java接口不具有实现代码，代码无法复用！

继承、接口都不能有效的解决问题(类继承：所有子类继承同样行为是不恰当的；接口继承：接口没有实现代码，不能实现代码复用)；

设计原则：
1、找出应用中需要变化的部分，独立封装，与不需要变化的分开(独立封装的部分，方便以后修改扩充，且不影响不需要变化的部分)；
2、针对接口编程，而不是针对实现编程(利用多态，声明类时不用理会执行时的真正对象类型，如Animal dog = new Dog();)；


第二章、观察者模式
气象监测系统应用：气象站、WeatherData、布告板；
出版者（主题，Subject）+订阅者（观察者，Observer）=观察者模式；
观察者模式，定义了对象间一对多的依赖关系，当一个对象状态改变时，它的所有依赖者都会收到通知并自动更新；


第三章、装饰者模式
***********************没有达到预期效果***********************

http://www.cnblogs.com/BoyXiao/archive/2010/05/04/1727383.html
装饰者模式动态的给一个对象添加一些责任（也就是功能），若要扩展功能的话，
装饰者提供了比继承更有弹性的替代方案，因为装饰者模式比生成子类更加灵活。

第四章、工厂模式
http://www.cnblogs.com/BoyXiao/archive/2010/05/06/1728808.html
简单工厂、工厂方法、抽象工厂；


第五章、单例模式
单例模式Singleton Pattern，确保一个类只有一个实例，并提供一个全局访问点；
单例模式为什么不使用静态类呢？


第六章、命令模式
命令模式：把方法(method invocation)调用封装起来；
将动作的请求者从动作的执行者对象中解耦。
命令模式来实现“队列、日志、支持撤销操作”；


第七章、适配器模式与外观模式
适配器，将一个接口转换为另一个接口，以符合客户的期望；适配器让原本不兼容的类合作无间；
一个适配器只能封装一个类吗？涉及到另一个模式——外观模式(Facade Pattern)；
双向适配器；


第八章、模板方法模式
模板方法模式：在一个方法中定义一个算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以在不改变算法结构的情况下，重新定义算法中的某些步骤；
模板方法定义了一个算法的步骤，并允许子类为一个或多个步骤提供实现；


第九章、迭代器(Iterator Pattern)与组合模式
引言：有许多种方法可以把对象堆起来成为一个集合，如数组、堆栈、列表、散列表；
迭代器模式，依赖于一个名为迭代器的接口；


第十章、状态模式
策略模式和状态模式是双胞胎，在出生时才分开；
策略模式是围绕可以互换的算法来创建成功业务的；
状态模式通过改变对象内部状态来帮助对象控制自己的行为；
状态模式，允许对象在内部状态改变时改变它的行为，对象看起来好像修改了它的类；


第十一章、代理模式(远程访问)
定义：为其他对象提供一种代理以控制对这个对象的访问；
在某些情况下，一个对象不适合或者不能直接引用另一个对象，而代理对象可以在客户端和目标对象之间起到中介的作用；
代理要做的(白脸黑脸游戏)：控制和管理访问；
代理模式：为另一个对象提供一个替身或占位符以控制对这个对象的访问；


第十二章、复合模式


剩下的模式(附录)：
桥接模式；
生成器模式(建造者模式)；
责任链模式；
蝇量模式(享元模式)；
解释器模式；
中介者模式；
备忘录模式；
原型模式；
访问者模式；

http://baike.baidu.com/view/66964.htm?fr=aladdin
设计模式分为三种类型，共23种。
创建型模式：单例模式、抽象工厂模式、建造者模式、工厂模式、原型模式。
结构型模式：适配器模式、桥接模式、装饰模式、组合模式、外观模式、享元模式、代理模式。
行为型模式：模版方法模式、命令模式、迭代器模式、观察者模式、中介者模式、备忘录模式、解释器模式、状态模式、策略模式、职责链模式、访问者模式。


第十三章、桥接模式(Bridge Pattern)
http://www.cnblogs.com/mengdd/archive/2013/05/12/3073710.html (桥接、生成器、责任链模式合装篇)
http://www.cnblogs.com/houleixx/archive/2008/02/23/1078877.html

第十四章、生成器模式(建造者模式，Builder Pattern)
http://www.cnblogs.com/lds85930/articles/643143.html

第十五章、责任链模式(Chain of Responsibility)
http://www.cnblogs.com/kym/archive/2009/04/06/1430078.html
http://www.cnblogs.com/suizhouqiwei/archive/2012/11/29/2773310.html

第十六章、蝇量模式(享元模式，Flyweight Pattern)
http://www.cnblogs.com/mengdd/archive/2013/05/12/3073725.html (蝇量、解释器、中介者模式合装篇)
如想让某个类的一个实例能用来提供许多“虚拟实例”，就使用蝇量模式（Flyweight Pattern）
http://www.cnblogs.com/hegezhou_hot/archive/2010/12/12/1903728.html
http://www.cnblogs.com/growup/archive/2011/04/20/2022669.html

第十七章、解释器模式(Interpreter Pattern) 无Demo
http://www.cnblogs.com/cbf4life/archive/2009/12/17/1626125.html (内容较多)

第十八章、中介者模式(Mediator Pattern)
定义一个中介对象来封装系列对象之间的交互。中介者使各个对象不需要显示地相互引用，从而使其耦合性松散，而且可以独立地改变他们之间的交互(类似QQ群)
http://www.cnblogs.com/BeyondAnyTime/archive/2012/08/30/2663922.html (C++ Demo)
http://www.cnblogs.com/zxj159/p/3466115.html (C#)

第十九章、备忘录模式(Memento Pattern)
http://blog.csdn.net/zhengzhb/article/details/7697549
在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样就可以将该对象恢复到原先保存的状态

第二十章、原型模式(Prototype Pattern)
http://blog.csdn.net/zhengzhb/article/details/7393528 
用原型实例指定创建对象的种类，并通过拷贝这些原型创建新的对象。

第二十一章、访问者模式(Visitor Pattern)
http://blog.csdn.net/zhengzhb/article/details/7489639
zxc