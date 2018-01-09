# Session : Querying : How to Query With Exact Match

By default `Where` method in `Query` uses case-insensitive match.

To perform case-sensitive match you should use `exact` parameter.

### Syntax

{CODE query_1_0@ClientApi\Session\Querying\HowToQueryWithExactMatch.cs /}

| Parameters | | |
| ------------- | ------------- | ----- |
| **predicate** | Expression<Func<T, int, bool>> | Predicate with match condition |
| **exact** | bool | Indicates if `predicate` should be matched in case-sensitive manner |

###Example I - Query With Exact Match

{CODE-TABS}
{CODE-TAB:csharp:Sync query_1_1@ClientApi\Session\Querying\HowToQueryWithExactMatch.cs /}
{CODE-TAB:csharp:Async query_1_1_async@ClientApi\Session\Querying\HowToQueryWithExactMatch.cs /}
{CODE-TAB-BLOCK:csharp:RQL}
from Employees where exact(FirstName == 'Robert')
{CODE-TAB-BLOCK/}
{CODE-TABS/}

### Example II - Query With Inner Exact Match

{CODE-TABS}
{CODE-TAB:csharp:Sync query_2_1@ClientApi\Session\Querying\HowToQueryWithExactMatch.cs /}
{CODE-TAB:csharp:Async query_2_1_async@ClientApi\Session\Querying\HowToQueryWithExactMatch.cs /}
{CODE-TAB-BLOCK:csharp:RQL}
from Orders 
where exact(Lines[].ProductName == 'Singaporean Hokkien Fried Mee')
{CODE-TAB-BLOCK/}
{CODE-TABS/}

### Related Articles

- [What are indexes?](../../../indexes/what-are-indexes)
- [Indexes : Querying: Basics](../../../indexes/querying/basics)  
- [Session : Querying : What is a Document Query?](../document-query/what-is-document-query.dotnet)