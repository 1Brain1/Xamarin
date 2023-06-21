namespace CarouselView;

public class MdnDto
{
    public string MndNumber { get; set; }
    public string Sim { get; set; }
    public string Imei { get; set; }
    public string Provider { get; set; }

    public string StatusColor { get; set; }
    public string Status { get; set; }

    public static string GetStatus(bool isActive)
    {
        return isActive ? "ACTIVE" : "INACTIVE";
    }

    public static string GetStatusColor(bool isActive)
    {
        return isActive ? "#60E17C" : "Red";
    }
}
