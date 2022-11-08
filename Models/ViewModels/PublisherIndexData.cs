using Sorocan_Alexandru_Lab2.Models;

namespace Sorocan_Alexandru_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
