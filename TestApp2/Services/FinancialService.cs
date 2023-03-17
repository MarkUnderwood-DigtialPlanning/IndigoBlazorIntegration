using System.Text.Json;

namespace TestApp2.Financial
{
    public class FinancialService: IFinancialService
    {
        private readonly IWebHostEnvironment _env;

        public FinancialService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/financial-box-office-revenue.json";
            if (!File.Exists(path))
            {
                return new List<BoxOfficeRevenueType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<BoxOfficeRevenueType>>(data, options));
        }
    }
}