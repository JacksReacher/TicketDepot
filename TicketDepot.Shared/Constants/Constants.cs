
namespace TicketDepot.Shared
{

    public static class ActiveDirectoryGroups
    {
        public const string ProductOwnersADGroup = "ProductOwnersADGroup";
        public const string DelegateOwnersADGroup = "DelegateOwnersADGroup";
    }

    public static class QueryErrorMessages
    {
        public const string ProductQueryTooManyResults = "Too many results were returned for product.";
        public const string WithId = "ID:";
        public const string WithAlias = "Alias:";
        public const string WithName = "Name:";
    }

    public static class QueryStrings
    {
        public const string SelectUserProductCache = "Select * from UserProductCache upc";
        public const string SelectAllConfigs = "SELECT c.id, c.configs FROM c";
        public const string SelectConfigById = "SELECT c.id, c.configs FROM c where c.id = @id";
        public const string SelectProductByAliasOrName = "SELECT * FROM c WHERE c.alias = @productAlias OR c.name = @productName";
        public const string SelectProductById = "SELECT * FROM c where c.id = @productId";
        public const string SelectProductByOwner = "SELECT Value p FROM Products p WHERE p.productOwner.id = @productOwnerId";
        public const string SelectProductByDevOpsName = "SELECT TOP 1 * FROM c WHERE STRINGEQUALS(c.adoProject.name, @adoProjectName, true)";
        public const string SelectProductByMsTeamsName = "SELECT TOP 1 VALUE p FROM Products p JOIN ms IN p.msTeams WHERE STRINGEQUALS(ms.name, @msTeamsName, true)";
        public const string SelectProductBySubscriptionName = "SELECT TOP 1 VALUE p FROM Products AS p JOIN s IN p.subscriptions WHERE STRINGEQUALS(s.name, @subscriptionName, true)";
        public const string SelectProductsByDelegateOwner = "SELECT VALUE p FROM Products p JOIN dg IN p.delegateOwners WHERE dg.id = @delegateOwnerId";

        public const string SelectRequestsByProductId = "SELECT * FROM c WHERE c.productId = @productId ORDER BY c.dateSubmitted DESC";
        public const string SelectPendingRequestsByProductId = "SELECT * FROM c WHERE c.productId = @productId AND c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed' AND c.status != 'Denied' ORDER BY c.dateSubmitted DESC";
        public const string SelectProductAreaPendingRequests = "SELECT c.status, c.reqType, c.requestInfo.devOpsName, c.requestInfo.teamsName, c.requestInfo.subscriptionPartialNames, c.requestInfo.displayName, c.requestInfo.projectName FROM c WHERE ARRAY_CONTAINS(@requestTypes, c.reqType) AND c.productId = @productId AND c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed' ORDER BY c.dateSubmitted DESC";
        public const string SelecRequestsByCreatedById = "SELECT * FROM c WHERE c.createdBy.id = @createdById ORDER BY c.dateSubmitted DESC";
        public const string SelectPendingRequestsByCreatedById = "SELECT * FROM c WHERE c.createdBy.id = @createdById AND c.reqType = 'New Product Setup' AND c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed' ORDER BY c.dateSubmitted DESC";
        public const string SelectRequestByProductIdCreatedById = "SELECT * FROM c WHERE c.productId = @productId AND c.createdBy.id = @createdById ORDER BY c.dateSubmitted DESC";
        public const string SelectPendingTeamMemberRequestsByProductId = "SELECT * FROM c WHERE c.productId = @productId AND c.requestInfo.teamMember.id = @teamMemberId AND c.reqType = @reqType AND (c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed') ORDER BY c.dateSubmitted DESC";
        public const string SelectPendingProductRequestsByAliasOrName = "SELECT * FROM c WHERE (c.requestInfo.alias=@productAlias or c.requestInfo.productName=@productName) AND c.reqType = @reqType AND (c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed') ORDER BY c.dateSubmitted DESC";
        public const string SelectMultiTypePendingTeamMemberRequests = "SELECT * FROM c WHERE c.productId = @productId AND ARRAY_CONTAINS(@requestTypes, c.reqType) AND (c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed')";
        public const string SelectDomainManagementGroups = "SELECT * FROM c";
        public const string SelectProductsByParentIds = "SELECT * FROM c WHERE ARRAY_CONTAINS(@parentIds, c.managementGroup.parentId)";
        public const string SelectPendingRequestsByProductIdAndRequestType = "SELECT c.productId, c.id AS requestId, c.requestType, c.status, c.dateSubmitted, c.createdBy FROM c WHERE ARRAY_CONTAINS(@requestTypes, c.reqType) AND c.productId = @productId AND c.status != 'Completed' AND c.status != 'Failed' AND c.status != 'Partially Failed' ORDER BY c.dateSubmitted DESC";
        public const string SelectRequestsInBatch = "SELECT * FROM c WHERE ARRAY_CONTAINS(@requestTypes, c.reqType) ORDER BY c.dateSubmitted desc OFFSET @offset LIMIT @batchSize";
        public const string SelectDocumentCount = "SELECT count(1) FROM c WHERE ARRAY_CONTAINS(@requestTypes, c.reqType)";
    }

    public static class QueryParameters
    {
        public const string Id = "@id";
        public const string ProductId = "@productId";
        public const string ProductOwnerId = "@productOwnerId";
        public const string DelegateOwnerId = "@delegateOwnerId";
        public const string ProductAlias = "@productAlias";
        public const string ProductName = "@productName";
        public const string CreatedById = "@createdById";
        public const string TeamMemberId = "@teamMemberId";
        public const string RequestType = "@reqType";
        public const string RequestTypes = "@requestTypes";
        public const string ParentIds = "@parentIds";
        public const string SubscriptionName = "@subscriptionName";
        public const string AdoProjectName = "@adoProjectName";
        public const string MsTeamsName = "@msTeamsName";
        public const string Offset = "@offset";
        public const string BatchSize = "@batchSize";
    }
#pragma warning restore SA1402 // File may only contain a single type
#pragma warning restore SA1649 // File name should match first type name
}
