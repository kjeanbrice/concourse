//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiscussionDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiscussionBoardMember
    {
        public int DiscussionBoardId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> UserRole { get; set; }
        public string UserName { get; set; }
        public Nullable<int> IsConfirmed { get; set; }
        public Nullable<int> IsBanned { get; set; }
        public Nullable<System.DateTime> DateJoined { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    
        public virtual DiscussionBoard DiscussionBoard { get; set; }
    }
}
