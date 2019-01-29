namespace DiffPlex.Model
{
    /// <summary>
            /// A block of consecutive edits from A and/or B
            /// </summary>
            /// <description>
            /// </description>
                    public class DiffBlock : DiffResult
    {
        /// <summary>
                        /// Position where deletions in A begin
                        /// </summary>
                        /// <description>
                        /// </description>
                                        public int DeleteStartA { get; }

        /// <summary>
                        /// The number of deletions in A
                        /// </summary>
                        /// <description>
                        /// </description>
                                        public int DeleteCountA { get; }

        /// <summary>
                        /// Position where insertion in B begin
                        /// </summary>
                        /// <description>
                        /// </description>
                                        public int InsertStartB { get; }

        /// <summary>
                        /// The number of insertions in B
                        /// </summary>
                        /// <description>
                        /// </description>
                                        public int InsertCountB { get; }


        
        /// <summary>
        /// [5c4054828e5c551c7085f5dd](Addedtaggroupto project_5c4054828e5c551c7085f5dd.cs)
        /// </summary>
        /// <description>
        /// </description>
        public DiffBlock(int deleteStartA, int deleteCountA, int insertStartB, int insertCountB)
        {
            DeleteStartA = deleteStartA;
            DeleteCountA = deleteCountA;
            InsertStartB = insertStartB;
            InsertCountB = insertCountB;
        }
    }
}