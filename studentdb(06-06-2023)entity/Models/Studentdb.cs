﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace studentdb_06_06_2023_entity.Models
{
    public partial class studentsDBcontextcs : DbContext
    {
        public studentsDBcontextcs()
        {
        }
        public studentsDBcontextcs(DbContextOptions<studentsDBcontextcs> options)
        : base(options)
        {
        }
        public virtual DbSet<Student> Students { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source =DRAPARTH-L-5507\\SQLEXPRESS; Initial Catalog = Studentdb; User Id=sa;Password=Welcome2evoke@1234; Trust Server Certificate=true");
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }



}

