﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace Currency_Exchange_Office.Migrations
{
    [DbContext(typeof(DbContextRepository))]
    [Migration("20230131142413_addData")]
    partial class addData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Client", b =>
                {
                    b.Property<int>("Client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Client_id"), 1L, 1);

                    b.Property<decimal>("Client_money")
                        .HasColumnType("money");

                    b.Property<string>("Client_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_parCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Client_phoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Client_id");

                    b.HasIndex("Client_parCode")
                        .IsUnique();

                    b.ToTable("Clients");

                    b.HasCheckConstraint("client_account_ch", "Client_money >= 0");
                });

            modelBuilder.Entity("Entities.CRecevier", b =>
                {
                    b.Property<int>("CR_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CR_id"), 1L, 1);

                    b.Property<string>("CR_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CR_phoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CR_id");

                    b.ToTable("CReceviers");
                });

            modelBuilder.Entity("Entities.Desposit", b =>
                {
                    b.Property<int>("Despt_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Despt_id"), 1L, 1);

                    b.Property<int>("Client_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Despt_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Despt_money_add")
                        .HasColumnType("money");

                    b.Property<decimal>("Despt_money_now")
                        .HasColumnType("money");

                    b.Property<decimal>("Despt_money_prv")
                        .HasColumnType("money");

                    b.HasKey("Despt_id");

                    b.HasIndex("Client_id");

                    b.ToTable("Desposits");

                    b.HasCheckConstraint("Despt_amount_add_ch", "Despt_money_add > 0");

                    b.HasCheckConstraint("Despt_amount_now_ch", "Despt_money_now > 0");

                    b.HasCheckConstraint("Despt_amount_prv_ch", "Despt_money_prv > 0");

                    b.HasCheckConstraint("Despt_date_ch", "Despt_date >= getdate()");
                });

            modelBuilder.Entity("Entities.Financal_Transaction", b =>
                {
                    b.Property<int>("FT_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FT_id"), 1L, 1);

                    b.Property<int>("CRecevier_id")
                        .HasColumnType("int");

                    b.Property<int>("Client_id")
                        .HasColumnType("int");

                    b.Property<decimal>("FT_amount")
                        .HasColumnType("money");

                    b.Property<string>("FT_countery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FT_currencyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FT_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FT_exchangeRate")
                        .HasColumnType("money");

                    b.Property<decimal>("FT_tranferedAmount")
                        .HasColumnType("money");

                    b.Property<string>("FT_transferType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FT_id");

                    b.HasIndex("CRecevier_id");

                    b.HasIndex("Client_id");

                    b.ToTable("Financal_Transactions");

                    b.HasCheckConstraint("FT_amount_ch", "FT_amount>=0");

                    b.HasCheckConstraint("FT_date_ch", "FT_date >= getdate()");

                    b.HasCheckConstraint("FT_exchangeRate_ch", "FT_exchangeRate>=0");

                    b.HasCheckConstraint("FT_transeredAmount_ch", "FT_tranferedAmount>=0");
                });

            modelBuilder.Entity("Entities.Sales_voucher", b =>
                {
                    b.Property<int>("SaV_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaV_id"), 1L, 1);

                    b.Property<decimal>("SaV_CostPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("SaV_Quantity")
                        .HasColumnType("money");

                    b.Property<string>("SaV_currencyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaV_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaV_paymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SaV_totalAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("SaV_transeferPrice")
                        .HasColumnType("money");

                    b.Property<int>("Trader_id")
                        .HasColumnType("int");

                    b.HasKey("SaV_id");

                    b.HasIndex("Trader_id");

                    b.ToTable("Sales_Vouchers");
                });

            modelBuilder.Entity("Entities.Shopping_Voucher", b =>
                {
                    b.Property<int>("ShV_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShV_id"), 1L, 1);

                    b.Property<decimal>("ShV_CostPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("ShV_Quantity")
                        .HasColumnType("money");

                    b.Property<string>("ShV_currencyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShV_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShV_paymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ShV_totalAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("ShV_transeferPrice")
                        .HasColumnType("money");

                    b.Property<int>("Trader_id")
                        .HasColumnType("int");

                    b.HasKey("ShV_id");

                    b.HasIndex("Trader_id");

                    b.ToTable("Shopping_Vouchers");
                });

            modelBuilder.Entity("Entities.Trader", b =>
                {
                    b.Property<int>("Tad_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tad_id"), 1L, 1);

                    b.Property<string>("Tad_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tad_parCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tad_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tad_id");

                    b.HasIndex("Tad_parCode")
                        .IsUnique();

                    b.ToTable("Traders");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"), 1L, 1);

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.withdrawal", b =>
                {
                    b.Property<int>("Withd_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Withd_id"), 1L, 1);

                    b.Property<int>("Client_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Withd_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Withd_money")
                        .HasColumnType("money");

                    b.HasKey("Withd_id");

                    b.HasIndex("Client_id");

                    b.ToTable("Withdrawals");
                });

            modelBuilder.Entity("Entities.Desposit", b =>
                {
                    b.HasOne("Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("Client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Entities.Financal_Transaction", b =>
                {
                    b.HasOne("Entities.CRecevier", "CRecevier")
                        .WithMany()
                        .HasForeignKey("CRecevier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("Client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CRecevier");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Entities.Sales_voucher", b =>
                {
                    b.HasOne("Entities.Trader", "Trader")
                        .WithMany()
                        .HasForeignKey("Trader_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trader");
                });

            modelBuilder.Entity("Entities.Shopping_Voucher", b =>
                {
                    b.HasOne("Entities.Trader", "Trader")
                        .WithMany()
                        .HasForeignKey("Trader_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trader");
                });

            modelBuilder.Entity("Entities.withdrawal", b =>
                {
                    b.HasOne("Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("Client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}