using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NursingHomes.Base.DbContext;

namespace NursingHomes.Base.Migrations
{
    [DbContext(typeof(BaseContext))]
    partial class BaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NursingHomes.Base.Domain.Nurser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.Property<string>("NurserNo");

                    b.Property<string>("Remark");

                    b.Property<int>("WorkYear");

                    b.HasKey("Id");

                    b.ToTable("Nurser");
                });

            modelBuilder.Entity("NursingHomes.Base.Domain.OldMan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("MedicalHistory");

                    b.Property<string>("RoomNo");

                    b.HasKey("Id");

                    b.ToTable("OldMan");
                });

            modelBuilder.Entity("NursingHomes.Base.Domain.Relation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name");

                    b.Property<Guid>("OldManId");

                    b.Property<int>("RelationType");

                    b.Property<int>("Sex");

                    b.Property<string>("Tel");

                    b.Property<string>("WorkInfo");

                    b.HasKey("Id");

                    b.HasIndex("OldManId");

                    b.ToTable("Relation");
                });

            modelBuilder.Entity("NursingHomes.Base.Domain.Relation", b =>
                {
                    b.HasOne("NursingHomes.Base.Domain.OldMan")
                        .WithMany()
                        .HasForeignKey("OldManId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
