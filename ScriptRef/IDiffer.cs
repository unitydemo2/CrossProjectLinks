using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                                                                /// Provides methods for generate differences between texts  <br/>
                                                                /// </summary>
                                                                /// <description>
                                                                /// <br/>  import java.util.Scanner;<br/>  rtttttttttttttttttttttttttttttttttttttttt<br/>   <br/>  class AddNumbers<br/>  {<br/>     public static void main(String args[])<br/>     {<br/>        int x, y, z;<br/>   <br/>        System.out.println("Enter two integers to calculate their sum");<br/>        Scanner in = new Scanner(System.in);<br/>       <br/>        x = in.nextInt();<br/>        y = in.nextInt();<br/>        z = x + y;<br/>       <br/>        System.out.println("Sum of the integers  &<>;:!@#$%^= " + z);<br/>     }<br/>  }<br/> <br/>
                                                                /// </description>
                                                                                                                            public interface IDiffer
    {
        
        
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}