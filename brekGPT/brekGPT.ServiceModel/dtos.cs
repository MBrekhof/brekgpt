/* Options:
Date: 2023-11-12 19:49:35
Version: 6.110
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: https://localhost:5001
UsePath: /crud/all/csharp

//GlobalNamespace: 
//MakePartial: False
//MakeVirtual: False
//MakeInternal: False
//MakeDataContractsExtensible: False
//AddNullableAnnotations: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: True
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: False
//ExportValueTypes: False
//IncludeTypes: 
//ExcludeTypes: 
//AddNamespaces: 
//AddDefaultXmlNamespace: 
//IncludeCrudOperations: 
//Schema: 
//NamedConnection: 
//IncludeTables: 
//ExcludeTables: 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using brekGPT.ServiceModel.Types;
using brekGPT.ServiceModel;

namespace brekGPT.ServiceModel
{
    [Route("/articles", "POST")]
    public class CreateArticle
        : IReturn<IdResponse>, IPost, ICreateDb<Article>
    {
        public string Articlename { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
    }

    [Route("/articledetails", "POST")]
    public class CreateArticledetail
        : IReturn<IdResponse>, IPost, ICreateDb<Articledetail>
    {
        public int Articleid { get; set; }
        public int Articlesequence { get; set; }
        public string Articlecontent { get; set; }
        public int Tokens { get; set; }
    }

    [Route("/chats", "POST")]
    public class CreateChat
        : IReturn<IdResponse>, IPost, ICreateDb<Chat>
    {
        public string Question { get; set; }
        public string Questiondatastring { get; set; }
        public int? Promptid { get; set; }
        public string Answer { get; set; }
        public int? Tokens { get; set; }
        public int? Chatmodelid { get; set; }
        public DateTime? Created { get; set; }
    }

    [Route("/chatmodels", "POST")]
    public class CreateChatmodel
        : IReturn<IdResponse>, IPost, ICreateDb<Chatmodel>
    {
        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    [Route("/codeobjects", "POST")]
    public class CreateCodeobject
        : IReturn<IdResponse>, IPost, ICreateDb<Codeobject>
    {
        public string Subject { get; set; }
        public int Codeobjectcategoryid { get; set; }
        public string Codeobjectcontent { get; set; }
        public int Tokens { get; set; }
    }

    [Route("/codeobjectcategories", "POST")]
    public class CreateCodeobjectcategory
        : IReturn<IdResponse>, IPost, ICreateDb<Codeobjectcategory>
    {
        public string Category { get; set; }
    }

    [Route("/costs", "POST")]
    public class CreateCost
        : IReturn<IdResponse>, IPost, ICreateDb<Cost>
    {
        public int? Sourcetype { get; set; }
        public int? Articledetailid { get; set; }
        public int? Llmaction { get; set; }
        public int? Codeobjectid { get; set; }
        public int? Chatid { get; set; }
        public int? Prompttokens { get; set; }
        public int? Completiontokens { get; set; }
        public int? Totaltokens { get; set; }
        public int? Articleid { get; set; }
        public DateTime? Created { get; set; }
    }

    [Route("/embeddingmodels", "POST")]
    public class CreateEmbeddingmodel
        : IReturn<IdResponse>, IPost, ICreateDb<Embeddingmodel>
    {
        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    [Route("/events", "POST")]
    public class CreateEvent
        : IReturn<IdResponse>, IPost, ICreateDb<Event>
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? Starton { get; set; }
        public DateTime? Endon { get; set; }
        public bool Allday { get; set; }
        public string Location { get; set; }
        public int Label { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Recurrenceinfoxml { get; set; }
        public Guid? Recurrencepatternid { get; set; }
        public string Reminderinfoxml { get; set; }
        public int Remindinseconds { get; set; }
        public DateTime? Alarmtime { get; set; }
        public bool Ispostponed { get; set; }
    }

    [Route("/filedatas", "POST")]
    public class CreateFiledata
        : IReturn<IdResponse>, IPost, ICreateDb<Filedata>
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public string Filename { get; set; }
        public byte[] Content { get; set; }
    }

    [Route("/filesystemstoreobjects", "POST")]
    public class CreateFilesystemstoreobject
        : IReturn<IdResponse>, IPost, ICreateDb<Filesystemstoreobject>
    {
        public Guid? Fileid { get; set; }
        public bool? Processed { get; set; }
    }

    [Route("/filesystemstoreobjectbases", "POST")]
    public class CreateFilesystemstoreobjectbase
        : IReturn<IdResponse>, IPost, ICreateDb<Filesystemstoreobjectbase>
    {
        public Guid Id { get; set; }
        public string Filename { get; set; }
        public int Size { get; set; }
    }

    [Route("/maildatas", "POST")]
    public class CreateMaildata
        : IReturn<IdResponse>, IPost, ICreateDb<Maildata>
    {
        public string[] To { get; set; }
        public string[] Bcc { get; set; }
        public string[] Cc { get; set; }
        public string Replyto { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }


    [Route("/prompts", "POST")]
    public class CreatePrompt
        : IReturn<IdResponse>, IPost, ICreateDb<Prompt>
    {
        public string Subject { get; set; }
        public string Systemprompt { get; set; }
        public string Assistantprompt { get; set; }
    }

    [Route("/reportdatav2s", "POST")]
    public class CreateReportdatav2
        : IReturn<IdResponse>, IPost, ICreateDb<Reportdatav2>
    {
        public Guid Id { get; set; }
        public string Datatypename { get; set; }
        public bool Isinplacereport { get; set; }
        public string Predefinedreporttypename { get; set; }
        public byte[] Content { get; set; }
        public string Displayname { get; set; }
        public string Parametersobjecttypename { get; set; }
    }

    [Route("/resources", "POST")]
    public class CreateResource
        : IReturn<IdResponse>, IPost, ICreateDb<Resource>
    {
        public Guid Key { get; set; }
        public string Caption { get; set; }
        public int ColorInt { get; set; }
    }

    [Route("/settings", "POST")]
    public class CreateSettings
        : IReturn<IdResponse>, IPost, ICreateDb<Settings>
    {
        public string Openaiorganization { get; set; }
        public string Openaikey { get; set; }
        public int? Chatmodelid { get; set; }
        public int? Embeddingmodelid { get; set; }
        public string Fromdisplayname { get; set; }
        public string Fromemailname { get; set; }
        public string Emailusername { get; set; }
        public string Emailpassword { get; set; }
        public string Smtphost { get; set; }
        public int Smtpport { get; set; }
        public bool Usessl { get; set; }
        public bool Usestarttls { get; set; }
    }

    [Route("/similarcontentarticlesresults", "POST")]
    public class CreateSimilarcontentarticlesresult
        : IReturn<IdResponse>, IPost, ICreateDb<Similarcontentarticlesresult>
    {
        public string Articlename { get; set; }
        public string Articlecontent { get; set; }
        public int? Articlesequence { get; set; }
        public Char Articletype { get; set; }
        public double CosineDistance { get; set; }
    }

    [Route("/tags", "POST")]
    public class CreateTag
        : IReturn<IdResponse>, IPost, ICreateDb<Tag>
    {
        public string Tagname { get; set; }
    }

    [Route("/usedknowledges", "POST")]
    public class CreateUsedknowledge
        : IReturn<IdResponse>, IPost, ICreateDb<Usedknowledge>
    {
        public int? Chatid { get; set; }
        public int? Articledetailid { get; set; }
        public int? Codeobjectid { get; set; }
        public double Cosinedistance { get; set; }
    }

    [Route("/websitedatas", "POST")]
    public class CreateWebsitedata
        : IReturn<IdResponse>, IPost, ICreateDb<Websitedata>
    {
        public string Website { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }

    [Route("/articles/{Articleid}", "DELETE")]
    public class DeleteArticle
        : IReturn<IdResponse>, IDelete, IDeleteDb<Article>
    {
        public int Articleid { get; set; }
    }

    [Route("/articledetails/{Articledetailid}", "DELETE")]
    public class DeleteArticledetail
        : IReturn<IdResponse>, IDelete, IDeleteDb<Articledetail>
    {
        public int Articledetailid { get; set; }
    }

    [Route("/chats/{Chatid}", "DELETE")]
    public class DeleteChat
        : IReturn<IdResponse>, IDelete, IDeleteDb<Chat>
    {
        public int Chatid { get; set; }
    }

    [Route("/chatmodels/{Id}", "DELETE")]
    public class DeleteChatmodel
        : IReturn<IdResponse>, IDelete, IDeleteDb<Chatmodel>
    {
        public int Id { get; set; }
    }

    [Route("/codeobjects/{Codeobjectid}", "DELETE")]
    public class DeleteCodeobject
        : IReturn<IdResponse>, IDelete, IDeleteDb<Codeobject>
    {
        public int Codeobjectid { get; set; }
    }

    [Route("/codeobjectcategories/{Codeobjectcategoryid}", "DELETE")]
    public class DeleteCodeobjectcategory
        : IReturn<IdResponse>, IDelete, IDeleteDb<Codeobjectcategory>
    {
        public int Codeobjectcategoryid { get; set; }
    }

    [Route("/costs/{Costid}", "DELETE")]
    public class DeleteCost
        : IReturn<IdResponse>, IDelete, IDeleteDb<Cost>
    {
        public int Costid { get; set; }
    }

    [Route("/embeddingmodels/{Id}", "DELETE")]
    public class DeleteEmbeddingmodel
        : IReturn<IdResponse>, IDelete, IDeleteDb<Embeddingmodel>
    {
        public int Id { get; set; }
    }

    [Route("/events/{Id}", "DELETE")]
    public class DeleteEvent
        : IReturn<IdResponse>, IDelete, IDeleteDb<Event>
    {
        public Guid Id { get; set; }
    }

    [Route("/filedatas/{Id}", "DELETE")]
    public class DeleteFiledata
        : IReturn<IdResponse>, IDelete, IDeleteDb<Filedata>
    {
        public Guid Id { get; set; }
    }

    [Route("/filesystemstoreobjects/{Id}", "DELETE")]
    public class DeleteFilesystemstoreobject
        : IReturn<IdResponse>, IDelete, IDeleteDb<Filesystemstoreobject>
    {
        public int Id { get; set; }
    }

    [Route("/filesystemstoreobjectbases/{Id}", "DELETE")]
    public class DeleteFilesystemstoreobjectbase
        : IReturn<IdResponse>, IDelete, IDeleteDb<Filesystemstoreobjectbase>
    {
        public Guid Id { get; set; }
    }

    [Route("/maildatas/{Id}", "DELETE")]
    public class DeleteMaildata
        : IReturn<IdResponse>, IDelete, IDeleteDb<Maildata>
    {
        public int Id { get; set; }
    }


    [Route("/prompts/{Promptid}", "DELETE")]
    public class DeletePrompt
        : IReturn<IdResponse>, IDelete, IDeleteDb<Prompt>
    {
        public int Promptid { get; set; }
    }

    [Route("/reportdatav2s/{Id}", "DELETE")]
    public class DeleteReportdatav2
        : IReturn<IdResponse>, IDelete, IDeleteDb<Reportdatav2>
    {
        public Guid Id { get; set; }
    }

    [Route("/resources/{Key}", "DELETE")]
    public class DeleteResource
        : IReturn<IdResponse>, IDelete, IDeleteDb<Resource>
    {
        public Guid Key { get; set; }
    }

    [Route("/settings/{Settingsid}", "DELETE")]
    public class DeleteSettings
        : IReturn<IdResponse>, IDelete, IDeleteDb<Settings>
    {
        public int Settingsid { get; set; }
    }

    [Route("/similarcontentarticlesresults/{Id}", "DELETE")]
    public class DeleteSimilarcontentarticlesresult
        : IReturn<IdResponse>, IDelete, IDeleteDb<Similarcontentarticlesresult>
    {
        public long Id { get; set; }
    }

    [Route("/tags/{Tagid}", "DELETE")]
    public class DeleteTag
        : IReturn<IdResponse>, IDelete, IDeleteDb<Tag>
    {
        public int Tagid { get; set; }
    }

    [Route("/usedknowledges/{Usedknowledgeid}", "DELETE")]
    public class DeleteUsedknowledge
        : IReturn<IdResponse>, IDelete, IDeleteDb<Usedknowledge>
    {
        public int Usedknowledgeid { get; set; }
    }

    [Route("/websitedatas/{Websitedataid}", "DELETE")]
    public class DeleteWebsitedata
        : IReturn<IdResponse>, IDelete, IDeleteDb<Websitedata>
    {
        public int Websitedataid { get; set; }
    }

    [Route("/articles/{Articleid}", "PATCH")]
    public class PatchArticle
        : IReturn<IdResponse>, IPatch, IPatchDb<Article>
    {
        public int Articleid { get; set; }
        public string Articlename { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
    }

    [Route("/articledetails/{Articledetailid}", "PATCH")]
    public class PatchArticledetail
        : IReturn<IdResponse>, IPatch, IPatchDb<Articledetail>
    {
        public int Articledetailid { get; set; }
        public int Articleid { get; set; }
        public int Articlesequence { get; set; }
        public string Articlecontent { get; set; }
        public int Tokens { get; set; }
    }

    [Route("/chats/{Chatid}", "PATCH")]
    public class PatchChat
        : IReturn<IdResponse>, IPatch, IPatchDb<Chat>
    {
        public int Chatid { get; set; }
        public string Question { get; set; }
        public string Questiondatastring { get; set; }
        public int? Promptid { get; set; }
        public string Answer { get; set; }
        public int? Tokens { get; set; }
        public int? Chatmodelid { get; set; }
        public DateTime? Created { get; set; }
    }

    [Route("/chatmodels/{Id}", "PATCH")]
    public class PatchChatmodel
        : IReturn<IdResponse>, IPatch, IPatchDb<Chatmodel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    [Route("/codeobjects/{Codeobjectid}", "PATCH")]
    public class PatchCodeobject
        : IReturn<IdResponse>, IPatch, IPatchDb<Codeobject>
    {
        public int Codeobjectid { get; set; }
        public string Subject { get; set; }
        public int Codeobjectcategoryid { get; set; }
        public string Codeobjectcontent { get; set; }
        public int Tokens { get; set; }
    }

    [Route("/codeobjectcategories/{Codeobjectcategoryid}", "PATCH")]
    public class PatchCodeobjectcategory
        : IReturn<IdResponse>, IPatch, IPatchDb<Codeobjectcategory>
    {
        public int Codeobjectcategoryid { get; set; }
        public string Category { get; set; }
    }

    [Route("/costs/{Costid}", "PATCH")]
    public class PatchCost
        : IReturn<IdResponse>, IPatch, IPatchDb<Cost>
    {
        public int Costid { get; set; }
        public int? Sourcetype { get; set; }
        public int? Articledetailid { get; set; }
        public int? Llmaction { get; set; }
        public int? Codeobjectid { get; set; }
        public int? Chatid { get; set; }
        public int? Prompttokens { get; set; }
        public int? Completiontokens { get; set; }
        public int? Totaltokens { get; set; }
        public int? Articleid { get; set; }
        public DateTime? Created { get; set; }
    }

    [Route("/embeddingmodels/{Id}", "PATCH")]
    public class PatchEmbeddingmodel
        : IReturn<IdResponse>, IPatch, IPatchDb<Embeddingmodel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    [Route("/events/{Id}", "PATCH")]
    public class PatchEvent
        : IReturn<IdResponse>, IPatch, IPatchDb<Event>
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? Starton { get; set; }
        public DateTime? Endon { get; set; }
        public bool Allday { get; set; }
        public string Location { get; set; }
        public int Label { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Recurrenceinfoxml { get; set; }
        public Guid? Recurrencepatternid { get; set; }
        public string Reminderinfoxml { get; set; }
        public int Remindinseconds { get; set; }
        public DateTime? Alarmtime { get; set; }
        public bool Ispostponed { get; set; }
    }

    [Route("/filedatas/{Id}", "PATCH")]
    public class PatchFiledata
        : IReturn<IdResponse>, IPatch, IPatchDb<Filedata>
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public string Filename { get; set; }
        public byte[] Content { get; set; }
    }

    [Route("/filesystemstoreobjects/{Id}", "PATCH")]
    public class PatchFilesystemstoreobject
        : IReturn<IdResponse>, IPatch, IPatchDb<Filesystemstoreobject>
    {
        public int Id { get; set; }
        public Guid? Fileid { get; set; }
        public bool? Processed { get; set; }
    }

    [Route("/filesystemstoreobjectbases/{Id}", "PATCH")]
    public class PatchFilesystemstoreobjectbase
        : IReturn<IdResponse>, IPatch, IPatchDb<Filesystemstoreobjectbase>
    {
        public Guid Id { get; set; }
        public string Filename { get; set; }
        public int Size { get; set; }
    }

    [Route("/maildatas/{Id}", "PATCH")]
    public class PatchMaildata
        : IReturn<IdResponse>, IPatch, IPatchDb<Maildata>
    {
        public int Id { get; set; }
        public string[] To { get; set; }
        public string[] Bcc { get; set; }
        public string[] Cc { get; set; }
        public string Replyto { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }


    [Route("/prompts/{Promptid}", "PATCH")]
    public class PatchPrompt
        : IReturn<IdResponse>, IPatch, IPatchDb<Prompt>
    {
        public int Promptid { get; set; }
        public string Subject { get; set; }
        public string Systemprompt { get; set; }
        public string Assistantprompt { get; set; }
    }

    [Route("/reportdatav2s/{Id}", "PATCH")]
    public class PatchReportdatav2
        : IReturn<IdResponse>, IPatch, IPatchDb<Reportdatav2>
    {
        public Guid Id { get; set; }
        public string Datatypename { get; set; }
        public bool Isinplacereport { get; set; }
        public string Predefinedreporttypename { get; set; }
        public byte[] Content { get; set; }
        public string Displayname { get; set; }
        public string Parametersobjecttypename { get; set; }
    }

    [Route("/resources/{Key}", "PATCH")]
    public class PatchResource
        : IReturn<IdResponse>, IPatch, IPatchDb<Resource>
    {
        public Guid Key { get; set; }
        public string Caption { get; set; }
        public int ColorInt { get; set; }
    }

    [Route("/settings/{Settingsid}", "PATCH")]
    public class PatchSettings
        : IReturn<IdResponse>, IPatch, IPatchDb<Settings>
    {
        public int Settingsid { get; set; }
        public string Openaiorganization { get; set; }
        public string Openaikey { get; set; }
        public int? Chatmodelid { get; set; }
        public int? Embeddingmodelid { get; set; }
        public string Fromdisplayname { get; set; }
        public string Fromemailname { get; set; }
        public string Emailusername { get; set; }
        public string Emailpassword { get; set; }
        public string Smtphost { get; set; }
        public int Smtpport { get; set; }
        public bool Usessl { get; set; }
        public bool Usestarttls { get; set; }
    }

    [Route("/similarcontentarticlesresults/{Id}", "PATCH")]
    public class PatchSimilarcontentarticlesresult
        : IReturn<IdResponse>, IPatch, IPatchDb<Similarcontentarticlesresult>
    {
        public long Id { get; set; }
        public string Articlename { get; set; }
        public string Articlecontent { get; set; }
        public int? Articlesequence { get; set; }
        public Char Articletype { get; set; }
        public double CosineDistance { get; set; }
    }

    [Route("/tags/{Tagid}", "PATCH")]
    public class PatchTag
        : IReturn<IdResponse>, IPatch, IPatchDb<Tag>
    {
        public int Tagid { get; set; }
        public string Tagname { get; set; }
    }

    [Route("/usedknowledges/{Usedknowledgeid}", "PATCH")]
    public class PatchUsedknowledge
        : IReturn<IdResponse>, IPatch, IPatchDb<Usedknowledge>
    {
        public int Usedknowledgeid { get; set; }
        public int? Chatid { get; set; }
        public int? Articledetailid { get; set; }
        public int? Codeobjectid { get; set; }
        public double Cosinedistance { get; set; }
    }

    [Route("/websitedatas/{Websitedataid}", "PATCH")]
    public class PatchWebsitedata
        : IReturn<IdResponse>, IPatch, IPatchDb<Websitedata>
    {
        public int Websitedataid { get; set; }
        public string Website { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }

    [Route("/articledetails", "GET")]
    [Route("/articledetails/{Articledetailid}", "GET")]
    public class QueryArticledetails
        : QueryDb<Articledetail>, IReturn<QueryResponse<Articledetail>>, IGet
    {
        public int? Articledetailid { get; set; }
    }

    [Route("/articles", "GET")]
    [Route("/articles/{Articleid}", "GET")]
    public class QueryArticles
        : QueryDb<Article>, IReturn<QueryResponse<Article>>, IGet
    {
        public int? Articleid { get; set; }
    }

    [Route("/chatmodels", "GET")]
    [Route("/chatmodels/{Id}", "GET")]
    public class QueryChatmodels
        : QueryDb<Chatmodel>, IReturn<QueryResponse<Chatmodel>>, IGet
    {
        public int? Id { get; set; }
    }

    [Route("/chats", "GET")]
    [Route("/chats/{Chatid}", "GET")]
    public class QueryChats
        : QueryDb<Chat>, IReturn<QueryResponse<Chat>>, IGet
    {
        public int? Chatid { get; set; }
    }

    [Route("/codeobjectcategories", "GET")]
    [Route("/codeobjectcategories/{Codeobjectcategoryid}", "GET")]
    public class QueryCodeobjectcategories
        : QueryDb<Codeobjectcategory>, IReturn<QueryResponse<Codeobjectcategory>>, IGet
    {
        public int? Codeobjectcategoryid { get; set; }
    }

    [Route("/codeobjects", "GET")]
    [Route("/codeobjects/{Codeobjectid}", "GET")]
    public class QueryCodeobjects
        : QueryDb<Codeobject>, IReturn<QueryResponse<Codeobject>>, IGet
    {
        public int? Codeobjectid { get; set; }
    }

    [Route("/costs", "GET")]
    [Route("/costs/{Costid}", "GET")]
    public class QueryCosts
        : QueryDb<Cost>, IReturn<QueryResponse<Cost>>, IGet
    {
        public int? Costid { get; set; }
    }

    [Route("/embeddingmodels", "GET")]
    [Route("/embeddingmodels/{Id}", "GET")]
    public class QueryEmbeddingmodels
        : QueryDb<Embeddingmodel>, IReturn<QueryResponse<Embeddingmodel>>, IGet
    {
        public int? Id { get; set; }
    }

    [Route("/events", "GET")]
    [Route("/events/{Id}", "GET")]
    public class QueryEvents
        : QueryDb<Event>, IReturn<QueryResponse<Event>>, IGet
    {
        public Guid? Id { get; set; }
    }

    [Route("/filedatas", "GET")]
    [Route("/filedatas/{Id}", "GET")]
    public class QueryFiledatas
        : QueryDb<Filedata>, IReturn<QueryResponse<Filedata>>, IGet
    {
        public Guid? Id { get; set; }
    }

    [Route("/filesystemstoreobjectbases", "GET")]
    [Route("/filesystemstoreobjectbases/{Id}", "GET")]
    public class QueryFilesystemstoreobjectbases
        : QueryDb<Filesystemstoreobjectbase>, IReturn<QueryResponse<Filesystemstoreobjectbase>>, IGet
    {
        public Guid? Id { get; set; }
    }

    [Route("/filesystemstoreobjects", "GET")]
    [Route("/filesystemstoreobjects/{Id}", "GET")]
    public class QueryFilesystemstoreobjects
        : QueryDb<Filesystemstoreobject>, IReturn<QueryResponse<Filesystemstoreobject>>, IGet
    {
        public int? Id { get; set; }
    }

    [Route("/maildatas", "GET")]
    [Route("/maildatas/{Id}", "GET")]
    public class QueryMaildatas
        : QueryDb<Maildata>, IReturn<QueryResponse<Maildata>>, IGet
    {
        public int? Id { get; set; }
    }


    [Route("/prompts", "GET")]
    [Route("/prompts/{Promptid}", "GET")]
    public class QueryPrompts
        : QueryDb<Prompt>, IReturn<QueryResponse<Prompt>>, IGet
    {
        public int? Promptid { get; set; }
    }

    [Route("/reportdatav2s", "GET")]
    [Route("/reportdatav2s/{Id}", "GET")]
    public class QueryReportdatav2s
        : QueryDb<Reportdatav2>, IReturn<QueryResponse<Reportdatav2>>, IGet
    {
        public Guid? Id { get; set; }
    }

    [Route("/resources", "GET")]
    [Route("/resources/{Key}", "GET")]
    public class QueryResources
        : QueryDb<Resource>, IReturn<QueryResponse<Resource>>, IGet
    {
        public Guid? Key { get; set; }
    }

    [Route("/settings", "GET")]
    [Route("/settings/{Settingsid}", "GET")]
    public class QuerySettings
        : QueryDb<Settings>, IReturn<QueryResponse<Settings>>, IGet
    {
        public int? Settingsid { get; set; }
    }

    [Route("/similarcontentarticlesresults", "GET")]
    [Route("/similarcontentarticlesresults/{Id}", "GET")]
    public class QuerySimilarcontentarticlesresults
        : QueryDb<Similarcontentarticlesresult>, IReturn<QueryResponse<Similarcontentarticlesresult>>, IGet
    {
        public long? Id { get; set; }
    }

    [Route("/tags", "GET")]
    [Route("/tags/{Tagid}", "GET")]
    public class QueryTags
        : QueryDb<Tag>, IReturn<QueryResponse<Tag>>, IGet
    {
        public int? Tagid { get; set; }
    }

    [Route("/usedknowledges", "GET")]
    [Route("/usedknowledges/{Usedknowledgeid}", "GET")]
    public class QueryUsedknowledges
        : QueryDb<Usedknowledge>, IReturn<QueryResponse<Usedknowledge>>, IGet
    {
        public int? Usedknowledgeid { get; set; }
    }

    [Route("/websitedatas", "GET")]
    [Route("/websitedatas/{Websitedataid}", "GET")]
    public class QueryWebsitedatas
        : QueryDb<Websitedata>, IReturn<QueryResponse<Websitedata>>, IGet
    {
        public int? Websitedataid { get; set; }
    }

    [Route("/articles/{Articleid}", "PUT")]
    public class UpdateArticle
        : IReturn<IdResponse>, IPut, IUpdateDb<Article>
    {
        public int Articleid { get; set; }
        public string Articlename { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
    }

    [Route("/articledetails/{Articledetailid}", "PUT")]
    public class UpdateArticledetail
        : IReturn<IdResponse>, IPut, IUpdateDb<Articledetail>
    {
        public int Articledetailid { get; set; }
        public int Articleid { get; set; }
        public int Articlesequence { get; set; }
        public string Articlecontent { get; set; }
        public int Tokens { get; set; }
    }

    [Route("/chats/{Chatid}", "PUT")]
    public class UpdateChat
        : IReturn<IdResponse>, IPut, IUpdateDb<Chat>
    {
        public int Chatid { get; set; }
        public string Question { get; set; }
        public string Questiondatastring { get; set; }
        public int? Promptid { get; set; }
        public string Answer { get; set; }
        public int? Tokens { get; set; }
        public int? Chatmodelid { get; set; }
        public DateTime? Created { get; set; }
    }

    [Route("/chatmodels/{Id}", "PUT")]
    public class UpdateChatmodel
        : IReturn<IdResponse>, IPut, IUpdateDb<Chatmodel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    [Route("/codeobjects/{Codeobjectid}", "PUT")]
    public class UpdateCodeobject
        : IReturn<IdResponse>, IPut, IUpdateDb<Codeobject>
    {
        public int Codeobjectid { get; set; }
        public string Subject { get; set; }
        public int Codeobjectcategoryid { get; set; }
        public string Codeobjectcontent { get; set; }
        public int Tokens { get; set; }
    }

    [Route("/codeobjectcategories/{Codeobjectcategoryid}", "PUT")]
    public class UpdateCodeobjectcategory
        : IReturn<IdResponse>, IPut, IUpdateDb<Codeobjectcategory>
    {
        public int Codeobjectcategoryid { get; set; }
        public string Category { get; set; }
    }

    [Route("/costs/{Costid}", "PUT")]
    public class UpdateCost
        : IReturn<IdResponse>, IPut, IUpdateDb<Cost>
    {
        public int Costid { get; set; }
        public int? Sourcetype { get; set; }
        public int? Articledetailid { get; set; }
        public int? Llmaction { get; set; }
        public int? Codeobjectid { get; set; }
        public int? Chatid { get; set; }
        public int? Prompttokens { get; set; }
        public int? Completiontokens { get; set; }
        public int? Totaltokens { get; set; }
        public int? Articleid { get; set; }
        public DateTime? Created { get; set; }
    }

    [Route("/embeddingmodels/{Id}", "PUT")]
    public class UpdateEmbeddingmodel
        : IReturn<IdResponse>, IPut, IUpdateDb<Embeddingmodel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    [Route("/events/{Id}", "PUT")]
    public class UpdateEvent
        : IReturn<IdResponse>, IPut, IUpdateDb<Event>
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? Starton { get; set; }
        public DateTime? Endon { get; set; }
        public bool Allday { get; set; }
        public string Location { get; set; }
        public int Label { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Recurrenceinfoxml { get; set; }
        public Guid? Recurrencepatternid { get; set; }
        public string Reminderinfoxml { get; set; }
        public int Remindinseconds { get; set; }
        public DateTime? Alarmtime { get; set; }
        public bool Ispostponed { get; set; }
    }

    [Route("/filedatas/{Id}", "PUT")]
    public class UpdateFiledata
        : IReturn<IdResponse>, IPut, IUpdateDb<Filedata>
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public string Filename { get; set; }
        public byte[] Content { get; set; }
    }

    [Route("/filesystemstoreobjects/{Id}", "PUT")]
    public class UpdateFilesystemstoreobject
        : IReturn<IdResponse>, IPut, IUpdateDb<Filesystemstoreobject>
    {
        public int Id { get; set; }
        public Guid? Fileid { get; set; }
        public bool? Processed { get; set; }
    }

    [Route("/filesystemstoreobjectbases/{Id}", "PUT")]
    public class UpdateFilesystemstoreobjectbase
        : IReturn<IdResponse>, IPut, IUpdateDb<Filesystemstoreobjectbase>
    {
        public Guid Id { get; set; }
        public string Filename { get; set; }
        public int Size { get; set; }
    }

    [Route("/maildatas/{Id}", "PUT")]
    public class UpdateMaildata
        : IReturn<IdResponse>, IPut, IUpdateDb<Maildata>
    {
        public int Id { get; set; }
        public string[] To { get; set; }
        public string[] Bcc { get; set; }
        public string[] Cc { get; set; }
        public string Replyto { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    [Route("/prompts/{Promptid}", "PUT")]
    public class UpdatePrompt
        : IReturn<IdResponse>, IPut, IUpdateDb<Prompt>
    {
        public int Promptid { get; set; }
        public string Subject { get; set; }
        public string Systemprompt { get; set; }
        public string Assistantprompt { get; set; }
    }

    [Route("/reportdatav2s/{Id}", "PUT")]
    public class UpdateReportdatav2
        : IReturn<IdResponse>, IPut, IUpdateDb<Reportdatav2>
    {
        public Guid Id { get; set; }
        public string Datatypename { get; set; }
        public bool Isinplacereport { get; set; }
        public string Predefinedreporttypename { get; set; }
        public byte[] Content { get; set; }
        public string Displayname { get; set; }
        public string Parametersobjecttypename { get; set; }
    }

    [Route("/resources/{Key}", "PUT")]
    public class UpdateResource
        : IReturn<IdResponse>, IPut, IUpdateDb<Resource>
    {
        public Guid Key { get; set; }
        public string Caption { get; set; }
        public int ColorInt { get; set; }
    }

    [Route("/settings/{Settingsid}", "PUT")]
    public class UpdateSettings
        : IReturn<IdResponse>, IPut, IUpdateDb<Settings>
    {
        public int Settingsid { get; set; }
        public string Openaiorganization { get; set; }
        public string Openaikey { get; set; }
        public int? Chatmodelid { get; set; }
        public int? Embeddingmodelid { get; set; }
        public string Fromdisplayname { get; set; }
        public string Fromemailname { get; set; }
        public string Emailusername { get; set; }
        public string Emailpassword { get; set; }
        public string Smtphost { get; set; }
        public int Smtpport { get; set; }
        public bool Usessl { get; set; }
        public bool Usestarttls { get; set; }
    }

    [Route("/similarcontentarticlesresults/{Id}", "PUT")]
    public class UpdateSimilarcontentarticlesresult
        : IReturn<IdResponse>, IPut, IUpdateDb<Similarcontentarticlesresult>
    {
        public long Id { get; set; }
        public string Articlename { get; set; }
        public string Articlecontent { get; set; }
        public int? Articlesequence { get; set; }
        public Char Articletype { get; set; }
        public double CosineDistance { get; set; }
    }

    [Route("/tags/{Tagid}", "PUT")]
    public class UpdateTag
        : IReturn<IdResponse>, IPut, IUpdateDb<Tag>
    {
        public int Tagid { get; set; }
        public string Tagname { get; set; }
    }

    [Route("/usedknowledges/{Usedknowledgeid}", "PUT")]
    public class UpdateUsedknowledge
        : IReturn<IdResponse>, IPut, IUpdateDb<Usedknowledge>
    {
        public int Usedknowledgeid { get; set; }
        public int? Chatid { get; set; }
        public int? Articledetailid { get; set; }
        public int? Codeobjectid { get; set; }
        public double Cosinedistance { get; set; }
    }

    [Route("/websitedatas/{Websitedataid}", "PUT")]
    public class UpdateWebsitedata
        : IReturn<IdResponse>, IPut, IUpdateDb<Websitedata>
    {
        public int Websitedataid { get; set; }
        public string Website { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }

}

namespace brekGPT.ServiceModel.Types
{
    public class Article
    {
        [AutoIncrement]
        public int Articleid { get; set; }

        public string Articlename { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
    }

    public class Articledetail
    {
        [AutoIncrement]
        public int Articledetailid { get; set; }

        public int Articleid { get; set; }
        public int Articlesequence { get; set; }
        public string Articlecontent { get; set; }
        public int Tokens { get; set; }
    }

    public class Chat
    {
        [AutoIncrement]
        public int Chatid { get; set; }

        public string Question { get; set; }
        public string Questiondatastring { get; set; }
        public int? Promptid { get; set; }
        public string Answer { get; set; }
        public int? Tokens { get; set; }
        public int? Chatmodelid { get; set; }
        public DateTime? Created { get; set; }
    }

    public class Chatmodel
    {
        [AutoIncrement]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    public class Codeobject
    {
        [AutoIncrement]
        public int Codeobjectid { get; set; }

        public string Subject { get; set; }
        public int Codeobjectcategoryid { get; set; }
        [Required]
        public string Codeobjectcontent { get; set; }

        public int Tokens { get; set; }
    }

    public class Codeobjectcategory
    {
        [AutoIncrement]
        public int Codeobjectcategoryid { get; set; }

        public string Category { get; set; }
    }

    public class Cost
    {
        [AutoIncrement]
        public int Costid { get; set; }

        public int? Sourcetype { get; set; }
        public int? Articledetailid { get; set; }
        public int? Llmaction { get; set; }
        public int? Codeobjectid { get; set; }
        public int? Chatid { get; set; }
        public int? Prompttokens { get; set; }
        public int? Completiontokens { get; set; }
        public int? Totaltokens { get; set; }
        public int? Articleid { get; set; }
        public DateTime? Created { get; set; }
    }

    public class Embeddingmodel
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public int? Size { get; set; }
        public float? Tokencost { get; set; }
    }

    public class Event
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? Starton { get; set; }
        public DateTime? Endon { get; set; }
        public bool Allday { get; set; }
        public string Location { get; set; }
        public int Label { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Recurrenceinfoxml { get; set; }
        public Guid? Recurrencepatternid { get; set; }
        public string Reminderinfoxml { get; set; }
        public int Remindinseconds { get; set; }
        public DateTime? Alarmtime { get; set; }
        public bool Ispostponed { get; set; }
    }

    public class Filedata
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public int Size { get; set; }
        public string Filename { get; set; }
        public byte[] Content { get; set; }
    }

    public class Filesystemstoreobject
    {
        [AutoIncrement]
        public int Id { get; set; }

        public Guid? Fileid { get; set; }
        public bool? Processed { get; set; }
    }

    public class Filesystemstoreobjectbase
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public string Filename { get; set; }
        public int Size { get; set; }
    }

    public class Maildata
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string[] To { get; set; }
        public string[] Bcc { get; set; }
        public string[] Cc { get; set; }
        public string Replyto { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class Prompt
    {
        [AutoIncrement]
        public int Promptid { get; set; }

        public string Subject { get; set; }
        public string Systemprompt { get; set; }
        public string Assistantprompt { get; set; }
    }

    public class Reportdatav2
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public string Datatypename { get; set; }
        public bool Isinplacereport { get; set; }
        public string Predefinedreporttypename { get; set; }
        public byte[] Content { get; set; }
        public string Displayname { get; set; }
        public string Parametersobjecttypename { get; set; }
    }

    public class Resource
    {
        [PrimaryKey]
        public Guid Key { get; set; }

        public string Caption { get; set; }
        public int ColorInt { get; set; }
    }

    public class Settings
    {
        [AutoIncrement]
        public int Settingsid { get; set; }

        public string Openaiorganization { get; set; }
        public string Openaikey { get; set; }
        public int? Chatmodelid { get; set; }
        public int? Embeddingmodelid { get; set; }
        public string Fromdisplayname { get; set; }
        public string Fromemailname { get; set; }
        public string Emailusername { get; set; }
        public string Emailpassword { get; set; }
        public string Smtphost { get; set; }
        public int Smtpport { get; set; }
        public bool Usessl { get; set; }
        public bool Usestarttls { get; set; }
    }

    public class Similarcontentarticlesresult
    {
        [AutoIncrement]
        public long Id { get; set; }

        public string Articlename { get; set; }
        public string Articlecontent { get; set; }
        public int? Articlesequence { get; set; }
        public Char Articletype { get; set; }
        public double CosineDistance { get; set; }
    }

    public class Tag
    {
        [AutoIncrement]
        public int Tagid { get; set; }

        public string Tagname { get; set; }
    }

    public class Usedknowledge
    {
        [AutoIncrement]
        public int Usedknowledgeid { get; set; }

        public int? Chatid { get; set; }
        public int? Articledetailid { get; set; }
        public int? Codeobjectid { get; set; }
        public double Cosinedistance { get; set; }
    }

    public class Websitedata
    {
        [AutoIncrement]
        public int Websitedataid { get; set; }

        public string Website { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }

}

