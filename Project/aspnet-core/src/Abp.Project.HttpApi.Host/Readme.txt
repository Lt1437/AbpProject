.Web 项目

包含应用程序的用户界面(UI).如果使用ASP.NET Core MVC UI, 它包括Razor页面,javascript文件,样式文件,图片等...

包含应用程序主要的 appsettings.json 配置文件,用于配置数据库连接字符串和应用程序的其他配置
--依赖 .HttpApi 项目,因为UI层需要使用解决方案的API和应用服务接口.

如果查看 .Web.csproj 源码, 你会看到对 .Application 和 .EntityFrameworkCore.DbMigrations 项目的引用.

在编写UI层时实际上不需要这些引用. 因为UI层通常不依赖于EF Core或应用层的实现. 这个启动模板已经为分层部署做好了准备,API层托管在不同与UI层的服务器中.

但是如果你不选择 --tiered 选项, .Web项目会有这些引用,以便能够将Web,Api和应用层托管在单个应用程序站点.

你可以在表示层中使用领域实体和仓储,但是根据DDD的理论,这被认为是一种不好的做法.