using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using InAndOut.Data;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Models
{
	public class Expense
	{
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }

        [DisplayName("Amount")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount must be greater than 0")]
        public int ExpenseAmount { get; set; }
    }
}
