// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using ApiDB.dal.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiDB
{
    public partial class User : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserLogin { get; set; }
        public int Role { get; set; }
        public School21 School21 { get; set; }
        public int Campus { get; set; }
       
        public List<Booking> bookings { get; set; }
        [StringLength(50)]
        public string telegramId { get; set; }
        public bool Block { get; set; }
    }
}