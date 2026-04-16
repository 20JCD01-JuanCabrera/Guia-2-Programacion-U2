Algoritmo Ejercicio4
	Definir opc como Real
	
	//Menu de operaciones
	Escribir "***************************"
	Escribir "Menu Principal"
	Escribir "1- Hamburguesa"
	Escribir "2- Pizza"
	Escribir "3- Pollo Frito"
	Escribir "4- Ensalada"
	Escribir "5- Salir"
	Escribir Sin Saltar "Digite un menu segun su opcion: "
	Leer opc
	
	
	//Evaluar la Opcion 
	Segun opc Hacer
		1:
			Escribir "Usted a solicitado --->"
			Escribir "Un platillo de Hamburguesa"
		2:
			Escribir "Usted a solicitado --->"
			Escribir "Un platillo de Pizza"
		3:
			Escribir "Usted a solicitado --->"
			Escribir "Un platillo de Pollo Frito"
			
		4:
			Escribir "Usted a solicitado --->"
			Escribir "Un platillo de Ensalada"
		5: 
			Escribir "Saliendo del sistema"
			
		De Otro Modo:
			Escribir"Seleccione una menu Valida!!!"
	Fin Segun
FinAlgoritmo
