# Tenor Unity SDK

The Tenos Unity  SDK makes it easy to integrate the Tenor API endpoints into your Unity project. Library provides simple programming methods and classes for making requests to Tenor web services.

## Getting started

### Call Example

* Initialize SDK with the correct API key.
* Create the correct Request Class with all the parameters.
* Call the method to get the information from the API endpoint.

    ```csharp
    // Search Trending GIFs
    public void ExampleTrendingTenorGIF() {
    
        // Initialize SDK
        TenorAPI.Initialize ("LIVDSRZULELA");
        
        // Prepare Request data
        TrendingRequest request = new TrendingRequest ();
        request.pos = "";
        request.limit = 5;
        
        // Call Coroutine to not freeze
        StartCoroutine(TenorAPI.Trending(request, ProcessAnswers));
        
    }
    
    void ProcessAnswers(Response data) {
        // Process data
    }
    ```
### TenorAPI public methods
The mainclass provide the following methods to calls API endpoints:

```csharp
public static IEnumerator Search(SearchRequest request, DelegateResponseAnswer delegateSearch)
public static IEnumerator Tags(TagRequest request, DelegateTagCollectionAnswer delegateTags)
public static IEnumerator HourlyTrending(HourlyTrendingRequest request, DelegateStringAnswer delegateHourlyTrending)
public static IEnumerator SearchSuggestions(SearchSuggestionsRequest request, DelegateStringAnswer delegateSearchSuggestions)
public static IEnumerator GIFs(GIFsRequest request, DelegateResponseAnswer delegateGIF)
public static IEnumerator RegisterShare(RegisterShareRequest request, DelegateStringAnswer delegateRegisterShare)
public static IEnumerator AutoComplete(AutoCompleteRequest request, DelegateStringAnswer delegateAutoComplete)
```
*

### Scenes

The SDK provides multiples scenes to get a quick look of the usage of this SDK.

* HourlyTrendingExample
* SearchExample
* TagsExample
* TrendingExample
* SearchSuggestionsExample


