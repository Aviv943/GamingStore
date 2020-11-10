﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GamingStore.Models
{
    public class Cart
    {
        public static int ItemCounter;

        public Cart()
        {
            Id = ItemCounter;
            Interlocked.Increment(ref ItemCounter);
        }

        [Key, DatabaseGenerated((DatabaseGeneratedOption.None))]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string CustomerId { get; set; }

        [DataType(DataType.Currency)]
        public int ItemId { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 9, ErrorMessage = "only 1-9 items is allowed")]
        public int Quantity { get; set; }

        [NotMapped] //todo: why?
        public Item Item { get; set; }
    }
}