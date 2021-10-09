# Return all values from enum via API in .NET
Code repository to go with the blog post: https://mariomucalo.com/return-all-values-from-enum-via-api-in-net

## Goal
The goal of this repository is to show how to make reusable code that will easily allow you to take an enum like this:

```csharp
public enum DogTypeEnum
{
    GERMAN_SHEPHERD = 1,
    LABRADOR_RETREIVER = 2,
    SIBERIAN_HUSKEY = 3    
}
```

and over your API return data like:

```
[
  {
    'key': 1,
    'name': 'German shepherd'
  },
  {
    'key': 2,
    'name': 'Labrador retriever'
  },
  {
    'key': 3,
    'name': 'Siberian huskey'
  }
]
```
