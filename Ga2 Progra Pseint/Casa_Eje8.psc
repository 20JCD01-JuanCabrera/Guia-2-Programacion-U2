Algoritmo Casa_Eje8
	Escribir "==== Estadio Doroteo Guamuch Flores ===="
	Definir a , b Como Entero
	Escribir "==== Opciones de Entrada ===="
	Escribir "1- Palco: Q300.00"
	Escribir "2- Tribuna: Q100.00 - Q125.00"
	Escribir "3- Preferencia: Q50.00 - Q75.00"
	Escribir "4- Generales: Q30.00 - Q50.00"
	
	Escribir "Digite la opcion de entrada que desee: "
	Leer a
	
	Escribir "Digite cuantas entradas desea: "
	Leer b
	
	Segun a Hacer
		1:
			Escribir "El total a pagar es: "
			Escribir "Ubicacion: Palco"
			Escribir "Entradas: ",b
			Escribir "El total a pagar es: Q.",(300*b)
		2:
			Escribir "El total a pagar es: "
			Escribir "Ubicacion: Tribuna"
			Escribir "Entradas: ",b
			Escribir "El total a pagar es: Q.",(100*b)
		3:
			Escribir "El total a pagar es: "
			Escribir "Ubicacion: Preferencia"
			Escribir "Entradas: ",b
			Escribir "El total a pagar es: Q.",(50*b)
		4:
			Escribir "El total a pagar es: "
			Escribir "Ubicacion : General"
			Escribir "Entradas: ",b
			Escribir "El total a pagar es: Q.",(30*b)

		De Otro Modo:
			Escribir "De una opcion valida"
	Fin Segun
	
	
	
	

	
FinAlgoritmo
