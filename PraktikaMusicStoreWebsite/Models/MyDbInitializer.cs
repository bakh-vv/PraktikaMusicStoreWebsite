using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PraktikaMusicStoreWebsite.Models
{
    class MyDbInitializer : CreateDatabaseIfNotExists<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            // create 3 students to seed the database
            //context.Students.Add(new Student { ID = 1, FirstName = "Mark", LastName = "Richards", EnrollmentDate = DateTime.Now });
            //context.Students.Add(new Student { ID = 2, FirstName = "Paula", LastName = "Allen", EnrollmentDate = DateTime.Now });
            context.Albums.Add(new Album { Name = "Cilvia Demo", Duration= 55, AlbumID = 1, Price = 10});
            base.Seed(context);
        }

    }
}
