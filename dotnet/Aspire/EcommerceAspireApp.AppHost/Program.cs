using k8s.Models;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

// API Service application
//var apiService = builder.AddProject<Projects.EcommerceAspireApp_ApiService>("apiservice");

// adding angular application 
builder.AddNpmApp("angular", "../../../web-ui/Angular/E-commerce")
    // .WithReference(apiService)                            //     At the moment there is no api 
    // .WaitFor(apiService)

    .WithHttpEndpoint(env: "PORT",port:4200)
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();


// add react application
builder.AddNpmApp("react","../../../web-ui/React/e-commerce-tsx")
  //  .WithReference(apiService)
  //  .WaitFor(apiService)
      .WithHttpEndpoint(env: "PORT", port:3000)
      .WithExternalHttpEndpoints()
      .PublishAsDockerFile();




// FOR FRONT ENT WE NOT USING BLAZOR WE USE ANGULAR AND RAECT 

//builder.AddProject<Projects.EcommerceAspireApp_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    .WithReference(cache)
//    .WaitFor(cache)
//    .WithReference(apiService)
//    .WaitFor(apiService);

builder.Build().Run();
