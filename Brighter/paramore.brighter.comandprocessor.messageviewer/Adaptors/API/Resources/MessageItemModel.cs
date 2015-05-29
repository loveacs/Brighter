using System;
using Humanizer;
using Raven.Imports.Newtonsoft.Json;

namespace paramore.brighter.commandprocessor.messageviewer.Adaptors.API.Resources
{
    public class MessageItemModel
    {
        public MessageItemModel(){}
        public MessageItemModel(Message message)
        {
            MessageId = message.Id;
            TimeStamp = message.Header.TimeStamp;
            MessageType = message.Header.MessageType.ToString();
            HandledCount = message.Header.HandledCount;
            Bag = JsonConvert.SerializeObject(message.Header.Bag);
            MessageBody = message.Body.Value;
            Topic = message.Header.Topic;
            TimeStampUI = TimeStamp.Humanize();
        }

        public string Topic { get; set; }
        public string Bag { get; set; }
        public string MessageBody { get; set; }
        public int HandledCount { get; set; }
        public string MessageType { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid MessageId { get; set; }
        public string TimeStampUI { get; set; }
    }
}