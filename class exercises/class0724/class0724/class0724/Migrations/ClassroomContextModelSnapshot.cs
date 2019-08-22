﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using class0724.Data;

namespace class0724.Migrations
{
    [DbContext(typeof(ClassroomContext))]
    partial class ClassroomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("class0724.Data.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("class0724.Data.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<int?>("InstructorId");

                    b.Property<string>("LastName");

                    b.HasKey("StudentId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("class0724.Data.Student", b =>
                {
                    b.HasOne("class0724.Data.Instructor", "Instructor")
                        .WithMany("Students")
                        .HasForeignKey("InstructorId");
                });
#pragma warning restore 612, 618
        }
    }
}