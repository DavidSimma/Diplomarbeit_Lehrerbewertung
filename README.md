# Mobile-App für Schüler*innen

## Was macht diese App?

Diese App ist ein Teil einer Plattform, welche die Absicht hat, Lehrpersonen die Verbesserung des eigenen Unterrichts mithilfe eines Feedback-Formulars zu erleichtern. Mit der Eingabe eines Schlüssels, welchen die Lehrperson bekannt gibt, können die Schüler\*innen das nun erhaltene Formular ausfüllen. Nach der Bearbeitung werden die Antworten anonym an einen Server geschickt. Die Lehrperson kann nun die Antworten über die Website ([separater Teil](https://github.com/DavidSimma/Diplomarbeit_Lehrerbewertung/tree/Website)) abrufen.  
Die App lässt sich über die eben genannte Website downloaden (derzeit nur für Android).

## Was wird dafür benötigt?

Das Programm lässt sich in der Entwicklungsumgebung `Visual Studio` ausführen.  

Für die einwandfreie Ausführung des Programms werden folgende NuGet-Packete benötigt:
 - Newtonsoft.Json
 - Xamarin.Essentials
 - Xamarin.Forms

## Wie führt man die App aus?

Damit man die App mit der Entwicklungsumgebung `Visual Studio` auf einem Windows Computer ausführen kann, ist eines der 2 folgenden Verfahren notwendig:
 - Debugging mittels externen Android Gerät
 - Verwendung eines Android Emulator auf dem Computer

### Debugging mittels externem Android Gerät

Als erstes muss der Debugging-Modus auf dem gewünschten Android Gerät aktiviert werden. Dafür öffnet man die `Einstellungen -> Über das Telefon`. Anschließend tippt man öfters auf die `Build-Nummer`. Nun sollte der Entwicklungsmodus aktiviert sein.  
Im weiteren Schritt öffnet man erneut `Einstellungen -> System & Aktualisierungen -> Entwickleroptionen` und aktiviert die Option `USB-Debugging`.  

Im Anschluss kann die App mittels des externen Gerätes gestartet werden. Es wird das Startprojekt `Diplomarbeit.Android` sowie das externe Handy gewählt:  

![Debugging-Handy](https://user-images.githubusercontent.com/56593280/151257740-bc127d0a-6db5-4d66-a5ca-2c30c3d98dad.jpg)


### Debugging mittels Android Emulator

Für das Debuggen mittels eines Android Emulators muss als erster Schritt ein virtuelles Android Gerät erstellt werden. Man wählt zuerst bei der Debuggeigenschaft das Feld `Android-Geräte-Manager`. In dem neu geöffnetem Fenster wählt man nun *Neu* und erstellt ein virtuelles Gerät seiner Wahl. Im Anschluss wählt man das Feld *Erstellen* und der `Android-Geräte-Manager` sieht dann wie folgt aus:  

![Debugging-Emulator](https://user-images.githubusercontent.com/56593280/151258821-625cfc40-c5f8-47cd-a578-a9df8c2a6dee.jpg)

Nun kann man das Fenster wieder schließen und erhält bei der Debugeigenschaft ein neues Feld mit dem eben erstellten virtuellen Handys. Dies wählt man nun aus und kann die App mit dem virtuellen Handy starten.

## Step by Step go thru:

Beim Start der App wird ein Schlüssel verlangt. Dieser Schlüssel wird den Schüler\*innen von der Lehrperson mitgeteilt. Der Schlüssel wird eingegeben und bestätigt:  



In den folgenden 8 Seiten werden die von der Lehrperson formulierten Fragen angezeigt. Diese sind mittels eines Reglers von 1 - 10 zu beantworten:  



Auf der Seite *Kommentar* kann noch eine weitere Anmerkung angegeben werden:  



Auf der Seite *Schlüssel für Lehrpersonen* muss nun ein weiterer Schlüssel angegeben werden, welcher den Lehrpersonen Hilft, die Verschiedenen Klassen zu unterschieden. Den Schlüssel kann die Lehrperson wieder selbst auswählen und den Schülern mitteilen:  



Die folgende und letzte Seite gibt den Status der Sendung des Formulars aus. Falls die Daten erfolgreich abgesendet werden konnten, erscheint dementsprechende Nachricht. Falls dies nicht der Fall ist wird eine Fehlermeldung zurückgegeben. Der Knopf *Abschließen* führt wieder zurück zur Startseite:  

