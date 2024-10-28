Algoritmo sin_titulo
	Definir Pdni Como Entero
	Definir Pnombre, Papellido Como Cadena
	Definir Pcalle Como Cadena
	Definir Pnumero Como Cadena
	Definir Pcp Como Cadena
	Definir Pdiagnostico Como Cadena
	Definir Csectorclinica Como Cadena
	Definir Cnumerocama Como Cadena
	Definir Cfechainternacion Como Cadena
	Definir Enombre Como Cadena
	Definir Edni Como Entero
	Definir Eapellido Como Cadena
	Definir Mnombre Como Cadena
	Definir Mapellido Como Cadena
	Definir Mespecialidad Como Cadena
	Escribir 'INGRESE LOS DATOS DEL PACIENTE dni, nombre, apellido, calle, numero, cp y diagnostico'
	Leer Pdni, Pnombre, Papellido, Pcalle, Pnumero, Pcp, Pdiagnostico
	Escribir 'se le asignara una cama'
	Csectorclinica <- 'internacion 2'
	Cnumero <- 14
	Cfechainternacion <- '2024-08-22'
	Escribir 'se le asignara un enfermero'
	Edni <- 321123321
	Enombre <- 'ana'
	Eapellido <- 'pastor'
	Escribir 'paciente ', Pdni, Pnombre, Papellido, ' de diagnostico: ', Pdiagnostico
	Escribir 'se le asigno la enfermera ', Edni, Enombre, Eapellido
	Escribir 'a la cama ', Csectorclinica, Cnumero, Cfechainternacion
	Escribir 'llego la fecha de internacion: ', Cfechainternacion
	Escribir 'se le asignara un medico'
	Mnombre <- 'Rodrigo'
	Mapellido <- 'Toledo'
	Mespecialidad <- 'base de datos con DFD'
	Escribir 'se le asigno el medico: ', Mnombre, Mapellido, Mespecialidad
	Escribir 'fin de la intervencion'
	Escribir 'se actualizara su historial clinico'
FinAlgoritmo
