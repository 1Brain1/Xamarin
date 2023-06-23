using System;

namespace CarouselView.Models;

public class MdnDto
{
    public string MndNumber { get; set; }
    public string Sim { get; set; }
    public string Imei { get; set; }

    public string Provider { get; set; }

    public bool IsActive { get; set; }


    public string ProviderColor => SetProviderColor(Provider);
    public string Status => SetStatus(IsActive);
    public string StatusColor => SetStatusColor(IsActive);


    private static string SetStatus(bool isActive)
    {
        return isActive ? "ACTIVE" : "INACTIVE";
    }

    private static string SetStatusColor(bool isActive)
    {
        return isActive ? "#81DC95" : "#808080";
    }

    private static string SetProviderColor(string provider)
    {
        return provider switch
        {
            nameof(LegacyCode.Red) => "#FB8997",
            nameof(LegacyCode.Purple) => "#AB97FA",
            _ => "Blue"
        };
    }
}

public enum LegacyCode
{ 
    None,
    Red,
    Purple
}