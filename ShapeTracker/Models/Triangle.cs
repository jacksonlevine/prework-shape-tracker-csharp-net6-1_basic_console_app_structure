using System.Collections.Generic;
namespace ShapeTracker.Models

{
  public class Triangle
  {
    private static List<Triangle> _instances = new List<Triangle>();
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    private int _side2;
    public int Side2
    {
      get { return _side2; }
      set { _side2 = value; }
    }
    private int _side3;
    public int Side3
    {
      get { return _side3; }
      set { _side3 = value; }
    }
    public Triangle(int length1)
    {
      _side1 = length1;
    }
    public Triangle(int length1, int length2)
    {
      _side1 = length1;
      _side2 = length2;
    }

    public Triangle(int length1, int length2, int l3)
    {
      _side1 = length1;
      _side2 = length2;
      _side3 = l3;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Triangle> GetAll()
    {
      return _instances;
    }

  }
}
