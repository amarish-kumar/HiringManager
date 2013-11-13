﻿using System.Configuration;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using HiringManager.EntityFramework;
using HiringManager.Web.App_Start;
using Ninject;
using TechTalk.SpecFlow;

namespace HiringManager.Web.Integration.Tests
{
    internal static class ScenarioContextExtensions
    {
        public static T GetFromNinject<T>(this ScenarioContext current)
        {
            return current.GetNinjectKernel().Get<T>();
        }

        public static IKernel GetNinjectKernel(this ScenarioContext current)
        {
            if (!current.ContainsKey("Ninject.Kernel"))
            {
                foreach (var connectionString in System.Configuration.ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>())
                {
                    var message = string.Format("Connection String Name: {0}; Value: {1}; Provider: {2};",
                        connectionString.Name, connectionString.ConnectionString, connectionString.ProviderName);
                    Trace.WriteLine(message);
                }

                var kernel = IntegrationTestConfiguration.Configure();
                current.Add("Ninject.Kernel", kernel);
            }
            var result = current["Ninject.Kernel"] as IKernel;
            return result;
        }
    }
}