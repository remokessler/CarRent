# Use-Cases

Für die Klare strukturierung werden Use-Cases pro Domänenobjekt bereitgestellt, da es sich hierbei um ein überschaubares kleines Beispiel handelt. In einem grössen Projekt, wäre wünschenswert die einzelnen Domänen in verschiedene Boards oder Lanes zu unterteilen. Um so die einzelnen Tasks besser zuteilen zu können, für eine einfachere Zusammenarbeit.

## Customerverwaltung

Als User möchte ich Customers via allen CRUD Operation verwalten können.

Ein Customer soll die Informationen Namen, Adresse und Kundennummer haben und kann mit der Kundennummer oder mit dem Namen gefunden werden.

-----

## Carverwaltung

Als User möchte ich Cars via allen CRUD Operationen verwalten können.
Bei einem Car soll zwischen Luxus, Mittel und Einfachklasse unterschieden werden können und ich möchte zudem jeder Klasse eine Tagesgebühr zuordnen können.

Ein Car soll ausserdem die Marke, den Typ und einen unique Identifier haben.

Dazu kommt, dass ich das Car als Benutzer finden möchte z.B. über dessen Id.

-----

## ReservationContractverwaltung

Als Customer möchte ich ein Auto über ein bestimmten Zeitraum ausleihen können und die Gesammtkosten kennen.

Als User möchte ich einen ReservationContract erstellen und verwalten können. Dabei soll das Start und Enddatum, Gesammtkosten und Klasse des Autos angegeben werden können. Wird der ReservationContract gespeichert, so soll er eine eindeutige ID erhalten.

-----

## RentContractverwaltung

Als User möchte ich bei der Abholung des Cars einen ReservationContract in einen RentContract umwandeln.

Anschliessend möchte ich als User den Contract verwalten und auffinden können.