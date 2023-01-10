# Singleton + Factory - Example

Ejemplo del patron de diseño Singleton y Factory en C# .Net 

## ¿Que hace?
<ul>
<li> Guarda en una lista los empledos segun su tipo - Administrativo, Gerencial y Operativo </li>
<li> Calcula el salario del empleado </li>
<li> Genera un codigo de empleado unico y aleatorio a partir del nombre de departamento del empleado </li>
</ul>

## ¿Como lo hace?

Usando el patron de diseño <strong>Singleton</strong>, me aseguro la clase gerencial solo tenga una instancia (solo hay un gerente) y proporciono un punto de acceso global a ella.

Ademas usando el patron de diseño <strong> Factory </strong> delego en la subclase "Fabrica" la creación de objetos lo que me permitiria añadir clases nuevas sin que la aplicación tenga que cambiar de ninguna manera.

He aqui su diseño UML

[![UML.png](https://i.postimg.cc/HLZTr4hf/UML.png)](https://postimg.cc/yJZM59BP)
