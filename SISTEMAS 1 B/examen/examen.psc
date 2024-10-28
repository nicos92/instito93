Algoritmo examen
	Definir dni Como Entero
	Definir nombre Como Cadena
	Definir apellido Como Cadena
	Definir telefono Como Cadena
	Definir codigo_ejemplar Como Entero
	Definir fecha_entrega Como Cadena
	Definir fecha_devolucion Como Cadena
	Definir opc Como Entero
	Definir acuerdo Como Entero
	Escribir 'bienvenidos'
	Repetir
		Escribir '1- registro usuario'
		Escribir '2- ingreso prestamo'
		Escribir '0- salir'
		Leer opc
		Según opc Hacer
			1:
				Escribir 'Registro usuario'
				Escribir '¿acepta el acuerdo de confidencialidad?'
				Escribir "1- si"
				Escribir "2- no"
				Leer acuerdo
				Si acuerdo = 1 Entonces
					Escribir 'ingrese DNI'
					Leer dni
					Escribir 'ingrese nombre'
					Leer nombre
					Escribir 'ingrese apellido'
					Leer apellido
					Escribir 'ingrese telefono'
					Leer telefono
					Escribir 'usuario registrado'
				SiNo
					Escribir "no se acpeto el acuerdo"
				FinSi
			2:
				Escribir 'ingreso prestamo'
				Escribir 'ingrese codigo de ejemplar'
				Leer codigo_ejemplar
				Escribir 'ingrese dni de usuario'
				Leer dni
				fecha_entrega <- ConvertirATexto(FechaActual())
				fecha_devolucion <- ConvertirATexto(FechaActual()+7)
				Escribir 'prestamo ingresado'
				Escribir 'fecha de entrega: ', fecha_entrega, ', fecha devolucion: ', fecha_devolucion
			0:
				Escribir 'hasta la proxima'
			De Otro Modo:
				Escribir 'ingreso invalido'
		FinSegún
	Hasta Que opc=0
FinAlgoritmo
