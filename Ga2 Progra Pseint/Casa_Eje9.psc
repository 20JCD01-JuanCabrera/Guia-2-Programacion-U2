Algoritmo Casa_Eje9
	Escribir "==== Conversor de medidas ===="
	Escribir "==== Opciones ===="
	Escribir "1- Metros"
	Escribir "2- Pies"
	Escribir "3- Centimetros"
	Escribir "4- Pulgadas"
	
	Definir a,b,c,x Como Real
	
	Escribir "Digite la opcion de medida  de origen: "
	Leer a
	
	Escribir "Cuanto es la longitud: "
	Leer b
	
	Segun a Hacer
		1:
			x = b
		2:
			x  = b/3.281
		3:
			x =  b/100
		4:
			x = b/39.37
		De Otro Modo:
			Escribir "Escriba un valor valido"
	Fin Segun
	
	Escribir "Digite la opcion de medida a la que quiere convertir: "
	Leer c
	
	
	Segun c Hacer
		1:
			Escribir "La cantidad en metros seria: ",(x) " Metros"
		2:
			Escribir "La cantidad en pies seria: ",(x*3.281) " Pies"
		3:
			Escribir "La cantidad en centimetros seria: ",(x*100) " Centimetros"
		4:
			Escribir "La cantidad en pulgadas seria: ",(x*39.37) " Pulgadas "
		De Otro Modo:
			Escribir "Escriba un valor valido"
	Fin Segun
	
FinAlgoritmo
