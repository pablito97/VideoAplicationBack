using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace VideoAplication.Models
{
    public partial class VideosContext : DbContext
    {
        public VideosContext()
        {
        }

        public VideosContext(DbContextOptions<VideosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Video> Videos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("Video");

                entity.Property(e => e.VideoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("video_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.Director)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("director");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
