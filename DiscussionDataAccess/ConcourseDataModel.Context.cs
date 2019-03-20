﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ConcourseEntities : DbContext
    {
        public ConcourseEntities()
            : base("name=ConcourseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminData> AdminDatas { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<DiscussionBoard> DiscussionBoards { get; set; }
        public virtual DbSet<DiscussionBoardCode> DiscussionBoardCodes { get; set; }
        public virtual DbSet<DiscussionBoardMember> DiscussionBoardMembers { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
    
        public virtual ObjectResult<spBanUserFromDiscussionBoard_Result> spBanUserFromDiscussionBoard(string userId, string userIdToBan, Nullable<int> discussionBoardId, Nullable<int> banValue)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var userIdToBanParameter = userIdToBan != null ?
                new ObjectParameter("UserIdToBan", userIdToBan) :
                new ObjectParameter("UserIdToBan", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var banValueParameter = banValue.HasValue ?
                new ObjectParameter("BanValue", banValue) :
                new ObjectParameter("BanValue", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spBanUserFromDiscussionBoard_Result>("spBanUserFromDiscussionBoard", userIdParameter, userIdToBanParameter, discussionBoardIdParameter, banValueParameter);
        }
    
        public virtual ObjectResult<spGetCommentsByPostId_Result> spGetCommentsByPostId(Nullable<int> discussionBoardId, Nullable<int> postId, string userId)
        {
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCommentsByPostId_Result>("spGetCommentsByPostId", discussionBoardIdParameter, postIdParameter, userIdParameter);
        }
    
        public virtual ObjectResult<spGetDiscussionBoardsByUserId_Result> spGetDiscussionBoardsByUserId(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetDiscussionBoardsByUserId_Result>("spGetDiscussionBoardsByUserId", userIdParameter);
        }
    
        public virtual int spConfirmUserById(string userId, string userIdToConfirm, Nullable<int> discussionBoardId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var userIdToConfirmParameter = userIdToConfirm != null ?
                new ObjectParameter("UserIdToConfirm", userIdToConfirm) :
                new ObjectParameter("UserIdToConfirm", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spConfirmUserById", userIdParameter, userIdToConfirmParameter, discussionBoardIdParameter);
        }
    
        public virtual int spCreateComment(string userId, Nullable<int> discussionBoardId, Nullable<int> postId, string content)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            var contentParameter = content != null ?
                new ObjectParameter("Content", content) :
                new ObjectParameter("Content", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCreateComment", userIdParameter, discussionBoardIdParameter, postIdParameter, contentParameter);
        }
    
        public virtual int spCreateDiscussionBoard(string userId, string title, string code, string description)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCreateDiscussionBoard", userIdParameter, titleParameter, codeParameter, descriptionParameter);
        }
    
        public virtual int spCreatePost(Nullable<int> discussionBoardId, string userId, string title, string content)
        {
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var contentParameter = content != null ?
                new ObjectParameter("Content", content) :
                new ObjectParameter("Content", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCreatePost", discussionBoardIdParameter, userIdParameter, titleParameter, contentParameter);
        }
    
        public virtual int spDeleteCommentById(string userId, Nullable<int> discussionBoardId, Nullable<int> commentId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var commentIdParameter = commentId.HasValue ?
                new ObjectParameter("CommentId", commentId) :
                new ObjectParameter("CommentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteCommentById", userIdParameter, discussionBoardIdParameter, commentIdParameter);
        }
    
        public virtual int spDeleteDiscussionBoard(string userId, Nullable<int> discussionBoardId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteDiscussionBoard", userIdParameter, discussionBoardIdParameter);
        }
    
        public virtual int spDeletePost(Nullable<int> discussionBoardId, string userId, Nullable<int> postId)
        {
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeletePost", discussionBoardIdParameter, userIdParameter, postIdParameter);
        }
    
        public virtual ObjectResult<spGetDiscussionBoardMembers_Result> spGetDiscussionBoardMembers(string userId, Nullable<int> discussionBoardId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetDiscussionBoardMembers_Result>("spGetDiscussionBoardMembers", userIdParameter, discussionBoardIdParameter);
        }
    
        public virtual ObjectResult<spGetPosts_Result> spGetPosts(Nullable<int> discussionBoardId, string userId)
        {
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPosts_Result>("spGetPosts", discussionBoardIdParameter, userIdParameter);
        }
    
        public virtual int spJoinDiscussionBoard(Nullable<int> codeId, string code, string userId)
        {
            var codeIdParameter = codeId.HasValue ?
                new ObjectParameter("CodeId", codeId) :
                new ObjectParameter("CodeId", typeof(int));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spJoinDiscussionBoard", codeIdParameter, codeParameter, userIdParameter);
        }
    
        public virtual int spRemoveUserFromDiscussionBoard(string userId, string userIdToRemove, Nullable<int> discussionBoardId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var userIdToRemoveParameter = userIdToRemove != null ?
                new ObjectParameter("UserIdToRemove", userIdToRemove) :
                new ObjectParameter("UserIdToRemove", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRemoveUserFromDiscussionBoard", userIdParameter, userIdToRemoveParameter, discussionBoardIdParameter);
        }
    
        public virtual int spUpdateCommentById(string userId, Nullable<int> commentId, Nullable<int> discussionBoardId, string newContent)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var commentIdParameter = commentId.HasValue ?
                new ObjectParameter("CommentId", commentId) :
                new ObjectParameter("CommentId", typeof(int));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var newContentParameter = newContent != null ?
                new ObjectParameter("NewContent", newContent) :
                new ObjectParameter("NewContent", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateCommentById", userIdParameter, commentIdParameter, discussionBoardIdParameter, newContentParameter);
        }
    
        public virtual int spUpdateDiscussionBoard(string userId, Nullable<int> discussionBoardId, string newTitle, string newDescription)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var newTitleParameter = newTitle != null ?
                new ObjectParameter("NewTitle", newTitle) :
                new ObjectParameter("NewTitle", typeof(string));
    
            var newDescriptionParameter = newDescription != null ?
                new ObjectParameter("NewDescription", newDescription) :
                new ObjectParameter("NewDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateDiscussionBoard", userIdParameter, discussionBoardIdParameter, newTitleParameter, newDescriptionParameter);
        }
    
        public virtual int spUpdateDiscussionBoardCode(string userId, Nullable<int> discussionBoardId, string newCode)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var newCodeParameter = newCode != null ?
                new ObjectParameter("NewCode", newCode) :
                new ObjectParameter("NewCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateDiscussionBoardCode", userIdParameter, discussionBoardIdParameter, newCodeParameter);
        }
    
        public virtual int spUpdatePost(Nullable<int> discussionBoardId, string userId, Nullable<int> postId, string newTitle, string newContent)
        {
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            var newTitleParameter = newTitle != null ?
                new ObjectParameter("NewTitle", newTitle) :
                new ObjectParameter("NewTitle", typeof(string));
    
            var newContentParameter = newContent != null ?
                new ObjectParameter("NewContent", newContent) :
                new ObjectParameter("NewContent", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdatePost", discussionBoardIdParameter, userIdParameter, postIdParameter, newTitleParameter, newContentParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int spHasPermissions(string userId, Nullable<int> discussionBoardId, ObjectParameter status)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spHasPermissions", userIdParameter, discussionBoardIdParameter, status);
        }
    
        public virtual int spIsAdmin(string userId, ObjectParameter status)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIsAdmin", userIdParameter, status);
        }
    
        public virtual int spIsBanned(string userId, Nullable<int> discussionBoardId, ObjectParameter status)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIsBanned", userIdParameter, discussionBoardIdParameter, status);
        }
    
        public virtual int spIsConfirmed(string userId, Nullable<int> discussionBoardId, ObjectParameter status)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIsConfirmed", userIdParameter, discussionBoardIdParameter, status);
        }
    
        public virtual int spIsMemberOfDiscussionBoard(string userId, Nullable<int> discussionBoardId, ObjectParameter status)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIsMemberOfDiscussionBoard", userIdParameter, discussionBoardIdParameter, status);
        }
    
        public virtual int spIsValidDiscussionBoard(Nullable<int> discussionBoardId, ObjectParameter status)
        {
            var discussionBoardIdParameter = discussionBoardId.HasValue ?
                new ObjectParameter("DiscussionBoardId", discussionBoardId) :
                new ObjectParameter("DiscussionBoardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIsValidDiscussionBoard", discussionBoardIdParameter, status);
        }
    
        public virtual int spIsValidUser(string id, ObjectParameter status)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIsValidUser", idParameter, status);
        }
    }
}
