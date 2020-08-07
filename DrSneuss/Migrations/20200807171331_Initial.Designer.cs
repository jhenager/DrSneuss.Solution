﻿// <auto-generated />
using DrSneuss.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrSneuss.Migrations
{
    [DbContext(typeof(DrSneussContext))]
    [Migration("20200807171331_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DrSneuss.Models.Engineer", b =>
                {
                    b.Property<int>("EngineerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EngineerName");

                    b.HasKey("EngineerId");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("DrSneuss.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MachineName");

                    b.HasKey("MachineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("DrSneuss.Models.MachineEngineer", b =>
                {
                    b.Property<int>("MachineEngineerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EngineerId");

                    b.Property<int>("MachineId");

                    b.HasKey("MachineEngineerId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineEngineer");
                });

            modelBuilder.Entity("DrSneuss.Models.MachineEngineer", b =>
                {
                    b.HasOne("DrSneuss.Models.Engineer", "engineer")
                        .WithMany("Machines")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrSneuss.Models.Machine", "machine")
                        .WithMany("Engineers")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
