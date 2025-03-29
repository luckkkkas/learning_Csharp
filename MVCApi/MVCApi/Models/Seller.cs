using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.MinimalApi;
using MVCApi.Migrations;
using System.ComponentModel.DataAnnotations;

namespace MVCApi.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} precisa ter entre {2} e {1} caracteres")]
        public string Name { get; set; }
     
        [Required]
        [EmailAddress (ErrorMessage = "Entre um Email Válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name="Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(1200, 5000, ErrorMessage ="{0} precisa ser entre {2} e {1}")]
        [Display(Name="Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public Double BaseSalary { get; set; }

        [Required]
        public Department Department { get; set; }
       
        [Required]
        public int DepartmentId { get; set; }
        
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) 
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public Double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
