using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreColumnOrder
{

    public class CustomAnnotationProvider : SqlServerMigrationsAnnotationProvider
    {
        public CustomAnnotationProvider(MigrationsAnnotationProviderDependencies dependencies)
            : base(dependencies)
        {
        }

        public override IEnumerable<IAnnotation> For(IProperty property)
        {
            var baseAnnotations = base.For(property);

            var orderAnnotation = property.FindAnnotation(CustomAnnotationNames.ColumnOrder);

            return orderAnnotation == null
                ? baseAnnotations
                : baseAnnotations.Concat(new[] { orderAnnotation });
        }
    }
}
