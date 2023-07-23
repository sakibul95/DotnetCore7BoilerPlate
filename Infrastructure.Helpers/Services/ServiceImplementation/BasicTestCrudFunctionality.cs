using Infrastructure.Helpers.DataContext;
using Infrastructure.Helpers.Models.Common;
using Infrastructure.Helpers.Services.ServiceInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers.Services.ServiceImplementation
{
    public class BasicTestCrudFunctionality : IBasicTestCrudFunctionality
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public BasicTestCrudFunctionality(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<ApiResponse> GetBasicTestDataList()
        {
            var response = new ApiResponse();
            try
            {
                var result = await _applicationDbContext.tbl_BasicTest.ToListAsync();
                if (result.Count > 0)
                {
                    response.StatusCode = 200;
                    response.Status = "Success";
                    response.Data = result;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = ex.StackTrace;
                return response;
            }
            return response;
        }
    }
}
