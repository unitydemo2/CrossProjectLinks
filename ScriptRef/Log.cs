using System.Diagnostics;

namespace DiffPlex
{
    
    /// <summary>
    /// [5c46c35d04915438846c9457](CSharp Code_5c46c35d04915438846c9457.cs)
    /// </summary>
    /// <description>
    /// [5c46c35d04915438846c9457](CSharp Code_5c46c35d04915438846c9457.cs)
    /// </description>
    public static class Log
    {
        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        [Conditional("LOG")]
        public static void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(string.Format(format, args));
        }

        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        [Conditional("LOG")]
        public static void Write(string format, params object[] args)
        {
            // not implemented
        }

        
        
        public delegate int TestDelegate(string s);

        
        
        public delegate void CalculateSquare(double number);
    }
}