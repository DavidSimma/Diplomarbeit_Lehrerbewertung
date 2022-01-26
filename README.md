# Mobile-App für Schüler*innen

## Was macht diese App?

Diese App ist ein Teil einer Plattform, welche die Absicht hat, Lehrpersonen die Verbesserung des eigenen Unterrichts mithilfe eines Feedback-Formulars zu erleichtern. Mit der Eingabe eines Schlüssels, welchen die Lehrperson bekannt gibt, können die Schüler\*innen das nun erhaltene Formular ausfüllen. Nach der Bearbeitung werden die Antworten anonym an einen Server geschickt. Die Lehrperson kann nun die Antworten über die Website (separater Teil) abrufen.  
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



## Step by Step go thru:

