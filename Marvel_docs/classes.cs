// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Url    {
        [JsonPropertyName("type")]
        public string Type; 

        [JsonPropertyName("url")]
        public string Url; 
    }

    public class Thumbnail    {
        [JsonPropertyName("path")]
        public string Path; 

        [JsonPropertyName("extension")]
        public string Extension; 
    }

    public class Item    {
        [JsonPropertyName("resourceURI")]
        public string ResourceURI; 

        [JsonPropertyName("name")]
        public string Name; 

        [JsonPropertyName("role")]
        public string Role; 
    }

    public class Creators    {
        [JsonPropertyName("available")]
        public int Available; 

        [JsonPropertyName("collectionURI")]
        public string CollectionURI; 

        [JsonPropertyName("items")]
        public List<Item> Items; 

        [JsonPropertyName("returned")]
        public int Returned; 
    }

    public class Item2    {
        [JsonPropertyName("resourceURI")]
        public string ResourceURI; 

        [JsonPropertyName("name")]
        public string Name; 
    }

    public class Characters    {
        [JsonPropertyName("available")]
        public int Available; 

        [JsonPropertyName("collectionURI")]
        public string CollectionURI; 

        [JsonPropertyName("items")]
        public List<Item2> Items; 

        [JsonPropertyName("returned")]
        public int Returned; 
    }

    public class Item3    {
        [JsonPropertyName("resourceURI")]
        public string ResourceURI; 

        [JsonPropertyName("name")]
        public string Name; 

        [JsonPropertyName("type")]
        public string Type; 
    }

    public class Stories    {
        [JsonPropertyName("available")]
        public int Available; 

        [JsonPropertyName("collectionURI")]
        public string CollectionURI; 

        [JsonPropertyName("items")]
        public List<Item3> Items; 

        [JsonPropertyName("returned")]
        public int Returned; 
    }

    public class Item4    {
        [JsonPropertyName("resourceURI")]
        public string ResourceURI; 

        [JsonPropertyName("name")]
        public string Name; 
    }

    public class Comics    {
        [JsonPropertyName("available")]
        public int Available; 

        [JsonPropertyName("collectionURI")]
        public string CollectionURI; 

        [JsonPropertyName("items")]
        public List<Item4> Items; 

        [JsonPropertyName("returned")]
        public int Returned; 
    }

    public class Events    {
        [JsonPropertyName("available")]
        public int Available; 

        [JsonPropertyName("collectionURI")]
        public string CollectionURI; 

        [JsonPropertyName("items")]
        public List<object> Items; 

        [JsonPropertyName("returned")]
        public int Returned; 
    }

    public class Result    {
        [JsonPropertyName("id")]
        public int Id; 

        [JsonPropertyName("title")]
        public string Title; 

        [JsonPropertyName("description")]
        public object Description; 

        [JsonPropertyName("resourceURI")]
        public string ResourceURI; 

        [JsonPropertyName("urls")]
        public List<Url> Urls; 

        [JsonPropertyName("startYear")]
        public int StartYear; 

        [JsonPropertyName("endYear")]
        public int EndYear; 

        [JsonPropertyName("rating")]
        public string Rating; 

        [JsonPropertyName("type")]
        public string Type; 

        [JsonPropertyName("modified")]
        public DateTime Modified; 

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail; 

        [JsonPropertyName("creators")]
        public Creators Creators; 

        [JsonPropertyName("characters")]
        public Characters Characters; 

        [JsonPropertyName("stories")]
        public Stories Stories; 

        [JsonPropertyName("comics")]
        public Comics Comics; 

        [JsonPropertyName("events")]
        public Events Events; 

        [JsonPropertyName("next")]
        public object Next; 

        [JsonPropertyName("previous")]
        public object Previous; 
    }

    public class Data    {
        [JsonPropertyName("offset")]
        public int Offset; 

        [JsonPropertyName("limit")]
        public int Limit; 

        [JsonPropertyName("total")]
        public int Total; 

        [JsonPropertyName("count")]
        public int Count; 

        [JsonPropertyName("results")]
        public List<Result> Results; 
    }

    public class Root    {
        [JsonPropertyName("code")]
        public int Code; 

        [JsonPropertyName("status")]
        public string Status; 

        [JsonPropertyName("copyright")]
        public string Copyright; 

        [JsonPropertyName("attributionText")]
        public string AttributionText; 

        [JsonPropertyName("attributionHTML")]
        public string AttributionHTML; 

        [JsonPropertyName("etag")]
        public string Etag; 

        [JsonPropertyName("data")]
        public Data Data; 
    }

