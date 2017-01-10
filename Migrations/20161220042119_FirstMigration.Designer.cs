using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OutBrain.DataAccess;

namespace OutBrain.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20161220042119_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("OutBrain.Models.DocumentsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<double>("ConfidenceLevel");

                    b.Property<int>("DocumentId");

                    b.HasKey("Id");

                    b.ToTable("DocumentsCategories");
                });
        }
    }
}
