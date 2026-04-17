**Mapa**

\[Player Base]---\[A]---\[B]---\[C]---\[Enemigo Base]



**\[Turno del jugador]**

\-Creación

\-Turno de los soldados



**\[Enemigo IA/Turno del enemigo]**

\- Crear enemigos si no tiene unidades.

\- La creación de enemigos utilizará la serie de fibonacci para crear enemigos, creando la primera vez 0 enemigos, luego 1, luego 1, luego 2, luego 3 y así sucesivamente.

\- La creación debe ser random pero inicialmente la probabilidad debe ser mayor en soldados y menor en helicópteros. Luego de cierta cantidad de turnos, la probabilidad debe ser equitativa.



**\[Turno de combate]**

Cada nodo puede albergar unidades o estructuras, pero si unidades o estructuras de diferentes bandos se encuentran en un mismo nodo deben enfrentarse y no pueden seguir avanzando hasta que ya no hayan unidades del bando contrario.



**\[Target priority]**

Si una unidad va a combatir el orden de prioridad son: otras unidades, estructuras de defensa y estructuras de mantenimiento.



**\[Loose / Win Condition]**

Si el jugador se queda sin estructuras, pierde y se le muestra cuántos turnos sobrevivió.

Si una unidad del jugador llega a la base del enemigo, el jugador gana y se le muestra cuanto turnos se demoró.



**Estructura**-> nombre, precio y vida

\-Recolección

\-Mantenimiento

\-Defensa



**Unidades** -> nombre, precio, vida, daño y velocidad.

\-Soldado  - Target -> Helicóptero o estructura

\-Tanque - Target -> Soldado  o estructura

\-Helicóptero - Target -> Tanque o estructura



**\[Menu]**

El menú del turno del jugador debe tener opciones para:

\- Ver sus estructuras

\- Ver sus unidades

\- Crear estructuras

\- Crear unidades

\- Ver a los enemigos --> Total

\- Ver los nodos-->Info especifica de zona

\- Pasar de turno





**----TAREAS---**



**Alesandro-> Game manager**

**-Maneja la repetición del jugador (Turno del jugador)->(Turno del enemigo)->(Resolución de combate) -> (Checkea win/loose condition) -> Termina o se repite**



**Alvaro ->Nodos del mapa**

**-Zonas con la capacidad de almacenar datos(Estructuras y Unidades) ya sean del jugador o enemigo.**



**Roseling -> Inventario**

**-Almacena datos como dinero, cantidad de unidades y estructuras(cantidad actual y máximo, el máximo es ajustable depende de estructura (mantenimiento))**



**Benja -> Turno del enemigo**

**- Crear enemigos si no tiene unidades.**

**- La creación de enemigos utilizará la serie de fibonacci para crear enemigos, creando la primera vez 0 enemigos, luego 1, luego 1, luego 2, luego 3 y así sucesivamente.**

**- La creación debe ser random pero inicialmente la probabilidad debe ser mayor en soldados y menor en helicópteros. Luego de cierta cantidad de turnos, la probabilidad debe ser equitativa.**



**Alonso -> Turno de combate/ Resolución de combate**

**-Checke si en un nodo hay unidades/estructuras de ambos(jugador y enemigo), combaten los del jugador atacan primero, luego de los enemigos**

**-Si una unidad va a combatir el orden de prioridad son: otras unidades, estructuras de defensa y estructuras de mantenimiento.**



**Francesca -> Estructura**

**-Clase Estructura-> maneja datos como nombre, precio y vida**

**-Recolección-> Cada turno respectivo genera dinero**

**-Mantenimiento-> Aumenta limite de estructuras y unidades**

**-Defensa -> Ataca a un enemigo del nodo donde esta**



**Boada -> Unidades**

**-Clase Unidad-> maneja datos como nombre, precio, vida, daño y velocidad**

**-Soldado  - Target -> Helicóptero o estructura**

**-Tanque - Target -> Soldado  o estructura**

**-Helicóptero - Target -> Tanque o estructura**











