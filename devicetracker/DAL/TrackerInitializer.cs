using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using devicetracker.Models;
namespace devicetracker.DAL
{
    public class TrackerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TrackerContext>
    {
        protected override void Seed(TrackerContext context)
        {
            //base.Seed(context);
            var Devices = new List<Device>()
            {
                new Device(){Brand="Huawe", Name="Nova 2ay", IsAvailable=true},
                new Device(){Brand="Apel", Name="Iphone 6es", IsAvailable=true},
                new Device(){Brand="Samung", Name="Galaxy Nut", IsAvailable=true},
                new Device(){Brand="Sonya", Name="Experyaya", IsAvailable=true},
                new Device(){Brand="Opo", Name="F4", IsAvailable=true},
                new Device(){Brand="Vev", Name="v23", IsAvailable=true},
            };

            Devices.ForEach(x => context.Devices.Add(x));
            context.SaveChanges();

            var Users = new List<User>()
            {
                new User(){FirstName="Reynard", LastName ="Natividad", Address="La Union"},
                new User(){FirstName="Angelo", LastName ="Diolata", Address="Batangas"},
                new User(){FirstName="Mitchie", LastName ="Miranda", Address="Metro Manila"},
                new User(){FirstName="Beverly", LastName ="Cruz", Address="Cebu"},
                new User(){FirstName="Jessel", LastName ="Zozobrado", Address="Cebu"},
            };

            Users.ForEach(y => context.Users.Add(y));
            context.SaveChanges();

        }
    }
}