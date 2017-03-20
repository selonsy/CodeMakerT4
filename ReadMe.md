# T4简介

T4(Text Template Transformation Toolkit)是微软官方在VisualStudio 2008中开始使用的代码生成引擎。

在 `Visual Studio` 中，`T4文本模板`是由一些文本块和控制逻辑组成的混合模板，它可以生成任何类型的文本，例如网页、资源文件或任何语言的程序源代码。

# CodeMakerT4

本项目以T4技术为基础，可根据数据库表设计（目前仅支持SQL Server）自动生成ORM框架模型的Model层代码，支持对数据进行简单的CRUD，并允许用户对其进行扩展。

# 示例

1、 新建数据表User，如下所示：  
![image](https://github.com/shenjl/MyPicRep/raw/master/GitHub/CodeMakerT4/user_table.jpg)
>注意：需要给每个表项增加说明，如UserName->用户名，以及表的说明。

2、配置数据库信息，如下所示：
![image](https://github.com/shenjl/MyPicRep/raw/master/GitHub/CodeMakerT4/configration.jpg)

3、生成模板文件：  

完成上一步后，点击保存（或Ctrl+s）即可生成Template.cs文件。  

由于采用了部分类（partial ），故可以将其拆分为两个同名的.cs文件，分别保存于`build`以及`custom`文件夹里面。  

>位于`build`里面的属于自动生成的部分，当数据库结果发生变化时，再次保存.tt模板文件覆盖原有即可。

>位于`custom`里面的属于用户自定义的部分，可以增加一些额外的操作数据库的方法等等。

4、示例如下：  
* /build/User.cs   
![image](https://github.com/shenjl/MyPicRep/raw/master/GitHub/CodeMakerT4/build.jpg)

* /custom/User.cs  
![image](https://github.com/shenjl/MyPicRep/raw/master/GitHub/CodeMakerT4/custom.jpg)