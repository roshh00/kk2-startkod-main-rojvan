Den börjar ge mig felmeddelande om att index är utanför arrayen på två ställen. I ShoppingList och i Program. 

Crashen börjar i ShoppingList på linje 90, där jag behövde lägga till en if-sats på raden. 
Nu kan jag köra koden. 

Den ger mig prisen som är skriven på items.txt och en total summa på 121kr
Började med att lägga till en vara och gav den namnet mjölk med priset 15kr. 
Nu är listan sparad med en beskriving av mjölk på 15kr. 
Har lagt till tre varor i menyn med namn och pris men extra siffrorna är fortfarande med när jag kör koden. 

Jag tog bort sifforna i txt filen och behöll dem nya, men nu visar det inte namnet på dem utan bara det nya priset. 
Ändrade i txt filen och gav namn till mjölk, bröd och ost. 

Men nu visar den bara Ost och hur mycket den kostar. 
Frågade Chatbotten i Vs Code och den gav mig att jag skulle ersätta två rader i ShoppingList
Ändrade till String Lines = File.ReadAllLines(path); istället för string text (ReadAllText);

Nu visar koden beskrivingen på alla tre varor med text och pris. 
