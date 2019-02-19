using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts
                /// </summary>
                /// <description>
                /// ![abc](angeler_5c6b9b40c6f96208d4f086d6.jpg)
                /// </description>
                            public interface IDiffer
    {
        
        /// <returns>
        /// <DiffPlex>
        /// <Model>
        /// <DiffResult>
        /// </DiffResult>
        /// </Model>
        /// </DiffPlex>
        /// </returns>
        /// <param name="oldText">
        /// </param>
        /// <param name="newText">
        /// </param>
        /// <param name="ignoreWhitespace">
        /// </param>
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        /// <returns>
        /// <DiffPlex>
        /// <Model>
        /// <DiffResult>
        /// </DiffResult>
        /// </Model>
        /// </DiffPlex>
        /// </returns>
        /// <param name="oldText">
        /// </param>
        /// <param name="newText">
        /// </param>
        /// <param name="ignoreWhitespace">
        /// </param>
        /// <param name="ignoreCase">
        /// </param>
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <returns>
        /// <DiffPlex>
        /// <Model>
        /// <DiffResult>
        /// </DiffResult>
        /// </Model>
        /// </DiffPlex>
        /// </returns>
        /// <param name="oldText">
        /// </param>
        /// <param name="newText">
        /// </param>
        /// <param name="ignoreWhitespace">
        /// </param>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        /// <returns>
        /// <DiffPlex>
        /// <Model>
        /// <DiffResult>
        /// </DiffResult>
        /// </Model>
        /// </DiffPlex>
        /// </returns>
        /// <param name="oldText">
        /// </param>
        /// <param name="newText">
        /// </param>
        /// <param name="ignoreWhitespace">
        /// </param>
        /// <param name="ignoreCase">
        /// </param>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <returns>
        /// <DiffPlex>
        /// <Model>
        /// <DiffResult>
        /// </DiffResult>
        /// </Model>
        /// </DiffPlex>
        /// </returns>
        /// <param name="oldText">
        /// </param>
        /// <param name="newText">
        /// </param>
        /// <param name="ignoreWhitespace">
        /// </param>
        /// <param name="separators">
        /// </param>
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        /// <returns>
        /// <DiffPlex>
        /// <Model>
        /// <DiffResult>
        /// </DiffResult>
        /// </Model>
        /// </DiffPlex>
        /// </returns>
        /// <param name="oldText">
        /// </param>
        /// <param name="newText">
        /// </param>
        /// <param name="ignoreWhitespace">
        /// </param>
        /// <param name="ignoreCase">
        /// </param>
        /// <param name="separators">
        /// </param>
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}