Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class CourseConfiguration
		Implements IEntityTypeConfiguration(Of Course)

		Public Sub Configure(builder As EntityTypeBuilder(Of Course)) Implements IEntityTypeConfiguration(Of Course).Configure

			builder.ToTable("Course")

			builder.Property(Function(e) e.CourseID).ValueGeneratedNever()
			builder.Property(Function(e) e.Title).IsRequired().HasMaxLength(100)

			builder.HasOne(Function(d) d.Department).
				WithMany(Function(p) p.Courses).
				HasForeignKey(Function(d) d.DepartmentID).
				OnDelete(DeleteBehavior.ClientSetNull).
				HasConstraintName("FK_Course_Department")

		End Sub

	End Class
End Namespace
