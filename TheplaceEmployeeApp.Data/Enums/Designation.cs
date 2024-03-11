using System.ComponentModel.DataAnnotations;

namespace TheplaceEmployeeApp.Data.Enums
{
    public enum Designation
    {
        Cashier = 1,
        Purchaser,
        Cook,
        Runner,
        Baker,
        [Display(Name = "Kitchen assistant")]
        Kitchen_Assistant,
        [Display(Name = "Restaurant supervisor")]
        Restaurant_Supervisor,
        [Display(Name = "Restaurant supervisor")]
        Restaurant_Manager,
        [Display(Name = "Area coordinator")]
        Area_Coordinator,
        Marketer,
        [Display(Name = "Head of marketing")]
        Head_Of_Marketing,
        [Display(Name = "Head of IT")]
        Head_Of_IT,
        [Display(Name = "Head of finance")]
        Head_Of_Finance,
        CEO,
        COO
    }
}
