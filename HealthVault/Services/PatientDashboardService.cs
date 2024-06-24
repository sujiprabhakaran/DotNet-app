using System.Net.Http.Json;
using HealthVault.Models.PatientDashboard;

namespace HealthVault.PatientDashboard
{
    public class PatientDashboardService: IPatientDashboardService
    {
        private readonly HttpClient _http;

        public PatientDashboardService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<WeightType>> GetWeightList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/b8fb8833-7e2c-4a84-e611-08daf8ae6744", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<WeightType>>().ConfigureAwait(false);
            }

            return new List<WeightType>();
        }

        public async Task<List<HeartRateType>> GetHeartRateList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/43cfd6ae-a6db-42b5-e610-08daf8ae6744", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<HeartRateType>>().ConfigureAwait(false);
            }

            return new List<HeartRateType>();
        }

        public async Task<List<BPSystolicDiastolicType>> GetBPSystolicDiastolicList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/16761321-7913-4d05-e616-08daf8ae6744", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<BPSystolicDiastolicType>>().ConfigureAwait(false);
            }

            return new List<BPSystolicDiastolicType>();
        }

        public async Task<List<GlucoseType>> GetGlucoseList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/e1b52986-0c42-4ee1-e617-08daf8ae6744", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<GlucoseType>>().ConfigureAwait(false);
            }

            return new List<GlucoseType>();
        }

        public async Task<List<TotalCholesterolType>> GetTotalCholesterolList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/2f36bf07-125a-4301-e612-08daf8ae6744", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TotalCholesterolType>>().ConfigureAwait(false);
            }

            return new List<TotalCholesterolType>();
        }

        public async Task<List<CholesterolHDLLDLType>> GetCholesterolHDLLDLList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/a1863711-3edb-42ae-e613-08daf8ae6744", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CholesterolHDLLDLType>>().ConfigureAwait(false);
            }

            return new List<CholesterolHDLLDLType>();
        }
    }
}
