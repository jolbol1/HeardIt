// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do one of these:
//
//    using HeardIt.Models;
//
//    var subRedditModel = SubRedditModel.FromJson(jsonString);
//    var PostPage = PostPage.FromJson(jsonString);

namespace HeardIt.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using R = Newtonsoft.Json.Required;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class Subreddit
    {
        [J("data")] public SubredditData Data { get; set; }
    }

    public partial class SubredditData
    {
        [J("children")]   public Posts[] Posts { get; set; }
    }

    public partial class Posts
    {
        [J("data")] public PostData Data { get; set; }
    }

    public partial class PostData
    {

        [J("id")] public string Id { get; set; }
        [J("url")] public Uri Url { get; set; }
        [J("permalink", NullValueHandling = N.Ignore)] public string Permalink { get; set; }                   

    }
    
    public partial class PostPage
    {
        [J("kind")] public string Kind { get; set; }       
        [J("data")] public PageData Data { get; set; }
    }

    public partial class PageData
    {
        [J("after")]      public object After { get; set; }          
        [J("dist")]       public long? Dist { get; set; }            
        [J("modhash")]    public string Modhash { get; set; }        
        [J("geo_filter")] public string GeoFilter { get; set; }      
        [J("children")]   public Post[] Children { get; set; }
        [J("before")]     public object Before { get; set; }         
    }

    public partial class Post
    {
        [J("kind")] public string Kind { get; set; }    
        [J("data")] public PostDetails Data { get; set; }
    }

    public partial class PostDetails
    {
        [J("approved_at_utc")]                                           public object ApprovedAtUtc { get; set; }               
        [J("subreddit", NullValueHandling = N.Ignore)]                   public string Subreddit { get; set; }                   
        [J("selftext", NullValueHandling = N.Ignore)]                    public string Selftext { get; set; }                    
        [J("user_reports", NullValueHandling = N.Ignore)]                public object[] UserReports { get; set; }               
        [J("saved", NullValueHandling = N.Ignore)]                       public bool? Saved { get; set; }                        
        [J("mod_reason_title")]                                          public object ModReasonTitle { get; set; }              
        [J("gilded", NullValueHandling = N.Ignore)]                      public long? Gilded { get; set; }                       
        [J("clicked", NullValueHandling = N.Ignore)]                     public bool? Clicked { get; set; }                      
        [J("title", NullValueHandling = N.Ignore)]                       public string Title { get; set; }                       
        [J("link_flair_richtext", NullValueHandling = N.Ignore)]         public object[] LinkFlairRichtext { get; set; }         
        [J("subreddit_name_prefixed", NullValueHandling = N.Ignore)]     public string SubredditNamePrefixed { get; set; }       
        [J("hidden", NullValueHandling = N.Ignore)]                      public bool? Hidden { get; set; }                       
        [J("pwls", NullValueHandling = N.Ignore)]                        public long? Pwls { get; set; }                         
        [J("link_flair_css_class")]                                      public object LinkFlairCssClass { get; set; }           
        [J("downs", NullValueHandling = N.Ignore)]                       public long? Downs { get; set; }                        
        [J("top_awarded_type")]                                          public object TopAwardedType { get; set; }              
        [J("parent_whitelist_status", NullValueHandling = N.Ignore)]     public string ParentWhitelistStatus { get; set; }       
        [J("hide_score", NullValueHandling = N.Ignore)]                  public bool? HideScore { get; set; }                    
        [J("name")]                                                      public string Name { get; set; }                        
        [J("quarantine", NullValueHandling = N.Ignore)]                  public bool? Quarantine { get; set; }                   
        [J("link_flair_text_color", NullValueHandling = N.Ignore)]       public string LinkFlairTextColor { get; set; }          
        [J("upvote_ratio", NullValueHandling = N.Ignore)]                public double? UpvoteRatio { get; set; }                
        [J("author_flair_background_color")]                             public object AuthorFlairBackgroundColor { get; set; }  
        [J("subreddit_type", NullValueHandling = N.Ignore)]              public string SubredditType { get; set; }               
        [J("ups", NullValueHandling = N.Ignore)]                         public long? Ups { get; set; }                          
        [J("total_awards_received", NullValueHandling = N.Ignore)]       public long? TotalAwardsReceived { get; set; }          
        [J("author_flair_template_id")]                                  public Guid? AuthorFlairTemplateId { get; set; }        
        [J("is_original_content", NullValueHandling = N.Ignore)]         public bool? IsOriginalContent { get; set; }            
        [J("author_fullname", NullValueHandling = N.Ignore)]             public string AuthorFullname { get; set; }              
        [J("secure_media")]                                              public object SecureMedia { get; set; }                 
        [J("is_reddit_media_domain", NullValueHandling = N.Ignore)]      public bool? IsRedditMediaDomain { get; set; }          
        [J("is_meta", NullValueHandling = N.Ignore)]                     public bool? IsMeta { get; set; }                       
        [J("category")]                                                  public object Category { get; set; }                    
        [J("link_flair_text")]                                           public object LinkFlairText { get; set; }               
        [J("can_mod_post", NullValueHandling = N.Ignore)]                public bool? CanModPost { get; set; }                   
        [J("score", NullValueHandling = N.Ignore)]                       public long? Score { get; set; }                        
        [J("approved_by")]                                               public object ApprovedBy { get; set; }                  
        [J("is_created_from_ads_ui", NullValueHandling = N.Ignore)]      public bool? IsCreatedFromAdsUi { get; set; }           
        [J("author_premium", NullValueHandling = N.Ignore)]              public bool? AuthorPremium { get; set; }                
        [J("thumbnail", NullValueHandling = N.Ignore)]                   public string Thumbnail { get; set; }                   
        [J("author_flair_css_class")]                                    public string AuthorFlairCssClass { get; set; }         
        [J("author_flair_richtext", NullValueHandling = N.Ignore)]       public object[] AuthorFlairRichtext { get; set; }       
        [J("content_categories")]                                        public object ContentCategories { get; set; }           
        [J("is_self", NullValueHandling = N.Ignore)]                     public bool? IsSelf { get; set; }                       
        [J("mod_note")]                                                  public object ModNote { get; set; }                     
        [J("created", NullValueHandling = N.Ignore)]                     public long? Created { get; set; }                      
        [J("link_flair_type", NullValueHandling = N.Ignore)]             public string LinkFlairType { get; set; }               
        [J("wls", NullValueHandling = N.Ignore)]                         public long? Wls { get; set; }                          
        [J("removed_by_category")]                                       public object RemovedByCategory { get; set; }           
        [J("banned_by")]                                                 public object BannedBy { get; set; }                    
        [J("author_flair_type", NullValueHandling = N.Ignore)]           public string AuthorFlairType { get; set; }             
        [J("domain", NullValueHandling = N.Ignore)]                      public string Domain { get; set; }                      
        [J("allow_live_comments", NullValueHandling = N.Ignore)]         public bool? AllowLiveComments { get; set; }            
        [J("selftext_html", NullValueHandling = N.Ignore)]               public string SelftextHtml { get; set; }                
        [J("likes")]                                                     public object Likes { get; set; }                       
        [J("suggested_sort")]                                            public object SuggestedSort { get; set; }               
        [J("banned_at_utc")]                                             public object BannedAtUtc { get; set; }                 
        [J("view_count")]                                                public object ViewCount { get; set; }                   
        [J("archived", NullValueHandling = N.Ignore)]                    public bool? Archived { get; set; }                     
        [J("no_follow", NullValueHandling = N.Ignore)]                   public bool? NoFollow { get; set; }                     
        [J("is_crosspostable", NullValueHandling = N.Ignore)]            public bool? IsCrosspostable { get; set; }              
        [J("pinned", NullValueHandling = N.Ignore)]                      public bool? Pinned { get; set; }                       
        [J("over_18", NullValueHandling = N.Ignore)]                     public bool? Over18 { get; set; }                       
        [J("awarders", NullValueHandling = N.Ignore)]                    public object[] Awarders { get; set; }                  
        [J("media_only", NullValueHandling = N.Ignore)]                  public bool? MediaOnly { get; set; }                    
        [J("can_gild", NullValueHandling = N.Ignore)]                    public bool? CanGild { get; set; }                      
        [J("spoiler", NullValueHandling = N.Ignore)]                     public bool? Spoiler { get; set; }                      
        [J("locked", NullValueHandling = N.Ignore)]                      public bool? Locked { get; set; }                       
        [J("author_flair_text")]                                         public string AuthorFlairText { get; set; }             
        [J("treatment_tags", NullValueHandling = N.Ignore)]              public object[] TreatmentTags { get; set; }             
        [J("visited", NullValueHandling = N.Ignore)]                     public bool? Visited { get; set; }                      
        [J("removed_by")]                                                public object RemovedBy { get; set; }                   
        [J("num_reports")]                                               public object NumReports { get; set; }                  
        [J("distinguished")]                                             public object Distinguished { get; set; }               
        [J("subreddit_id", NullValueHandling = N.Ignore)]                public string SubredditId { get; set; }                 
        [J("author_is_blocked", NullValueHandling = N.Ignore)]           public bool? AuthorIsBlocked { get; set; }              
        [J("mod_reason_by")]                                             public object ModReasonBy { get; set; }                 
        [J("removal_reason")]                                            public object RemovalReason { get; set; }               
        [J("link_flair_background_color", NullValueHandling = N.Ignore)] public string LinkFlairBackgroundColor { get; set; }    
        [J("id")]                                                        public string Id { get; set; }                          
        [J("is_robot_indexable", NullValueHandling = N.Ignore)]          public bool? IsRobotIndexable { get; set; }             
        [J("num_duplicates", NullValueHandling = N.Ignore)]              public long? NumDuplicates { get; set; }                
        [J("report_reasons")]                                            public object ReportReasons { get; set; }               
        [J("author", NullValueHandling = N.Ignore)]                      public string Author { get; set; }                      
        [J("discussion_type")]                                           public object DiscussionType { get; set; }              
        [J("num_comments", NullValueHandling = N.Ignore)]                public long? NumComments { get; set; }                  
        [J("send_replies", NullValueHandling = N.Ignore)]                public bool? SendReplies { get; set; }                  
        [J("media")]                                                     public object Media { get; set; }                       
        [J("contest_mode", NullValueHandling = N.Ignore)]                public bool? ContestMode { get; set; }                  
        [J("author_patreon_flair", NullValueHandling = N.Ignore)]        public bool? AuthorPatreonFlair { get; set; }           
        [J("author_flair_text_color")]                                   public string AuthorFlairTextColor { get; set; }        
        [J("permalink", NullValueHandling = N.Ignore)]                   public string Permalink { get; set; }                   
        [J("whitelist_status", NullValueHandling = N.Ignore)]            public string WhitelistStatus { get; set; }             
        [J("stickied", NullValueHandling = N.Ignore)]                    public bool? Stickied { get; set; }                     
        [J("url", NullValueHandling = N.Ignore)]                         public Uri Url { get; set; }                            
        [J("subreddit_subscribers", NullValueHandling = N.Ignore)]       public long? SubredditSubscribers { get; set; }         
        [J("created_utc", NullValueHandling = N.Ignore)]                 public long? CreatedUtc { get; set; }                   
        [J("num_crossposts", NullValueHandling = N.Ignore)]              public long? NumCrossposts { get; set; }                
        [J("mod_reports", NullValueHandling = N.Ignore)]                 public object[] ModReports { get; set; }                
        [J("is_video", NullValueHandling = N.Ignore)]                    public bool? IsVideo { get; set; }                      
        [J("comment_type")]                                              public object CommentType { get; set; }                 
        [J("collapsed_reason_code")]                                     public object CollapsedReasonCode { get; set; }         
        [J("parent_id", NullValueHandling = N.Ignore)]                   public string ParentId { get; set; }                    
        [J("collapsed", NullValueHandling = N.Ignore)]                   public bool? Collapsed { get; set; }                    
        [J("body", NullValueHandling = N.Ignore)]                        public string Body { get; set; }                        
        [J("is_submitter", NullValueHandling = N.Ignore)]                public bool? IsSubmitter { get; set; }                  
        [J("body_html", NullValueHandling = N.Ignore)]                   public string BodyHtml { get; set; }                    
        [J("collapsed_reason")]                                          public object CollapsedReason { get; set; }             
        [J("associated_award")]                                          public object AssociatedAward { get; set; }             
        [J("unrepliable_reason")]                                        public object UnrepliableReason { get; set; }           
        [J("score_hidden", NullValueHandling = N.Ignore)]                public bool? ScoreHidden { get; set; }                  
        [J("link_id", NullValueHandling = N.Ignore)]                     public string LinkId { get; set; }                      
        [J("controversiality", NullValueHandling = N.Ignore)]            public long? Controversiality { get; set; }             
        [J("depth", NullValueHandling = N.Ignore)]                       public long? Depth { get; set; }                        
        [J("collapsed_because_crowd_control")]                           public object CollapsedBecauseCrowdControl { get; set; }
        [J("count", NullValueHandling = N.Ignore)]                       public long? Count { get; set; }                        
        [J("children", NullValueHandling = N.Ignore)]                    public string[] Children { get; set; }                  
    }
    

    public partial class Subreddit
    {
        public static Subreddit FromJson(string json) => JsonConvert.DeserializeObject<Subreddit>(json, HeardIt.Models.Converter.Settings);
    }

    public partial class PostPage
    {
        public static PostPage[] FromJson(string json) => JsonConvert.DeserializeObject<PostPage[]>(json, HeardIt.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Subreddit self) => JsonConvert.SerializeObject(self, HeardIt.Models.Converter.Settings);
        public static string ToJson(this PostPage[] self) => JsonConvert.SerializeObject(self, HeardIt.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    
}
