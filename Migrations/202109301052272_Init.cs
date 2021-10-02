namespace k2_CodeFirstWithMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentLessons",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false),
                        LessonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DepartmentID, t.LessonID })
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Lessons", t => t.LessonID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.LessonID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        FacultyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Faculties", t => t.FacultyID, cascadeDelete: true)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyID = c.Int(nullable: false, identity: true),
                        FacultyName = c.String(),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Number = c.String(),
                        ConsultantTrainerID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        ConsultantTrainer_TrainerID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Trainers", t => t.ConsultantTrainer_TrainerID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.ConsultantTrainer_TrainerID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.TrainerID);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        LessonID = c.Int(nullable: false, identity: true),
                        LessonCode = c.String(),
                        LessonName = c.String(),
                        TrainerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LessonID)
                .ForeignKey("dbo.Trainers", t => t.TrainerID, cascadeDelete: true)
                .Index(t => t.TrainerID);
            
            CreateTable(
                "dbo.StudentLessons",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        LessonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.LessonID })
                .ForeignKey("dbo.Lessons", t => t.LessonID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.LessonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Students", "ConsultantTrainer_TrainerID", "dbo.Trainers");
            DropForeignKey("dbo.Lessons", "TrainerID", "dbo.Trainers");
            DropForeignKey("dbo.StudentLessons", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentLessons", "LessonID", "dbo.Lessons");
            DropForeignKey("dbo.DepartmentLessons", "LessonID", "dbo.Lessons");
            DropForeignKey("dbo.Departments", "FacultyID", "dbo.Faculties");
            DropForeignKey("dbo.DepartmentLessons", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.StudentLessons", new[] { "LessonID" });
            DropIndex("dbo.StudentLessons", new[] { "StudentID" });
            DropIndex("dbo.Lessons", new[] { "TrainerID" });
            DropIndex("dbo.Students", new[] { "ConsultantTrainer_TrainerID" });
            DropIndex("dbo.Students", new[] { "DepartmentID" });
            DropIndex("dbo.Departments", new[] { "FacultyID" });
            DropIndex("dbo.DepartmentLessons", new[] { "LessonID" });
            DropIndex("dbo.DepartmentLessons", new[] { "DepartmentID" });
            DropTable("dbo.StudentLessons");
            DropTable("dbo.Lessons");
            DropTable("dbo.Trainers");
            DropTable("dbo.Students");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.DepartmentLessons");
        }
    }
}
