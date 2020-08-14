using RabbitMQ.Client;
using System;
using System.Text;

namespace Core.DataAccess.RabitMQ
{
	public class Publisher
	{
		private readonly RabbitMQService _rabbitMQService;

		public Publisher()
		{
			_rabbitMQService = new RabbitMQService();

			//using (var connection = _rabbitMQService.GetRabbitMQConnection()) {
			//	using (var channel = connection.CreateModel()) {
			//		channel.QueueDeclare(queueName, false, false, false, null);

			//		channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

			//		Console.WriteLine("{0} queue'su üzerine, \"{1}\" mesajı yazıldı.", queueName, message);
			//	}
			//}
		}
		public void Publish(string queueName, string message)
		{
			using (var connection = _rabbitMQService.GetRabbitMQConnection())
			{
				using (var channel = connection.CreateModel())
				{
					channel.QueueDeclare(queue: queueName,
					durable: false,
					exclusive: false,
					autoDelete: false,
					arguments: null);

					channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

					Console.WriteLine("{0} queue'su üzerine, \"{1}\" mesajı yazıldı.", queueName, message);
				}
			}
		}

	}
}
