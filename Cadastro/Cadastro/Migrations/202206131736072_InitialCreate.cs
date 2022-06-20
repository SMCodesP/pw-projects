namespace Cadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Endereco = c.String(nullable: false, maxLength: 80),
                        CPF = c.String(nullable: false, maxLength: 14),
                        Email = c.String(nullable: false, maxLength: 70),
                        DataNascimento = c.DateTime(nullable: false),
                        RM = c.String(nullable: false, maxLength: 9),
                        Celular = c.String(nullable: false, maxLength: 15),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alunoes");
        }
    }
}
