using Microsoft.EntityFrameworkCore.Migrations;

namespace PierreSSTreat.Migrations
{
    public partial class CorrectTabels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTag_Tags_FlavorId",
                table: "RecipeTag");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTag_Recipes_TreatId",
                table: "RecipeTag");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_UserId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeTag",
                table: "RecipeTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Flavors");

            migrationBuilder.RenameTable(
                name: "RecipeTag",
                newName: "FlavorTreat");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Treats");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_UserId",
                table: "Flavors",
                newName: "IX_Flavors_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeTag_TreatId",
                table: "FlavorTreat",
                newName: "IX_FlavorTreat_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeTag_FlavorId",
                table: "FlavorTreat",
                newName: "IX_FlavorTreat_FlavorId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_UserId",
                table: "Treats",
                newName: "IX_Treats_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors",
                column: "FlavorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorTreat",
                table: "FlavorTreat",
                column: "FlavorTreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treats",
                table: "Treats",
                column: "TreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treats",
                table: "Treats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorTreat",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "Treats",
                newName: "Recipes");

            migrationBuilder.RenameTable(
                name: "FlavorTreat",
                newName: "RecipeTag");

            migrationBuilder.RenameTable(
                name: "Flavors",
                newName: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_Treats_UserId",
                table: "Recipes",
                newName: "IX_Recipes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreat_TreatId",
                table: "RecipeTag",
                newName: "IX_RecipeTag_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreat_FlavorId",
                table: "RecipeTag",
                newName: "IX_RecipeTag_FlavorId");

            migrationBuilder.RenameIndex(
                name: "IX_Flavors_UserId",
                table: "Tags",
                newName: "IX_Tags_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "TreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeTag",
                table: "RecipeTag",
                column: "FlavorTreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTag_Tags_FlavorId",
                table: "RecipeTag",
                column: "FlavorId",
                principalTable: "Tags",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTag_Recipes_TreatId",
                table: "RecipeTag",
                column: "TreatId",
                principalTable: "Recipes",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_UserId",
                table: "Tags",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
