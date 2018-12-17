using Itofinity.Bitbucket.Refit.Model;

namespace Itofinity.Bitbucket.Refit.Ext.Model
{
    public interface IPageable
    {
        PaginatedEmailAddresses Next { get; }

        PaginatedEmailAddresses Previous { get; }
    }
}