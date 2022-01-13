using UnityEngine;

abstract class Shapes
{
    public abstract double GetPerimeter();
}

class Rect : Shapes
{
    double length, breadth;
    public Rect(double len, double brdth)
    {
        this.length = len;
        this.breadth = brdth;
    }

    public override double GetPerimeter()
    {
        return (length + breadth) * 2;
    }
}

class Triangle : Shapes
{
    private double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double GetPerimeter()
    {
        return a * b * c;
    }
}
public class AbstractClasses : MonoBehaviour
{
    void OnDisable()
    {
        Rect rect = new Rect(10, 20);
        Triangle tri = new Triangle(2, 3, 4);
        Shapes[] shapes = new Shapes[] { rect, tri };
        foreach (Shapes shape in shapes)
        {
            Debug.Log(shape.GetPerimeter());
        }
    }
}
