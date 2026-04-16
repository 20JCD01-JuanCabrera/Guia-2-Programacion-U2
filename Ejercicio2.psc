//Pide dos numeros y una Opcion 
// Sumar, 2 Restar, 3. Multiplicar. 4  dividir
Algoritmo Ejercicio2
	Definir num1,num2,opc,resul como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valores numericos: "
	leer num1
	leer num2
	
	//Menu de operaciones
	Escribir "***************************"
	Escribir "Menu Principal"
	Escribir "1- Suma"
	Escribir "2- Resta"
	Escribir "3- Multiplicacion"
	Escribir "4- Division"
	Escribir "5- Salir"
	Escribir Sin Saltar "Digite el numero segun su operacion"
	Leer opc
	
	
	//Evaluar la Opcion 
	Segun opc Hacer
		1:
			msj = "El resultado de la suma es "
			resul = num1+num2
		2:
			msj = "El resultado de la resta es "
			resul = num1-num2
		3:
			msj = "El resultado de la Multiplicacion es "
			resul = num1*num2
			
		4:
			msj = "El resultado de la Division es "
			resul = num1/num2
		5: 
			msj = "Saliendo del sistema"
			
		De Otro Modo:
			msj = "Seleccione una opciom Valida!!!"
	Fin Segun
	Escribir msj
	Escribir resul
	
FinAlgoritmo
