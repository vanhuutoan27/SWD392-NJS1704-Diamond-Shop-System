using DiamonShop.Core.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiamonShop.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                    new AppRole
                    {
                        Id = new Guid("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                        Name = "Customer",
                        NormalizedName = "CUSTOMER",
                        DisplayName = "Khách Hàng"
                    },
                     new AppRole
                     {
                         Id = new Guid("C0278115-8549-4FAD-890A-44F8E8FCC022"),
                         Name = "Manager",
                         NormalizedName = "MANAGER",
                         DisplayName = "Quản Lí"
                     },
                       new AppRole
                       {
                           Id = new Guid("AB8E4032-2D95-45CC-89C1-C039E9E8BC39"),
                           Name = "DeliveryStaff",
                           NormalizedName = "DELIVERYSTAFF",
                           DisplayName = "Nhân Viên Giao Hàng"
                       },
                        new AppRole
                        {
                            Id = new Guid("1401744D-0421-41EB-B9D6-F888AACCCA91"),
                            Name = "SaleStaff",
                            NormalizedName = "SALESTAFF",
                            DisplayName = "Nhân Viên Bán Hàng"
                        }
                );
        }
    }
}
