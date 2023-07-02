¿Qué son los patrones de diseño?

Según Christopher Alexander, "cada patrón describe un problema que ocurre una y otra vez en nuestro entorno, así como la solución a ese problema, de tal modo que se pueda aplicar esta solución un millón de veces, sin hacer lo mismo dos veces”
En general, un patrón tiene cuatro elementos esenciales:
1) El nombre del patrón permite describir, en una o dos palabras, un problema de diseño junto con sus soluciones y consecuencias. Al dar nombre a un patrón inmediatamente estamos incrementando nuestro vocabulario de diseño, lo que nos permite diseñar con mayor abstracción. Tener un vocabulario de patrones nos permite hablar de ellos con otros colegas, mencionarlos en nuestra documentación y tenerlos nosotros mismos en cuenta. De esta manera, resulta más fácil pensar en nuestros diseños y transmitirlos a otros, junto con sus ventajas e inconvenientes. Encontrar buenos nombres ha sido una de las partes más difíciles al desarrollar el catálogo de patrones.
2) El problema describe cuándo aplicar el patrón. Explica el problema y su contexto. Puede describir problemas concretos de diseño (por ejemplo, cómo representar algoritmos como objetos), así como las estructuras de clases u objetos que son sintomáticas de un diseño inflexible. A veces el problema incluye una serie de condiciones que deben darse para que tenga sentido aplicar el patrón.
3) La solución describe los elementos que constituyen el diseño, sus relaciones, responsabilidades y colaboraciones. La solución no describe un diseño o una implementación en concreto, sino que un patrón es más bien como una plantilla que puede aplicarse en muchas situaciones diferentes. El patrón proporciona una descripción abstracta de un problema de diseño y cómo lo resuelve una disposición general de elementos (en nuestro caso, clases y objetos).
4) Las consecuencias son los resultados así como las ventajas e inconvenientes de aplicar el patrón. Aunque cuando se describen decisiones de diseño muchas veces no se reflejan sus consecuencias, éstas son fundamentales para evaluar las alternativas de diseño y comprender los costos y beneficios de aplicar el patrón. Las consecuencias en el software suelen referirse al equilibrio entre espacio y tiempo. También pueden tratar cuestiones de lenguaje e implementación. Por otro lado, puesto que la reutilización suele ser uno de lo factores de los diseños orientados a objetos, las consecuencias de un patrón incluyen su impacto sobre la flexibilidad, extensibilidad y portabilidad de un sistema. Incluir estas consecuencias de un modo explícito nos ayudará a comprenderlas y evaluarlas.

Qué es y qué no es un patrón de diseño es una cuestión que depende del punto de vista de cada uno. Lo que para una persona es un patrón puede ser un bloque primitivo de construcción para otra. Lo que sí podemos deducir, es que un patrón de diseño describe un problema que ocurre una y otra vez en un ambiente de desarrollo de software, y luego describe la solución de forma tal que es posible reutilizarla todas las veces que aparezca el problema en cuestión, aplicando las modificaciones y ajustes pertinentes al caso.
En este módulo nos centraremos en patrones situados en un cierto nivel de abstracción, no nos ocuparemos de diseños como listas enlazadas y tablas de dispersión (hash) que pueden codificarse en clases y reutilizarse como tales. Tampoco abordaremos complicados diseños específicos de un dominio para una aplicación o subsistema completo. Los patrones de diseño de este módulo son descripciones de clases y objetos relacionados que están particularizados para resolver un problema de diseño general en un determinado contexto.
Un patrón de diseño abstrae e identifica los aspectos clave de una estructura de diseño común, lo que los hace útiles para crear un diseño orientado a objetos reutilizable. El patrón de diseño identifica las clases e instancias participantes, sus roles y colaboraciones, y la distribución de responsabilidades. Cada patrón de diseño se centra en un problema concreto, describiendo cuándo aplicarlo y si tiene sentido implementarlo, teniendo en cuenta otras restricciones de diseño, así como las consecuencias y las ventajas e inconvenientes de su uso.
A continuación, presentamos el catálogo de patrones y su clasificación:


Patrones Creacionales

Proveeen diferentes formas de crear objetos
•	Abstract Factory
•	Builder
•	Factory Method
•	Prototype
•	Singleton


Patrones Estructurales

Describen formas de componer objetos para formar nuevas estructuras flexibles y eficientes
•	Adapter
•	Bridge
•	Composite
•	Facade
•	Flyweight
•	Proxy
•	Decorator


Patrones de Comportamiento

Gestionan algoritmos y responsabilidades entre objetos
•	Chain Of Responsability
•	Command
•	Interpreter
•	Iterator
•	Mediator
•	Memento
•	Observer
•	State
•	Strategy
•	Template Method
•	Visitor
