# LB02 Dokumentation

## Wissensstand

### IoT - Internet of things

Das Internet of things, deutsch Internet der Dinge, beschreibt pyhsikallische Objekte welche Daten sammeln, verarbeiten und untereinader verteilen können.

### Sensoren

Ein Gerät, das eine physikalische Eigenschaft erfasst oder misst und diese aufzeichnet, anzeigt oder anderweitig darauf reagiert.

### Aktor

Bauelement, das elektrische Signale in mechanische Bewegung oder in andere physikalische Größen umsetzt.

### Service

Ein Dienst, welcher gewisse Schnittstellen, welche von anderen Objekten konsumiert werden können, zur verfügung stellt.

## Aufsetzten des Projektes

1. Iotkit v3 mit Computer verbinden
2. Motor bei M01 einstecken, NFC/RFID sensor einstecken
3. unter mbed_app.json dein Wlan eingeben (Achtung die Applikation muss im gleichen Netzwerk sein)
4. Programm mit MBed Studio starten
5. file Solution-Ordner\.vs\SolutionName\config\applicationhost.config öffnen
6. `<binding protocol="http" bindingInformation="*:8750:localhost" />` mit `<binding protocol="http" bindingInformation="<deine Ip>:8750:*" /> <binding protocol="http" bindingInformation="*:8750:0.0.0.0" />` erweitern
7. Endpoints.sln in Visual Studio als Administrator öffnen
8. Unter HomeController "keyCardCode" eigener Keycard Code eingeben
9. Private & Public Firewall deaktivieren
10. `netsh http add urlacl url=http://<deine Ip>:8750/ user=everyone`
11. IIS Express starten
12. MBed Studio Projekt starten

## Reflexion David Oberkalmsteiner

Ich denke, dass wir bei der LB02 gut vorankamen und ein gutes Produkt erstellt haben. Dies lag wahrscheinlich hauptsächlich daran, dass beide sehr motiviert waren. Ich hatte mich schon vor der Lehre für IoT interessiert. Auch schon als Abschlussarbeit in der Sek entwickelte ich ein kleines Selbstfahrendes Auto, welches von einem Raspberry PI gesteuert wird und mehrere Sensoren hat. Dadurch hatten wir schon ein gutes Basiswissen und konnten ohne Probleme das Programm für das IoT-Kit schreiben. Jedoch hatten wir grosse Probleme beim Entwickeln einer Backend Applikation, welche wir von unserem IoT-Kit ansteuern möchten. Dort hatten wir zuerst Probleme damit, die Endpoints der Applikation so zu öffnen, dass man über das Netzwerk darauf zugreifen kann. Später kam noch hinzu, dass wir grosse Mühe hatten ein Userinterface zu erstellen. Diese zwei Probleme entstanden eigentlich nur, weil wir noch nie mit der Technologie gearbeitet hatten. Wir wählten extra diese Technologie aus, da wir nur eine simple Applikation umsetzten wollten und somit auch eine simple Technologie wollten. Beim nächsten Mal werden wir bei den Technologien bleiben, die wir schon kennen.

## Reflexion Luca Hofstetter

Diese LB ist sehr gut verlaufen. Wir haben alle verlangten Kriterien bei den Kompetenzen erfüllt. Wir konnten auch mehr oder weniger im Zeitplan bleiben. Was Herr Oberkalmsteiner und ich gut gemacht haben, ist regelmässig zu fragen, sobald wir nicht mehr weiterkamen. Ich persönlich hatte ein paar Probleme mit meinem Equipment, sodass ich und Herr Oberkalmsteiner schon relativ früh beschlossen, gemeinsam im pair-programming zu arbeiten. Wir hatten zu Beginn auch schon gute Vorkenntnisse, sodass das Programmieren der Logik kein Problem war. Jedoch mussten wir im Backend viel Zeit investieren, um das Programm zu debuggen. Ich denke, dass wir länger brauchten, da wir vorher noch nie mit so einer Technologie gearbeitet hatten. Ich werde mir für nächstes mal vornehmen, dass ich meine Hardware auf den richtigen Stand bringe, damit ich auch auf meinem Laptop programmieren kann.
