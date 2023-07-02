using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMKioskSystem
{
    public class LoginWindowEntity
    {
        public bool AgentLogin(Agent agent)
        {
            CommonResponseDTO<int> commonResponseDTO = new CommonResponseDTO<int>();
            using (HttpClient client = new HttpClient())
            {
                commonResponseDTO = client.PostAsJsonAsync($"https://localhost:44373/Api/Agent/", agent).Result.Content.ReadFromJsonAsync<CommonResponseDTO<int>>().Result;
            }

            if (commonResponseDTO.Data > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AdminLogin(Admin admin)
        {
            CommonResponseDTO<int> commonResponseDTO = new CommonResponseDTO<int>();
            using (HttpClient client = new HttpClient())
            {
                commonResponseDTO = client.PostAsJsonAsync($"https://localhost:44373/Api/Admin", admin).Result.Content.ReadFromJsonAsync<CommonResponseDTO<int>>().Result;
            }

            if (commonResponseDTO.Data > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
