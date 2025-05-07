var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BSDClassroom_Api>("bsdclassroom-api");

builder.AddProject<Projects.BSDClassroom_BFF>("bsdclassroom-bff");

builder.Build().Run();
