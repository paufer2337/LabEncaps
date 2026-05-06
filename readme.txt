=== C# Lab - Encapsulation ===
___________________________________________________________


¤ Bakgrund / Syfte

En OOP-labb med fokus på encapsulation i C#.

Målet med övningen är att förstå hur man arbetar med:

- Klasser och objekt
- private fields
- properties (get/set)
- constructors
- validation
- exceptions
- objektbaserad logik

Programmet läser in personer med:
firstname, lastname, age och salary,
och räknar sedan ut ny salary baserat på en percentage increase.

Fokus i denna labb ligger främst på att förstå hur data skyddas
och hanteras korrekt inne i en klass istället för direkt i Program.cs.

___________________________________________________________


¤ Hur är programmets struktur uppbyggd?

 - Program.cs  = Hanterar input/output och skapar Person-objekt
 - Person.cs   = Hanterar encapsulation, validation och salary logic

===========================================================


¤ Vilka klasser/metoder innehåller programmet?


~ Program:
|   Main             = Startar programmet och hanterar programmets flöde      |

~ Klass:
|   Person           = Representerar en person med namn, ålder och salary     |

~ Metoder:
|   IncreaseSalary   = Räknar ut salary increase baserat på percentage        |
|   ToString         = Skriver ut personen i rätt format                      |

===========================================================


¤ Vad innehåller programmet logiskt?


~ Encapsulation:
|   private fields   = Skyddar data inne i klassen                            |
|   properties       = Kontrollerar åtkomst till fields                       |
|   this             = Refererar till klassens egna fields/properties         |

~ Constructor:
|   Person(...)      = Skapar objekt och sätter värden                        |

~ Validation:
|   FirstName        = Minst 3 tecken                                         |
|   LastName         = Minst 3 tecken                                         |
|   Age              = Får inte vara 0 eller negativ                          |
|   Salary           = Får inte vara mindre än 460 dollars                    |

~ Exception handling:
|   ArgumentException = Kastas vid ogiltig data                               |
|   try / catch       = Fångar exceptions och skriver ut error message        |

===========================================================


¤ Extra / teknisk detalj:


|   CultureInfo.InvariantCulture = Hanterar decimal input med punkt           |
|                                  exempel: 444.55                            |
|                                                                             |
|   F2                           = Skriver ut salary med två decimaler        |
|                                  exempel: 660.00                            |

===========================================================

cmd:
dotnet run

===========================================================

~ Tack för mig :) ~