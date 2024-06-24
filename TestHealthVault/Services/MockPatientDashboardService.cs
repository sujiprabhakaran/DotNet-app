using HealthVault.Models.PatientDashboard;

namespace HealthVault.PatientDashboard
{
    public class MockPatientDashboardService : IPatientDashboardService
    {
        public Task<List<WeightType>> GetWeightList()
        {
            return Task.FromResult<List<WeightType>>(new());
        }

        public Task<List<HeartRateType>> GetHeartRateList()
        {
            return Task.FromResult<List<HeartRateType>>(new());
        }

        public Task<List<BPSystolicDiastolicType>> GetBPSystolicDiastolicList()
        {
            return Task.FromResult<List<BPSystolicDiastolicType>>(new());
        }

        public Task<List<GlucoseType>> GetGlucoseList()
        {
            return Task.FromResult<List<GlucoseType>>(new());
        }

        public Task<List<TotalCholesterolType>> GetTotalCholesterolList()
        {
            return Task.FromResult<List<TotalCholesterolType>>(new());
        }

        public Task<List<CholesterolHDLLDLType>> GetCholesterolHDLLDLList()
        {
            return Task.FromResult<List<CholesterolHDLLDLType>>(new());
        }
    }
}
