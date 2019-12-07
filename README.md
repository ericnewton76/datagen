# datagen

datagen is a C# library for easily generating sample/seed data with minimal effort.
Designed for use with Entity Framework Seed method, but can be utilized for any seed/sample data generation needs.

## Usage

```c#
public void CreatePersons()
{
  //initialize with a specific random seed to enable repeatable results
  var gen = new datagen.generator(0); 

  for(int i=0; i < 100; i++)
  {
    var newperson = new DataModels.Person()
    {
      FirstName = gen.firstname(),  //generates random firstname
      LastName = gen.lastname(),    //generates random lastname
      Gender = gen.random("M","F"), //notice list of available options
      Age = gen.integer(10,100),    //generates an integer between 10 and 100
      Email = gen.email(),          //generates a random email
      City = gen.city(),            //generates a fictious or real city name
      State = gen.state(),          //generates a state or region, pass "US" for US states
      Company = gen.companyname(),  //generates a fictious company name
      Biography = gen.loremipsum(paragraphs:5) //generates lorem ipsum text, 5 paragraphs of 4 sentences with about 20 words each.
    };
    
    mydbcontext.Person.Add(newperson);
  }
  
  mydbcontext.SaveChanges();
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
 



