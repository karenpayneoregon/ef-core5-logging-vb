Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class OnsiteCourseConfiguration
		Implements IEntityTypeConfiguration(Of OnsiteCourse)

		Public Sub Configure(ByVal entity As EntityTypeBuilder(Of OnsiteCourse)) Implements IEntityTypeConfiguration(Of OnsiteCourse).Configure

			entity.HasKey(Function(e) e.CourseID)

			entity.ToTable("OnsiteCourse")

			entity.Property(Function(e) e.CourseID).
				ValueGeneratedNever()

			entity.Property(Function(e) e.Days).IsRequired().
				HasMaxLength(50)

			entity.Property(Function(e) e.Location).
				IsRequired().
				HasMaxLength(50)

			entity.Property(Function(e) e.Time).
				HasColumnType("smalldatetime").
				HasAnnotation("Relational:ColumnType", "smalldatetime")

			entity.HasOne(Function(d) d.Course).
				WithOne(Function(p) p.OnsiteCourse).
				HasForeignKey(Of OnsiteCourse)(Function(d) d.CourseID).
				OnDelete(DeleteBehavior.ClientSetNull).
				HasConstraintName("FK_OnsiteCourse_Course")

		End Sub

	End Class
End Namespace
