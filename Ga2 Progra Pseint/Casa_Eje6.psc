Algoritmo Casa_Eje6
	
	Escribir "=== Calculadora de angulos ==="
	Definir g Como Real
	Definir op Como Real
	Escribir "Digite el angulo del triangulo: "
	Leer g
	Escribir "=== Lista de opciones ==="
	Escribir "1- Seno"
	Escribir "2- Coseno"
	Escribir "3- Tangente"
	Escribir "Digite la opcion que desee: "
	Leer op

	
	Segun op Hacer
		1:
			Escribir "El Seno del angulo ",g " es " sen(g)
		2:
			Escribir "El Coseno del angulo ",g " es" ,cos(g)
		3:
			Escribir "La Tangente del angulo ",g " es" ,tan(g)
		De Otro Modo:
			Escribir "Digite un angulo correcto !!!"
	Fin Segun
	
	
	
	
FinAlgoritmo
