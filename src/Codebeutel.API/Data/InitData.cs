using Codebeutel.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Data
{
    public class InitData
    {
        DbContext dBContext;

        public InitData(DbContext dbContext)
        {

            Dispenser dispenserItems0 = new Dispenser
            {
                Latitude = 52.0233965,
                Longitude = 7.7807085,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems0);
            Dispenser dispenserItems1 = new Dispenser
            {
                Latitude = 51.919739,
                Longitude = 7.9673135,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems1);
            Dispenser dispenserItems2 = new Dispenser
            {
                Latitude = 51.8222681,
                Longitude = 7.5375615,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems2);
            Dispenser dispenserItems3 = new Dispenser
            {
                Latitude = 51.9131417,
                Longitude = 7.4821038,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems3);
            Dispenser dispenserItems4 = new Dispenser
            {
                Latitude = 51.8585311,
                Longitude = 7.4840029,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems4);
            Dispenser dispenserItems5 = new Dispenser
            {
                Latitude = 51.860726,
                Longitude = 7.4840139,
                IsEmpty = false,
                IsDefect = true,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems5);
            Dispenser dispenserItems6 = new Dispenser
            {
                Latitude = 51.866136,
                Longitude = 7.4860353,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems6);
            Dispenser dispenserItems7 = new Dispenser
            {
                Latitude = 51.9018409,
                Longitude = 7.6735556,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems7);
            Dispenser dispenserItems8 = new Dispenser
            {
                Latitude = 51.7947676,
                Longitude = 7.7390955,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = true
            };
            dbContext.Add(dispenserItems8);
            Dispenser dispenserItems9 = new Dispenser
            {
                Latitude = 52.0025843,
                Longitude = 7.5972367,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems9);
            Dispenser dispenserItems10 = new Dispenser
            {
                Latitude = 51.9916507,
                Longitude = 7.5589786,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems10);
            Dispenser dispenserItems11 = new Dispenser
            {
                Latitude = 51.9677888,
                Longitude = 7.6319488,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems11);
            Dispenser dispenserItems12 = new Dispenser
            {
                Latitude = 51.967365,
                Longitude = 7.6222486,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems12);
            Dispenser dispenserItems13 = new Dispenser
            {
                Latitude = 51.9630744,
                Longitude = 7.6135879,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = true
            };
            dbContext.Add(dispenserItems13);
            Dispenser dispenserItems14 = new Dispenser
            {
                Latitude = 51.8648883,
                Longitude = 7.7305891,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems14);
            Dispenser dispenserItems15 = new Dispenser
            {
                Latitude = 51.8633007,
                Longitude = 7.7378069,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems15);
            Dispenser dispenserItems16 = new Dispenser
            {
                Latitude = 51.8624423,
                Longitude = 7.7362137,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems16);
            Dispenser dispenserItems17 = new Dispenser
            {
                Latitude = 51.9432773,
                Longitude = 7.5937759,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems17);
            Dispenser dispenserItems18 = new Dispenser
            {
                Latitude = 51.9833509,
                Longitude = 7.6283893,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems18);
            Dispenser dispenserItems19 = new Dispenser
            {
                Latitude = 51.9894884,
                Longitude = 7.6502996,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems19);
            Dispenser dispenserItems20 = new Dispenser
            {
                Latitude = 51.9869773,
                Longitude = 7.6426973,
                IsEmpty = false,
                IsDefect = true,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems20);
            Dispenser dispenserItems21 = new Dispenser
            {
                Latitude = 51.9132509,
                Longitude = 7.6514338,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems21);
            Dispenser dispenserItems22 = new Dispenser
            {
                Latitude = 51.9788988,
                Longitude = 7.6281289,
                IsEmpty = false,
                IsDefect = true,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems22);
            Dispenser dispenserItems23 = new Dispenser
            {
                Latitude = 51.9818168,
                Longitude = 7.622224,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems23);
            Dispenser dispenserItems24 = new Dispenser
            {
                Latitude = 51.7965842,
                Longitude = 7.7363287,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems24);
            Dispenser dispenserItems25 = new Dispenser
            {
                Latitude = 51.7596364,
                Longitude = 7.7939133,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems25);
            Dispenser dispenserItems26 = new Dispenser
            {
                Latitude = 51.765255,
                Longitude = 7.7922276,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems26);
            Dispenser dispenserItems27 = new Dispenser
            {
                Latitude = 51.9958917,
                Longitude = 7.6470378,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems27);
            Dispenser dispenserItems28 = new Dispenser
            {
                Latitude = 52.0684393,
                Longitude = 7.3200636,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems28);
            Dispenser dispenserItems29 = new Dispenser
            {
                Latitude = 51.8202084,
                Longitude = 7.5420848,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems29);
            Dispenser dispenserItems30 = new Dispenser
            {
                Latitude = 51.8619833,
                Longitude = 7.4844555,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems30);
            Dispenser dispenserItems31 = new Dispenser
            {
                Latitude = 51.8166506,
                Longitude = 7.5894445,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems31);
            Dispenser dispenserItems32 = new Dispenser
            {
                Latitude = 51.9774842,
                Longitude = 7.2849287,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems32);
            Dispenser dispenserItems33 = new Dispenser
            {
                Latitude = 51.9779028,
                Longitude = 7.2863469,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems33);
            Dispenser dispenserItems34 = new Dispenser
            {
                Latitude = 51.9830596,
                Longitude = 7.2814818,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems34);
            Dispenser dispenserItems35 = new Dispenser
            {
                Latitude = 51.7974048,
                Longitude = 7.7455035,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = true
            };
            dbContext.Add(dispenserItems35);
            Dispenser dispenserItems36 = new Dispenser
            {
                Latitude = 52.0403453,
                Longitude = 7.4795398,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems36);
            Dispenser dispenserItems37 = new Dispenser
            {
                Latitude = 52.0867542,
                Longitude = 7.5967865,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems37);
            Dispenser dispenserItems38 = new Dispenser
            {
                Latitude = 51.9845374,
                Longitude = 7.2825259,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems38);
            Dispenser dispenserItems39 = new Dispenser
            {
                Latitude = 51.9832676,
                Longitude = 7.2904806,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems39);
            Dispenser dispenserItems40 = new Dispenser
            {
                Latitude = 51.9871131,
                Longitude = 7.296714,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems40);
            Dispenser dispenserItems41 = new Dispenser
            {
                Latitude = 51.9884775,
                Longitude = 7.297862,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems41);
            Dispenser dispenserItems42 = new Dispenser
            {
                Latitude = 51.987645,
                Longitude = 7.3036127,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems42);
            Dispenser dispenserItems43 = new Dispenser
            {
                Latitude = 51.9854879,
                Longitude = 7.3007583,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems43);
            Dispenser dispenserItems44 = new Dispenser
            {
                Latitude = 51.9827634,
                Longitude = 7.2965129,
                IsEmpty = false,
                IsDefect = true,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems44);
            Dispenser dispenserItems45 = new Dispenser
            {
                Latitude = 51.9812145,
                Longitude = 7.2969782,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems45);
            Dispenser dispenserItems46 = new Dispenser
            {
                Latitude = 51.9741395,
                Longitude = 7.2883901,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems46);
            Dispenser dispenserItems47 = new Dispenser
            {
                Latitude = 51.9729332,
                Longitude = 7.2925847,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems47);
            Dispenser dispenserItems48 = new Dispenser
            {
                Latitude = 51.9721017,
                Longitude = 7.2975727,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems48);
            Dispenser dispenserItems49 = new Dispenser
            {
                Latitude = 51.9691964,
                Longitude = 7.2946589,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems49);
            Dispenser dispenserItems50 = new Dispenser
            {
                Latitude = 51.9777112,
                Longitude = 7.3015042,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems50);
            Dispenser dispenserItems51 = new Dispenser
            {
                Latitude = 51.8452514,
                Longitude = 7.688866,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems51);
            Dispenser dispenserItems52 = new Dispenser
            {
                Latitude = 51.842408,
                Longitude = 7.6849442,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems52);
            Dispenser dispenserItems53 = new Dispenser
            {
                Latitude = 51.7693392,
                Longitude = 7.8796012,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems53);
            Dispenser dispenserItems54 = new Dispenser
            {
                Latitude = 51.9675482,
                Longitude = 7.2918351,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = true
            };
            dbContext.Add(dispenserItems54);
            Dispenser dispenserItems55 = new Dispenser
            {
                Latitude = 51.9751017,
                Longitude = 7.2870665,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems55);
            Dispenser dispenserItems56 = new Dispenser
            {
                Latitude = 51.868012,
                Longitude = 7.7348927,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems56);
            Dispenser dispenserItems57 = new Dispenser
            {
                Latitude = 51.8668018,
                Longitude = 7.7311195,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems57);
            Dispenser dispenserItems58 = new Dispenser
            {
                Latitude = 51.868046,
                Longitude = 7.7304992,
                IsEmpty = false,
                IsDefect = true,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems58);
            Dispenser dispenserItems59 = new Dispenser
            {
                Latitude = 51.8458665,
                Longitude = 7.8296712,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems59);
            Dispenser dispenserItems60 = new Dispenser
            {
                Latitude = 51.8516541,
                Longitude = 7.8288598,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems60);
            Dispenser dispenserItems61 = new Dispenser
            {
                Latitude = 51.8491341,
                Longitude = 7.8202741,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems61);
            Dispenser dispenserItems62 = new Dispenser
            {
                Latitude = 51.8481888,
                Longitude = 7.8327283,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems62);
            Dispenser dispenserItems63 = new Dispenser
            {
                Latitude = 51.9912383,
                Longitude = 7.6027559,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems63);
            Dispenser dispenserItems64 = new Dispenser
            {
                Latitude = 51.7574698,
                Longitude = 7.9253892,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems64);
            Dispenser dispenserItems65 = new Dispenser
            {
                Latitude = 51.7560117,
                Longitude = 7.923576,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems65);
            Dispenser dispenserItems66 = new Dispenser
            {
                Latitude = 51.7564587,
                Longitude = 7.8765126,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems66);
            Dispenser dispenserItems67 = new Dispenser
            {
                Latitude = 51.7717612,
                Longitude = 7.8834428,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems67);
            Dispenser dispenserItems68 = new Dispenser
            {
                Latitude = 51.962276,
                Longitude = 7.6218195,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems68);
            Dispenser dispenserItems69 = new Dispenser
            {
                Latitude = 51.9611105,
                Longitude = 7.6220172,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems69);
            Dispenser dispenserItems70 = new Dispenser
            {
                Latitude = 51.9604114,
                Longitude = 7.6147248,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems70);
            Dispenser dispenserItems71 = new Dispenser
            {
                Latitude = 51.9697346,
                Longitude = 7.6643521,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems71);
            Dispenser dispenserItems72 = new Dispenser
            {
                Latitude = 52.0030925,
                Longitude = 7.6017782,
                IsEmpty = true,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems72);
            Dispenser dispenserItems73 = new Dispenser
            {
                Latitude = 52.0884454,
                Longitude = 7.6300162,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems73);
            Dispenser dispenserItems74 = new Dispenser
            {
                Latitude = 52.0895555,
                Longitude = 7.6266363,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems74);
            Dispenser dispenserItems75 = new Dispenser
            {
                Latitude = 52.0826156,
                Longitude = 7.6177222,
                IsEmpty = false,
                IsDefect = false,
                IsDeleted = false
            };
            dbContext.Add(dispenserItems75);

            // Add categories
            var catRestaurant = new Category
            {
                Title = "Restaurant",
                Description = "Dog friendly restaurants"
            };
            var catPark = new Category
            {
                Title = "Park",
                Description = "Dog friendly parks"
            };
            dbContext.AddRange(new[] { catRestaurant, catPark });


            dbContext.SaveChanges();
        }
    }
}
