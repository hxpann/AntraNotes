using System;
namespace Assignment3;

class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    //Color Consturctor
    public Color(int red, int green, int blue, int alpha = 255)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    //getters for data members
    public int getRed()
    {
        return red;
    }
    public int getGreen()
    {
        return green;
    }
    public int getBlue()
    {
        return blue;
    }
    public int getAlpha()
    {
        return alpha;
    }
    //setters for data members
    public void setRed(int red)
    {
        this.red = red;
    }
    public void setGreen(int green)
    {
        this.green = green;
    }
    public void setBlue(int blue)
    {
        this.blue = blue;
    }
    public void setAlpha(int alpha)
    {
        this.alpha = alpha;
    }

    //get the grascale value
    public double getGrayScaleValue()
    {
        return ((red + green + blue) * 1.0) / 3;
    }
}

class Ball
{
    private int size;
    private Color color;
    private int numThrows;

    //Constructor for Ball class
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        numThrows = 0;
    }

    //getters and setter for data members
    public int getSize()
    {
        return size;
    }

    public Color getColor()
    {
        return color;
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        //if ball has not been popped, add the numThrows
        if (size != 0)
        {
            numThrows++;
        }
    }
    public int getNumThrows()
    {
        return numThrows;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Color cl
    }
}