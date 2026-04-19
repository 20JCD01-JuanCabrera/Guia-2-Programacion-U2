Algoritmo Casa_Eje7
	Escribir "==== Identificador de carater ===="
	Definir a Como Caracter
	
	Escribir "Escribe un caracter: "
	Leer a
	
	Segun a Hacer
		"a", "e" , "i " , "u" , "o","A","E","I","O","U":
			Escribir "Es una vocal"
		"1","2","3","4","5","6","7","8","9","0":
			Escribir "Es un digito"
		De Otro Modo:
			Escribir "El caracter no es una vocal ni un digito"
	Fin Segun
FinAlgoritmo
