using System.ComponentModel.DataAnnotations;

namespace TheplaceEmployeeApp.Data.Enums
{
    public enum SkinColor
    {
        [Display(Name = "Extremely fair skin")]
        ExtremelyFairSkin = 1,
        [Display(Name = "Fair skin")]
        FairSkin,
        [Display(Name = "Medium skin")]
        MediumSkin,
        [Display(Name = "Olive skin")]
        OliveSkin,
        [Display(Name = "Brown skin")]
        BrownSkin,
        [Display(Name = "Black skin")]
        BlackSkin
    }
}

