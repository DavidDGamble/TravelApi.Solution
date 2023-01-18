namespace TravelApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string Name { get; set; }

    public List<Review> Reviews { get; }
  }
}