namespace ParcelObjects
{
  public class Parcel
  {
    public int Length {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}
    public int Weight {get; set;}

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public int GetVolume()
    {
      return Length * Width * Height;
    }
    public int GetShippingCost()
    {
      return (Length/2) + (Width * 3) + (Height - 50);
    }
  }
}
