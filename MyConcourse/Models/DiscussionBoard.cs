//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyConcourse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiscussionBoard
    {
        public int DiscussionBoardId { get; set; }
        public string AdminId { get; set; }
        public string Title { get; set; }
        public string BoardDescription { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }

        public DiscussionBoard() { }
    }
}
