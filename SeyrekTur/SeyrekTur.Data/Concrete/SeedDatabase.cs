using Microsoft.EntityFrameworkCore;
using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Concrete
{
   public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new TurContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }

                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }

                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);
                }

                if (context.Admins.Count() == 0)
                {
                    context.Admins.AddRange(Admins);
                }
                context.SaveChanges();
            }
        }

        private static Route[] Routes =
        {
            new Route() {RouteId=1,Start="İstanbul",Route1="İzmit",Route2="Bursa",Route3="Eskişehir",Finish="Ankara",date="27.06.2022",Time="18:00",ImageUrl="1.jpg",Price=200 },
             new Route() {RouteId=2,Start="Ankara",Route1="Kahramanmaraş",Route2="Gaziantep",Route3="Şanlıurfa",Finish="Mardin",date="27.06.2022",Time="15:00",ImageUrl="2.jpg",Price=400 }
        };

        private static Ticket[] Tickets =
        {
            new Ticket() {TicketId=1,Name="Veli",Surname="Seyrek",Mail="veli@gmail.com",From="İstanbul",To="Ankara",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {TicketId=2,Name="Doğukan",Surname="Durkaya",Mail="dogukan@gmail.com",From="İstanbul",To="Bursa",SeatNo=10,Price=100,RouteId=1},
            new Ticket() {TicketId=3,Name="Yasemin",Surname="Mutlu",Mail="yasemin@gmail.com",From="İstanbul",To="İzmit",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {TicketId=4,Name="Esra",Surname="Topçuoğlu",Mail="esra@gmail.com",From="İstanbul",To="Eskişehir",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {TicketId=5,Name="Ahmet",Surname="Yıldız",Mail="ahmetyıldız@gmail.com",From="Bursa",To="Ankara",SeatNo=1,Price=200,RouteId=1},
            new Ticket() {TicketId=6,Name="Okan",Surname="Karakoç",Mail="okan@gmail.com",From="Ankara",To="Şanlıurfa",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {TicketId=7,Name="Salih",Surname="Demir",Mail="salih@gmail.com",From="Ankara",To="Kahramanmaraş",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {TicketId=8,Name="Murat",Surname="Yıldırım",Mail="murat@gmail.com",From="Ankara",To="Gaziantep",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {TicketId=9,Name="Ömer",Surname="Duman",Mail="omerduman@gmail.com",From="Ankara",To="Mardin",SeatNo=1,Price=200,RouteId=2},
            new Ticket() {TicketId=10,Name="Sezen",Surname="Aksu",Mail="veli@gmail.com",From="Gaziantep",To="Mardin",SeatNo=1,Price=200,RouteId=2},
        };

        private static City[] Cities =
        {
            new City() {CityId=1,CityName="İstanbul"},
            new City() {CityId=2,CityName="İzmit"},
            new City() {CityId=3,CityName="Bursa"},
            new City() {CityId=4,CityName="Eskişehir"},
            new City() {CityId=5,CityName="Ankara"},
            new City() {CityId=6,CityName="Kahramanmaraş"},
            new City() {CityId=7,CityName="Gaziantep"},
            new City() {CityId=8,CityName="Şanlıurfa"},
            new City() {CityId=9,CityName="Mardin"}
        };

        private static Admin[] Admins =
        {
            new Admin() {AdminID=1,AdminUserName="Veli@gmail.com",AdminPassword="12345"}
        };
    }
}
