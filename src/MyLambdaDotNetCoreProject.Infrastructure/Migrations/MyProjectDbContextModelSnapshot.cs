﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLambdaDotNetCoreProject.Infrastructure.Ef;

namespace MyLambdaDotNetCoreProject.Infrastructure.Migrations
{
    [DbContext(typeof(MyProjectDbContext))]
    partial class MyProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate.Entity1", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Entity1");
                });
#pragma warning restore 612, 618
        }
    }
}
