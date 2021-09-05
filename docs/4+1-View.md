# 4+1 - View

## Deployment View

![image-20210905193252821](C:\Users\Remo\AppData\Roaming\Typora\typora-user-images\image-20210905193252821.png)

DB und Web Client sind noch nicht umgesetzt, würden aber so hineinpassen.

## Logical View

Siehe C4 Diagramme.

## Implementation View

Definieren Sie die Repository und Source-Struktur, sowie wichtige Elemente der Services und  Komponenten.

CarRent

* CarRent.Backend
	* Solution
	* CarRent.Backend
		* API
		* Application
		* Domain
			* Cars --> Enthält Domain Objects zum Typ Car.
				* Brand
				* Car
				* CarClass
				* ICarRepository
			* Contracts--> Enthält Domain Objects zu den Contracttypen 
			* Customers
		* Infrastructure --> Enthält klassen mit Db-Zugriffen
			* Persistance
				* CareRentDbContext
				* CarRepository
				* CustomerRepository
				* RentContractRepository
				* ReservationContractRepository