using Business.Enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class SeedData
    {
        private static readonly IEnumerable<Town> Towns = new List<Town>()
        {
            new Town()
            {
                Name = "Воронеж",

            },
        };
        public static readonly IEnumerable<District> Districts = new List<District>()
        {
            new District()
            {
                Name = "Центральный район",
                TownId = 0,
                Town = Towns.ElementAt(0),
            },
            new District()
            {
                Name = "Левобережный район",
                TownId = 0,
                Town = Towns.ElementAt(0),
            },
        };
        private static readonly IEnumerable<Street> Streets = new List<Street>()
        {
            new Street()
            {
                Name = "Ленина",
                District = Districts.ElementAt(0),
                DistrictId = 0,
            },
            new Street()
            {
                Name = "Минская",
                District = Districts.ElementAt(1),
                DistrictId = 1,
            },
            new Street()
            {
                Name = "Остужева",
                District = Districts.ElementAt(1),
                DistrictId = 1,
            },
        };


        private static readonly IEnumerable<EstateType> EstateTypes = new List<EstateType>()
        {
            new EstateType()
            {
                Name = "Жилой",
            },
             new EstateType()
            {
                Name = "Нежилой",
            },
        };
        private static readonly IEnumerable<Client> Clients = new List<Client>()
        {
            new Client()
            {
                FullName = "Воробьев Иван Петрович",
                Phone = 2265696,
            },
            new Client()
            {
                FullName = "Смирнов Андрей Иванович",
                Phone = 2213456,
            },
            new Client()
            {
                FullName = "Попов Иван Викторович",
                Phone = 2234567,
            },

        };
        private static readonly IEnumerable<Estate> Estates = new List<Estate>()
        {
            new Estate()
            {
                Name = "Дом",
                Price = 350000,
                Area = 30,
                YearOfConsruction = 2020,
                RoomsCount = 1,
                FloorsCount = 1,
                EstateType = EstateTypes.ElementAt(0),
                EstateTypeId = 0,
                Street = Streets.ElementAt(0),
                StreetId = 0,
                Client = Clients.ElementAt(0),
                ClientId = 0,
            },
            new Estate()
            {
                Name = "Квартира",
                Price = 900000,
                Area = 40,
                YearOfConsruction = 1995,
                RoomsCount = 1,
                FloorsCount = 1,
                EstateType = EstateTypes.ElementAt(1),
                EstateTypeId = 1,
                Street = Streets.ElementAt(1),
                StreetId = 1,
                Client = Clients.ElementAt(1),
                ClientId = 1,
            },

        };


        private static readonly IEnumerable<Realtor> Realtors = new List<Realtor>()
        {
            new Realtor()
            {
                FullName = "Петрова Алина Александровна",
                Phone = 2245367,
                Experience = 5,
            },
            new Realtor()
            {
                FullName = "Андреев Виктор Михайлович",
                Phone = 2264758,
                Experience = 8,
            },

        };
        private static readonly IEnumerable<Deal> Deals = new List<Deal>()
        {
            new Deal() 
            {
              Client = Clients.ElementAt(0),
              ClientId = 0,
              Estate = Estates.ElementAt(0),
              EstateId = 0,
              Realtor = Realtors.ElementAt(0),
              RealtorId = 0,
              Date = new DateTime(2020,10,21),
              Sum = 50000000,
            },
            new Deal()
            {
              Client = Clients.ElementAt(1),
              ClientId = 1,
              Estate = Estates.ElementAt(1),
              EstateId = 1,
              Realtor = Realtors.ElementAt(1),
              RealtorId = 1,
              Date = new DateTime(2022,01,23),
              Sum = 1000000,
            },

        };
        public static void Initialize(Context context)
        {
            if (!context.Towns.Any())
            {
                context.Towns.AddRange(Towns);
                context.SaveChanges();
            }
            if (!context.Districts.Any())
            {
                context.Districts.AddRange(Districts);
                context.SaveChanges();
            }
            if (!context.Streets.Any())
            {
                context.Streets.AddRange(Streets);
                context.SaveChanges();
            }

            if (!context.EstateTypes.Any())
            {
                context.EstateTypes.AddRange(EstateTypes);
                context.SaveChanges();
            }

            if (!context.Estates.Any())
            {
                context.Estates.AddRange(Estates);
                context.SaveChanges();
            }

            if (!context.Clients.Any())
            {
                context.Clients.AddRange(Clients);
                context.SaveChanges();
            }
            if (!context.Realtors.Any())
            {
                context.Realtors.AddRange(Realtors);
                context.SaveChanges();
            }
            if(!context.Deals.Any())
            {
                context.Deals.AddRange(Deals);
                context.SaveChanges();
            }

        }
       



    }

}








