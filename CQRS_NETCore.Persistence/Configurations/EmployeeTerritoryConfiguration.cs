﻿using CQRS_NETCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS_NETCore.Persistence.Configurations
{
    public class EmployeeTerritoryConfiguration : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
        {
            builder.HasKey(e => new { e.EmployeeId, e.TerritoryId })
                .ForSqlServerIsClustered(false);

            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            builder.Property(e => e.TerritoryId)
                .HasColumnName("TerritoryID")
                .HasMaxLength(20);

            builder.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerritories_Employees");

            builder.HasOne(d => d.Territory)
                .WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(d => d.TerritoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerritories_Territories");
        }
    }
}
