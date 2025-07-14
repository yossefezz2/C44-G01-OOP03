internal class Rectangle
{
    private int length;
    private int width;

    internal Rectangle()
    {
        this.length = 0;
        this.width = 0;
    }
    internal Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    internal Rectangle(int length)
    {
        this.length = length;
        this.width = length;
    }

    internal int GetArea()
    {
        return length * width;
    }
}
