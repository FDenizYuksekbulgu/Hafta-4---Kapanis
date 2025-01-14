TEKNOLOJİ MAPĞAZASI
It is a console application for a bit technology store that takes phone and computer records.

We are taking phone and computer records in a technology store.

Phone -> It has the features of Production Date, Serial Number, Name, Description, Operating System, Tr Licensed or not.

Computer -> It has the features of Production Date, Serial Number, Name, Description, Operating System, USB Port Count, Bluetooth or not.

A BaseClass named BaseMakine was inherited from Phone and Computer classes. (Inheritance)

For Computer, the USB port count can be assigned as 2 or 4, otherwise a warning message is given and a value of -1 is assigned. (Encapsulation)

The Production Date value is automatically assigned when an object is created. It is valid for both Phone and Computer.

A BilgiPrint() method was defined in the Base Class (BaseMakine) that prints common information such as Production Date, Serial Number, Name, Description, Operating System. In Derived classes (Phone, Computer), this method was overridden and a function was added to the Base function to print their own properties. (Polymorphism)

By defining an abstract method called GetProductName() and overriding it separately for Phone and Computer

"Your phone name ---> ......"

"Your computer name ---> ......"

Console messages were printed as follows. (Abstraction)

Program flow:

1- The user was told from the console screen that he/she should press 1 to produce a phone and 2 to produce a computer.

2- According to the user's choice, an object was produced from the relevant class and its properties were taken from the console screen, that is, from the user.

3- When all the information was entered, a message was sent stating that the product was successfully produced and asking whether he/she wanted to produce another product.

4- If the user answered yes, go back to step 1, if the user answered no, the application was terminated by wishing him/her a good day.
