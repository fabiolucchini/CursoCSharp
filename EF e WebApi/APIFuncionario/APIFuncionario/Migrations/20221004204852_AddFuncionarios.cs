using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFuncionario.Migrations
{
    public partial class AddFuncionarios : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Funcionarios(Nome) Values('Fabio')");
            mb.Sql("Insert into Funcionarios(Nome) Values('Roberto')");
            mb.Sql("Insert into Funcionarios(Nome) Values('Aline')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Funcionarios");
        }
    }
}
