using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalClinic.DataBase.Models;

public class Patient {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Imię")]
    public string ?firstName { get; set; }

    [Required]
    [Display(Name = "Nazwisko")]
    public string ?lastName { get; set; }

    [Required]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "PESEL must contain 11 digits")]
    [Display(Name = "PESEL")]
    public string ?pesel { get; set; }

    [Required]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email format")]
    [Display(Name = "Email")]
    public string ?email { get; set; }

    [Required]
    [Display(Name = "Miasto")]
    public string ?city { get; set; }

    [Required]
    [Display(Name = "Ulica")]
    public string ?street { get; set; }

    [Required]
    [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Zip code must be in format XX-XXX")]
    [Display(Name = "Kod pocztowy")]
    public string ?zipCode { get; set; }

    public override string ToString() {
        return $"Id: {Id}, firstName: {firstName}, lastName: {lastName}, pesel: {pesel}, email: {email}, city: {city}, street: {street}, zipCode: {zipCode}";
    }
    
}