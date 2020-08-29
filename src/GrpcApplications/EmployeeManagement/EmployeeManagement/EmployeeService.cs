using EmployeeMessages;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static EmployeeMessages.EmployeeService;

namespace EmployeeManagement
{
    public class EmployeeService: EmployeeServiceBase
    {
        public override Task<GetEmployeeResponse> GetEmployee(GetEmployeeRequest request, ServerCallContext context)
        {
            var response = new GetEmployeeResponse();
            response.Employee.Add(new Employee()
            {
                Firstname = "Michel",
                Lastname = "Scofield"
            });
            return Task<GetEmployeeResponse>.FromResult(response);
        }
    }
}
