﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RLRMBL.Context;

#nullable disable

namespace RLRMBL.Migrations
{
    [DbContext(typeof(RLRMDBContext))]
    [Migration("20220322222235_update_ProductToProduction")]
    partial class update_ProductToProduction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RLRMBL.Models.AlphabeticDate", b =>
                {
                    b.Property<int>("MonthNumber")
                        .HasColumnType("int")
                        .HasColumnName("monthNumber");

                    b.Property<string>("AlphabeticCode")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("alphabeticCode")
                        .IsFixedLength();

                    b.HasKey("MonthNumber")
                        .HasName("PK__alphabet__82D52291379915E9");

                    b.ToTable("alphabeticDate", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Distilation", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("DrumLotNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("drumLotNumber")
                        .IsFixedLength();

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("endDate");

                    b.Property<int?>("Heels")
                        .HasColumnType("int")
                        .HasColumnName("heels");

                    b.Property<bool?>("HeelsPumped")
                        .HasColumnType("bit")
                        .HasColumnName("heelsPumped");

                    b.Property<int?>("Prefraction")
                        .HasColumnType("int")
                        .HasColumnName("prefraction");

                    b.Property<string>("ProductLotNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("productLotNumber")
                        .IsFixedLength();

                    b.Property<int?>("RawMaterialLoaded")
                        .HasColumnType("int")
                        .HasColumnName("rawMaterialLoaded");

                    b.Property<int?>("RunNumber")
                        .HasColumnType("int")
                        .HasColumnName("runNumber");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("startDate");

                    b.HasKey("ProductId")
                        .HasName("PK__distilat__2D10D16A8BDBBBCE");

                    b.HasIndex("DrumLotNumber");

                    b.HasIndex("ProductLotNumber");

                    b.ToTable("distilation", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employeeId");

                    b.Property<string>("FirstName")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("firstName")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("lastName")
                        .IsFixedLength();

                    b.HasKey("EmployeeId");

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Material", b =>
                {
                    b.Property<int>("MaterialNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("materialNameId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialNameId"), 1L, 1);

                    b.Property<int?>("CarbonDrumDaysAllowed")
                        .HasColumnType("int")
                        .HasColumnName("carbonDrumDaysAllowed");

                    b.Property<bool?>("CarbonDrumRequired")
                        .HasColumnType("bit")
                        .HasColumnName("carbonDrumRequired");

                    b.Property<int?>("CarbonDrumWeightAllowed")
                        .HasColumnType("int")
                        .HasColumnName("carbonDrumWeightAllowed");

                    b.Property<string>("MaterialName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("materialName");

                    b.Property<string>("MaterialNameAbreviation")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("materialNameAbreviation");

                    b.Property<string>("PermitNumber")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("permitNumber");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("productCode");

                    b.Property<string>("RawMaterialCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("rawMaterialCode");

                    b.HasKey("MaterialNameId")
                        .HasName("PK__material__6A6E3BCD2C8F556A");

                    b.ToTable("material", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.MaterialId", b =>
                {
                    b.Property<int>("MaterialId1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("materialId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId1"), 1L, 1);

                    b.Property<int?>("CurrentSequenceId")
                        .HasColumnType("int")
                        .HasColumnName("currentSequenceId");

                    b.Property<int?>("MaterialNumber")
                        .HasColumnType("int")
                        .HasColumnName("materialNumber");

                    b.Property<int?>("SequenceId")
                        .HasColumnType("int")
                        .HasColumnName("sequenceId");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int")
                        .HasColumnName("vendorId");

                    b.HasKey("MaterialId1")
                        .HasName("PK__material__99B653FDF99C4B8E");

                    b.HasIndex("MaterialNumber");

                    b.ToTable("materialId", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.MaterialNumber", b =>
                {
                    b.Property<int>("MaterialNumber1")
                        .HasColumnType("int")
                        .HasColumnName("materialNumber");

                    b.Property<bool?>("BatchManaged")
                        .HasColumnType("bit")
                        .HasColumnName("batchManaged");

                    b.Property<bool?>("IsRawMaterial")
                        .HasColumnType("bit")
                        .HasColumnName("isRawMaterial");

                    b.Property<int?>("MaterialNameId")
                        .HasColumnType("int")
                        .HasColumnName("materialNameId");

                    b.Property<bool?>("RequiresProcessOrder")
                        .HasColumnType("bit")
                        .HasColumnName("requiresProcessOrder");

                    b.Property<string>("UnitOfIssue")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("unitOfIssue")
                        .IsFixedLength();

                    b.HasKey("MaterialNumber1")
                        .HasName("PK__material__EE13FB891D767955");

                    b.HasIndex("MaterialNameId");

                    b.ToTable("materialNumber", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Production", b =>
                {
                    b.Property<string>("ProductLotNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("productLotNumber")
                        .IsFixedLength();

                    b.Property<int?>("MaterialNumber")
                        .HasColumnType("int")
                        .HasColumnName("materialNumber");

                    b.Property<decimal?>("ProcessOrder")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("processOrder");

                    b.Property<int?>("ProductionBatchNumber")
                        .HasColumnType("int")
                        .HasColumnName("productionBatchNumber");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("ReceiverId")
                        .HasColumnType("int")
                        .HasColumnName("receiverId");

                    b.Property<string>("SampleSubmitNumber")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("sampleSubmitNumber")
                        .IsFixedLength();

                    b.HasKey("ProductLotNumber")
                        .HasName("PK__product__794840451FC26F46");

                    b.HasIndex("MaterialNumber");

                    b.HasIndex("SampleSubmitNumber");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.ProductNumberSequence", b =>
                {
                    b.Property<int>("SequenceId")
                        .HasColumnType("int")
                        .HasColumnName("sequenceId");

                    b.Property<int?>("SequenceIdEnd")
                        .HasColumnType("int")
                        .HasColumnName("sequenceIdEnd");

                    b.Property<int>("SequenceIdStart")
                        .HasColumnType("int")
                        .HasColumnName("sequenceIdStart");

                    b.HasKey("SequenceId")
                        .HasName("PK__productN__53F4086332C9F781");

                    b.ToTable("productNumberSequence", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.QualityControl", b =>
                {
                    b.Property<string>("SampleSubmitNumber")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("sampleSubmitNumber")
                        .IsFixedLength();

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("date")
                        .HasColumnName("approvalDate");

                    b.Property<DateTime?>("ExperiationDate")
                        .HasColumnType("date")
                        .HasColumnName("experiationDate");

                    b.Property<decimal?>("InspectionLotNumber")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("inspectionLotNumber");

                    b.Property<bool?>("Rejected")
                        .HasColumnType("bit")
                        .HasColumnName("rejected");

                    b.Property<DateTime?>("RejectedDate")
                        .HasColumnType("date")
                        .HasColumnName("rejectedDate");

                    b.Property<int?>("VendorBatchId")
                        .HasColumnType("int")
                        .HasColumnName("vendorBatchId");

                    b.HasKey("SampleSubmitNumber")
                        .HasName("PK__qualityC__45525A7E70D8374B");

                    b.HasIndex("VendorBatchId");

                    b.ToTable("qualityControl", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.RawMaterial", b =>
                {
                    b.Property<string>("DrumLotNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("drumLotNumber")
                        .IsFixedLength();

                    b.Property<string>("ContainerNumber")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("char(7)")
                        .HasColumnName("containerNumber")
                        .IsFixedLength();

                    b.Property<DateTime>("DateUsed")
                        .HasColumnType("date")
                        .HasColumnName("dateUsed");

                    b.Property<int?>("DrumWeight")
                        .HasColumnType("int")
                        .HasColumnName("drumWeight");

                    b.Property<int?>("MaterialNumber")
                        .HasColumnType("int")
                        .HasColumnName("materialNumber");

                    b.Property<decimal?>("ProcessOrder")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("processOrder");

                    b.Property<string>("SampleSubmitNumber")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("sampleSubmitNumber")
                        .IsFixedLength();

                    b.Property<int?>("SapBatchNumber")
                        .HasColumnType("int")
                        .HasColumnName("sapBatchNumber");

                    b.Property<int?>("VendorBatchId")
                        .HasColumnType("int")
                        .HasColumnName("vendorBatchId");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int")
                        .HasColumnName("vendorId");

                    b.HasKey("DrumLotNumber")
                        .HasName("PK__rawMater__944152908680F7FA");

                    b.HasIndex("MaterialNumber");

                    b.HasIndex("SampleSubmitNumber");

                    b.HasIndex("VendorBatchId");

                    b.HasIndex("VendorId");

                    b.ToTable("rawMaterial", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Receiver", b =>
                {
                    b.Property<int>("ReceiverId")
                        .HasColumnType("int")
                        .HasColumnName("receiverId");

                    b.Property<string>("ReceiverName")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("receiverName")
                        .IsFixedLength();

                    b.HasKey("ReceiverId");

                    b.ToTable("receiver", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("vendorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"), 1L, 1);

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("vendorName");

                    b.HasKey("VendorId");

                    b.ToTable("vendor", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.VendorBatchInformation", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("batchId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchId"), 1L, 1);

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<string>("VendorBatchNumber")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("vendorBatchNumber");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int")
                        .HasColumnName("vendorId");

                    b.HasKey("BatchId")
                        .HasName("PK__vendorBa__78CCD773230650CE");

                    b.HasIndex("VendorId");

                    b.ToTable("vendorBatchInformation", (string)null);
                });

            modelBuilder.Entity("RLRMBL.Models.Distilation", b =>
                {
                    b.HasOne("RLRMBL.Models.RawMaterial", "DrumLotNumberNavigation")
                        .WithMany("Distilations")
                        .HasForeignKey("DrumLotNumber")
                        .HasConstraintName("FK__distilati__drumL__403A8C7D");

                    b.HasOne("RLRMBL.Models.Production", "ProductLotNumberNavigation")
                        .WithMany("Distilations")
                        .HasForeignKey("ProductLotNumber")
                        .HasConstraintName("FK__distilati__produ__3F466844");

                    b.Navigation("DrumLotNumberNavigation");

                    b.Navigation("ProductLotNumberNavigation");
                });

            modelBuilder.Entity("RLRMBL.Models.MaterialId", b =>
                {
                    b.HasOne("RLRMBL.Models.MaterialNumber", "MaterialNumberNavigation")
                        .WithMany("MaterialIds")
                        .HasForeignKey("MaterialNumber")
                        .HasConstraintName("FK__materialI__mater__32E0915F");

                    b.Navigation("MaterialNumberNavigation");
                });

            modelBuilder.Entity("RLRMBL.Models.MaterialNumber", b =>
                {
                    b.HasOne("RLRMBL.Models.Material", "MaterialName")
                        .WithMany("MaterialNumbers")
                        .HasForeignKey("MaterialNameId")
                        .HasConstraintName("FK__materialN__mater__300424B4");

                    b.Navigation("MaterialName");
                });

            modelBuilder.Entity("RLRMBL.Models.Production", b =>
                {
                    b.HasOne("RLRMBL.Models.MaterialNumber", "MaterialNumberNavigation")
                        .WithMany("Products")
                        .HasForeignKey("MaterialNumber")
                        .HasConstraintName("FK__product__materia__3B75D760");

                    b.HasOne("RLRMBL.Models.QualityControl", "SampleSubmitNumberNavigation")
                        .WithMany("Products")
                        .HasForeignKey("SampleSubmitNumber")
                        .HasConstraintName("FK__product__sampleS__3C69FB99");

                    b.Navigation("MaterialNumberNavigation");

                    b.Navigation("SampleSubmitNumberNavigation");
                });

            modelBuilder.Entity("RLRMBL.Models.QualityControl", b =>
                {
                    b.HasOne("RLRMBL.Models.VendorBatchInformation", "VendorBatch")
                        .WithMany("QualityControls")
                        .HasForeignKey("VendorBatchId")
                        .HasConstraintName("FK__qualityCo__vendo__2B3F6F97");

                    b.Navigation("VendorBatch");
                });

            modelBuilder.Entity("RLRMBL.Models.RawMaterial", b =>
                {
                    b.HasOne("RLRMBL.Models.MaterialNumber", "MaterialNumberNavigation")
                        .WithMany("RawMaterials")
                        .HasForeignKey("MaterialNumber")
                        .HasConstraintName("FK__rawMateri__mater__35BCFE0A");

                    b.HasOne("RLRMBL.Models.QualityControl", "SampleSubmitNumberNavigation")
                        .WithMany("RawMaterials")
                        .HasForeignKey("SampleSubmitNumber")
                        .HasConstraintName("FK__rawMateri__sampl__36B12243");

                    b.HasOne("RLRMBL.Models.VendorBatchInformation", "VendorBatch")
                        .WithMany("RawMaterials")
                        .HasForeignKey("VendorBatchId")
                        .HasConstraintName("FK__rawMateri__vendo__38996AB5");

                    b.HasOne("RLRMBL.Models.Vendor", "Vendor")
                        .WithMany("RawMaterials")
                        .HasForeignKey("VendorId")
                        .HasConstraintName("FK__rawMateri__vendo__37A5467C");

                    b.Navigation("MaterialNumberNavigation");

                    b.Navigation("SampleSubmitNumberNavigation");

                    b.Navigation("Vendor");

                    b.Navigation("VendorBatch");
                });

            modelBuilder.Entity("RLRMBL.Models.VendorBatchInformation", b =>
                {
                    b.HasOne("RLRMBL.Models.Vendor", "Vendor")
                        .WithMany("VendorBatchInformations")
                        .HasForeignKey("VendorId")
                        .HasConstraintName("FK__vendorBat__vendo__267ABA7A");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("RLRMBL.Models.Material", b =>
                {
                    b.Navigation("MaterialNumbers");
                });

            modelBuilder.Entity("RLRMBL.Models.MaterialNumber", b =>
                {
                    b.Navigation("MaterialIds");

                    b.Navigation("Products");

                    b.Navigation("RawMaterials");
                });

            modelBuilder.Entity("RLRMBL.Models.Production", b =>
                {
                    b.Navigation("Distilations");
                });

            modelBuilder.Entity("RLRMBL.Models.QualityControl", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("RawMaterials");
                });

            modelBuilder.Entity("RLRMBL.Models.RawMaterial", b =>
                {
                    b.Navigation("Distilations");
                });

            modelBuilder.Entity("RLRMBL.Models.Vendor", b =>
                {
                    b.Navigation("RawMaterials");

                    b.Navigation("VendorBatchInformations");
                });

            modelBuilder.Entity("RLRMBL.Models.VendorBatchInformation", b =>
                {
                    b.Navigation("QualityControls");

                    b.Navigation("RawMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}