# PrincipiosSolidAct

CON EL FIN DE EXPONER LOS PRINCIPIOS SOLID SE OPTO POR DISEÑAR UN DISPENSER QUE LIBERE DISTINTOS TIPOS DE LIQUIDOS. EN EL CASO DEL AGUA DEBERÁ SALIR POR LA CANILLA 1, Y EL RESTO DE LAS BEBIBAS DEBERAN SER LIEBRADAS DESDE LA CANILLA 2. TODAS LAS CLASES DEBERAN HEREDAR DE LA "CLASELIQUIDOS" Y DE LA INTERFAZ "ILIQUIDOS".

INSTRUCCIONES PARA LIBERAR LIQUIDOS
AGUA = TECLA "A"
SPRITE = TECLA "B"
COCA = TECLA "D"
FANTA = TECLA "F"

LOS LIQUIDOS DEBERAN DESAPARECER AL CAER DESDE LA CANILLA.



14/11/24

Patrón de Diseño elegido: “Factory Method”

Se reutilizó el proyecto anterior para implementar el Patrón de Diseño elegido. Se trabajó en una nueva Branch llamada "patron-de-diseno"

Resumen: Se espera ver un dispenser que desde la "Canilla1" libere "Agua" y desde la "Canilla2" libere "Gaseosas".
Funcionamiento:
TECLA "A" libera Agua
TECLA "B" libera Sprite
TECLA "D" libera Coca
TECLA "F" libera Fanta

Al crear instancias de las clases de líquidos directamente en la clase Dispenser, el código queda muy dependiente a las clases Coca, Fanta, Agua, Sprite. Cualquier cambio en la implementación nos obliga a hacer cambios en la clase Dispenser. Además, si en el futuro necesitamos agregar nuevos tipos de líquidos se tendría que modificar la clase Dispenser para incluir la lógica de creación de estos nuevos tipos. “Esto viola el Principio SOLID de abierto/cerrado (Open/Closed Principle) que establece que el código debe estar abierto para la extensión, pero cerrado para la modificación”.

El patrón Factory Method independiza la creación de objetos de su uso ya que la clase Dispenser no necesita conocer los detalles de las clases concretas de líquidos. Solo necesita interactuar con la interfaz ILiquidos. Esto reduce la dependencia y hace que el código sea más flexible y fácil de mantener. Además, para agregar un nuevo tipo de líquido ahora solo se necesita modificar la fábrica "CreadorLiquidos" para incluir la lógica de creación del nuevo tipo. Y lo más importante… “La clase Dispenser no necesita ser modificada, lo que sigue el principio de abierto/cerrado”

Ventajas:
-	Evitas un acoplamiento fuerte entre el creador y los productos concretos.
-	Principio de responsabilidad única. Puedes mover el código de creación de producto a un lugar del programa, haciendo que el código sea más fácil de mantener.
-	Principio de abierto/cerrado. Puedes incorporar nuevos tipos de productos en el programa sin descomponer el código cliente existente.

Desventajas:
 Puede ser que el código se complique, ya que debes incorporar una multitud de nuevas subclases para implementar el patrón. La situación ideal sería introducir el patrón en una jerarquía existente de clases creadoras.
