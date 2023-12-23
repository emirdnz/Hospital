using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hospital.MVC.Data;

// Add profile data for application users by adding properties to the HospitalUser class
public class HospitalUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }


    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string? Email { get; set; }
}



