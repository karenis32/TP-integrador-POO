namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arregloTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clinicas", newName: "Clínica");
            RenameTable(name: "dbo.Directors", newName: "Director");
            RenameTable(name: "dbo.Enfermeroes", newName: "Enfermero");
            RenameTable(name: "dbo.Habitacions", newName: "Habitación");
            RenameTable(name: "dbo.Medicos", newName: "Medico");
            RenameTable(name: "dbo.Pacientes", newName: "Paciente");
            AlterColumn("dbo.Clínica", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Clínica", "Domicilio", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Clínica", "Telefono", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "Especialidad", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "PostGrado", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "Domicilio", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "Telefono", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Director", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermero", "CUIL", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermero", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermero", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermero", "Domicilio", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermero", "Telefono", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermero", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Habitación", "Estado", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Especialidad", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Domicilio", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Telefono", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Paciente", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Paciente", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Paciente", "Domicilio", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Paciente", "Telefono", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Paciente", "Email", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Paciente", "Email", c => c.String());
            AlterColumn("dbo.Paciente", "Telefono", c => c.String());
            AlterColumn("dbo.Paciente", "Domicilio", c => c.String());
            AlterColumn("dbo.Paciente", "Apellido", c => c.String());
            AlterColumn("dbo.Paciente", "Nombre", c => c.String());
            AlterColumn("dbo.Medico", "Email", c => c.String());
            AlterColumn("dbo.Medico", "Telefono", c => c.String());
            AlterColumn("dbo.Medico", "Domicilio", c => c.String());
            AlterColumn("dbo.Medico", "Apellido", c => c.String());
            AlterColumn("dbo.Medico", "Nombre", c => c.String());
            AlterColumn("dbo.Medico", "Especialidad", c => c.String());
            AlterColumn("dbo.Habitación", "Estado", c => c.String());
            AlterColumn("dbo.Enfermero", "Email", c => c.String());
            AlterColumn("dbo.Enfermero", "Telefono", c => c.String());
            AlterColumn("dbo.Enfermero", "Domicilio", c => c.String());
            AlterColumn("dbo.Enfermero", "Apellido", c => c.String());
            AlterColumn("dbo.Enfermero", "Nombre", c => c.String());
            AlterColumn("dbo.Enfermero", "CUIL", c => c.String());
            AlterColumn("dbo.Director", "Email", c => c.String());
            AlterColumn("dbo.Director", "Telefono", c => c.String());
            AlterColumn("dbo.Director", "Domicilio", c => c.String());
            AlterColumn("dbo.Director", "Apellido", c => c.String());
            AlterColumn("dbo.Director", "Nombre", c => c.String());
            AlterColumn("dbo.Director", "PostGrado", c => c.String());
            AlterColumn("dbo.Director", "Especialidad", c => c.String());
            AlterColumn("dbo.Clínica", "Telefono", c => c.String());
            AlterColumn("dbo.Clínica", "Domicilio", c => c.String());
            AlterColumn("dbo.Clínica", "Nombre", c => c.String());
            RenameTable(name: "dbo.Paciente", newName: "Pacientes");
            RenameTable(name: "dbo.Medico", newName: "Medicos");
            RenameTable(name: "dbo.Habitación", newName: "Habitacions");
            RenameTable(name: "dbo.Enfermero", newName: "Enfermeroes");
            RenameTable(name: "dbo.Director", newName: "Directors");
            RenameTable(name: "dbo.Clínica", newName: "Clinicas");
        }
    }
}
