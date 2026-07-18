using Confluent.Kafka;

namespace Lab6_KafkaChat.Producer
{
    public class KafkaProducer
    {
        private readonly string _topic = "chat-topic";

        private readonly ProducerConfig _config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        public async Task SendMessageAsync(string message)
        {
            using var producer = new ProducerBuilder<Null, string>(_config).Build();

            await producer.ProduceAsync(_topic, new Message<Null, string>
            {
                Value = message
            });

            producer.Flush(TimeSpan.FromSeconds(5));
        }
    }
}