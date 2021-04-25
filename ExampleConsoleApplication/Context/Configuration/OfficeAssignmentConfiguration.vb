Imports ExampleConsoleApplication.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Namespace Context.Configuration
	Public Class OfficeAssignmentConfiguration
		Implements IEntityTypeConfiguration(Of OfficeAssignment)

		Public Sub Configure(builder As EntityTypeBuilder(Of OfficeAssignment)) Implements IEntityTypeConfiguration(Of OfficeAssignment).Configure
			builder.HasKey(Function(e) e.InstructorID)
			builder.ToTable("OfficeAssignment")
			builder.Property(Function(e) e.InstructorID).ValueGeneratedNever()
			builder.Property(Function(e) e.Location).IsRequired().HasMaxLength(50)
			builder.Property(Function(e) e.Timestamp).IsRequired().IsRowVersion().IsConcurrencyToken()
			builder.HasOne(Function(d) d.Instructor).WithOne(Function(p) p.OfficeAssignment).HasForeignKey(Of OfficeAssignment)(Function(d) d.InstructorID).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_OfficeAssignment_Person")
		End Sub
	End Class
End Namespace
