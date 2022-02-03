# Website für Lehrpersonen

## Wofür ist diese Website

Diese Website ist ein Teil einer Plattform, welche die Absicht hat, Lehrpersonen die Verbesserung des eigenen Unterrichts mithilfe eines Feedback-Formulars zu erleichtern. Auf der Website stehen standardisierte Formulare zur Verfügung. Wenn die vorgefertigten Formularen unpassend sind, können zusätzlich neue, individuelle Formulare erstellen. Durch die Angabe des gewollten Formulars (FormularID) sowie eines einzigartigen Schlüssels kann ein neues Feedback erstellt werden. Die FormularID sowie Schlüssel müssen von der Lehrperson den Schüler:innen mitgeteilt werden, damit diese die notwendigen Angaben in der Mobilen-App ([separater Teil](https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/tree/Mobile-App) machen können. Die Mobile-App kann man auf dieser Website downloaden. Wenn die Ausfüllung der Formulare durch die Schüler:innen abgeschlossen ist, kann die Auswertung der Formulare auf der Website angesehen werden.

## Wie wird die Website ausgeführt und was wird dafür benötigt?

Das Programm lässt sich in der Entwicklungsumgebung `Visual Studio` ausführen und wurde ausschließlich in der Programmiersprache `C#` entwickelt.  

Für die einwandfreie Ausführung des Programms werden folgende NuGet-Packete benötigt:
 - Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
 - Microsoft.EntityFrameworkCore.Tools
 - Microsoft.EntityFrameworkCore.SqlServer
 - Microsoft.VisualStudio.Web.CodeGeneration.Design
 - Microsoft.Extensions.Logging.Debug
 - MySql.Data

## Step by Step go thru:

Beim Aufrufen der Website kommt man auf die Startseite. Hier steht nochmals ein Verwendungshinweiß sowio eine kurze Schritt-für-Schritt-Anweisung. Über die einzelen Taps der Navi-Bar kann man sich durch die einzelen Seiten der Website klicken. 


<img src="https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/blob/Website/Website/Startseite.PNG?raw=true" width="800">