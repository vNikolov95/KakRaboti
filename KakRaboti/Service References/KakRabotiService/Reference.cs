﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KakRaboti.KakRabotiService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Article", Namespace="http://schemas.datacontract.org/2004/07/KakRabotiBusiness", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Article : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KakRaboti.KakRabotiService.Category CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KakRaboti.KakRabotiService.Comment[] CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAddedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FriendlyTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThumbnailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ViewsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KakRaboti.KakRabotiService.Category Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryID {
            get {
                return this.CategoryIDField;
            }
            set {
                if ((this.CategoryIDField.Equals(value) != true)) {
                    this.CategoryIDField = value;
                    this.RaisePropertyChanged("CategoryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KakRaboti.KakRabotiService.Comment[] Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded {
            get {
                return this.DateAddedField;
            }
            set {
                if ((this.DateAddedField.Equals(value) != true)) {
                    this.DateAddedField = value;
                    this.RaisePropertyChanged("DateAdded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FriendlyTitle {
            get {
                return this.FriendlyTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.FriendlyTitleField, value) != true)) {
                    this.FriendlyTitleField = value;
                    this.RaisePropertyChanged("FriendlyTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Thumbnail {
            get {
                return this.ThumbnailField;
            }
            set {
                if ((object.ReferenceEquals(this.ThumbnailField, value) != true)) {
                    this.ThumbnailField = value;
                    this.RaisePropertyChanged("Thumbnail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Views {
            get {
                return this.ViewsField;
            }
            set {
                if ((this.ViewsField.Equals(value) != true)) {
                    this.ViewsField = value;
                    this.RaisePropertyChanged("Views");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/KakRabotiBusiness", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KakRaboti.KakRabotiService.Article[] ArticlesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KakRaboti.KakRabotiService.Article[] Articles {
            get {
                return this.ArticlesField;
            }
            set {
                if ((object.ReferenceEquals(this.ArticlesField, value) != true)) {
                    this.ArticlesField = value;
                    this.RaisePropertyChanged("Articles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/KakRabotiBusiness", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private KakRaboti.KakRabotiService.Article ArticleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ArticleIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAddedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KakRaboti.KakRabotiService.Article Article {
            get {
                return this.ArticleField;
            }
            set {
                if ((object.ReferenceEquals(this.ArticleField, value) != true)) {
                    this.ArticleField = value;
                    this.RaisePropertyChanged("Article");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ArticleId {
            get {
                return this.ArticleIdField;
            }
            set {
                if ((this.ArticleIdField.Equals(value) != true)) {
                    this.ArticleIdField = value;
                    this.RaisePropertyChanged("ArticleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded {
            get {
                return this.DateAddedField;
            }
            set {
                if ((this.DateAddedField.Equals(value) != true)) {
                    this.DateAddedField = value;
                    this.RaisePropertyChanged("DateAdded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KakRabotiService.IKakRabotiService")]
    public interface IKakRabotiService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/DeleteComment", ReplyAction="http://tempuri.org/IKakRabotiService/DeleteCommentResponse")]
        void DeleteComment(int commentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/DeleteComment", ReplyAction="http://tempuri.org/IKakRabotiService/DeleteCommentResponse")]
        System.Threading.Tasks.Task DeleteCommentAsync(int commentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetAllArticles", ReplyAction="http://tempuri.org/IKakRabotiService/GetAllArticlesResponse")]
        KakRaboti.KakRabotiService.Article[] GetAllArticles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetAllArticles", ReplyAction="http://tempuri.org/IKakRabotiService/GetAllArticlesResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article[]> GetAllArticlesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetNotApprovedArticles", ReplyAction="http://tempuri.org/IKakRabotiService/GetNotApprovedArticlesResponse")]
        KakRaboti.KakRabotiService.Article[] GetNotApprovedArticles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetNotApprovedArticles", ReplyAction="http://tempuri.org/IKakRabotiService/GetNotApprovedArticlesResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article[]> GetNotApprovedArticlesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/ApproveArticle", ReplyAction="http://tempuri.org/IKakRabotiService/ApproveArticleResponse")]
        void ApproveArticle(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/ApproveArticle", ReplyAction="http://tempuri.org/IKakRabotiService/ApproveArticleResponse")]
        System.Threading.Tasks.Task ApproveArticleAsync(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetArticleById", ReplyAction="http://tempuri.org/IKakRabotiService/GetArticleByIdResponse")]
        KakRaboti.KakRabotiService.Article GetArticleById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetArticleById", ReplyAction="http://tempuri.org/IKakRabotiService/GetArticleByIdResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article> GetArticleByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/UpdateArticleViews", ReplyAction="http://tempuri.org/IKakRabotiService/UpdateArticleViewsResponse")]
        void UpdateArticleViews(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/UpdateArticleViews", ReplyAction="http://tempuri.org/IKakRabotiService/UpdateArticleViewsResponse")]
        System.Threading.Tasks.Task UpdateArticleViewsAsync(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetAllCategories", ReplyAction="http://tempuri.org/IKakRabotiService/GetAllCategoriesResponse")]
        KakRaboti.KakRabotiService.Category[] GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetAllCategories", ReplyAction="http://tempuri.org/IKakRabotiService/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category[]> GetAllCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetCategoryById", ReplyAction="http://tempuri.org/IKakRabotiService/GetCategoryByIdResponse")]
        KakRaboti.KakRabotiService.Category GetCategoryById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetCategoryById", ReplyAction="http://tempuri.org/IKakRabotiService/GetCategoryByIdResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category> GetCategoryByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/CreateCategory", ReplyAction="http://tempuri.org/IKakRabotiService/CreateCategoryResponse")]
        KakRaboti.KakRabotiService.Category CreateCategory(KakRaboti.KakRabotiService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/CreateCategory", ReplyAction="http://tempuri.org/IKakRabotiService/CreateCategoryResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category> CreateCategoryAsync(KakRaboti.KakRabotiService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/EditCategory", ReplyAction="http://tempuri.org/IKakRabotiService/EditCategoryResponse")]
        KakRaboti.KakRabotiService.Category EditCategory(KakRaboti.KakRabotiService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/EditCategory", ReplyAction="http://tempuri.org/IKakRabotiService/EditCategoryResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category> EditCategoryAsync(KakRaboti.KakRabotiService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/CreateArticle", ReplyAction="http://tempuri.org/IKakRabotiService/CreateArticleResponse")]
        KakRaboti.KakRabotiService.Article CreateArticle(KakRaboti.KakRabotiService.Article article);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/CreateArticle", ReplyAction="http://tempuri.org/IKakRabotiService/CreateArticleResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article> CreateArticleAsync(KakRaboti.KakRabotiService.Article article);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/DeleteCategory", ReplyAction="http://tempuri.org/IKakRabotiService/DeleteCategoryResponse")]
        void DeleteCategory(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/DeleteCategory", ReplyAction="http://tempuri.org/IKakRabotiService/DeleteCategoryResponse")]
        System.Threading.Tasks.Task DeleteCategoryAsync(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/EditArticle", ReplyAction="http://tempuri.org/IKakRabotiService/EditArticleResponse")]
        void EditArticle(KakRaboti.KakRabotiService.Article article);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/EditArticle", ReplyAction="http://tempuri.org/IKakRabotiService/EditArticleResponse")]
        System.Threading.Tasks.Task EditArticleAsync(KakRaboti.KakRabotiService.Article article);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/DeleteArticle", ReplyAction="http://tempuri.org/IKakRabotiService/DeleteArticleResponse")]
        KakRaboti.KakRabotiService.Article DeleteArticle(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/DeleteArticle", ReplyAction="http://tempuri.org/IKakRabotiService/DeleteArticleResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article> DeleteArticleAsync(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetComments", ReplyAction="http://tempuri.org/IKakRabotiService/GetCommentsResponse")]
        KakRaboti.KakRabotiService.Comment[] GetComments(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/GetComments", ReplyAction="http://tempuri.org/IKakRabotiService/GetCommentsResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Comment[]> GetCommentsAsync(int articleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/CreateComment", ReplyAction="http://tempuri.org/IKakRabotiService/CreateCommentResponse")]
        KakRaboti.KakRabotiService.Comment CreateComment(KakRaboti.KakRabotiService.Comment comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKakRabotiService/CreateComment", ReplyAction="http://tempuri.org/IKakRabotiService/CreateCommentResponse")]
        System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Comment> CreateCommentAsync(KakRaboti.KakRabotiService.Comment comment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKakRabotiServiceChannel : KakRaboti.KakRabotiService.IKakRabotiService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KakRabotiServiceClient : System.ServiceModel.ClientBase<KakRaboti.KakRabotiService.IKakRabotiService>, KakRaboti.KakRabotiService.IKakRabotiService {
        
        public KakRabotiServiceClient() {
        }
        
        public KakRabotiServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KakRabotiServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KakRabotiServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KakRabotiServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DeleteComment(int commentId) {
            base.Channel.DeleteComment(commentId);
        }
        
        public System.Threading.Tasks.Task DeleteCommentAsync(int commentId) {
            return base.Channel.DeleteCommentAsync(commentId);
        }
        
        public KakRaboti.KakRabotiService.Article[] GetAllArticles() {
            return base.Channel.GetAllArticles();
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article[]> GetAllArticlesAsync() {
            return base.Channel.GetAllArticlesAsync();
        }
        
        public KakRaboti.KakRabotiService.Article[] GetNotApprovedArticles() {
            return base.Channel.GetNotApprovedArticles();
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article[]> GetNotApprovedArticlesAsync() {
            return base.Channel.GetNotApprovedArticlesAsync();
        }
        
        public void ApproveArticle(int articleId) {
            base.Channel.ApproveArticle(articleId);
        }
        
        public System.Threading.Tasks.Task ApproveArticleAsync(int articleId) {
            return base.Channel.ApproveArticleAsync(articleId);
        }
        
        public KakRaboti.KakRabotiService.Article GetArticleById(int id) {
            return base.Channel.GetArticleById(id);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article> GetArticleByIdAsync(int id) {
            return base.Channel.GetArticleByIdAsync(id);
        }
        
        public void UpdateArticleViews(int articleId) {
            base.Channel.UpdateArticleViews(articleId);
        }
        
        public System.Threading.Tasks.Task UpdateArticleViewsAsync(int articleId) {
            return base.Channel.UpdateArticleViewsAsync(articleId);
        }
        
        public KakRaboti.KakRabotiService.Category[] GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category[]> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
        
        public KakRaboti.KakRabotiService.Category GetCategoryById(int id) {
            return base.Channel.GetCategoryById(id);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category> GetCategoryByIdAsync(int id) {
            return base.Channel.GetCategoryByIdAsync(id);
        }
        
        public KakRaboti.KakRabotiService.Category CreateCategory(KakRaboti.KakRabotiService.Category category) {
            return base.Channel.CreateCategory(category);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category> CreateCategoryAsync(KakRaboti.KakRabotiService.Category category) {
            return base.Channel.CreateCategoryAsync(category);
        }
        
        public KakRaboti.KakRabotiService.Category EditCategory(KakRaboti.KakRabotiService.Category category) {
            return base.Channel.EditCategory(category);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Category> EditCategoryAsync(KakRaboti.KakRabotiService.Category category) {
            return base.Channel.EditCategoryAsync(category);
        }
        
        public KakRaboti.KakRabotiService.Article CreateArticle(KakRaboti.KakRabotiService.Article article) {
            return base.Channel.CreateArticle(article);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article> CreateArticleAsync(KakRaboti.KakRabotiService.Article article) {
            return base.Channel.CreateArticleAsync(article);
        }
        
        public void DeleteCategory(int categoryId) {
            base.Channel.DeleteCategory(categoryId);
        }
        
        public System.Threading.Tasks.Task DeleteCategoryAsync(int categoryId) {
            return base.Channel.DeleteCategoryAsync(categoryId);
        }
        
        public void EditArticle(KakRaboti.KakRabotiService.Article article) {
            base.Channel.EditArticle(article);
        }
        
        public System.Threading.Tasks.Task EditArticleAsync(KakRaboti.KakRabotiService.Article article) {
            return base.Channel.EditArticleAsync(article);
        }
        
        public KakRaboti.KakRabotiService.Article DeleteArticle(int articleId) {
            return base.Channel.DeleteArticle(articleId);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Article> DeleteArticleAsync(int articleId) {
            return base.Channel.DeleteArticleAsync(articleId);
        }
        
        public KakRaboti.KakRabotiService.Comment[] GetComments(int articleId) {
            return base.Channel.GetComments(articleId);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Comment[]> GetCommentsAsync(int articleId) {
            return base.Channel.GetCommentsAsync(articleId);
        }
        
        public KakRaboti.KakRabotiService.Comment CreateComment(KakRaboti.KakRabotiService.Comment comment) {
            return base.Channel.CreateComment(comment);
        }
        
        public System.Threading.Tasks.Task<KakRaboti.KakRabotiService.Comment> CreateCommentAsync(KakRaboti.KakRabotiService.Comment comment) {
            return base.Channel.CreateCommentAsync(comment);
        }
    }
}