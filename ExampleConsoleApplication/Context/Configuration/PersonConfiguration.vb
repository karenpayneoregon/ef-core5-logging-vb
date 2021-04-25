Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders
Imports Person = ExampleConsoleApplication.Models.Person

Namespace Context.Configuration
	Public Class PersonConfiguration
		Implements IEntityTypeConfiguration(Of Person)

		Public Sub Configure(ByVal entity As EntityTypeBuilder(Of Person)) Implements IEntityTypeConfiguration(Of Person).Configure
			entity.ToTable("Person")

			entity.Property(Function(e) e.Discriminator).IsRequired().HasMaxLength(50)

			entity.Property(Function(e) e.EnrollmentDate).HasColumnType("datetime").HasAnnotation("Relational:ColumnType", "datetime")

			entity.Property(Function(e) e.FirstName).IsRequired().HasMaxLength(50)

			entity.Property(Function(e) e.HireDate).HasColumnType("datetime").HasAnnotation("Relational:ColumnType", "datetime")

			entity.Property(Function(e) e.LastName).IsRequired().HasMaxLength(50)
		End Sub


	End Class
End Namespace
