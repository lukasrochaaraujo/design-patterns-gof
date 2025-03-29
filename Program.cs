using DesignPatterns._04_Prototype;

Console.WriteLine("Hello, everyone! Welcome to the Meetup!");

//*********************
//* _03_FactoryMethod *
//*********************

//new DesignPatterns._03_FactoryMethod.SomeStuffService().NotifyUser();

//*****************
//* _04_Prototype *
//*****************

// var proposal = new SaleProposal(48, 20_000);
// //for some reason the proposal was canceled
// proposal.Cancel();
// //new one will be created
// var newProposal = proposal.Clone();
// newProposal.SetAmount(15_000);

// Console.WriteLine($"CANCELED..: {proposal.Id()} : Status {proposal.Status()} : R$ {proposal.Amount()} : Months {proposal.DurationMonths()}");
// Console.WriteLine($"NEW COPIED: {newProposal.Id()} : Status {newProposal.Status()} : R$ {newProposal.Amount()} : Months {newProposal.DurationMonths()}");
