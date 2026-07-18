# Handson 6 – Kafka Chat Application

## Objective
Develop a Windows Forms chat application using Apache Kafka for message publishing and consuming.

## Technologies Used
- C#
- .NET 8
- Windows Forms
- Apache Kafka
- Confluent.Kafka NuGet Package

## Project Structure

Lab6_KafkaChat
│
├── Consumer
│   └── KafkaConsumer.cs
├── Producer
│   └── KafkaProducer.cs
├── Models
│   └── ChatMessage.cs
├── Form1.cs
├── Program.cs
└── Lab6_KafkaChat.csproj

## Features
- Publish messages to Kafka topic.
- Consume messages from Kafka topic.
- Simple Windows Forms interface.
- Producer and Consumer separated into different classes.

## Output
The application allows sending and receiving chat messages through Apache Kafka.