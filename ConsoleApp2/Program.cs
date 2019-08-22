﻿using Autofac;
using ClassLibrary.model;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBulder = new ContainerBuilder();
            containerBulder.Register(X =>
            {
                var cfg = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1\source\repos\ClassLibrary.model\ConsoleApp2\Database1.mdf;Integrated Security=True")
                .Dialect<MsSql2012Dialect>()).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Person>());
                var conf = cfg.BuildConfiguration();
                var schemeExport = new SchemaUpdate(conf);
                schemeExport.Execute(true, true);
                return cfg.BuildSessionFactory();
            }).As<ISessionFactory>().SingleInstance();
            containerBulder.Register(x => x.Resolve<ISessionFactory>().OpenSession()).As<ISession>();
            var container = containerBulder.Build();


            var right = new AccessRight() { Right = 1 };            
            Document doc = new Document() { NameFolder = "Название документа" };
            var person = new Person() {Login = "sad"};
            var Group = new Group() { NameGroup = "название группы" };
            var version = new ClassLibrary.model.Version() { Id = 1000 };

            var session = container.Resolve<ISession>();
            using(var tran=session.BeginTransaction())
            {
                try
                {
                    session.Save(person);
                    tran.Commit();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                }
            }
        }
    }
}
