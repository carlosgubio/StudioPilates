﻿using Microsoft.EntityFrameworkCore;

namespace StudioPilates.Data
{
    public class StudioPilatesContext : DbContext
    {
        public StudioPilatesContext(DbContextOptions<StudioPilatesContext> options)
            : base(options)
        {
        }

        public DbSet<StudioPilates.Models.Customer> Customers { get; set; }
        public DbSet<StudioPilates.Models.Address> Address { get; set; }
        public DbSet<StudioPilates.Models.Customer_payment> Customer_Payments { get; set; }
        public DbSet<StudioPilates.Models.Customer_plan> Customer_plans { get; set; }
        public DbSet<StudioPilates.Models.Customer_question_response> Customer_Question_Responses { get; set; }
        public DbSet<StudioPilates.Models.Plan> Plans { get; set; }
        public DbSet<StudioPilates.Models.Question> Questions { get; set; }
        //public DbSet<StudioPilates.Models.Questionnaire> Questionnaires  { get; set; }



    }
}