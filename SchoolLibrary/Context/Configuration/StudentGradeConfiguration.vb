Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders
Imports SchoolLibrary.Models

Namespace Context.Configuration
	Public Class StudentGradeConfiguration
		Implements IEntityTypeConfiguration(Of StudentGrade)

		Public Sub Configure(ByVal entity As EntityTypeBuilder(Of StudentGrade)) Implements IEntityTypeConfiguration(Of StudentGrade).Configure

			entity.HasKey(Function(e) e.EnrollmentID)

			entity.ToTable("StudentGrade")

			entity.Property(Function(e) e.Grade).
				HasColumnType("decimal(3, 2)").
				HasAnnotation("Relational:ColumnType", "decimal(3, 2)")

			entity.HasOne(Function(d) d.Course).
				WithMany(Function(p) p.StudentGrades).
				HasForeignKey(Function(d) d.CourseID).
				OnDelete(DeleteBehavior.ClientSetNull).
				HasConstraintName("FK_StudentGrade_Course")

			entity.HasOne(Function(d) d.Student).
				WithMany(Function(p) p.StudentGrades).
				HasForeignKey(Function(d) d.StudentID).
				OnDelete(DeleteBehavior.ClientSetNull).
				HasConstraintName("FK_StudentGrade_Student")

		End Sub

	End Class
End Namespace
