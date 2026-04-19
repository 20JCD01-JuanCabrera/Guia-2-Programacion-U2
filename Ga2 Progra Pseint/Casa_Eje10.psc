Algoritmo Casa_Eje10
	Definir a,b,i,it, c Como Real 
	Escribir "==== T&S, S.A de C.A ===="
	Escribir "==== Impresoras a Q.650.00 C/U (Sin IVA) ===="
	Escribir "==== Formas de pago ==== Descuento===="
	Escribir "      1- Efectivo           10%"
	Escribir " 2- Tarjeta de credito      5%"
	Escribir "   3- Vale de regalo        15%"
	
	Escribir "Digite la opcion de pago que desea: "
	Leer a
	
	Escribir "Digite la cantidad de impresoras que desea comprar: "
	Leer b
	
	i = 650 * 0.12
	it = 650 + i
	
	Segun a Hacer
		1:
			Escribir "La cantidad de impresoras que va a comprar es de: ",b
			Escribir "El precio unitario de la impresora (con IVA) es: " ,(it)
			Escribir "El total sin descuento es: ",(it * b)
			Escribir "La forma de pago sera en Efectivo"
			Escribir "El descuento realizado es de: ",((it*b)*0.10)
			Escribir "El total a pagar es de: " ,((it*b)-(((it*b)*0.10)))
		2:
			Escribir "La cantidad de impresoras que va a comprar es de: ",b
			Escribir "El precio unitario de la impresora (con IVA) es: " ,(it)
			Escribir "El total sin descuento es: ",(it * b)
			Escribir "La forma de pago sera con Tarjeta de credito"
			Escribir "El descuento realizado es de: ",((it*b)*0.05)
			Escribir "El total a pagar es de: " ,((it*b)-(((it*b)*0.05)))
		3:
			Escribir "La cantidad de impresoras que va a comprar es de: ",b
			Escribir "El precio unitario de la impresora (con IVA) es: " ,(it)
			Escribir "El total sin descuanto es: ",(it * b)
			Escribir "La forma de pago sera con Vale de regalo"
			Escribir "El descuento realizado es de: ",((it*b)*0.15)
			Escribir "El total a pagar es de: " ,((it*b)-(((it*b)*0.15)))
		De Otro Modo:
			Escribir "Digite una opcion valida"
	Fin Segun
	
	
FinAlgoritmo
