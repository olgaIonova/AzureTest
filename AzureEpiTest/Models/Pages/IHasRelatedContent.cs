using EPiServer.Core;

namespace AzureEpiTest.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
