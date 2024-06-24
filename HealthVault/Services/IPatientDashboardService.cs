using HealthVault.Models.PatientDashboard;

namespace HealthVault.PatientDashboard
{
    public interface IPatientDashboardService
    {
        Task<List<WeightType>> GetWeightList();
        Task<List<HeartRateType>> GetHeartRateList();
        Task<List<BPSystolicDiastolicType>> GetBPSystolicDiastolicList();
        Task<List<GlucoseType>> GetGlucoseList();
        Task<List<TotalCholesterolType>> GetTotalCholesterolList();
        Task<List<CholesterolHDLLDLType>> GetCholesterolHDLLDLList();
    }
}
