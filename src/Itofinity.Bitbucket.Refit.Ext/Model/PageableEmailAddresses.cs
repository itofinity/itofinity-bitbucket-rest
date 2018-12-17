using Itofinity.Bitbucket.Refit.Model;

namespace Itofinity.Bitbucket.Refit.Ext.Model
{
    public class PageableEmailAddresses : IPageable
    {
        public PaginatedEmailAddresses Next
        {
            get { return null as PaginatedEmailAddresses; }
        }

        public PaginatedEmailAddresses Previous
        {
            get { return null as PaginatedEmailAddresses; }
            
        }
    }
}