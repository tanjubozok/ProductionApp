﻿namespace ProductionApp.Service.Mappings.Helpers;

public static class ProfileHelper
{
    public static List<Profile> GetProfiles()
    {
        return new List<Profile>
        {
            new GroupProfile(),
            new StockProfile()
        };
    }
}
