namespace TestCodes;

public class Complex
{
    public int Real { get; set; }
    public int Img { get; set; }
    public Complex()
    {
        Real = Img = 0;
    }
    public Complex(int _real, int _img)
    {
        Real = _real;
        Img = _img;
    }

    public override string ToString()
    {
        return $"{Real}+{Img}i";
    }

    public static Complex operator +(Complex left, Complex right)
    {
        Complex retval = new Complex() { Real = left.Real + right.Real, Img = left.Img + right.Img };
        return retval;
    }

    public static Complex operator ++(Complex com)
    {
        Complex result = new Complex() { Real = com.Real + 1, Img = com.Img + 1 };
        return result;
    }

    public static bool operator >(Complex left, Complex right)
    {
        return (left.Real > right.Real) && (left.Img > right.Img);
    }
    public static bool operator <(Complex left, Complex right)
    {
        return (left.Real < right.Real) && (left.Img < right.Img);
    }
    public static bool operator ==(Complex left, Complex right)
    {
        return (left.Real == right.Real) && (left.Img == right.Img);
    }
    public static bool operator !=(Complex left, Complex right)
    {
        return !(left == right);
    }

    public static implicit operator int(Complex com)
    {
        return com.Real;
    }

    public static explicit operator string(Complex com)
    {
        return com.ToString();
    }

    public static implicit operator Complex(int real)
    {
        return new Complex() {Real = real, Img = 0};
    }
}
