﻿using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Security;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace brekGPT.Module.BusinessObjects;

[Table("permissionpolicyuserlogininfo")]
public class ApplicationUserLoginInfo : ISecurityUserLoginInfo {

    public ApplicationUserLoginInfo() { }

    [Browsable(false)]
    public virtual Guid ID { get; protected set; }

    [Appearance("PasswordProvider", Enabled = false, Criteria = "!(IsNewObject(this)) and LoginProviderName == '" + SecurityDefaults.PasswordAuthentication + "'", Context = "DetailView")]
    public virtual string LoginProviderName { get; set; }

    [Appearance("PasswordProviderUserKey", Enabled = false, Criteria = "!(IsNewObject(this)) and LoginProviderName == '" + SecurityDefaults.PasswordAuthentication + "'", Context = "DetailView")]
    public virtual string ProviderUserKey { get; set; }

    [Browsable(false)]
    public virtual Guid UserForeignKey { get; set; }

    [Required]
    [ForeignKey(nameof(UserForeignKey))]
    public virtual ApplicationUser User { get; set; }

    object ISecurityUserLoginInfo.User => User;
}
