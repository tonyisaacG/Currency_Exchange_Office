using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Currency_Exchange_Office.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_parCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Client_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_phoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_money = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Client_id);
                    table.CheckConstraint("client_account_ch", "Client_money >= 0");
                });

            migrationBuilder.CreateTable(
                name: "CReceviers",
                columns: table => new
                {
                    CR_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CR_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CR_phoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CReceviers", x => x.CR_id);
                });

            migrationBuilder.CreateTable(
                name: "Traders",
                columns: table => new
                {
                    Tad_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tad_parCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tad_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tad_phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.Tad_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Desposits",
                columns: table => new
                {
                    Despt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Despt_money_prv = table.Column<decimal>(type: "money", nullable: false),
                    Despt_money_add = table.Column<decimal>(type: "money", nullable: false),
                    Despt_money_now = table.Column<decimal>(type: "money", nullable: false),
                    Despt_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desposits", x => x.Despt_id);
                    table.CheckConstraint("Despt_amount_add_ch", "Despt_money_add > 0");
                    table.CheckConstraint("Despt_amount_now_ch", "Despt_money_now > 0");
                    table.CheckConstraint("Despt_amount_prv_ch", "Despt_money_prv > 0");
                    table.CheckConstraint("Despt_date_ch", "Despt_date >= getdate()");
                    table.ForeignKey(
                        name: "FK_Desposits_Clients_Client_id",
                        column: x => x.Client_id,
                        principalTable: "Clients",
                        principalColumn: "Client_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Withdrawals",
                columns: table => new
                {
                    Withd_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Withd_money = table.Column<decimal>(type: "money", nullable: false),
                    Withd_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Withdrawals", x => x.Withd_id);
                    table.ForeignKey(
                        name: "FK_Withdrawals_Clients_Client_id",
                        column: x => x.Client_id,
                        principalTable: "Clients",
                        principalColumn: "Client_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Financal_Transactions",
                columns: table => new
                {
                    FT_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FT_amount = table.Column<decimal>(type: "money", nullable: false),
                    FT_tranferedAmount = table.Column<decimal>(type: "money", nullable: false),
                    FT_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FT_transferType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FT_currencyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FT_exchangeRate = table.Column<decimal>(type: "money", nullable: false),
                    FT_countery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRecevier_id = table.Column<int>(type: "int", nullable: false),
                    Client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financal_Transactions", x => x.FT_id);
                    table.CheckConstraint("FT_amount_ch", "FT_amount>=0");
                    table.CheckConstraint("FT_date_ch", "FT_date >= getdate()");
                    table.CheckConstraint("FT_exchangeRate_ch", "FT_exchangeRate>=0");
                    table.CheckConstraint("FT_transeredAmount_ch", "FT_tranferedAmount>=0");
                    table.ForeignKey(
                        name: "FK_Financal_Transactions_Clients_Client_id",
                        column: x => x.Client_id,
                        principalTable: "Clients",
                        principalColumn: "Client_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Financal_Transactions_CReceviers_CRecevier_id",
                        column: x => x.CRecevier_id,
                        principalTable: "CReceviers",
                        principalColumn: "CR_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales_Vouchers",
                columns: table => new
                {
                    SaV_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaV_paymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaV_Quantity = table.Column<decimal>(type: "money", nullable: false),
                    SaV_currencyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaV_transeferPrice = table.Column<decimal>(type: "money", nullable: false),
                    SaV_totalAmount = table.Column<decimal>(type: "money", nullable: false),
                    SaV_CostPrice = table.Column<decimal>(type: "money", nullable: false),
                    SaV_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trader_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Vouchers", x => x.SaV_id);
                    table.ForeignKey(
                        name: "FK_Sales_Vouchers_Traders_Trader_id",
                        column: x => x.Trader_id,
                        principalTable: "Traders",
                        principalColumn: "Tad_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shopping_Vouchers",
                columns: table => new
                {
                    ShV_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShV_paymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShV_Quantity = table.Column<decimal>(type: "money", nullable: false),
                    ShV_currencyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShV_transeferPrice = table.Column<decimal>(type: "money", nullable: false),
                    ShV_totalAmount = table.Column<decimal>(type: "money", nullable: false),
                    ShV_CostPrice = table.Column<decimal>(type: "money", nullable: false),
                    ShV_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trader_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopping_Vouchers", x => x.ShV_id);
                    table.ForeignKey(
                        name: "FK_Shopping_Vouchers_Traders_Trader_id",
                        column: x => x.Trader_id,
                        principalTable: "Traders",
                        principalColumn: "Tad_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Client_parCode",
                table: "Clients",
                column: "Client_parCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desposits_Client_id",
                table: "Desposits",
                column: "Client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Financal_Transactions_Client_id",
                table: "Financal_Transactions",
                column: "Client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Financal_Transactions_CRecevier_id",
                table: "Financal_Transactions",
                column: "CRecevier_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Vouchers_Trader_id",
                table: "Sales_Vouchers",
                column: "Trader_id");

            migrationBuilder.CreateIndex(
                name: "IX_Shopping_Vouchers_Trader_id",
                table: "Shopping_Vouchers",
                column: "Trader_id");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_Tad_parCode",
                table: "Traders",
                column: "Tad_parCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Withdrawals_Client_id",
                table: "Withdrawals",
                column: "Client_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desposits");

            migrationBuilder.DropTable(
                name: "Financal_Transactions");

            migrationBuilder.DropTable(
                name: "Sales_Vouchers");

            migrationBuilder.DropTable(
                name: "Shopping_Vouchers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Withdrawals");

            migrationBuilder.DropTable(
                name: "CReceviers");

            migrationBuilder.DropTable(
                name: "Traders");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
