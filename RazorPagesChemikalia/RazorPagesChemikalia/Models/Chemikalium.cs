﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesChemikalia.Models;

public class Chemikalium
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Nazwa { get; set; }
    
    [Display(Name = "Data odkrycia")]
    [DataType(DataType.Date)]
    public DateTime DataOdkrycia { get; set; }

    
    [Required]
    [StringLength(50)]
    public string? Ph { get; set; }

    
    [Required]
    [StringLength(50)]
    public string? Rozpuszczalnosc { get; set; }

    
    [Required]
    [StringLength(50)]
    public string? Toksycznosc { get; set; }

    
    [Required]
    [StringLength(50)]
    public string? Zapach { get; set; }

    
    [Required]
    [StringLength(50)]
    [Display(Name = "Stan skupienia")]
    public string? StanSkupienia { get; set; }
    
    public string? Barwa { get; set; }

    
    [Required]
    [StringLength(50)]
    [Display(Name = "Temperatura topnienia")]
    public string? TemperaturaTopnienia { get; set; }

    
    [Required]
    [StringLength(50)]
    public string Uzytecznosc { get; set; } = string.Empty;

}

