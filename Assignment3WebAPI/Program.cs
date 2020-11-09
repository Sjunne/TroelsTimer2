using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3WebAPI.Data;
using Assignment3WebAPI.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Assignment3WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileAdapter fileAdapter = new FileAdapter();
            var allFamilies = fileAdapter.getAllFamilies();
            

            //AddAllFamilies(allFamilies);

            using (FamilyDbContext familyDbContext = new FamilyDbContext())
            {
                var first = familyDbContext.Childs.First(child => child.FirstName.Equals("Maria"));
                Interest interest = familyDbContext.Interests.First(interst => interst.Type.Equals("Fodbold"));
                ChildInterest childInterest = new ChildInterest()
                {
                    Child = first,
                    Interest = interest
                };

                familyDbContext.ChildInterests.Add(childInterest);
                familyDbContext.SaveChanges();


            }
            
            
            
            
            CreateHostBuilder(args).Build().Run();
        }

        private static void AddAllFamilies(IList<Family> allFamilies)
        {
            using (FamilyDbContext familyDbContext = new FamilyDbContext())
            {
            for (int i = 0; i < allFamilies.Count; i++)
            {

                familyDbContext.Families.Add(new Family()
                {
                    HouseNumber = allFamilies[i].HouseNumber,
                    StreetName = allFamilies[i].StreetName
                });
                familyDbContext.SaveChanges();
            }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}