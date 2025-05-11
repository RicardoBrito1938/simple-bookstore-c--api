namespace simple_bookstore_api.Communication.Response;

public class ResponseRegisteredBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public int Price { get; set; }
}