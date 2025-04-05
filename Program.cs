using DesignPatterns._04_Prototype;
using DesignPatterns._05_Singleton;
using DesignPatterns._06_Adapter;
using DesignPatterns._07_Bridge;
using DesignPatterns._08_Composite;
using DesignPatterns._09_Decorator;
using DesignPatterns._10_Facade;
using DesignPatterns._11_Flyweight;
using DesignPatterns._12_Proxy;
using DesignPatterns._13_ChainOfResponsability;
using DesignPatterns._14_Command;
using DesignPatterns._15_Interpreter;
using DesignPatterns._16_Iterator;
using DesignPatterns._17_Mediator;
using DesignPatterns._18_Memento;
using DesignPatterns._19_Observer;
using DesignPatterns._20_State;

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

//**************
//* _10_Facade *
//**************
// //using all classes to activate the night mode
// //you need to know that all this activates the night mode :(
// var light = new Light();
// var thermostat = new Thermostat();
// var doorLock = new DoorLock();

// light.TurnOff();
// thermostat.Temperature(25);
// doorLock.Lock();

// //using SmartHomeFacade 
// var smartHome = new SmartHomeFacade();
// smartHome.ActivateNightMode();

//**************
//* _12_Proxy *
//**************
// //initialize an attachment is expensive
// var fileId = Guid.NewGuid();
// var attachment = new Attachment(fileId);

// //using proxy
// var attachmentProxy = new AttachmentLazy(fileId); //no file initialization until you need
// //some stuff before need to load the file
// attachmentProxy.GetFile();

//*****************************
//* _13_ChainOfResponsability *
//*****************************
// var chainOfApprovals = new NoCustomerApprovalHandler();
// chainOfApprovals
//     .Next(new MaxDiscountApprovalHandler())
//     .Next(new SpecialPaymentMethodApprovalHandler());

// var order = new Order();
// chainOfApprovals.Handle(order);

//***************
//* _14_Command *
//***************
// var actor = new GameActor();
// var joystick = new Joystick(
//     new FireCommand(),
//     new ChangeWeaponCommand(),
//     new CrouchCommand(),
//     new JumpCommand()
// );
// while (true)
// {
//     Console.WriteLine("Game started (Press Esc [Exit], A,B,X or Y)!");
//     var buttonPressed = ButtonMapper.Map(Console.ReadKey());

//     if (buttonPressed == Button.Start) break;
//     Console.WriteLine();

//     var command = joystick.HandleInput(buttonPressed);
//     command?.Execute(actor);
// }

//*******************
//* _15_Interpreter *
//*******************
// var customer = new Customer(29, 1700);
// var expressionA = new AndExpression(
//     new AgeGreaterThan(18),
//     new MonthlyIncomeGreaterThan(1500)
// );
// var expressionB = new AndExpression(
//     new AgeGreaterThan(65),
//     new MonthlyIncomeGreaterThan(3000)
// );
// var expressionC = new OrExpression(
//     expressionA,
//     expressionB
// );
// bool result = expressionC.Interpret(customer);
// Console.WriteLine($"Result of customer evaluation: {(result ? "Approved": "Reproved")}!");
// // (29 > 18 && 1700 > 1500) || (29 > 65 && 1700 > 3000)
// //Or(And(AgeGreaterThan(18),MonthlyIncomeGreaterThan(1500));And(AgeGreaterThan(65),MonthlyIncomeGreaterThan(3000)))

//****************
//* _16_Iterator *
//****************
// var box = new Box();
// box.Put(new Book());
// box.Put(new Book());
// box.Put(new Book());
// box.Put(new Book());
// box.Put(new Book());

// var iterator = box.Iterator();
// for (iterator.Start(); !iterator.Done(); iterator.Next())
// {
//     var currentBook = iterator.Current();
//     Console.WriteLine(currentBook.Isbn);
// }
// //In C# exists the IEnumerator abstraction
// //In Java exists the Iterator abstraction

//****************
//* _17_Mediator *
//****************
// var dialogBox = new DialogBox();
// dialogBox.ClickOnConfirm();
// dialogBox.InputText();
// dialogBox.ClickOnConfirm();

//***************
//* _18_Memento *
//***************
// var editor = new TextEditor(new TextWindow());
// editor.Write("Memento Pattern");
// editor.Write("Is used so to manage internal editor state without exposes internal details.");
// editor.Save();
// editor.Write("It's Azeiming");
// editor.Print();
// editor.Undo();
// editor.Write("It's amazing!");
// editor.Print();

//****************
//* _19_Observer *
//****************
// var newsChannel = new NewsNotification();
// newsChannel.Register(new EmailChannel());
// newsChannel.Register(new SmsChannel());
// newsChannel.Register(new WhatsAppChannel());
// newsChannel.Notify(new Message("Go Horse is now the most used pattern in real world projects!"));
// newsChannel.Notify(new Message("PHP is dead in 2025?"));

//*************
//* _20_State *
//*************
// var vendingMachine = new VendingMachine(new List<Product>
// {
//     new Product("CB001", 10, 2.99m),
//     new Product("SB001", 10, 2.99m),
//     new Product("PB001", 1, 5.99m)
// });
// vendingMachine.Select("CB001");
// vendingMachine.InsertMoney(5);
// vendingMachine.InsertMoney(5);
// vendingMachine.Select("PB001");
// vendingMachine.InsertMoney(5);
// vendingMachine.InsertMoney(5);
// vendingMachine.Select("PB001");