﻿using CarBookProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBookProject.Persistence.Context
{
	public class CarBookContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;initial catalog=CarBookDb;integrated security=true;TrustServerCertificate=true");
		}
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Banner> Banners { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<CarDescription> CarDescriptions { get; set; }
		public DbSet<CarFeature> CarFeatures { get; set; }
		public DbSet<CarPricing> CarPricings { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<ContactCategory> ContactCategories { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<FooterAddress> FooterAddresses { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Pricing> Pricings { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<TagBlog> TagBlogs { get; set; }
		public DbSet<RentACar> RentACars { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<ReservationStatus> ReservationStatuses { get; set; }
		public DbSet<Review> Reviews { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Reservation>()
				  .HasOne(x => x.PickUpLocation)
				 .WithMany(y => y.PickUpReservation)
				   .HasForeignKey(m => m.PickUpLocationId)
				 .OnDelete(DeleteBehavior.ClientSetNull);

			modelBuilder.Entity<Reservation>()
				.HasOne(x => x.DropOffLocation)
			   .WithMany(y => y.DropOffReservation)
				 .HasForeignKey(m => m.DropOffLocationId)
			   .OnDelete(DeleteBehavior.ClientSetNull);
		}
	}
}
