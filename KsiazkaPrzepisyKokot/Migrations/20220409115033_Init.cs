using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KsiazkaPrzepisyKokot.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    idLog = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    login = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    haslo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    imie = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    nazwisko = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.idLog);
                });

            migrationBuilder.CreateTable(
                name: "Przepisy",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Przepis = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    nazwaDania = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    czas = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    liczbaPorcji = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przepisy", x => x.idPrzepisu);
                });

            migrationBuilder.CreateTable(
                name: "WszystkieSkladniki",
                columns: table => new
                {
                    idWszystkieSkladniki = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    skladnik = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    lyzka_kcal = table.Column<double>(type: "REAL", nullable: true),
                    lyzeczka_kcal = table.Column<double>(type: "REAL", nullable: true),
                    gram_kcal = table.Column<double>(type: "REAL", nullable: true),
                    szklanka_kcal = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WszystkieSkladniki", x => x.idWszystkieSkladniki);
                });

            migrationBuilder.CreateTable(
                name: "Ciasta",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    drozdzowe = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_zimno = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_cieplo = table.Column<bool>(type: "INTEGER", nullable: false),
                    ciasto_francuskie = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_owsianka = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_owocami = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciasta", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Ciasta_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinki",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    wodka = table.Column<bool>(type: "INTEGER", nullable: false),
                    whisky = table.Column<bool>(type: "INTEGER", nullable: false),
                    rum = table.Column<bool>(type: "INTEGER", nullable: false),
                    yager = table.Column<bool>(type: "INTEGER", nullable: false),
                    bezalkoholowy = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinki", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Drinki_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fit",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    z_owsianka = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_jogurtem = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_owocami = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_kasza = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_ryzem = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fit", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Fit_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kolacje",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    na_slono = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_slodko = table.Column<bool>(type: "INTEGER", nullable: false),
                    fit = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolacje", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Kolacje_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obiady",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    z_kurczakiem = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_wolowina = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_wieprzowina = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_mielonym = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_makaronem = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_ryzem = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_kartoflami = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obiady", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Obiady_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salatki",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    z_kurczakiem = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_cieplo = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_zimno = table.Column<bool>(type: "INTEGER", nullable: false),
                    z_makaronem = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salatki", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Salatki_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slone_przekaski",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    na_zimno = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_cieplo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slone_przekaski", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Slone_przekaski_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sniadania",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    z_jajkiem = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_slono = table.Column<bool>(type: "INTEGER", nullable: false),
                    na_slodko = table.Column<bool>(type: "INTEGER", nullable: false),
                    fit = table.Column<bool>(type: "INTEGER", nullable: false),
                    bez_miesa = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sniadania", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Sniadania_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sosy",
                columns: table => new
                {
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    slone = table.Column<bool>(type: "INTEGER", nullable: false),
                    slodkie = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sosy", x => x.idPrzepisu);
                    table.ForeignKey(
                        name: "FK_Sosy_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ulubione",
                columns: table => new
                {
                    idUlubione = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idPrzepis = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulubione", x => x.idUlubione);
                    table.ForeignKey(
                        name: "FK_Ulubione_Przepisy_idPrzepis",
                        column: x => x.idPrzepis,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkladnikiPrzepisu",
                columns: table => new
                {
                    idSkladnika = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idWszystkieSkladniki = table.Column<int>(type: "INTEGER", nullable: false),
                    idPrzepisu = table.Column<int>(type: "INTEGER", nullable: false),
                    jaka_miara = table.Column<string>(type: "TEXT", nullable: false),
                    ilosc = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkladnikiPrzepisu", x => x.idSkladnika);
                    table.ForeignKey(
                        name: "FK_SkladnikiPrzepisu_Przepisy_idPrzepisu",
                        column: x => x.idPrzepisu,
                        principalTable: "Przepisy",
                        principalColumn: "idPrzepisu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkladnikiPrzepisu_WszystkieSkladniki_idWszystkieSkladniki",
                        column: x => x.idWszystkieSkladniki,
                        principalTable: "WszystkieSkladniki",
                        principalColumn: "idWszystkieSkladniki",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkladnikiPrzepisu_idPrzepisu",
                table: "SkladnikiPrzepisu",
                column: "idPrzepisu");

            migrationBuilder.CreateIndex(
                name: "IX_SkladnikiPrzepisu_idWszystkieSkladniki",
                table: "SkladnikiPrzepisu",
                column: "idWszystkieSkladniki");

            migrationBuilder.CreateIndex(
                name: "IX_Ulubione_idPrzepis",
                table: "Ulubione",
                column: "idPrzepis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciasta");

            migrationBuilder.DropTable(
                name: "Drinki");

            migrationBuilder.DropTable(
                name: "Fit");

            migrationBuilder.DropTable(
                name: "Kolacje");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Obiady");

            migrationBuilder.DropTable(
                name: "Salatki");

            migrationBuilder.DropTable(
                name: "SkladnikiPrzepisu");

            migrationBuilder.DropTable(
                name: "Slone_przekaski");

            migrationBuilder.DropTable(
                name: "Sniadania");

            migrationBuilder.DropTable(
                name: "Sosy");

            migrationBuilder.DropTable(
                name: "Ulubione");

            migrationBuilder.DropTable(
                name: "WszystkieSkladniki");

            migrationBuilder.DropTable(
                name: "Przepisy");
        }
    }
}
