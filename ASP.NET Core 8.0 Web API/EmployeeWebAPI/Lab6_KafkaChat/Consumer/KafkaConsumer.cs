using Confluent.Kafka;

namespace Lab6_KafkaChat.Consumer
{
    public class KafkaConsumer
    {
        private readonly string _topic = "chat-topic";

        private readonly ConsumerConfig _config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        public void StartConsuming(Action<string> onMessageReceived)
        {
            Task.Run(() =>
            {
                using var consumer = new ConsumerBuilder<Ignore, string>(_config).Build();

                consumer.Subscribe(_topic);

                while (true)
                {
                    try
                    {
                        var result = consumer.Consume();
                        onMessageReceived(result.Message.Value);
                    }
                    catch (ConsumeException ex)
                    {
                        MessageBox.Show(ex.Error.Reason);
                    }
                }
            });
        }
    }
}