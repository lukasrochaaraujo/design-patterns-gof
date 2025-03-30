using System.Drawing;
using DesignPatterns._04_Prototype;
using DesignPatterns._05_Singleton;
using DesignPatterns._06_Adapter;
using DesignPatterns._07_Bridge;
using DesignPatterns._08_Composite;
using DesignPatterns._09_Decorator;

Console.WriteLine("Hello, everyone! Welcome to the Meetup!\n");

//*********************
//* _03_FactoryMethod *
//*********************
//new DesignPatterns._03_FactoryMethod.SomeStuffService().NotifyUser();

//*****************
//* _04_Prototype *
//*****************
// var proposalService = new ProposalService();
// var proposal = new SaleProposal(48, 5000);
// var newProposal = proposalService.Copy(proposal);
// Console.WriteLine($"DELETED...: {proposal.Id()} : Status {proposal.Status()} : R$ {proposal.Amount()} : Months {proposal.DurationMonths()}");
// Console.WriteLine($"NEW COPIED: {newProposal.Id()} : Status {newProposal.Status()} : R$ {newProposal.Amount()} : Months {newProposal.DurationMonths()}");

//*****************
//* _05_Singleton *
//*****************
// var counter = Enumerable.Range(0, 10);
// foreach (var count in counter)
// {
//     Console.WriteLine($"App version: {ApplicationSettingsManager.Instance().Version}");
// }

//***************
//* _06_Adapter *
//***************
// //adaptee
// //SellerPaymentService can't use the FooPaymentService interface
// var fooPaymentService = new FooPaymentService();

// //adapter
// //FooPaymentGatewayAdapter encapsulates FooPaymentService with compatible interface
// var fooPaymentGatewayAdapter = new FooPaymentGatewayAdapter(fooPaymentService);

// //client
// //Now SellerPaymentService can use FooPaymentService with the adapter
// var sellerPaymentService = new SellerPaymentService(fooPaymentGatewayAdapter);
// sellerPaymentService.Transfer(new Payment());

//**************
//* _07_Bridge *
//**************
// var currentAccount = new CurrentAccount(new Pix());
// currentAccount.Transfer(100);
// currentAccount = new CurrentAccount(new Ted());
// currentAccount.Transfer(200);

//*****************
//* _08_Composite *
//*****************
// var words = new List<Word>
// {
//     new('I', '\'', 'm'),
//     new('y', 'o', 'u', 'r'),
//     new('f', 'a', 't', 'h', 'e', 'r', '!')
// };
// var sentence = new Sentence(words);
// sentence.Print();

//*****************
//* _09_Decorator *
//*****************
// var fileDataSource = new FileDataSource();
// fileDataSource.Save("plain content");
// var encryptionDataSource = new EncryptionDataSourceDecorator(
//     new FileDataSource()
// );
// encryptionDataSource.Save("plain content");