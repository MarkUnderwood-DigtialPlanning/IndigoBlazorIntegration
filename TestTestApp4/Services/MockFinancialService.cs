namespace TestApp4.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }
    }
}