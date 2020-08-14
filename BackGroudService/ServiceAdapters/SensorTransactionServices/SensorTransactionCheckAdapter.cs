using Core.ApiClientServiceCore;
using System;

namespace BackGroudService.ServiceAdapters.SensorTransactionServices
{
	public class SensorTransactionCheckAdapter : ISensorTransactionCheckService
    {

        private string url = "http://localhost/WebApi/";

		public void CheckSensorTransaction(DateTime startDateTime, DateTime endDateTime)
		{
			this.url = DefaultValues.Defaults.WebApiUrl;
			//this.url = "https://localhost:5001/"; // api/Transactions/checkAllCriticalSensorValues?minutes=10";
			string urlParameters = string.Format("api/Transactions/checkAllCriticalSensorValues?minutes={0}", 10);
			var response = APICall.RunAsync<object>(url, urlParameters).GetAwaiter().GetResult();
		
		
		}
		
	}
}
