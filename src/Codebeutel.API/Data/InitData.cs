using Codebeutel.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Data
{
    public class InitData
    {
        DbContext dBContext;

        public InitData(DbContext dbContext)
        {
            dBContext = dbContext;
            Dispenser dispenserAasee = new Dispenser
            {
                Latitude = 51.95587487045323,
                Longitude = 7.613923806626525,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };

            Dispenser dispenserHub = new Dispenser
            {
                Latitude = 51.952255522049796,
                Longitude = 7.640386436142227,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };

            Dispenser dispenserItems = new Dispenser
            {
                Latitude = 51.95217689840853,
                Longitude = 7.639092241833312,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };

            dbContext.Add(dispenserAasee);
            dbContext.Add(dispenserHub);
            dbContext.Add(dispenserItems);


            dbContext.SaveChanges();
        }
    }
}
