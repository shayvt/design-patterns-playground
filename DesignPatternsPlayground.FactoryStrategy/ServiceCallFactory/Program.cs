//using DesignPatternsPlayground.FactoryStrategy.ServiceCallFactory;
//using Microsoft.Extensions.DependencyInjection;

//ServiceCollection services = new();

//services.AddTransient<IStrategyFactory, StrategyFactory>();

//services.AddTransient<IStrategy, StrategyA>();
//services.AddTransient<IStrategy, StrategyB>();

//services.AddTransient<IService, Service>();

//var serviceProvider = services.BuildServiceProvider();

//var service = serviceProvider.GetRequiredService<IService>();

//service.DoServiceWork(0);
//service.DoServiceWork(1);