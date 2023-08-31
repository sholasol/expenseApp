using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseApp.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionId { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; } //foreign key

		public int Amount { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string? Note { get; set; }

		public DateTime Date { get; set; } = DateTime.Now;
	}
}

