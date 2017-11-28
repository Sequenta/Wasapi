# Wasapi
C# client for [wordassociations.net](wordassociations.net)

## Usage sample
``` c#
Api api = new Api("insert your key for test");
RequestSettings settings = new RequestSettings 
{
    Language = Language.En,
    ResultType = ResultType.Stimulus,
    Limit = 10,
    PartsOfSpeech = new[] {PartOfSpeech.Noun, PartOfSpeech.Adjective},
    Indent = true
};
Response response = await api.Associations().GetAssociationsAsync(new[] {"hello"}, settings);
foreach(var associationResult in response.Result)
{
    Console.WriteLine(associationResult.Word);
    foreach (var association in associationResult.Associations)
    {
        Console.WriteLine(association.Item);
        Console.WriteLine(association.Pos);
        Console.WriteLine(association.Weight);
    }
}
```
