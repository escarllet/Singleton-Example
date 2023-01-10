# Singleton + Factory - Example

Ejemplo del patrón de diseño Singleton y Factory en C# .Net 

## ¿Qué hace?
<ul>
<li> Guarda en una lista los empleados según su tipo - Administrativo, Gerencial y Operativo. </li>
<li> Calcula el salario del empleado. </li>
<li> Genera un código de empleado único y aleatorio a partir del nombre de departamento del empleado </li>
</ul>

## ¿Cómo lo hace?

Usando el patrón de diseño <strong>Singleton</strong>, me aseguro la clase gerencial solo tenga una instancia (solo hay un gerente) y proporciono un punto de acceso global a ella.

Además usando el patrón de diseño <strong> Factory </strong> delego en la subclase "Fabrica" la creación de objetos lo que me permitiría añadir clases nuevas sin que la aplicación tenga que cambiar de ninguna manera.

He aquí su diseño UML

[![UML.png](https://i.postimg.cc/HLZTr4hf/UML.png)](https://postimg.cc/yJZM59BP)
