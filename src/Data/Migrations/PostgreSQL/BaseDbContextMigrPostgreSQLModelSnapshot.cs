﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RGF.Demo.Northwind.Area.RGF.DbModel;

#nullable disable

namespace RGF.Demo.Northwind.Data.Migrations.PostgreSQL
{
    [DbContext(typeof(BaseDbContextMigrPostgreSQL))]
    partial class BaseDbContextMigrPostgreSQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Recrovit.RecroGridFramework.Data.vRecroSec", b =>
                {
                    b.Property<int>("ObjectPermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("objectpermissionid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ObjectPermissionId"));

                    b.Property<string>("ObjectKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("objectkey");

                    b.Property<string>("ObjectName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("objectname");

                    b.HasKey("ObjectPermissionId")
                        .HasName("pk_vrecrosec");

                    b.ToTable("vrecrosec", "public", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Recrovit.RecroGridFramework.Data.vRecroSec_FEP", b =>
                {
                    b.Property<int>("FEPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("fepid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FEPId"));

                    b.Property<int>("EntityId")
                        .HasColumnType("integer")
                        .HasColumnName("entityid");

                    b.Property<int>("FEPType")
                        .HasColumnType("integer")
                        .HasColumnName("feptype");

                    b.Property<string>("Key1")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("key1");

                    b.Property<int>("TransactionId")
                        .HasColumnType("integer")
                        .HasColumnName("transactionid");

                    b.HasKey("FEPId")
                        .HasName("pk_vrecrosec_fep");

                    b.ToTable("vrecrosec_fep", "public", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Categories", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("categoryid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("categoryname");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("bytea")
                        .HasColumnName("picture");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("CategoryID")
                        .HasName("pk_categories");

                    b.HasIndex("CategoryName")
                        .HasDatabaseName("ix_categories_categoryname");

                    b.ToTable("categories", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("character(5)")
                        .HasColumnName("customerid");

                    b.Property<string>("CustomerTypeID")
                        .HasColumnType("character(10)")
                        .HasColumnName("customertypeid");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("CustomerID", "CustomerTypeID")
                        .HasName("pk_customercustomerdemo");

                    b.HasIndex("CustomerTypeID")
                        .HasDatabaseName("ix_customercustomerdemo_customertypeid");

                    b.ToTable("customercustomerdemo", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.CustomerDemographics", b =>
                {
                    b.Property<string>("CustomerTypeID")
                        .HasColumnType("character(10)")
                        .HasColumnName("customertypeid");

                    b.Property<string>("CustomerDesc")
                        .HasColumnType("text")
                        .HasColumnName("customerdesc");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("CustomerTypeID")
                        .HasName("pk_customerdemographics");

                    b.ToTable("customerdemographics", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Customers", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("character(5)")
                        .HasColumnName("customerid");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("city");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("companyname");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("contactname");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("contacttitle");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("fax");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("postalcode");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("region");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("CustomerID")
                        .HasName("pk_customers");

                    b.HasIndex("City")
                        .HasDatabaseName("ix_customers_city");

                    b.HasIndex("CompanyName")
                        .HasDatabaseName("ix_customers_companyname");

                    b.HasIndex("PostalCode")
                        .HasDatabaseName("ix_customers_postalcode");

                    b.HasIndex("Region")
                        .HasDatabaseName("ix_customers_region");

                    b.ToTable("customers", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("employeeid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("address");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("birthdate");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("country");

                    b.Property<string>("Extension")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("extension");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("firstname");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("hiredate");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("homephone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("lastname");

                    b.Property<string>("Notes")
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea")
                        .HasColumnName("photo");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("photopath");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("postalcode");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("region");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("integer")
                        .HasColumnName("reportsto");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("title");

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("titleofcourtesy");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("EmployeeID")
                        .HasName("pk_employees");

                    b.HasIndex("LastName")
                        .HasDatabaseName("ix_employees_lastname");

                    b.HasIndex("PostalCode")
                        .HasDatabaseName("ix_employees_postalcode");

                    b.HasIndex("ReportsTo")
                        .HasDatabaseName("ix_employees_reportsto");

                    b.ToTable("employees", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.EmployeeTerritories", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("integer")
                        .HasColumnName("employeeid");

                    b.Property<string>("TerritoryID")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("territoryid");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("EmployeeID", "TerritoryID")
                        .HasName("pk_employeeterritories");

                    b.HasIndex("TerritoryID")
                        .HasDatabaseName("ix_employeeterritories_territoryid");

                    b.ToTable("employeeterritories", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Order_Details", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("orderid");

                    b.Property<int>("ProductID")
                        .HasColumnType("integer")
                        .HasColumnName("productid");

                    b.Property<float>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasColumnName("discount")
                        .HasDefaultValueSql("(0)");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("quantity")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(19,4)")
                        .HasColumnName("unitprice")
                        .HasDefaultValueSql("(0)");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("OrderId", "ProductID")
                        .HasName("pk_orderdetails");

                    b.HasIndex("OrderId")
                        .HasDatabaseName("ix_ordersorder_details");

                    b.HasIndex("ProductID")
                        .HasDatabaseName("ix_ordersorder_productsorder_details");

                    b.ToTable("orderdetails", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Orders", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("orderid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderID"));

                    b.Property<string>("CustomerID")
                        .HasColumnType("character(5)")
                        .HasColumnName("customerid");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("integer")
                        .HasColumnName("employeeid");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(19,4)")
                        .HasColumnName("freight")
                        .HasDefaultValueSql("(0)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("orderdate");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("requireddate");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("shipaddress");

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("shipcity");

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("shipcountry");

                    b.Property<string>("ShipName")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("shipname");

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("shippostalcode");

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("shipregion");

                    b.Property<int?>("ShipVia")
                        .HasColumnType("integer")
                        .HasColumnName("shipvia");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("shippeddate");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("OrderID")
                        .HasName("pk_orders");

                    b.HasIndex("CustomerID")
                        .HasDatabaseName("ix_orders_customersorders");

                    b.HasIndex("EmployeeID")
                        .HasDatabaseName("ix_orders_employeesorders");

                    b.HasIndex("OrderDate")
                        .HasDatabaseName("ix_orders_orderdate");

                    b.HasIndex("ShipPostalCode")
                        .HasDatabaseName("ix_orders_shippostalcode");

                    b.HasIndex("ShipVia")
                        .HasDatabaseName("ix_orders_shippersorders");

                    b.HasIndex("ShippedDate")
                        .HasDatabaseName("ix_orders_shippeddate");

                    b.ToTable("orders", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("productid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("integer")
                        .HasColumnName("categoryid");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("boolean")
                        .HasColumnName("discontinued");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("productname");

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("quantityperunit");

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("reorderlevel")
                        .HasDefaultValueSql("(0)");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("integer")
                        .HasColumnName("supplierid");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(19,4)")
                        .HasColumnName("unitprice")
                        .HasDefaultValueSql("(0)");

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("unitsinstock")
                        .HasDefaultValueSql("(0)");

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("unitsonorder")
                        .HasDefaultValueSql("(0)");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("ProductID")
                        .HasName("pk_products");

                    b.HasIndex("CategoryID")
                        .HasDatabaseName("ix_products_categoryid");

                    b.HasIndex("ProductName")
                        .HasDatabaseName("ix_products_productname");

                    b.HasIndex("SupplierID")
                        .HasDatabaseName("ix_products_suppliersproducts");

                    b.ToTable("products", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .HasColumnType("integer")
                        .HasColumnName("regionid");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasColumnType("character(50)")
                        .HasColumnName("regiondescription");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("RegionID")
                        .HasName("pk_region");

                    b.ToTable("region", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Shippers", b =>
                {
                    b.Property<int>("ShipperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("shipperid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ShipperID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("companyname");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("phone");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("ShipperID")
                        .HasName("pk_shippers");

                    b.ToTable("shippers", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Suppliers", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("supplierid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SupplierID"));

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("city");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("companyname");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("contactname");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("contacttitle");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("fax");

                    b.Property<string>("HomePage")
                        .HasColumnType("text")
                        .HasColumnName("homepage");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("postalcode");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("region");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("SupplierID")
                        .HasName("pk_suppliers");

                    b.HasIndex("CompanyName")
                        .HasDatabaseName("ix_suppliers_companyname");

                    b.HasIndex("PostalCode")
                        .HasDatabaseName("ix_suppliers_postalcode");

                    b.ToTable("suppliers", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Territories", b =>
                {
                    b.Property<string>("TerritoryID")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("territoryid");

                    b.Property<int>("RegionID")
                        .HasColumnType("integer")
                        .HasColumnName("regionid");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasColumnType("character(50)")
                        .HasColumnName("territorydescription");

                    b.Property<int>("rowversion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("rowversion")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("TerritoryID")
                        .HasName("pk_territories");

                    b.HasIndex("RegionID")
                        .HasDatabaseName("ix_territories_regionid");

                    b.ToTable("territories", "public");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.CustomerCustomerDemo", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Customers", "Customer")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerID")
                        .IsRequired()
                        .HasConstraintName("fk_customercustomerdemo_customers");

                    b.HasOne("RGF.Demo.Northwind.Models.CustomerDemographics", "CustomerType")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerTypeID")
                        .IsRequired()
                        .HasConstraintName("fk_customercustomerdemo");

                    b.Navigation("Customer");

                    b.Navigation("CustomerType");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Employees", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Employees", "Employees2")
                        .WithMany("Employees1")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("fk_employees_employees");

                    b.Navigation("Employees2");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.EmployeeTerritories", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Employees", "Employees")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeID")
                        .IsRequired()
                        .HasConstraintName("fk_employeeterritories_employees");

                    b.HasOne("RGF.Demo.Northwind.Models.Territories", "Territories")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryID")
                        .IsRequired()
                        .HasConstraintName("fk_employeeterritories_territories");

                    b.Navigation("Employees");

                    b.Navigation("Territories");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Order_Details", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Orders", "Orders")
                        .WithMany("Order_Details")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("fk_order_details_orders");

                    b.HasOne("RGF.Demo.Northwind.Models.Products", "Products")
                        .WithMany("Order_Details")
                        .HasForeignKey("ProductID")
                        .IsRequired()
                        .HasConstraintName("fk_order_details_products");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Orders", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Customers", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .HasConstraintName("fk_orders_customers");

                    b.HasOne("RGF.Demo.Northwind.Models.Employees", "Employees")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID")
                        .HasConstraintName("fk_orders_employees");

                    b.HasOne("RGF.Demo.Northwind.Models.Shippers", "Shippers")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("fk_orders_shippers");

                    b.Navigation("Customers");

                    b.Navigation("Employees");

                    b.Navigation("Shippers");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Products", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .HasConstraintName("fk_products_categories");

                    b.HasOne("RGF.Demo.Northwind.Models.Suppliers", "Suppliers")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .HasConstraintName("fk_products_suppliers");

                    b.Navigation("Categories");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Territories", b =>
                {
                    b.HasOne("RGF.Demo.Northwind.Models.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionID")
                        .IsRequired()
                        .HasConstraintName("fk_territories_region");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.CustomerDemographics", b =>
                {
                    b.Navigation("CustomerCustomerDemo");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Customers", b =>
                {
                    b.Navigation("CustomerCustomerDemo");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Employees", b =>
                {
                    b.Navigation("EmployeeTerritories");

                    b.Navigation("Employees1");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Orders", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Products", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Region", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Shippers", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Suppliers", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("RGF.Demo.Northwind.Models.Territories", b =>
                {
                    b.Navigation("EmployeeTerritories");
                });
#pragma warning restore 612, 618
        }
    }
}
