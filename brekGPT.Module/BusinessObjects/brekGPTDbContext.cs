using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Pgvector.EntityFrameworkCore;

namespace brekGPT.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class brekGPTContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<brekGPTEFCoreDbContext>()
            //.UseSqlServer(";")
            .UseNpgsql(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new brekGPTEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class brekGPTDesignTimeDbContextFactory : IDesignTimeDbContextFactory<brekGPTEFCoreDbContext> {
	public brekGPTEFCoreDbContext CreateDbContext(string[] args) {
        //throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        // Get connection string from configuration
        var connectionString = configuration.GetConnectionString("ConnectionString");

        var optionsBuilder = new DbContextOptionsBuilder<brekGPTEFCoreDbContext>();
        //optionsBuilder.UseSqlServer("Encrypt=false;Integrated Security=SSPI;MultipleActiveResultSets=True;Data Source=BCH-BTO;Initial Catalog=E965_EFCore");
        //TODO: get this from a config file?
        optionsBuilder.UseNpgsql(connectionString, o => o.UseVector()).UseLowerCaseNamingConvention();
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
        return new brekGPTEFCoreDbContext(optionsBuilder.Options);
    }
}
[TypesInfoInitializer(typeof(brekGPTContextInitializer))]
public class brekGPTEFCoreDbContext : DbContext {
	public brekGPTEFCoreDbContext(DbContextOptions<brekGPTEFCoreDbContext> options) : base(options) {
	}
	//public DbSet<ModuleInfo> ModulesInfo { get; set; }
	public DbSet<ModelDifference> ModelDifferences { get; set; }
	public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
	public DbSet<PermissionPolicyRole> Roles { get; set; }
	public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<ApplicationUserLoginInfo> UserLoginInfos { get; set; }
	public DbSet<FileData> FileData { get; set; }
	public DbSet<ReportDataV2> ReportDataV2 { get; set; }
	public DbSet<DashboardData> DashboardData { get; set; }
    public DbSet<Event> Event { get; set; }
    public DbSet<FileSystemStoreObject> FileSystemStoreObject { get; set; }

    public DbSet<Article> Article { get; set; }
    public DbSet<ArticleDetail> ArticleDetail { get; set; }

    public DbSet<Chat> Chat { get; set; }
    public DbSet<Prompt> Prompt { get; set; }

    public DbSet<CodeObject> CodeObject { get; set; }
    public DbSet<CodeObjectCategory> CodeObjectCategory { get; set; }
    public DbSet<Settings> Settings { get; set; }
    public DbSet<ChatModel> ChatModel { get; set; }

    public DbSet<EmbeddingModel> EmbeddingModel { get; set; }
    public DbSet<MailData> MailData { get; set; }
    public DbSet<SimilarContentArticlesResult> SimilarContentArticlesResult { get; set; }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<UsedKnowledge> UsedKnowledge { get; set; }
    public DbSet<Cost> Cost { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction);
        modelBuilder.Entity<ApplicationUserLoginInfo>(b => {
            b.HasIndex(nameof(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.LoginProviderName), nameof(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.ProviderUserKey)).IsUnique();
        });
        modelBuilder.Entity<ModelDifference>()
            .HasMany(t => t.Aspects)
            .WithOne(t => t.Owner)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Article>()
    .HasMany(e => e.ArticleDetail)
    .WithOne(e => e.Article)
    .OnDelete(DeleteBehavior.ClientCascade);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        // Get connection string from configuration
        var connectionString = configuration.GetConnectionString("ConnectionString");

        //optionsBuilder.UseSqlServer("Encrypt=false;Integrated Security=SSPI;MultipleActiveResultSets=True;Data Source=BCH-BTO;Initial Catalog=E965_EFCore");
        //TODO: get this from a config file?
        optionsBuilder.UseNpgsql(connectionString, o => o.UseVector()).UseLowerCaseNamingConvention();
        optionsBuilder.UseChangeTrackingProxies();
    }
    public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddDebug(); });
}
