﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScriptManager.Infrastructure.Data;

#nullable disable

namespace ScriptManager.Infrastructure.Migrations
{
    [DbContext(typeof(ScriptManagerContext))]
    [Migration("20230212163629_MinorUpdateOnCampaign")]
    partial class MinorUpdateOnCampaign
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ScriptManager.Domain.CampaignAggregate.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScriptId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScriptId");

                    b.ToTable("Campaigns", (string)null);
                });

            modelBuilder.Entity("ScriptManager.Domain.ScriptAggregate.Script", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Scripts", (string)null);
                });

            modelBuilder.Entity("ScriptManager.Domain.CampaignAggregate.Campaign", b =>
                {
                    b.HasOne("ScriptManager.Domain.ScriptAggregate.Script", null)
                        .WithMany()
                        .HasForeignKey("ScriptId");
                });

            modelBuilder.Entity("ScriptManager.Domain.ScriptAggregate.Script", b =>
                {
                    b.OwnsMany("ScriptManager.Domain.ScriptAggregate.Entities.Question", "Questions", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<int>("CompanyId")
                                .HasColumnType("int");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("ScriptId")
                                .HasColumnType("int");

                            b1.Property<string>("Text")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Title")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("ScriptId");

                            b1.ToTable("Questions", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ScriptId");

                            b1.OwnsMany("ScriptManager.Domain.ScriptAggregate.Entities.Answer", "Answers", b2 =>
                                {
                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b2.Property<int>("Id"));

                                    b2.Property<int>("CompanyId")
                                        .HasColumnType("int");

                                    b2.Property<int>("QuestionId")
                                        .HasColumnType("int");

                                    b2.Property<string>("Text")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("Id");

                                    b2.HasIndex("QuestionId");

                                    b2.ToTable("Answers", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("QuestionId");
                                });

                            b1.Navigation("Answers");
                        });

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
