﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCities.API.Data.Models
{
    [Table("Cities")]
    [Index(nameof(Name))]
    [Index(nameof(Lat))]
    [Index(nameof(Lon))]
    public class City
    {
        #region Properties
        /// <summary>
        /// The unique Id and primary key for this city
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// City name (in UTF8 format)
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// City latitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lat { get; set; }

        /// <summary>
        /// City longitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lon { get; set; }

        /// <summary>
        /// Country Id (foreign key)
        /// </summary>
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        #endregion

        #region Navigation Properties
        /// <summary>
        /// The country related to this city.
        /// </summary>
        public Country? Country { get; set; } = null!;
        #endregion
    }
}
