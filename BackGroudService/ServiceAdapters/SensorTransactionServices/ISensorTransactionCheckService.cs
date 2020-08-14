using System;


namespace BackGroudService.ServiceAdapters.SensorTransactionServices
{
	public interface ISensorTransactionCheckService
	{
		/// <summary>
		/// thirh party bir firmadan data cekiliyor
		///http://localhost/WebApi/ dan data cekiliyor suanda
		/// </summary>
		/// <returns></returns>
		void CheckSensorTransaction(DateTime startDateTime, DateTime endDateTime);		
	}
}
