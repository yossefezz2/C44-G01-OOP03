
internal class ComplexNumber
{
    private double real = default;
    private double imaginary = default;
    internal ComplexNumber()
    {

    }
    internal ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    override public string ToString()
    {
        return $"{real} + {imaginary}i";
    }
    public static ComplexNumber operator + (ComplexNumber number1 , ComplexNumber number2)
    {
        return new ComplexNumber
        {
           real = (number1?.real ?? 0 ) + (number2?.real ?? 0),
           imaginary = (number1?.imaginary ?? 0) + (number2?.imaginary ?? 0)
        };
    }

    public static ComplexNumber operator +(ComplexNumber number1, int number2)
    {
        return new ComplexNumber
        {
            real = (number1?.real ?? 0) + number2 ,
            imaginary = (number1?.imaginary ?? 0) 
        };
    }

    public static ComplexNumber operator +(int number2 , ComplexNumber number1)
    {
        return number1 + number2;
    }

    public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
    {
        return new ComplexNumber
        {
            real = (number1?.imaginary ?? 0) - (number2?.real ?? 0),
            imaginary = (number1?.imaginary ?? 0) - (number2?.imaginary ?? 0)
        };
    }

    public static ComplexNumber operator -(ComplexNumber number1, int number2)
    {
        return new ComplexNumber
        {
            real = (number1?.real ?? 0) - number2,
            imaginary = (number1?.imaginary ?? 0)
        };
    }

    public static ComplexNumber operator -(int number2, ComplexNumber number1)
    {
        number1.real = 0 - number1.real;
        number1.imaginary = 0 - number1.imaginary;
        return number1 + number2;
    }
}

