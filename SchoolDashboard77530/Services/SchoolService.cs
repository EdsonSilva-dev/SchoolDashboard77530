using SchoolDashboard77530.Models;

namespace SchoolDashboard77530.Services
{
    public class SchoolService
    {
        private readonly HttpClient _httpClient;

        public SchoolService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<School>> GetSchoolsAsync()
        {
            var schools = await _httpClient.GetFromJsonAsync<List<School>>(
                "https://edutots.net/api/school"
            );

            return schools ?? new List<School>();
        }
    }
}