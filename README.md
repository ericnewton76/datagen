# data-seeder

C# library for easily generating sample/seed data with minimal effort.
Designed for use with Entity Framework Seed method, but can be utilized for any seed/sample data generation needs.

## Usage

```c#
public void CreatePersons()
{
  var gen = new data_seeder.generator(0); //use a specific number to have optionally have repeatable results

  for(int i=0; i < 1000; i++)
  {
    var newperson = new DataModels.Person()
    {
      FirstName = gen.firstname(),
      LastName = gen.lastname(),
      Gender = gen.random("M","F")
      Age = gen.integer(10,100)
    };
    
    context.Person.Add(newperson);
  }
  
  context.SaveChanges();
}
```

### Current implementation and Future plans

Currently supports
- firstnames
- lastnames (surnames)
- pick random items from supplied array
- pick random integers from a range
- pick random DateTime values from a range

Coming soon:
- email addresses
- lorem ipsum general text in paragraphs/sentences/words
- city
- states (us)
- regions (ca/others)
- fictious company names
 



