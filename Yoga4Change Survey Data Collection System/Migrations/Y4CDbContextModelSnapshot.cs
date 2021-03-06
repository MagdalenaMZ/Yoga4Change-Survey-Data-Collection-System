// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yoga4Change_Survey_Data_Collection_System.EntityFramework;

namespace Yoga4Change_Survey_Data_Collection_System.Migrations
{
    [DbContext(typeof(Y4CDbContext))]
    partial class Y4CDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Yoga4Change_Survey_Data_Collection_System.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Yoga4Change_Survey_Data_Collection_System.Models.QuestionOption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOption");
                });

            modelBuilder.Entity("Yoga4Change_Survey_Data_Collection_System.Models.QuestionOption", b =>
                {
                    b.HasOne("Yoga4Change_Survey_Data_Collection_System.Models.Question", null)
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
