using System.ComponentModel;

namespace SelfOrder.API.Models.Enums;

public enum MenuCategory
{
    [Description("天丼")]
    Tendon = 1,

    [Description("天ぷら単品")]
    Tenpura = 2,

    [Description("ドリンク")]
    Drink = 3,
}


public enum TendonCategory
{
    [Description("全て")]
    All = 1,
}

public enum TenpuraCategory
{
    [Description("天ぷら")]
    Tenpura = 2,

    [Description("野菜天")]
    Vegetable = 3,
}

public enum DrinkCategory
{
    [Description("全て")]
    All = 4,
}