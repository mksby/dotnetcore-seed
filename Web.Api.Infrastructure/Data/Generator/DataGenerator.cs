using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Web.Api.Core.Domain.Entities;
using Web.Api.Infrastructure.Identity;

namespace Web.Api.Infrastructure.Data.Generator
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MemoryDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MemoryDbContext>>()))
            {
                if (context.DistrictsCoordinates.Any())
                {
                    return;   // Data was already seeded
                }

                var type = "FeatureCollection";
                var test = Directory.GetParent(Environment.CurrentDirectory).ToString();
                var districtsCoordinatesJSONString = File.ReadAllText(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).ToString(), "Web.Api.Infrastructure\\Data\\Generator\\districtscoordinates.json"));                

                context.DistrictsCoordinates.Add(
                    new DistrictsCoordinates(type, districtsCoordinatesJSONString)
                );

                context.SaveChanges();
            }
        }
    }
}
