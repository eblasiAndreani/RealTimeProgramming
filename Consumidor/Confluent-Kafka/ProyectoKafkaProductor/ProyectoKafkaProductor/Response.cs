using MediatR;
using System.Net;

namespace ProyectoKafkaProductor
{
    public class Response<T>
    {
        public T Content { get; set; }
        public IReadOnlyCollection<string> Notifications { get; set; }
        public bool Valid { get => !Notifications.Any(); }
        public bool Invalid { get => Notifications.Any(); }
        public HttpStatusCode StatusCode { get; set; }
        public Response(T content)
        {
            Content = content;
            Notifications = new List<string>();
        }

        public Response(IReadOnlyCollection<string> notifications, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            Notifications = notifications;
            StatusCode = statusCode;
        }
    }
}
