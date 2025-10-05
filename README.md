1.	Club Deportivo Console  
**Materia:** Desarrollo de Sistemas Orientado a Objetos – 1°B  
**Instituto:** Agencia de Habilidades para el Futuro  
**Autor:** Ángel Domínguez  
**Versión:** 1.0 – Octubre 2025  

2.	Objetivo del Proyecto
El propósito de este trabajo es **desarrollar una aplicación de consola en C#** que permita **gestionar un Club Deportivo**, aplicando los **principios de la Programación Orientada a Objetos (POO)**.
El sistema busca representar un entorno funcional que incluya la administración de **socios, actividades, profesores y pagos**, poniendo en práctica los pilares fundamentales de la POO:
- **Abstracción**  
- **Encapsulamiento**  
- **Herencia**  
- **Polimorfismo**

3.	Descripción General
El proyecto simula el funcionamiento de un sistema de gestión interna de un club, donde se pueden realizar operaciones básicas como:
- Alta, baja y modificación de socios.  
- Asignación de actividades deportivas.  
- Registro de profesores y control de cuotas.  
- Visualización de datos en consola.

Se emplean **clases**, **métodos** y **colecciones** para organizar la información y representar entidades reales dentro del dominio del problema.

4.	 Estructura del Sistema
- **Program.cs:** Punto de entrada del programa principal.  
- **ClubDeportivo.csproj:** Archivo de configuración del proyecto.  
- **Dominio/** (opcional): Carpeta donde se almacenan las clases principales.  

5.	Clases principales

Clase	      Descripción  	                                                           Atributos relevantes
`Socio`	    Representa a un socio del club.	                                          nombre, documento, cuotaPaga
`Actividad`	Representa una disciplina o actividad del club.	                          nombre, profesor, cupoMaximo
`Profesor`	Representa al instructor a cargo de una actividad.                        nombre, especialidad
`Club`	    Contiene las listas de socios y actividades, y métodos para gestionarlos. listaSocios, listaActividades

6. Tecnologías Utilizadas
   
- **Lenguaje:** C# (.NET)  
- **IDE:** Visual Studio / Visual Studio Code  
- **Paradigma:** Programación Orientada a Objetos (POO)  
- **Control de versiones:** Git y GitHub  

7.  Resultados Esperados
   
- Aplicar correctamente los conceptos de POO en un caso práctico.  
- Modelar clases y relaciones entre objetos mediante herencia y composición.  
- Comprender la lógica de encapsulamiento y modularización.  
- Desarrollar habilidades de documentación y control de versiones.  

8.  Integrantes
Adriana Lazzeretti
Angel Dominguez
Gislena Gil Lopez
Gloria Escobar
Karen Florindez

9. Licencia
Uso libre con fines educativos y de formación técnica.  
