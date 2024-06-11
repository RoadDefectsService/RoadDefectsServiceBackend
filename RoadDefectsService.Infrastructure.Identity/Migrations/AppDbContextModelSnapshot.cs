﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RoadDefectsService.Infrastructure.Identity.Contexts;

#nullable disable

namespace RoadDefectsService.Infrastructure.Identity.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ContractorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("DeadlineDateOnly")
                        .HasColumnType("date");

                    b.Property<Guid>("FixationDefectId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId")
                        .IsUnique();

                    b.HasIndex("FixationDefectId")
                        .IsUnique();

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Contractor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ContractorFullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.CustomRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.CustomUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HighestRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.DefectType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DefectTypes");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.FixationDefect", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double?>("CoordinatesX")
                        .HasColumnType("double precision");

                    b.Property<double?>("CoordinatesY")
                        .HasColumnType("double precision");

                    b.Property<double?>("DamagedCanvasSquareMeter")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("DefectTypeId")
                        .HasColumnType("uuid");

                    b.Property<string>("ExactAddress")
                        .HasColumnType("text");

                    b.Property<DateTime>("RecordedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DefectTypeId");

                    b.ToTable("FixationDefects");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.FixationWork", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("RecordedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("WorkDone")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("FixationWorks");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Operator", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("FixationDefectId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("FixationWorkId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FixationDefectId");

                    b.HasIndex("FixationWorkId", "FixationDefectId");

                    b.ToTable("Photos", t =>
                        {
                            t.HasCheckConstraint("CK_ModelC_SingleReference", "(\"FixationWorkId\" IS NULL     AND \"FixationDefectId\" IS NOT NULL OR \"FixationWorkId\" IS NOT NULL AND \"FixationDefectId\" IS NULL)");
                        });
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.RoadInspector", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("RoadInspectors");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.TaskEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<Guid?>("FixationDefectId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RoadInspectorId")
                        .HasColumnType("uuid");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("integer");

                    b.Property<int>("TaskType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FixationDefectId")
                        .IsUnique();

                    b.HasIndex("RoadInspectorId");

                    b.ToTable("Tasks");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TaskEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.TaskFixationDefect", b =>
                {
                    b.HasBaseType("RoadDefectsService.Core.Domain.Models.TaskEntity");

                    b.Property<string>("ApproximateAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("TaskFixationDefect");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.TaskFixationWork", b =>
                {
                    b.HasBaseType("RoadDefectsService.Core.Domain.Models.TaskEntity");

                    b.Property<Guid?>("FixationWorkId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PrevTaskId")
                        .HasColumnType("uuid");

                    b.HasIndex("FixationWorkId")
                        .IsUnique();

                    b.HasIndex("PrevTaskId")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("TaskFixationWork");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Assignment", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.Contractor", "Contractor")
                        .WithOne()
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.Assignment", "ContractorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoadDefectsService.Core.Domain.Models.FixationDefect", "FixationDefect")
                        .WithOne()
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.Assignment", "FixationDefectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contractor");

                    b.Navigation("FixationDefect");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.FixationDefect", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.DefectType", "DefectType")
                        .WithMany()
                        .HasForeignKey("DefectTypeId");

                    b.Navigation("DefectType");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Operator", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomUser", "User")
                        .WithOne()
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.Operator", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.Photo", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.FixationDefect", null)
                        .WithMany("Photos")
                        .HasForeignKey("FixationDefectId");

                    b.HasOne("RoadDefectsService.Core.Domain.Models.FixationWork", null)
                        .WithMany("Photos")
                        .HasForeignKey("FixationWorkId");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.RoadInspector", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.CustomUser", "User")
                        .WithOne()
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.RoadInspector", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.TaskEntity", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.FixationDefect", "FixationDefect")
                        .WithOne("Task")
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.TaskEntity", "FixationDefectId");

                    b.HasOne("RoadDefectsService.Core.Domain.Models.RoadInspector", "RoadInspector")
                        .WithMany("AppointedTasks")
                        .HasForeignKey("RoadInspectorId");

                    b.Navigation("FixationDefect");

                    b.Navigation("RoadInspector");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.TaskFixationWork", b =>
                {
                    b.HasOne("RoadDefectsService.Core.Domain.Models.FixationWork", "FixationWork")
                        .WithOne("TaskFixationWork")
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.TaskFixationWork", "FixationWorkId");

                    b.HasOne("RoadDefectsService.Core.Domain.Models.TaskEntity", "PrevTask")
                        .WithOne()
                        .HasForeignKey("RoadDefectsService.Core.Domain.Models.TaskFixationWork", "PrevTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FixationWork");

                    b.Navigation("PrevTask");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.FixationDefect", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.FixationWork", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("TaskFixationWork");
                });

            modelBuilder.Entity("RoadDefectsService.Core.Domain.Models.RoadInspector", b =>
                {
                    b.Navigation("AppointedTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
