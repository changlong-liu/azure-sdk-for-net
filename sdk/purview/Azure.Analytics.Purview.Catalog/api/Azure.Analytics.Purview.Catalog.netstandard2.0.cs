namespace Azure.Analytics.Purview.Catalog
{
    public partial class PurviewCatalogClient
    {
        protected PurviewCatalogClient() { }
        public PurviewCatalogClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public PurviewCatalogClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Catalog.PurviewCatalogClientOptions options) { }
        public Azure.Analytics.Purview.Catalog.PurviewCollections Collections { get { throw null; } }
        public Azure.Analytics.Purview.Catalog.PurviewEntities Entities { get { throw null; } }
        public Azure.Analytics.Purview.Catalog.PurviewGlossaries Glossaries { get { throw null; } }
        public Azure.Analytics.Purview.Catalog.PurviewLineages Lineages { get { throw null; } }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public Azure.Analytics.Purview.Catalog.PurviewRelationships Relationships { get { throw null; } }
        public Azure.Analytics.Purview.Catalog.PurviewTypes Types { get { throw null; } }
        public virtual Azure.Response AutoComplete(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AutoCompleteAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response Browse(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> BrowseAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Analytics.Purview.Catalog.PurviewCollections GetPurviewCollectionsClient() { throw null; }
        public virtual Azure.Analytics.Purview.Catalog.PurviewEntities GetPurviewEntitiesClient() { throw null; }
        public virtual Azure.Analytics.Purview.Catalog.PurviewGlossaries GetPurviewGlossariesClient() { throw null; }
        public virtual Azure.Analytics.Purview.Catalog.PurviewLineages GetPurviewLineagesClient() { throw null; }
        public virtual Azure.Analytics.Purview.Catalog.PurviewRelationships GetPurviewRelationshipsClient() { throw null; }
        public virtual Azure.Analytics.Purview.Catalog.PurviewTypes GetPurviewTypesClient() { throw null; }
        public virtual Azure.Response Search(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SearchAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response Suggest(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SuggestAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class PurviewCatalogClientOptions : Azure.Core.ClientOptions
    {
        public PurviewCatalogClientOptions(Azure.Analytics.Purview.Catalog.PurviewCatalogClientOptions.ServiceVersion version = Azure.Analytics.Purview.Catalog.PurviewCatalogClientOptions.ServiceVersion.V2021_05_01_preview) { }
        public enum ServiceVersion
        {
            V2021_05_01_preview = 1,
        }
    }
    public partial class PurviewCollections
    {
        protected PurviewCollections() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response CreateOrUpdateEntity(string collection, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateEntityAsync(string collection, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateOrUpdateEntityInBulk(string collection, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateEntityInBulkAsync(string collection, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response MoveEntitiesToCollection(string collection, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> MoveEntitiesToCollectionAsync(string collection, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class PurviewEntities
    {
        protected PurviewEntities() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddClassification(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddClassificationAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response AddClassifications(string guid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddClassificationsAsync(string guid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response AddClassificationsByUniqueAttribute(string typeName, Azure.Core.RequestContent content, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddClassificationsByUniqueAttributeAsync(string typeName, Azure.Core.RequestContent content, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateOrUpdate(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateOrUpdateEntities(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateEntitiesAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteByGuids(System.Collections.Generic.IEnumerable<string> guids, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteByGuidsAsync(System.Collections.Generic.IEnumerable<string> guids, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteByUniqueAttribute(string typeName, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteByUniqueAttributeAsync(string typeName, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteClassification(string guid, string classificationName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteClassificationAsync(string guid, string classificationName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteClassificationByUniqueAttribute(string typeName, string classificationName, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteClassificationByUniqueAttributeAsync(string typeName, string classificationName, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetByGuid(string guid, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetByGuidAsync(string guid, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetByGuids(System.Collections.Generic.IEnumerable<string> guids, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), System.Collections.Generic.IEnumerable<string> excludeRelationshipTypes = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetByGuidsAsync(System.Collections.Generic.IEnumerable<string> guids, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), System.Collections.Generic.IEnumerable<string> excludeRelationshipTypes = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetByUniqueAttributes(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetByUniqueAttributesAsync(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetClassification(string guid, string classificationName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationAsync(string guid, string classificationName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetClassifications(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationsAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEntitiesByUniqueAttributes(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrNQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntitiesByUniqueAttributesAsync(string typeName, bool? minExtInfo = default(bool?), bool? ignoreRelationships = default(bool?), string attrNQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetHeader(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetHeaderAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PartialUpdateEntityAttributeByGuid(string guid, string name, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateEntityAttributeByGuidAsync(string guid, string name, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PartialUpdateEntityByUniqueAttributes(string typeName, Azure.Core.RequestContent content, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateEntityByUniqueAttributesAsync(string typeName, Azure.Core.RequestContent content, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response SetClassifications(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SetClassificationsAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateClassifications(string guid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateClassificationsAsync(string guid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateClassificationsByUniqueAttribute(string typeName, Azure.Core.RequestContent content, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateClassificationsByUniqueAttributeAsync(string typeName, Azure.Core.RequestContent content, string attrQualifiedName = null, Azure.RequestContext context = null) { throw null; }
    }
    public partial class PurviewGlossaries
    {
        protected PurviewGlossaries() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AssignTermToEntities(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AssignTermToEntitiesAsync(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGlossary(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGlossaryCategories(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryCategoriesAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGlossaryCategory(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryCategoryAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGlossaryTerm(Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryTermAsync(Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateGlossaryTerms(Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateGlossaryTermsAsync(Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteGlossary(string glossaryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGlossaryAsync(string glossaryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteGlossaryCategory(string categoryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGlossaryCategoryAsync(string categoryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteGlossaryTerm(string termGuid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGlossaryTermAsync(string termGuid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteTermAssignmentFromEntities(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTermAssignmentFromEntitiesAsync(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response ExportGlossaryTermsAsCsv(string glossaryGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ExportGlossaryTermsAsCsvAsync(string glossaryGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetCategoryTerms(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCategoryTermsAsync(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetDetailedGlossary(string glossaryGuid, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDetailedGlossaryAsync(string glossaryGuid, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEntitiesAssignedWithTerm(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntitiesAssignedWithTermAsync(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaries(int? limit = default(int?), int? offset = default(int?), string sort = null, bool? ignoreTermsAndCategories = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossariesAsync(int? limit = default(int?), int? offset = default(int?), string sort = null, bool? ignoreTermsAndCategories = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossary(string glossaryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryAsync(string glossaryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaryCategories(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryCategoriesAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaryCategoriesHeaders(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryCategoriesHeadersAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaryCategory(string categoryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryCategoryAsync(string categoryGuid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaryTerm(string termGuid, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryTermAsync(string termGuid, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaryTermHeaders(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryTermHeadersAsync(string glossaryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetGlossaryTerms(string glossaryGuid, bool? includeTermHierarchy = default(bool?), int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetGlossaryTermsAsync(string glossaryGuid, bool? includeTermHierarchy = default(bool?), int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetImportCsvOperationStatus(string operationGuid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetImportCsvOperationStatusAsync(string operationGuid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRelatedCategories(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelatedCategoriesAsync(string categoryGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRelatedTerms(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelatedTermsAsync(string termGuid, int? limit = default(int?), int? offset = default(int?), string sort = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTermsByGlossaryName(string glossaryName, int? limit = default(int?), int? offset = default(int?), bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTermsByGlossaryNameAsync(string glossaryName, int? limit = default(int?), int? offset = default(int?), bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> ImportGlossaryTermsViaCsv(Azure.WaitUntil waitUntil, string glossaryGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> ImportGlossaryTermsViaCsvAsync(Azure.WaitUntil waitUntil, string glossaryGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> ImportGlossaryTermsViaCsvByGlossaryName(Azure.WaitUntil waitUntil, string glossaryName, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> ImportGlossaryTermsViaCsvByGlossaryNameAsync(Azure.WaitUntil waitUntil, string glossaryName, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PartialUpdateGlossary(string glossaryGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateGlossaryAsync(string glossaryGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PartialUpdateGlossaryCategory(string categoryGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateGlossaryCategoryAsync(string categoryGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response PartialUpdateGlossaryTerm(string termGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PartialUpdateGlossaryTermAsync(string termGuid, Azure.Core.RequestContent content, bool? includeTermHierarchy = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response RemoveTermAssignmentFromEntities(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RemoveTermAssignmentFromEntitiesAsync(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateGlossary(string glossaryGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGlossaryAsync(string glossaryGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateGlossaryCategory(string categoryGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGlossaryCategoryAsync(string categoryGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateGlossaryTerm(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateGlossaryTermAsync(string termGuid, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class PurviewLineages
    {
        protected PurviewLineages() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response GetLineageGraph(string guid, string direction, int? depth = default(int?), int? width = default(int?), bool? includeParent = default(bool?), bool? getDerivedLineage = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetLineageGraphAsync(string guid, string direction, int? depth = default(int?), int? width = default(int?), bool? includeParent = default(bool?), bool? getDerivedLineage = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response NextPageLineage(string guid, string direction, bool? getDerivedLineage = default(bool?), int? offset = default(int?), int? limit = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> NextPageLineageAsync(string guid, string direction, bool? getDerivedLineage = default(bool?), int? offset = default(int?), int? limit = default(int?), Azure.RequestContext context = null) { throw null; }
    }
    public partial class PurviewRelationships
    {
        protected PurviewRelationships() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response Create(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response Delete(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetPurviewRelationship(string guid, bool? extendedInfo = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetPurviewRelationshipAsync(string guid, bool? extendedInfo = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response Update(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class PurviewTypes
    {
        protected PurviewTypes() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response CreateTypeDefinitions(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateTypeDefinitionsAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteTypeByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTypeByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteTypeDefinitions(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTypeDefinitionsAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetAllTypeDefinitions(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAllTypeDefinitionsAsync(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetClassificationDefByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationDefByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetClassificationDefByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetClassificationDefByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEntityDefinitionByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntityDefinitionByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEntityDefinitionByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEntityDefinitionByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEnumDefByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEnumDefByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetEnumDefByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEnumDefByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRelationshipDefByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelationshipDefByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRelationshipDefByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRelationshipDefByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetStructDefByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetStructDefByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetStructDefByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetStructDefByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTermTemplateDefByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTermTemplateDefByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTermTemplateDefByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTermTemplateDefByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTypeDefinitionByGuid(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTypeDefinitionByGuidAsync(string guid, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTypeDefinitionByName(string name, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTypeDefinitionByNameAsync(string name, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTypeDefinitionHeaders(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTypeDefinitionHeadersAsync(bool? includeTermTemplate = default(bool?), string type = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateAtlasTypeDefinitions(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAtlasTypeDefinitionsAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
}
