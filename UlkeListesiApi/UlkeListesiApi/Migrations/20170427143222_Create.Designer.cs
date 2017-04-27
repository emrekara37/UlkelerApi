using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UlkeListesiApi.Models;

namespace UlkeListesiApi.Migrations
{
    [DbContext(typeof(UlkeDbContext))]
    [Migration("20170427143222_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UlkeListesiApi.Models.Ulkeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UlkeAdi");

                    b.HasKey("Id");

                    b.ToTable("Ulkeler");
                });
        }
    }
}
