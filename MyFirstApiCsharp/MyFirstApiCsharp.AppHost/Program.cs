var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MyFirstApiCsharp>("myfirstapicsharp");

builder.Build().Run();
