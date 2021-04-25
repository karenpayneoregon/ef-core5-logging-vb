Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class DepartmentConfiguration
		Implements IEntityTypeConfiguration(Of Department)

		Public Sub Configure(builder As EntityTypeBuilder(Of Department)) Implements IEntityTypeConfiguration(Of Department).Configure

			builder.ToTable("Department")

			builder.Property(Function(e) e.DepartmentID).
				ValueGeneratedNever()

			builder.Property(Function(e) e.Budget).
				HasColumnType("money").
				HasAnnotation("Relational:ColumnType", "money")

			builder.Property(Function(e) e.Name).
				IsRequired().
				HasMaxLength(50)

			builder.Property(Function(e) e.StartDate).
				HasColumnType("datetime").
				HasAnnotation("Relational:ColumnType", "datetime")

		End Sub
	End Class
End Namespace
