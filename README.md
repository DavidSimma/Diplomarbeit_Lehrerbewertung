# Diplomarbeit_Lehrerbewertung

## Wofür ist dieser Server

Dieser Server ist ein Teil einer Plattform, welche die Absicht hat, Lehrpersonen die Verbesserung des eigenen Unterrichts mithilfe eines Feedback-Formulars zu erleichtern. Auf dem Server steht die Datenbank zur Speicherung der Daten für die Kommunikation zwischen Website und mobiler App. Es können Daten in die Datenbank gespeichert und ausgelesen werden. Mithilfe einer öffentilichen IP-Adresse kann der Server auch von jedem Client dieser Welt angesprochen werden. Was bedeutet das der Server nicht zwingend in der Schule, welche diese Plattform verwendet stehen muss, sondern er kann auch an einem externen Ort stehen und gehostet werden.

## Wie wird die Website ausgeführt und was wird dafür benötigt?

Das Programm lässt sich in der Entwicklungsumgebung `Visual Studio Code` ausführen und wurde ausschließlich in der Programmiersprache `Python` entwickelt.  

Für die einwandfreie Ausführung des Servers werden folgende zusätzliche Programme benötigt:
 - XAMPP
 - MySQL
 - Postman (zum testen)
 - Google Chrome (zum testen)
 
## Step by Step go thru:

Wenn der Server gestartet wird, sind am Anfang noch keine Aktionen sichtbar, da noch niemand auf die API zugegriffen hat. Das sieht man im folgenden Bild: 

<img src="https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/blob/Backend/Manuel/Server%20Start.png" width="800">

Mit einer GET-Abfrage werden Daten vom Server abgerufen und dem Client am Bildschirm in JSON-Form angezeigt. Was wieder dem darunter stehenden Bild entnehmen kann:

<img src="https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/blob/Backend/Manuel/DB%20GET.png" width="800">

Ebenso sieht man diese Aktion am Server:

<img src="https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/blob/Backend/Manuel/Server%20GET.png" width="800">

Mit POST-Abfragen werden Daten, in JSON-Form an den Server geschickt, welcher dies dann in die Datenbank speichert. Erkenntlich im folgenden Bild:

<img src="https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/blob/Backend/Manuel/DB%20POST.png" width="800">

Auch diese Aktion sieht man am Server:

<img src="https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/blob/Backend/Manuel/Server%20POST.png" width="800">
