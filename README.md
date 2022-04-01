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
2. unter mbed_app.json dein Wlan eingeben (Achtung die Applikation muss im gleichen Netzwerk sein)
3. Programm mit MBed Studio starten
4. file Solution-Ordner\.vs\SolutionName\config\applicationhost.config öffnen
5. `<binding protocol="http" bindingInformation="*:8750:localhost" />` mit `<binding protocol="http" bindingInformation="<deine Ip>:8750:*" /> <binding protocol="http" bindingInformation="*:8750:0.0.0.0" />` erweitern
6. Endpoints.sln in Visual Studio öffnen
7. IIS Express starten
