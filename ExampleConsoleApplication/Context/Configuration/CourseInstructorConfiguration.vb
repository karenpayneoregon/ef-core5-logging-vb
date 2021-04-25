Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class CourseInstructorConfiguration
		Implements IEntityTypeConfiguration(Of CourseInstructor)

		Public Sub Configure(builder As EntityTypeBuilder(Of CourseInstructor)) Implements IEntityTypeConfiguration(Of CourseInstructor).Configure

			builder.HasKey(Function(e) New With {Key e.CourseID, Key e.PersonID})

			builder.ToTable("CourseInstructor")

			builder.HasOne(Function(d) d.Course).
				WithMany(Function(p) p.CourseInstructors).
				HasForeignKey(Function(d) d.CourseID).
				OnDelete(DeleteBehavior.ClientSetNull).
				HasConstraintName("FK_CourseInstructor_Course")

			builder.HasOne(Function(d) d.Person).
				WithMany(Function(p) p.CourseInstructors).
				HasForeignKey(Function(d) d.PersonID).
				OnDelete(DeleteBehavior.ClientSetNull).
				HasConstraintName("FK_CourseInstructor_Person")

		End Sub
	End Class
End Namespace
