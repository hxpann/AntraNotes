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
        Color color1 = new Color(18, 243, 107);
        Ball ball1 = new Ball(4, color1);

        //throw the ball 3 times
        ball1.Throw();
        ball1.Throw();
        ball1.Throw();
        Console.WriteLine("Throw count of Ball 1 before popping: " + ball1.getNumThrows());

        //pop the ball
        ball1.Pop();

        //throw the ball twice again after popping the ball
        ball1.Throw();
        ball1.Throw();

        //print the number of throws : should be same (as ball was popped)
        Console.WriteLine("Throw count of Ball 1 after popping: " + ball1.getNumThrows());


        Console.WriteLine();

        //create another color and ball object
        Color color2 = new Color(27, 87, 94, 148);
        Ball ball2 = new Ball(2, color2);

        ball2.Pop(); //pop the ball

        //throw the ball2 5 times
        for (int i = 0; i < 5; i++) ball2.Throw();

        //output should be zero as ball was popped initially
        Console.WriteLine("Ball 2 throw count: " + ball2.getNumThrows());
    }
}