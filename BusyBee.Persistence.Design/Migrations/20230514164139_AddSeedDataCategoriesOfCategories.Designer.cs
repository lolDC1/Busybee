﻿// <auto-generated />
using System;
using BusyBee.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BusyBee.Persistence.Design.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230514164139_AddSeedDataCategoriesOfCategories")]
    partial class AddSeedDataCategoriesOfCategories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BusyBee.Core.Entities.CategoryOfCategories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("IconFilename")
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("CategoriesOfCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            IconFilename = "category_icon_dim.svg",
                            Title = "Дім"
                        },
                        new
                        {
                            Id = new Guid("ef5ed6a2-3fda-4307-97a5-e6600d8e1c52"),
                            IconFilename = "category_icon_domashniy_master.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Домашній майстер"
                        },
                        new
                        {
                            Id = new Guid("ba194614-fdc8-4830-bde0-647532e7da46"),
                            IconFilename = "category_icon_cliningovi_poslugi.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Клінінгові послуги"
                        },
                        new
                        {
                            Id = new Guid("2ff6ac44-616c-491e-99a4-184b12719b35"),
                            IconFilename = "category_icon_ozdoblyvalni_roboti.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Оздоблювальні роботи"
                        },
                        new
                        {
                            Id = new Guid("59e69eb2-b25d-40fa-ae1b-2e131e5ee44b"),
                            IconFilename = "category_icon_remont_texniki.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Ремонт техніки"
                        },
                        new
                        {
                            Id = new Guid("413efb83-bd36-425d-a5e4-0b9d13888d7b"),
                            IconFilename = "category_icon_budivelni_roboti.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Будівельні роботи"
                        },
                        new
                        {
                            Id = new Guid("7f86e643-cadd-4dea-9a76-22987ec2667b"),
                            IconFilename = "category_icon_pobutovi_poslugi.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Побутові послуги"
                        },
                        new
                        {
                            Id = new Guid("ba72f604-2c3f-42a1-9838-8a4ab3e4f9be"),
                            IconFilename = "category_icon_poslugi_dlya_tvarin.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Послуги для тварин"
                        },
                        new
                        {
                            Id = new Guid("a518d3c3-2fe5-4746-a4e5-e59ea9607ee0"),
                            IconFilename = "category_icon_meblevi_roboti.svg",
                            ParentId = new Guid("08f60624-5d16-4fff-9d2a-004a2087d0e6"),
                            Title = "Меблеві роботи"
                        },
                        new
                        {
                            Id = new Guid("443f7547-3a93-438b-b6d5-7f5cac0a3e13"),
                            IconFilename = "category_icon_dostavka.svg",
                            Title = "Доставка"
                        },
                        new
                        {
                            Id = new Guid("b1423856-84b3-49ad-9ff1-57fd45e2d8d4"),
                            IconFilename = "category_icon_kurerski_poslugi.svg",
                            ParentId = new Guid("443f7547-3a93-438b-b6d5-7f5cac0a3e13"),
                            Title = "Кур'єрські послуги"
                        },
                        new
                        {
                            Id = new Guid("2d2dc17a-abfd-4e1c-ab88-b8dc7e72dfe8"),
                            IconFilename = "category_icon_transportni_skladski_poslugi.svg",
                            ParentId = new Guid("443f7547-3a93-438b-b6d5-7f5cac0a3e13"),
                            Title = "Транспортні та складські послуги"
                        },
                        new
                        {
                            Id = new Guid("e08a3dc0-c504-45ee-b5db-fd20c60c5dd4"),
                            IconFilename = "category_icon_frilans.svg",
                            Title = "Фріланс"
                        },
                        new
                        {
                            Id = new Guid("09696c51-d66a-4e9c-a830-ec4518419b1f"),
                            IconFilename = "category_icon_robota_v_interneti.svg",
                            ParentId = new Guid("e08a3dc0-c504-45ee-b5db-fd20c60c5dd4"),
                            Title = "Робота в Інтернеті"
                        },
                        new
                        {
                            Id = new Guid("00b3cc7c-7f0e-4061-a7e7-eec8e8d98972"),
                            IconFilename = "category_icon_rozrobka_saitiv_i_dodtkiv.svg",
                            ParentId = new Guid("e08a3dc0-c504-45ee-b5db-fd20c60c5dd4"),
                            Title = "Розробка сайтів та додатків"
                        },
                        new
                        {
                            Id = new Guid("1ecb5ad5-a310-498a-b354-3dd515b665dd"),
                            IconFilename = "category_icon_design.svg",
                            ParentId = new Guid("e08a3dc0-c504-45ee-b5db-fd20c60c5dd4"),
                            Title = "Дизайн"
                        },
                        new
                        {
                            Id = new Guid("e6f62be5-4676-41f6-91cc-b4f8b035503d"),
                            IconFilename = "category_icon_reklama_v_interneti.svg",
                            ParentId = new Guid("e08a3dc0-c504-45ee-b5db-fd20c60c5dd4"),
                            Title = "Реклама в Інтернеті"
                        },
                        new
                        {
                            Id = new Guid("17ad73db-4fd7-4dd1-a26a-b049a69a1606"),
                            IconFilename = "category_icon_vikladachi.svg",
                            Title = "Викладачі"
                        },
                        new
                        {
                            Id = new Guid("104dda7e-6050-4a3b-b58c-64ba8f77cd20"),
                            IconFilename = "category_icon_poslugi_repetitoriv.svg",
                            ParentId = new Guid("17ad73db-4fd7-4dd1-a26a-b049a69a1606"),
                            Title = "Послуги репетиторів"
                        },
                        new
                        {
                            Id = new Guid("1252db5f-d58b-4dbf-9f27-aadfa481f559"),
                            IconFilename = "category_icon_poslugi_treneriv.svg",
                            ParentId = new Guid("17ad73db-4fd7-4dd1-a26a-b049a69a1606"),
                            Title = "Послуги тренерів"
                        },
                        new
                        {
                            Id = new Guid("0afc549d-c57c-48e5-aa35-de0000bb7179"),
                            IconFilename = "category_icon_buro_perekladiv.svg",
                            ParentId = new Guid("17ad73db-4fd7-4dd1-a26a-b049a69a1606"),
                            Title = "Бюро перекладів"
                        },
                        new
                        {
                            Id = new Guid("c9a09ee1-56b8-43f0-9f2a-51b1f05b8a3e"),
                            IconFilename = "category_icon_bisnes.svg",
                            Title = "Бізнес"
                        },
                        new
                        {
                            Id = new Guid("24456e3a-5c01-4e14-9d99-7277c9676f08"),
                            IconFilename = "category_icon_dilovi_poslugi.svg",
                            ParentId = new Guid("c9a09ee1-56b8-43f0-9f2a-51b1f05b8a3e"),
                            Title = "Ділові послуги"
                        },
                        new
                        {
                            Id = new Guid("8d894f67-5f26-43a6-8984-5fdd6628d7fa"),
                            Title = "Iнше"
                        },
                        new
                        {
                            Id = new Guid("3ed80317-e242-4804-afdf-20dd8ffc1414"),
                            IconFilename = "category_icon_volonterska_dopomoga.svg",
                            ParentId = new Guid("8d894f67-5f26-43a6-8984-5fdd6628d7fa"),
                            Title = "Волонтерська допомога"
                        },
                        new
                        {
                            Id = new Guid("36c0821a-9317-4456-ad19-8aa73a805453"),
                            IconFilename = "category_icon_photo_i_video.svg",
                            ParentId = new Guid("8d894f67-5f26-43a6-8984-5fdd6628d7fa"),
                            Title = "Фото- і відео-послуги"
                        },
                        new
                        {
                            Id = new Guid("25bafeec-da51-46e5-a160-9596e6aad7b6"),
                            IconFilename = "category_icon_organizacia_sviat.svg",
                            ParentId = new Guid("8d894f67-5f26-43a6-8984-5fdd6628d7fa"),
                            Title = "Організація свят"
                        },
                        new
                        {
                            Id = new Guid("39196572-1e31-4cdd-bcee-b42fd0922dd4"),
                            IconFilename = "category_icon_poslugi_krasi_i_zdorovia.svg",
                            ParentId = new Guid("8d894f67-5f26-43a6-8984-5fdd6628d7fa"),
                            Title = "Послуги краси і здоров'я"
                        },
                        new
                        {
                            Id = new Guid("8183db09-7cfe-4017-89b9-6f40f45119ee"),
                            IconFilename = "category_icon_remont_avto.svg",
                            ParentId = new Guid("8d894f67-5f26-43a6-8984-5fdd6628d7fa"),
                            Title = "Ремонт авто"
                        });
                });

            modelBuilder.Entity("BusyBee.Core.Entities.CategoryOfTasks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("IconFilename")
                        .HasColumnType("text");

                    b.Property<Guid?>("OrderAddressDataTemplateId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PaymentDataTemplateId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrderAddressDataTemplateId");

                    b.HasIndex("ParentId");

                    b.HasIndex("PaymentDataTemplateId");

                    b.ToTable("CategoriesOfTasks");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("EstimatedCost")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("DataTemplates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cd081f14-3b0d-4d49-9aea-d3cb1fe379d8"),
                            EstimatedCost = 0.0
                        },
                        new
                        {
                            Id = new Guid("7cfc38e6-97fc-41d6-a267-0e160c2d2fba"),
                            EstimatedCost = 0.0
                        });
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplateItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DataTemplateId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DataTemplateId");

                    b.ToTable("DataTemplateItems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90883a11-4a54-4c3e-b574-4b1d033c391d"),
                            DataTemplateId = new Guid("cd081f14-3b0d-4d49-9aea-d3cb1fe379d8"),
                            Title = "Адрес",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("0d6701ca-8e30-4105-a9f8-6485b02eaffa"),
                            DataTemplateId = new Guid("7cfc38e6-97fc-41d6-a267-0e160c2d2fba"),
                            Title = "От",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("1f7dcab2-0c35-47c5-b433-f2334c1ede08"),
                            DataTemplateId = new Guid("7cfc38e6-97fc-41d6-a267-0e160c2d2fba"),
                            Title = "До",
                            Type = 0
                        });
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplateItemValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("AddedMoney")
                        .HasColumnType("integer");

                    b.Property<Guid>("DataTemplateItemId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DataTemplateItemId");

                    b.ToTable("DataTemplateItemValues");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConfidentialInfo")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.TaskDataTemplateItemValue", b =>
                {
                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DataTemplateItemId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DataTemplateItemValueId")
                        .HasColumnType("uuid");

                    b.HasKey("TaskId", "DataTemplateItemId", "DataTemplateItemValueId");

                    b.HasIndex("DataTemplateItemId");

                    b.HasIndex("DataTemplateItemValueId");

                    b.ToTable("TaskDataTemplateItemValues");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.TaskDataValue", b =>
                {
                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DataTemplateItemId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TaskId", "DataTemplateItemId");

                    b.HasIndex("DataTemplateItemId");

                    b.ToTable("TaskDataValues");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.CategoryOfCategories", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.CategoryOfCategories", "Parent")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.CategoryOfTasks", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.DataTemplate", "OrderAddressDataTemplate")
                        .WithMany()
                        .HasForeignKey("OrderAddressDataTemplateId");

                    b.HasOne("BusyBee.Core.Entities.CategoryOfCategories", "Parent")
                        .WithMany("CategoriesOfTasks")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusyBee.Core.Entities.DataTemplate", "PaymentDataTemplate")
                        .WithMany()
                        .HasForeignKey("PaymentDataTemplateId");

                    b.Navigation("OrderAddressDataTemplate");

                    b.Navigation("Parent");

                    b.Navigation("PaymentDataTemplate");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplateItem", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.DataTemplate", "DataTemplate")
                        .WithMany("DataTemplateItems")
                        .HasForeignKey("DataTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTemplate");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplateItemValue", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.DataTemplateItem", "DataTemplateItem")
                        .WithMany("DataTemplateAdditional")
                        .HasForeignKey("DataTemplateItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTemplateItem");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.Task", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.CategoryOfTasks", "CategoryOfTasks")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryOfTasks");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.TaskDataTemplateItemValue", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.DataTemplateItem", "DataTemplateItem")
                        .WithMany()
                        .HasForeignKey("DataTemplateItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusyBee.Core.Entities.DataTemplateItemValue", "DataTemplateItemValue")
                        .WithMany()
                        .HasForeignKey("DataTemplateItemValueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusyBee.Core.Entities.Task", "Task")
                        .WithMany("TaskDataTemplateItemValues")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTemplateItem");

                    b.Navigation("DataTemplateItemValue");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.TaskDataValue", b =>
                {
                    b.HasOne("BusyBee.Core.Entities.DataTemplateItem", "DataTemplateItem")
                        .WithMany()
                        .HasForeignKey("DataTemplateItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusyBee.Core.Entities.Task", "Task")
                        .WithMany("TaskDataValues")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTemplateItem");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.CategoryOfCategories", b =>
                {
                    b.Navigation("CategoriesOfTasks");

                    b.Navigation("ChildCategories");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.CategoryOfTasks", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplate", b =>
                {
                    b.Navigation("DataTemplateItems");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.DataTemplateItem", b =>
                {
                    b.Navigation("DataTemplateAdditional");
                });

            modelBuilder.Entity("BusyBee.Core.Entities.Task", b =>
                {
                    b.Navigation("TaskDataTemplateItemValues");

                    b.Navigation("TaskDataValues");
                });
#pragma warning restore 612, 618
        }
    }
}
