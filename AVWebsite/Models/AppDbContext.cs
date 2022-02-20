using System;
using AVWebsite.Models.HH;
using AVWebsite.Models.Tour;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace AVWebsite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<AdditionalService> AdditionalServices { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<WhatToExpect> WhatToExpects { get; set; }

        // TOUR MAIN & UTILITY
        public DbSet<Tours> Tours { get; set; }
        public DbSet<TourFaq> TourFaqs { get; set; }
        public DbSet<TourCategory> TourCategories { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }

        //TOUR RELATIONAL
        public DbSet<About_Tour> About_Tours { get; set; }
        public DbSet<WhatToExpect_Tour> WhatToExpect_Tours { get; set; }
        public DbSet<TourFaq_Tour> TourFaq_Tours { get; set; }
        public DbSet<Review_Tour> Review_Tours { get; set; }
        public DbSet<AdditionalService_Tour> AdditionalService_Tours { get; set; }
        public DbSet<Location_Tours> Location_Tours { get; set; }
        public DbSet<TourPackage_Tour> TourPackage_Tours { get; set; }
        public DbSet<TourCategory_Tour> TourCategory_Tours { get; set; }
        public DbSet<TourType_Tour> TourType_Tours { get; set; }

        // HH MAIN & UTILITY
        public DbSet<HolidayHome> HolidayHomes { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<HHPackage> HHPackages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HHType> HHTypes { get; set; }
        public DbSet<HHCategory> HHCategories { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Features> Features { get; set; }

        // HH RELATIONAL
        public DbSet<About_HH> About_HHs { get; set; }
        public DbSet<Facility_HH> Facility_HHs { get; set; }
        public DbSet<HHPackage_HH> HHPackage_HHs { get; set; }
        public DbSet<Room_HH> Room_HHs { get; set; }
        public DbSet<Room_RoomAmenities> Room_RoomAmenities { get; set; }
        public DbSet<HHType_HH> HHType_HHs { get; set; }
        public DbSet<HHCategory_HH> HHCategory_HHs { get; set; }
        public DbSet<Features_HH> Features_HHs { get; set; }
        public DbSet<Faq_HH> Faq_HHs { get; set; }
        public DbSet<Review_HH> Review_HHs { get; set; }
        public DbSet<AdditionalService_HH> AdditionalService_HHs { get; set; }
        public DbSet<Location_HH> Location_HHs { get; set; }
        public DbSet<HHPackage_Amenities> HHPackage_Amenities { get; set; }



    }
}



