using Lab6_KafkaChat.Consumer;
using Lab6_KafkaChat.Producer;

namespace Lab6_KafkaChat
{
    public partial class Form1 : Form
    {
        private readonly KafkaProducer _producer;
        private readonly KafkaConsumer _consumer;

        public Form1()
        {
            InitializeComponent();

            _producer = new KafkaProducer();
            _consumer = new KafkaConsumer();

            _consumer.StartConsuming(DisplayMessage);
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => lstMessages.Items.Add(message)));
            }
            else
            {
                lstMessages.Items.Add(message);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            await _producer.SendMessageAsync(txtMessage.Text);

            txtMessage.Clear();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {

        }
    }
}