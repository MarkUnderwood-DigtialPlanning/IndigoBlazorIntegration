//namespace TestApp4.Data.Financial; // Razor won't recognize third level namespace
namespace TestApp4.Financial;

public class BoxOfficeRevenueType
{
    public string Franchise { get; set; }
    public double TotalWorldBoxOfficeRevenue { get; set; }
    public double HighestGrossingMovieInSeries { get; set; }
}
