using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class poly
    {
        // A utility function to return maximum of two integers  
        static int max(int m, int n)
        {
            return (m > n) ? m : n;
        }
        public static int[] String2Int(string[] A)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
                B[i] = int.Parse(A[i]);
            return B;
        }
        // A[] represents coefficients of first polynomial  
        // B[] represents coefficients of second polynomial  
        // m and n are sizes of A[] and B[] respectively  
        public static int[] add(int[] A, int[] B)
        {
            int m = A.Length;
            int n = B.Length;
            int size = max(m, n);
            int[] sum = new int[size];
            // Initialize the porduct polynomial  
            for (int i = 0; i < m; i++)
            {
                sum[i] = A[i];
            }
            // Take ever term of first polynomial  
            for (int i = 0; i < n; i++)
            {
                sum[i] += B[i];
            }
            return sum;
        }
        public static int[] sub(int[] A, int[] B)
        {
            int m = A.Length;
            int n = B.Length;
            int size = max(m, n);
            int[] sum = new int[size];
            // Initialize the porduct polynomial  
            for (int i = 0; i < m; i++)
            {
                sum[i] = A[i];
            }
            // Take ever term of first polynomial  
            for (int i = 0; i < n; i++)
            {
                sum[i] -= B[i];
            }
            return sum;
        }
        public static int[] multiply(int[] A, int[] B)
        {
            int m = A.Length;
            int n = B.Length;
            int[] prod = new int[m + n - 1];
            // Initialize the porduct polynomial 
            for (int i = 0; i < m + n - 1; i++)
            {
                prod[i] = 0;
            }
            // Multiply two polynomials term by term 
            // Take ever term of first polynomial 
            for (int i = 0; i < m; i++)
            {
                // Multiply the current term of first polynomial 
                // with every term of second polynomial. 
                for (int j = 0; j < n; j++)
                {
                    prod[i + j] += A[i] * B[j];
                }
            }
            return prod;
        }
        //evaluation
        public static int Eval(int[] A, int x)
        {
            int polySum = A[0];
            int num = A.Length;
            for (int i = 1; i < num; i++)
            {
                polySum += A[i] * (int)Math.Pow(x, i);
            }
            return polySum;
        }
        // A utility function to print a polynomial  
        public static string printPoly(int[] poly)
        {
            int n = poly.Length;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                str.Append(poly[i]);
                if (i != 0)
                {
                    str.Append("x^" + i);
                }
                if (i != n - 1)
                {
                    str.Append(" + ");
                }
            }
            return str.ToString();
        }
    }
}
