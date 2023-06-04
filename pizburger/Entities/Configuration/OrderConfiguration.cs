using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace pizburger.Entities.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<order>
    {
        public void Configure(EntityTypeBuilder<order> builder)
        {
            
        }
    }
}
