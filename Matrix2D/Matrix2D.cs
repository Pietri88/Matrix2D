namespace Matrix2DLib
{
    public class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Matrix2D() : this(1,0,0,1)
        {
            
        }

        public static readonly Matrix2D Zero = new (0, 0, 0, 0);
        public static readonly Matrix2D Id = new();
        public override string ToString() => $"[[{A}, {B}], [{C}, {D}]]";

        public bool Equals(Matrix2D? other)
        {
            if(other is null) return false;
            return A == other.A && B==other.B && C == other.C && D == other.D;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Matrix2D) return false;

            return Equals((Matrix2D)obj );
        }


        public override int GetHashCode()=> HashCode.Combine(A, B, C, D);
        

        public static bool operator==(Matrix2D left, Matrix2D right)
                                               => left.Equals(right);
        public static bool operator !=(Matrix2D left, Matrix2D right)
                                               => !(left==right);

    }
}
