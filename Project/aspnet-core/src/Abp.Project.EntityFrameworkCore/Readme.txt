.EntityFrameworkCore 项目

这是集成EF Core的项目. 它定义了 DbContext 并实现 .Domain 项目中定义的仓储接口.
--它依赖 .Domain 项目,因为它需要引用实体和仓储接口.

只有在你使用了EF Core做为数据库提供程序时,此项目才会可用. 如果选择的是其他数据库提供程序那么项目的名称会改变