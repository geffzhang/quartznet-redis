Quartz.NET-Redis
======================================================================

## Overview
[Quartz.NET](http://quartznet.sourceforge.net/) Quartz.NET is a full-featured, open source job scheduling system that can be used from smallest apps to large scale enterprise systems.

This provider enables [Redis](http://redis.io/) to be used as the back-end job store via the [C#/.NET Client for Redis](https://github.com/ServiceStack/ServiceStack.Redis
).
Hugely inspired by the [RedisJobStore project](https://github.com/RedisLabs/redis-quartz).

## Usage
The easiest way to add this to a project is via the [quartz.impl.redis NuGET package](http://nuget.org/packages/quartz.impl.redis) which will add the required assemblies to your project.

## Configuration
Here is an example web or app config file snippet:

    <quartz>
      <add key="quartz.jobStore.type" value="Quartz.Impl.Redis.JobStore, Quartz.Impl.Redis"/>
    </quartz>
    <connectionStrings>
      <add name="quartznet-redis" connectionString="redis://localhost:6379"/>
    </connectionStrings>

You may want to use the in-code method to configure your scheduler as it is easier in a clustered environment.
Remember this will still need to set a valid connection string in web or app config file :

	// get a scheduler
	NameValueCollection properties = new NameValueCollection();
	properties["quartz.scheduler.instanceName"] = "MyApplicationScheduler"; // needed if you plan to use the same database for many schedulers
	properties["quartz.scheduler.instanceId"] = System.Environment.MachineName + DateTime.UtcNow.Ticks; // requires uniqueness
	properties["quartz.jobStore.type"] = "Quartz.Impl.Redis.JobStore, Quartz.Impl.redis";
	
	IScheduler scheduler = new Quartz.Impl.StdSchedulerFactory(properties).GetScheduler();

 