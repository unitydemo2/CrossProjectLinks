//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    /// <summary>
    /// Testing cross project links for scriptref12121
    /// </summary>
    /// <description>
    /// ![](Chrysanthemum_5c6792fa1b16f52820f886c3.jpeg)
    /// </description>
    public interface IMerger
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}
