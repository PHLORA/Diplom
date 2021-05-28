﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_2._0.Entities.Store
{
	public class Order
	{
        public int Id { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        public string Oplata { get; set; }
        public virtual Book Book { get; set; }
        public DateTime Date { get; set; }
    }
}
