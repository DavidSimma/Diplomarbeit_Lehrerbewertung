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

![Startseite](https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/tree/Website/Website/Startseite.PNG)
<img src="D:\SimonHTL\Diplomarbeit\Website\Startseite.PNG" width="300">

In den folgenden 8 Seiten werden die von der Lehrperson formulierten Fragen angezeigt. Diese sind mittels eines Reglers von 1 - 10 zu beantworten:  

<img src="https://user-images.githubusercontent.com/56593280/151261763-f599dd34-5f5e-412f-9d7b-9acfdbee2fa1.jpg" width="300">

Auf der Seite *Kommentar* kann noch eine weitere Anmerkung angegeben werden:  

<img src="https://user-images.githubusercontent.com/56593280/151261777-9a5e3e11-e4cc-4274-8642-16afe62557b8.jpg" width="300">

Auf der Seite *Schlüssel für Lehrpersonen* muss nun ein weiterer Schlüssel angegeben werden, welcher den Lehrpersonen Hilft, die Verschiedenen Klassen zu unterschieden. Den Schlüssel kann die Lehrperson wieder selbst auswählen und den Schülern mitteilen:  

<img src="https://user-images.githubusercontent.com/56593280/151261784-6d53022d-939c-4cb0-b9fc-53306ed6209d.jpg" width="300">


Die folgende und letzte Seite gibt den Status der Sendung des Formulars aus. Falls die Daten erfolgreich abgesendet werden konnten, erscheint dementsprechende Nachricht. Falls dies nicht der Fall ist wird eine Fehlermeldung zurückgegeben. Der Knopf *Abschließen* führt wieder zurück zur Startseite:  

<img src="https://user-images.githubusercontent.com/56593280/151261795-0b5b547c-3ccf-4905-8329-8a7d4289b26c.jpg" width="300">